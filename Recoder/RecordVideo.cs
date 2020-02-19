using Accord.Audio;
using Accord.Math;
using Accord.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recorder
{
    /// <summary>
    /// 录制视频
    /// </summary>
    public class RecordVideo
    {
        /// <summary>
        /// 摄像头录制
        /// </summary>
        private CameraRecorder cameraRecoder = new CameraRecorder();
        /// <summary>
        /// 屏幕录制
        /// </summary>
        private ScreenRecorder screenRecorder = new ScreenRecorder();
        /// <summary>
        /// 音频录制
        /// </summary>
        private AudioRecorder audioRecorder = new AudioRecorder();

        /// <summary>
        ///  摄像头视频帧集合
        /// </summary>
        private List<Bitmap> cameraFrames = new List<Bitmap>();
        /// <summary>
        /// 屏幕视频帧集合
        /// </summary>
        private List<Bitmap> screenFrames = new List<Bitmap>();
        /// <summary>
        /// 音频帧集合
        /// </summary>
        private List<Signal> audioFrames = new List<Signal>();

        private long videoCount = 0;

        private long lastOutputTicks = DateTime.Now.Ticks;

        private long outputIntervalTicks = 50000000; // 5秒

        public RecordVideo()
        {

        }

        public void Start()
        {
            screenRecorder.OnOutputFrame += ScreenRecorder_OnOutputFrame;
            audioRecorder.OnOutputFrame += AudioRecorder_OnOutputFrame;
            screenRecorder.StartRecorder();
            audioRecorder.StartRecorder();
            lastOutputTicks = DateTime.Now.Ticks;
        }

        public void Stop()
        {
            screenRecorder.OnOutputFrame -= ScreenRecorder_OnOutputFrame;
            audioRecorder.OnOutputFrame -= AudioRecorder_OnOutputFrame;
            screenRecorder.StopRecorder();
            audioRecorder.StopRecorder();
        }

        private void ScreenRecorder_OnOutputFrame(object sender, OutputFrameArgs eventArgs)
        {
            
            screenFrames.Add(eventArgs.Frame);
        }

        private void AudioRecorder_OnOutputFrame(object sender, NewFrameEventArgs e)
        {
            audioFrames.Add(e.Signal);
        }

        public void Output()
        {
            if (screenFrames.Count == 0 || audioFrames.Count == 0)
            {
                return;
            }
            var frames = new List<Bitmap>(screenFrames);
            screenFrames.Clear();
            var signals = new List<Signal>(audioFrames);
            audioFrames.Clear();


            string tmpFolder = "tmps";
            if (!Directory.Exists(tmpFolder))
            {
                Directory.CreateDirectory(tmpFolder);
            }

            // 音频
            MemoryStream ms = new MemoryStream();
            var encoder = new Accord.Audio.Formats.WaveEncoder(ms);
            foreach (var signal in signals)
            {
                encoder.Encode(signal);
                signal.Dispose();
            }
            var wavPath = Path.Combine(tmpFolder, string.Format("{0}.wav", videoCount));
            File.WriteAllBytes(wavPath, ms.ToArray());
            encoder.Close();
            
            ms.Close();
            ms.Dispose();

            // 视频
            var w = frames[0].Width;
            var h = frames[0].Height;
            var vwriter = new Accord.Video.FFMPEG.VideoFileWriter();



            var f = frames[0];
            var flvPath = Path.Combine(tmpFolder, string.Format("{0}.flv", videoCount));

            vwriter.Open(flvPath, w, h, new Rational(frames.Count / 5), VideoCodec.FLV1);

            //vwriter.Open(Path.Combine(tmpFolder, string.Format("{0}.flv", videoCount)), w, h, new Rational(frames.Length / 5), VideoCodec.FLV1, 800000, AudioCodec.MP3, 500000, signals[0].SampleRate, 1);

            foreach (var frame in frames)
            {
                vwriter.WriteVideoFrame(frame);
                frame.Dispose();
            }
            //foreach (var signal in signals)
            //{
            //    vwriter.WriteAudioFrame(signal.RawData);
            //    signal.Dispose();
            //}
            vwriter.Flush();
            vwriter.Close();
            vwriter.Dispose();

            var pinfo = new ProcessStartInfo()
            {
                FileName = "ffmpeg.exe",
                Arguments = string.Format("-i {0} -i {1} -y -c:v copy -c:a aac -strict experimental " + Path.Combine(tmpFolder, string.Format("{0}-.flv", videoCount)), flvPath, wavPath, videoCount),

                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,

        };
            var p = Process.Start(pinfo);
            p.WaitForExit();
            File.Delete(flvPath);
            File.Delete(wavPath);

            //  ffmpeg -re -i localFile.mp4 -c copy -f flv rtmp://server/live/streamName

            pinfo = new ProcessStartInfo()
            {
                FileName = "ffmpeg.exe",
                Arguments = string.Format("-re -i {0} -c copy -f flv rtmp://39.105.62.152:2935/live/livestream/777", Path.Combine(tmpFolder, string.Format("{0}-.flv", videoCount)), videoCount),

                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,

            };
            p = Process.Start(pinfo);
            p.WaitForExit();
            File.Delete(Path.Combine(tmpFolder, string.Format("{0}-.flv", videoCount)));

            videoCount++;
        }


    }
}
