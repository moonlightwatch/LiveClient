using Accord.Video;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recorder
{
    /// <summary>
    /// 录制屏幕的工具类
    /// </summary>
    public class ScreenRecorder
    {
        /// <summary>
        /// 屏幕录制实例
        /// </summary>
        private ScreenCaptureStream screenCaptureStream = null;

        /// <summary>
        /// 录制帧间隔，单位-毫秒，默认-40（25fps），设置后重启生效
        /// </summary>
        public int FrameInterval { get; set; } = 40;

        /// <summary>
        /// 录制区域，默认全屏。设置后重启生效
        /// </summary>
        public Rectangle RecorderArea { get; set; } = Screen.PrimaryScreen.Bounds;

        /// <summary>
        /// 视频帧尺寸，默认-1366x768
        /// </summary>
        public Size FrameSize { get; set; } = new Size(1366, 768);


        /// <summary>
        /// 输出视频帧事件
        /// 给予默认绑定，是为了避免调用错误
        /// </summary>
        public event OutputFrameHandler OnOutputFrame = (object sender, OutputFrameArgs e) => { };

        /// <summary>
        /// 创建 屏幕录制 实例
        /// </summary>
        public ScreenRecorder()
        {

        }

        /// <summary>
        /// 启动录制
        /// </summary>
        public void StartRecorder()
        {
            try
            {
                screenCaptureStream = new ScreenCaptureStream(RecorderArea, FrameInterval);
                screenCaptureStream.Start();
                screenCaptureStream.NewFrame += ScreenCaptureStream_NewFrame;
                screenCaptureStream.VideoSourceError += ScreenCaptureStream_VideoSourceError;
            }
            catch (Exception exc)
            {
                throw exc;
            }

        }

        /// <summary>
        /// 停止录制
        /// </summary>
        public void StopRecorder()
        {
            // 若 screenCaptureStream 未初始化，则不进行动作
            if (screenCaptureStream == null)
            {
                return;
            }
            screenCaptureStream.NewFrame -= ScreenCaptureStream_NewFrame;
            screenCaptureStream.VideoSourceError -= ScreenCaptureStream_VideoSourceError;
            screenCaptureStream.Stop();
            screenCaptureStream = null;

        }

        private void ScreenCaptureStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // 调整尺寸后的视频帧
            var frame = this.resizeBitmap(eventArgs.Frame, this.FrameSize);
            // 触发输出视频帧事件
            OnOutputFrame(this, new OutputFrameArgs(frame));
        }

        private void ScreenCaptureStream_VideoSourceError(object sender, VideoSourceErrorEventArgs eventArgs)
        {
            this.StopRecorder();
            throw new Exception("已停止录制。VideoSourceError: \n" + eventArgs.Description, eventArgs.Exception);
        }

        /// <summary>
        /// 缩放至新尺寸
        /// </summary>
        /// <param name="sourceBitmap"></param>
        /// <param name="newSize"></param>
        /// <returns></returns>
        private Bitmap resizeBitmap(Bitmap sourceBitmap, Size newSize)
        {
            // 创建目标尺寸的bitmap
            var targetBitmap = new Bitmap(FrameSize.Width, FrameSize.Height);
            // 创建 Graphics 对象，其绘制将在 targetBitmap 体现
            Graphics g = Graphics.FromImage(targetBitmap);
            // 对 Graphics 对象应用变换矩阵，使之缩放至目标尺寸
            g.ScaleTransform((float)newSize.Width / sourceBitmap.Width, (float)newSize.Height / sourceBitmap.Height);
            // 使用 Graphics 从(0,0) 点绘制图片
            g.DrawImage(sourceBitmap, 0, 0);
            // 销毁 Graphics 对象，避免内存占用。虽然垃圾回收会回收，但此方法可能有大量频繁调用，所以手动销毁。
            g.Dispose();
            return targetBitmap;
        }
    }
}
