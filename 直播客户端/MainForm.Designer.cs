namespace 直播客户端
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUpDown_cameraFPS = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_cameraheight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_camerawidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_camerastop = new System.Windows.Forms.Button();
            this.button_camerastart = new System.Windows.Forms.Button();
            this.pictureBox_camera = new System.Windows.Forms.PictureBox();
            this.屏幕录制测试 = new System.Windows.Forms.TabPage();
            this.numericUpDown_screenheight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_screenwidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button_screenstop = new System.Windows.Forms.Button();
            this.button_screenstart = new System.Windows.Forms.Button();
            this.pictureBox_screen = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.打印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印预览VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤消UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重复RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.内容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cameraFPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cameraheight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_camerawidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).BeginInit();
            this.屏幕录制测试.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_screenheight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_screenwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_screen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 638);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.屏幕录制测试);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 638);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDown_cameraFPS);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numericUpDown_cameraheight);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numericUpDown_camerawidth);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button_camerastop);
            this.tabPage1.Controls.Add(this.button_camerastart);
            this.tabPage1.Controls.Add(this.pictureBox_camera);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "摄像头采集测试";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_cameraFPS
            // 
            this.numericUpDown_cameraFPS.Location = new System.Drawing.Point(619, 13);
            this.numericUpDown_cameraFPS.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_cameraFPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_cameraFPS.Name = "numericUpDown_cameraFPS";
            this.numericUpDown_cameraFPS.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_cameraFPS.TabIndex = 8;
            this.numericUpDown_cameraFPS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_cameraFPS.ValueChanged += new System.EventHandler(this.numericUpDown_cameraFPS_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "FPS：";
            // 
            // numericUpDown_cameraheight
            // 
            this.numericUpDown_cameraheight.Location = new System.Drawing.Point(372, 13);
            this.numericUpDown_cameraheight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_cameraheight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_cameraheight.Name = "numericUpDown_cameraheight";
            this.numericUpDown_cameraheight.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_cameraheight.TabIndex = 6;
            this.numericUpDown_cameraheight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_cameraheight.ValueChanged += new System.EventHandler(this.numericUpDown_cameraheight_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "高：";
            // 
            // numericUpDown_camerawidth
            // 
            this.numericUpDown_camerawidth.Location = new System.Drawing.Point(214, 13);
            this.numericUpDown_camerawidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_camerawidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_camerawidth.Name = "numericUpDown_camerawidth";
            this.numericUpDown_camerawidth.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_camerawidth.TabIndex = 4;
            this.numericUpDown_camerawidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_camerawidth.ValueChanged += new System.EventHandler(this.numericUpDown_camerawidth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "宽：";
            // 
            // button_camerastop
            // 
            this.button_camerastop.Enabled = false;
            this.button_camerastop.Location = new System.Drawing.Point(87, 12);
            this.button_camerastop.Name = "button_camerastop";
            this.button_camerastop.Size = new System.Drawing.Size(75, 23);
            this.button_camerastop.TabIndex = 2;
            this.button_camerastop.Text = "停止";
            this.button_camerastop.UseVisualStyleBackColor = true;
            this.button_camerastop.Click += new System.EventHandler(this.button_camerastop_Click);
            // 
            // button_camerastart
            // 
            this.button_camerastart.Location = new System.Drawing.Point(6, 12);
            this.button_camerastart.Name = "button_camerastart";
            this.button_camerastart.Size = new System.Drawing.Size(75, 23);
            this.button_camerastart.TabIndex = 1;
            this.button_camerastart.Text = "启动";
            this.button_camerastart.UseVisualStyleBackColor = true;
            this.button_camerastart.Click += new System.EventHandler(this.button_camerastart_Click);
            // 
            // pictureBox_camera
            // 
            this.pictureBox_camera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_camera.Location = new System.Drawing.Point(6, 40);
            this.pictureBox_camera.Name = "pictureBox_camera";
            this.pictureBox_camera.Size = new System.Drawing.Size(858, 566);
            this.pictureBox_camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_camera.TabIndex = 0;
            this.pictureBox_camera.TabStop = false;
            // 
            // 屏幕录制测试
            // 
            this.屏幕录制测试.Controls.Add(this.numericUpDown_screenheight);
            this.屏幕录制测试.Controls.Add(this.label5);
            this.屏幕录制测试.Controls.Add(this.numericUpDown_screenwidth);
            this.屏幕录制测试.Controls.Add(this.label6);
            this.屏幕录制测试.Controls.Add(this.button_screenstop);
            this.屏幕录制测试.Controls.Add(this.button_screenstart);
            this.屏幕录制测试.Controls.Add(this.pictureBox_screen);
            this.屏幕录制测试.Location = new System.Drawing.Point(4, 22);
            this.屏幕录制测试.Name = "屏幕录制测试";
            this.屏幕录制测试.Padding = new System.Windows.Forms.Padding(3);
            this.屏幕录制测试.Size = new System.Drawing.Size(872, 612);
            this.屏幕录制测试.TabIndex = 1;
            this.屏幕录制测试.Text = "屏幕录制测试";
            this.屏幕录制测试.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_screenheight
            // 
            this.numericUpDown_screenheight.Location = new System.Drawing.Point(297, 12);
            this.numericUpDown_screenheight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_screenheight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_screenheight.Name = "numericUpDown_screenheight";
            this.numericUpDown_screenheight.Size = new System.Drawing.Size(54, 21);
            this.numericUpDown_screenheight.TabIndex = 14;
            this.numericUpDown_screenheight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_screenheight.ValueChanged += new System.EventHandler(this.numericUpDown_screenheight_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "高：";
            // 
            // numericUpDown_screenwidth
            // 
            this.numericUpDown_screenwidth.Location = new System.Drawing.Point(214, 12);
            this.numericUpDown_screenwidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_screenwidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_screenwidth.Name = "numericUpDown_screenwidth";
            this.numericUpDown_screenwidth.Size = new System.Drawing.Size(51, 21);
            this.numericUpDown_screenwidth.TabIndex = 12;
            this.numericUpDown_screenwidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_screenwidth.ValueChanged += new System.EventHandler(this.numericUpDown_screenwidth_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "宽：";
            // 
            // button_screenstop
            // 
            this.button_screenstop.Enabled = false;
            this.button_screenstop.Location = new System.Drawing.Point(87, 11);
            this.button_screenstop.Name = "button_screenstop";
            this.button_screenstop.Size = new System.Drawing.Size(75, 23);
            this.button_screenstop.TabIndex = 10;
            this.button_screenstop.Text = "停止";
            this.button_screenstop.UseVisualStyleBackColor = true;
            this.button_screenstop.Click += new System.EventHandler(this.button_screenstop_Click);
            // 
            // button_screenstart
            // 
            this.button_screenstart.Location = new System.Drawing.Point(6, 11);
            this.button_screenstart.Name = "button_screenstart";
            this.button_screenstart.Size = new System.Drawing.Size(75, 23);
            this.button_screenstart.TabIndex = 9;
            this.button_screenstart.Text = "启动";
            this.button_screenstart.UseVisualStyleBackColor = true;
            this.button_screenstart.Click += new System.EventHandler(this.button_screenstart_Click);
            // 
            // pictureBox_screen
            // 
            this.pictureBox_screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_screen.Location = new System.Drawing.Point(6, 39);
            this.pictureBox_screen.Name = "pictureBox_screen";
            this.pictureBox_screen.Size = new System.Drawing.Size(858, 567);
            this.pictureBox_screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_screen.TabIndex = 1;
            this.pictureBox_screen.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.toolStripSeparator,
            this.保存SToolStripMenuItem,
            this.另存为AToolStripMenuItem,
            this.toolStripSeparator1,
            this.打印PToolStripMenuItem,
            this.打印预览VToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripMenuItem.Image")));
            this.新建NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripMenuItem.Image")));
            this.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(162, 6);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripMenuItem.Image")));
            this.保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // 打印PToolStripMenuItem
            // 
            this.打印PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印PToolStripMenuItem.Image")));
            this.打印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印PToolStripMenuItem.Name = "打印PToolStripMenuItem";
            this.打印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.打印PToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.打印PToolStripMenuItem.Text = "打印(&P)";
            // 
            // 打印预览VToolStripMenuItem
            // 
            this.打印预览VToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印预览VToolStripMenuItem.Image")));
            this.打印预览VToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印预览VToolStripMenuItem.Name = "打印预览VToolStripMenuItem";
            this.打印预览VToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.打印预览VToolStripMenuItem.Text = "打印预览(&V)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤消UToolStripMenuItem,
            this.重复RToolStripMenuItem,
            this.toolStripSeparator3,
            this.剪切TToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴PToolStripMenuItem,
            this.toolStripSeparator4,
            this.全选AToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 撤消UToolStripMenuItem
            // 
            this.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem";
            this.撤消UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤消UToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.撤消UToolStripMenuItem.Text = "撤消(&U)";
            // 
            // 重复RToolStripMenuItem
            // 
            this.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem";
            this.重复RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.重复RToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.重复RToolStripMenuItem.Text = "重复(&R)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // 剪切TToolStripMenuItem
            // 
            this.剪切TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪切TToolStripMenuItem.Image")));
            this.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem";
            this.剪切TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切TToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.剪切TToolStripMenuItem.Text = "剪切(&T)";
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripMenuItem.Image")));
            this.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            // 
            // 粘贴PToolStripMenuItem
            // 
            this.粘贴PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripMenuItem.Image")));
            this.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
            this.粘贴PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.粘贴PToolStripMenuItem.Text = "粘贴(&P)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.全选AToolStripMenuItem.Text = "全选(&A)";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自定义CToolStripMenuItem,
            this.选项OToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 自定义CToolStripMenuItem
            // 
            this.自定义CToolStripMenuItem.Name = "自定义CToolStripMenuItem";
            this.自定义CToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.自定义CToolStripMenuItem.Text = "自定义(&C)";
            // 
            // 选项OToolStripMenuItem
            // 
            this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            this.选项OToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.选项OToolStripMenuItem.Text = "选项(&O)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.内容CToolStripMenuItem,
            this.索引IToolStripMenuItem,
            this.搜索SToolStripMenuItem,
            this.toolStripSeparator5,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 内容CToolStripMenuItem
            // 
            this.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem";
            this.内容CToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.内容CToolStripMenuItem.Text = "内容(&C)";
            // 
            // 索引IToolStripMenuItem
            // 
            this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            this.索引IToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.索引IToolStripMenuItem.Text = "索引(&I)";
            // 
            // 搜索SToolStripMenuItem
            // 
            this.搜索SToolStripMenuItem.Name = "搜索SToolStripMenuItem";
            this.搜索SToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.搜索SToolStripMenuItem.Text = "搜索(&S)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(122, 6);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 685);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "直播客户端（测试）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cameraFPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cameraheight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_camerawidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).EndInit();
            this.屏幕录制测试.ResumeLayout(false);
            this.屏幕录制测试.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_screenheight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_screenwidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_screen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox_camera;
        private System.Windows.Forms.TabPage 屏幕录制测试;
        private System.Windows.Forms.PictureBox pictureBox_screen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 打印PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印预览VToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤消UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重复RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 剪切TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 内容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button button_camerastart;
        private System.Windows.Forms.NumericUpDown numericUpDown_cameraheight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_camerawidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_cameraFPS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_camerastop;
        private System.Windows.Forms.NumericUpDown numericUpDown_screenheight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_screenwidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_screenstop;
        private System.Windows.Forms.Button button_screenstart;
    }
}

