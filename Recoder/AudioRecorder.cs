using Accord.Audio;
using Accord.Audio.Formats;
using Accord.DirectSound;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recorder
{
    /// <summary>
    /// 录制声音的工具类
    /// </summary>
    public class AudioRecorder
    {
        /// <summary>
        /// 音频输入设备
        /// </summary>
        private AudioCaptureDevice audioCaptureDevice = null;

        /// <summary>
        /// 输出音频帧事件
        /// </summary>
        public event EventHandler<NewFrameEventArgs> OnOutputFrame = (object sender, NewFrameEventArgs e) => { };

        /// <summary>
        /// 创建录制声音的实例
        /// </summary>
        public AudioRecorder()
        {

        }

        /// <summary>
        /// 使用默认设备启动录制
        /// </summary>
        public void StartRecorder()
        {
            // 获取视频输入设备列表
            var devices = AudioRecorder.AudioDevices();
            // 检查设备存在性
            if (devices.Count == 0)
            {
                throw new Exception("未发现音频输入设备");
            }
            // 调用指定设备启动录制
            this.StartRecorder(devices[0]);
        }

        /// <summary>
        /// 使用指定设备启动录制，monikerString 来自静态方法 VideoDevices 
        /// </summary>
        /// <param name="monikerString">monikerString</param>
        public void StartRecorder(AudioDeviceInfo device)
        {
            // 若 audioCaptureDevice 已存在
            if (audioCaptureDevice != null)
            {
                // 和当前的实例相同，则什么都不做
                if (audioCaptureDevice.Source == device.Description)
                {
                    return;
                }
                // 和当前实例不同，则使其停止
                else
                {
                    audioCaptureDevice.Stop();
                }
            }
            // 创建新的 audioCaptureDevice 实例
            audioCaptureDevice = new AudioCaptureDevice(device);

            // 添加 产生音频帧 事件的处理
            audioCaptureDevice.NewFrame += this.AudioCaptureDevice_NewFrame;

            // 添加 音频源错误 事件的处理
            audioCaptureDevice.AudioSourceError += this.AudioCaptureDevice_AudioSourceError;

            // 开始录制
            audioCaptureDevice.Start();
        }

        /// <summary>
        /// 停止录制，并卸载资源
        /// </summary>
        public void StopRecorder()
        {
            // 若 audioCaptureDevice 未初始化，则不进行动作
            if (audioCaptureDevice == null)
            {
                return;
            }
            // 移除事件处理
            audioCaptureDevice.NewFrame -= AudioCaptureDevice_NewFrame;
            audioCaptureDevice.AudioSourceError -= AudioCaptureDevice_AudioSourceError;
            // 停止录制
            audioCaptureDevice.Stop();
            // 初始化 videoCaptureDevice 
            audioCaptureDevice = null;
        }

        /// <summary>
        /// 录制时 产生音频帧的事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AudioCaptureDevice_NewFrame(object sender, Accord.Audio.NewFrameEventArgs e)
        {
            OnOutputFrame(this, e);
        }

        private void AudioCaptureDevice_AudioSourceError(object sender, Accord.Audio.AudioSourceErrorEventArgs e)
        {
            this.StopRecorder();
            throw new Exception("已停止录制。VideoSourceError: \n" + e.Description);
        }

        /// <summary>
        /// 获取音频输入设备
        /// </summary>
        /// <returns></returns>
        public static List<AudioDeviceInfo> AudioDevices()
        {
            AudioDeviceCollection audioDeviceInfos = new AudioDeviceCollection(AudioDeviceCategory.Capture);
            return audioDeviceInfos.ToList();
        }

    }
}
