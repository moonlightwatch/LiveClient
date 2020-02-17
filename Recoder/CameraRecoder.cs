using Accord.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Recorder
{
    /// <summary>
    /// 摄像头录制工具类
    /// </summary>
    public class CameraRecorder
    {
        // 视频设备实例
        private VideoCaptureDevice videoCaptureDevice = null;

        /// <summary>
        /// 上一帧的 Ticks
        /// </summary>
        private long lastFrameTicks = DateTime.Now.Ticks;

        /// <summary>
        ///  视频帧间隔的 Ticks，默认-400000 （40毫秒）
        /// </summary>
        private int intervalTicks = 400000;

        /// <summary>
        /// 视频帧间隔，单位-毫秒，默认-40（25fps）
        /// </summary>
        public int FrameInterval
        {
            get
            {
                return intervalTicks / 10000;
            }
            set
            {
                intervalTicks = value * 10000;
            }
        }

        /// <summary>
        /// 视频帧尺寸，默认-800x800
        /// </summary>
        public Size FrameSize { get; set; } = new Size(800, 800);


        /// <summary>
        /// 输出视频帧事件
        /// 给予默认绑定，是为了避免调用错误
        /// </summary>
        public event OutputFrameHandler OnOutputFrame = (object sender, OutputFrameArgs e) => { };

        /// <summary>
        /// 创建 CameraRecoder 实例
        /// </summary>
        public CameraRecorder()
        {

        }

        /// <summary>
        /// 使用默认设备启动录制
        /// </summary>
        public void StartRecorder()
        {
            // 获取视频输入设备列表
            var devices = CameraRecorder.VideoDevices();
            // 检查设备存在性
            if (devices.Count == 0)
            {
                throw new Exception("未发现视频输入设备");
            }
            // 调用指定设备启动录制
            this.StartRecorder(devices[0].MonikerString);
        }

        /// <summary>
        /// 使用指定设备启动录制，monikerString 来自静态方法 VideoDevices 
        /// </summary>
        /// <param name="monikerString">monikerString</param>
        public void StartRecorder(string monikerString)
        {
            // 若 videoCaptureDevice 已存在
            if (videoCaptureDevice != null)
            {
                // 和当前的实例相同，则什么都不做
                if (videoCaptureDevice.Source == monikerString)
                {
                    return;
                }
                // 和当前实例不同，则使其停止
                else
                {
                    videoCaptureDevice.Stop();
                }
            }
            // 创建新的 videoCaptureDevice 实例
            videoCaptureDevice = new VideoCaptureDevice(monikerString);

            // 添加 产生视频帧 事件的处理
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;

            // 添加 视频源错误 事件的处理
            videoCaptureDevice.VideoSourceError += VideoCaptureDevice_VideoSourceError;

            // 开始录制
            videoCaptureDevice.Start();
        }

        /// <summary>
        /// 停止录制，并卸载资源
        /// </summary>
        public void StopRecorder()
        {
            // 若 videoCaptureDevice 未初始化，则不进行动作
            if (videoCaptureDevice == null)
            {
                return;
            }
            // 移除事件处理
            videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
            videoCaptureDevice.VideoSourceError -= VideoCaptureDevice_VideoSourceError;
            // 停止录制
            videoCaptureDevice.Stop();
            // 初始化 videoCaptureDevice 
            videoCaptureDevice = null;
        }


        /// <summary>
        /// 录制时 产生视频帧的事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void VideoCaptureDevice_NewFrame(object sender, Accord.Video.NewFrameEventArgs eventArgs)
        {
            // 当前的时间Ticks
            var nowTicks = DateTime.Now.Ticks;

            // 若 上次帧时间与当前时间之差 小于 设定的帧间隔，则什么都不做
            if (nowTicks - lastFrameTicks < intervalTicks)
            {
                return;
            }
            lastFrameTicks = nowTicks;
            // 调整尺寸后的视频帧
            var frame = this.resizeBitmap(eventArgs.Frame, this.FrameSize);
            // 触发输出视频帧事件
            OnOutputFrame(this, new OutputFrameArgs(frame));
        }

        /// <summary>
        /// 视频源错误处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void VideoCaptureDevice_VideoSourceError(object sender, Accord.Video.VideoSourceErrorEventArgs eventArgs)
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

        /// <summary>
        /// （静态）获取视频输入设备列表
        /// </summary>
        /// <returns>视频输入设备列表</returns>
        public static List<FilterInfo> VideoDevices()
        {
            FilterInfoCollection filterInfos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            return filterInfos.ToList(); // 用 List 纯属个人喜好
        }
    }
}
