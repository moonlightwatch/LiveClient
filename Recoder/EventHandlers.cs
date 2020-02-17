using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recoder
{
    /// <summary>
    /// 输出视频帧的事件参数
    /// </summary>
    public class OutputFrameArgs : EventArgs
    {
        /// <summary>
        /// 帧图像
        /// </summary>
        public Bitmap Frame { get; set; } = null;

        /// <summary>
        /// 创建输出视频帧事件参数
        /// </summary>
        /// <param name="frame">视频帧</param>
        public OutputFrameArgs(Bitmap frame)
        {
            Frame = frame;
        }
    }

    /// <summary>
    /// 输出视频帧事件处理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="eventArgs"></param>
    public delegate void OutputFrameHandler(object sender, OutputFrameArgs eventArgs);
}
