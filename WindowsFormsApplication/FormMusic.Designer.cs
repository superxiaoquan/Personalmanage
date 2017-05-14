namespace WindowsFormsApplication
{
    partial class FormMusic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusic));
            this.LastMusicButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddMusicButton = new System.Windows.Forms.PictureBox();
            this.Min = new System.Windows.Forms.Label();
            this.CloseMusicBox = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new WindowsFormsApplication.Mylistbox();
            this.skinContextMenuStrip1 = new CCWin.SkinControl.SkinContextMenuStrip();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.skinTrackBar1 = new CCWin.SkinControl.SkinTrackBar();
            this.trackBar1 = new CCWin.SkinControl.SkinTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer_jc = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LastMusicButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddMusicButton)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.skinContextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // LastMusicButton
            // 
            this.LastMusicButton.BackColor = System.Drawing.Color.Transparent;
            this.LastMusicButton.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.preview_on;
            this.LastMusicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastMusicButton.Location = new System.Drawing.Point(11, 20);
            this.LastMusicButton.Name = "LastMusicButton";
            this.LastMusicButton.Size = new System.Drawing.Size(29, 26);
            this.LastMusicButton.TabIndex = 12;
            this.LastMusicButton.TabStop = false;
            this.LastMusicButton.Click += new System.EventHandler(this.LastMusicButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApplication.Properties.Resources.play_on;
            this.pictureBox1.Location = new System.Drawing.Point(46, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.next_on;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(81, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AddMusicButton
            // 
            this.AddMusicButton.BackColor = System.Drawing.Color.Transparent;
            this.AddMusicButton.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.list_on;
            this.AddMusicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMusicButton.Location = new System.Drawing.Point(116, 20);
            this.AddMusicButton.Name = "AddMusicButton";
            this.AddMusicButton.Size = new System.Drawing.Size(29, 26);
            this.AddMusicButton.TabIndex = 15;
            this.AddMusicButton.TabStop = false;
            this.AddMusicButton.Click += new System.EventHandler(this.AddMusicButton_Click);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.BackColor = System.Drawing.Color.Transparent;
            this.Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Min.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Min.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Min.Location = new System.Drawing.Point(724, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(18, 17);
            this.Min.TabIndex = 17;
            this.Min.Text = "__";
            this.Min.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // CloseMusicBox
            // 
            this.CloseMusicBox.AutoSize = true;
            this.CloseMusicBox.BackColor = System.Drawing.Color.Transparent;
            this.CloseMusicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseMusicBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseMusicBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseMusicBox.Location = new System.Drawing.Point(744, 5);
            this.CloseMusicBox.Name = "CloseMusicBox";
            this.CloseMusicBox.Size = new System.Drawing.Size(19, 19);
            this.CloseMusicBox.TabIndex = 18;
            this.CloseMusicBox.Text = "X";
            this.CloseMusicBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseMusicBox.Click += new System.EventHandler(this.CloseMusicBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(2, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 312);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "播放列表";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.listBox1.ContextMenuStrip = this.skinContextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 292);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick_1);
            // 
            // skinContextMenuStrip1
            // 
            this.skinContextMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinContextMenuStrip1.Back = System.Drawing.Color.White;
            this.skinContextMenuStrip1.BackRadius = 4;
            this.skinContextMenuStrip1.Base = System.Drawing.Color.Silver;
            this.skinContextMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinContextMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinContextMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinContextMenuStrip1.ItemAnamorphosis = true;
            this.skinContextMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.ItemBorderShow = true;
            this.skinContextMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.ItemRadius = 4;
            this.skinContextMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.清空列表ToolStripMenuItem});
            this.skinContextMenuStrip1.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.Name = "skinContextMenuStrip1";
            this.skinContextMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            this.skinContextMenuStrip1.SkinAllColor = true;
            this.skinContextMenuStrip1.TitleAnamorphosis = true;
            this.skinContextMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinContextMenuStrip1.TitleRadius = 4;
            this.skinContextMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 清空列表ToolStripMenuItem
            // 
            this.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem";
            this.清空列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空列表ToolStripMenuItem.Text = "清空列表";
            this.清空列表ToolStripMenuItem.Click += new System.EventHandler(this.清空列表ToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.skinTrackBar1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.LastMusicButton);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.AddMusicButton);
            this.groupBox2.Location = new System.Drawing.Point(2, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 58);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "music";
            // 
            // skinTrackBar1
            // 
            this.skinTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.skinTrackBar1.Bar = null;
            this.skinTrackBar1.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.skinTrackBar1.BaseColor = System.Drawing.Color.Gray;
            this.skinTrackBar1.Location = new System.Drawing.Point(151, 13);
            this.skinTrackBar1.Name = "skinTrackBar1";
            this.skinTrackBar1.Size = new System.Drawing.Size(65, 45);
            this.skinTrackBar1.TabIndex = 27;
            this.skinTrackBar1.Track = null;
            this.skinTrackBar1.Value = 65;
            this.skinTrackBar1.Scroll += new System.EventHandler(this.skinTrackBar1_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Transparent;
            this.trackBar1.Bar = null;
            this.trackBar1.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.trackBar1.BaseColor = System.Drawing.Color.Blue;
            this.trackBar1.Location = new System.Drawing.Point(222, 13);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(532, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Track = null;
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "music for me";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(451, 191);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(0, 0);
            this.axWindowsMediaPlayer1.TabIndex = 25;
            // 
            // timer_jc
            // 
            this.timer_jc.Interval = 1000;
            this.timer_jc.Tick += new System.EventHandler(this.timer_jc_Tick);
            // 
            // FormMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.skin4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 400);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseMusicBox);
            this.Controls.Add(this.Min);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音乐资源管理";
            this.Load += new System.EventHandler(this.FormMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LastMusicButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddMusicButton)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.skinContextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LastMusicButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox AddMusicButton;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label CloseMusicBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CCWin.SkinControl.SkinTrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Mylistbox listBox1;
        private System.Windows.Forms.Timer timer_jc;
        private CCWin.SkinControl.SkinContextMenuStrip skinContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空列表ToolStripMenuItem;
        private CCWin.SkinControl.SkinTrackBar skinTrackBar1;
    }
}