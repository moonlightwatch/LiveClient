using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 直播客户端
{
    public partial class MainForm : Form
    {
        private Recoder.CameraRecoder cameraRecoder = new Recoder.CameraRecoder();

        public MainForm()
        {
            InitializeComponent();
            this.numericUpDown_cameraFPS.Value = 1000 / cameraRecoder.FrameInterval;
            this.numericUpDown_camerawidth.Value = cameraRecoder.FrameSize.Width;
            this.numericUpDown_cameraheight.Value = cameraRecoder.FrameSize.Height;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cameraRecoder.StopRecoder();
        }

        private void button_camerastart_Click(object sender, EventArgs e)
        {
            cameraRecoder.StartRecoder();
            cameraRecoder.OnOutputFrame += CameraRecoder_OnOutputFrame;
            button_camerastop.Enabled = true;
            button_camerastart.Enabled = false;
        }

        private void button_camerastop_Click(object sender, EventArgs e)
        {
            cameraRecoder.StopRecoder();
            cameraRecoder.OnOutputFrame -= CameraRecoder_OnOutputFrame;
            button_camerastop.Enabled = false;
            button_camerastart.Enabled = true;
        }

        private void CameraRecoder_OnOutputFrame(object sender, Recoder.OutputFrameArgs eventArgs)
        {
            if (this.pictureBox_camera.Image != null)
            {
                // 由于调用频率高，自动回收不及时，要手动销毁
                this.pictureBox_camera.Image.Dispose();
            }
            this.pictureBox_camera.Image = eventArgs.Frame;
        }

        private void numericUpDown_camerawidth_ValueChanged(object sender, EventArgs e)
        {
            cameraRecoder.FrameSize = new Size((int)numericUpDown_camerawidth.Value, cameraRecoder.FrameSize.Height);
        }

        private void numericUpDown_cameraheight_ValueChanged(object sender, EventArgs e)
        {
            cameraRecoder.FrameSize = new Size(cameraRecoder.FrameSize.Width, (int)numericUpDown_cameraheight.Value);
        }

        private void numericUpDown_cameraFPS_ValueChanged(object sender, EventArgs e)
        {
            cameraRecoder.FrameInterval = 1000 / (int)numericUpDown_cameraFPS.Value;
        }
    }
}
