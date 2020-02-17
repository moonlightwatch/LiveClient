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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
