using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication
{
    public partial class FormMain : Form
    {
        DBDataContext db = new DBDataContext();
        public int cuan;
        public FormMain()
        {
            InitializeComponent();
            FormClosed += FormMain_FormClosed;
            Load+=FormMain_Load;
            this.SizeChanged +=FormMain_SizeChanged;
        }

        void FormMain_SizeChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            BoundType();
            BoundItems();
        }

       // private void FriendTime()
        //{
       //     System.DateTime currentTime = new System.DateTime();
       //     string strMd = currentTime.ToString("m");
      //      
      //  }
        private void BoundItems()
        {
            
            dgvItems.DataSource = db.TimeTable
                .Where(item => item.Title.Contains(txtTitle.Text))
                .Where(item => cboType.SelectedIndex == 0 ? true : item.TtpeId == Convert.ToInt32(cboType.SelectedValue))
                .Where(item => rbAll.Checked ? true : item.IsFinished == Convert.ToBoolean(rbIsFinished.Checked))
                .Where(item => item.typeId == Convert.ToInt32(cuan)) 
                .Select(item => new
                {
                    
                    标题 = item.Title,
                    分类 = item.Type.Name,
                    开始时间 = item.BeginTime,
                    结束时间 = item.EndTime,
                    状态 = Convert.ToBoolean(item.IsFinished) ? "已完成" : "未完成"
                }).ToList();
        }

        private void BoundType()
        {
            var types = db.Type.ToList();
            types.Insert(0, new Type { Id = 0, Name = "全部" });
            cboType.DataSource = types;
            cboType.DisplayMember = "Name";
            cboType.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoundItems();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 新建项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEdit frm = new FormEdit { TimeTable=null};
            frm.cuan = this.cuan;
            frm.ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvItems.SelectedRows.Count>0)
            {
                var id = Convert.ToString(dgvItems.SelectedRows[0].Cells[0].Value);
                var item=db.TimeTable.FirstOrDefault(t=>t.Title==id);
                db.TimeTable.DeleteOnSubmit(item);
                db.SubmitChanges();
                BoundItems();
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                var id = Convert.ToString(dgvItems.SelectedRows[0].Cells[0].Value);
                var item = db.TimeTable.FirstOrDefault(t => t.Title == id);
                FormEdit frm = new FormEdit { TimeTable = item };
                frm.cuan = this.cuan;
                frm.ShowDialog();
            }
           

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Friends frm = new Friends ();
            frm.cuan = this.cuan;
            frm.ShowDialog();
        }

        private void 暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                Thread thread = new Thread(new ThreadStart(PlayThread));
                thread.Start();
            }   
        }
        private void PlayThread()
        {
            axWindowsMediaPlayer1.URL = @"E:/Music/SomeOne.avi";
   
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FormMain_Resize(object sender,EventArgs e)
        {
           // if(this.WindowState==FormWindowState.Minimized)
           // {
          //      notifyIcon1.Visible = true;
          //  }
          //  else
          //  {
           //     notifyIcon1.Visible = false;
          //  }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          //  this.Visible = true;
          //  this.WindowState = FormWindowState.Normal;
        }

        private void skinContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void FormMain_SizeChanged_1(object sender, EventArgs e)
        {
         
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
      
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }

        private void 学习ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 我的清单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            FormRead frm = new FormRead();
            frm.cuan = this.cuan;
            frm.Show();
            

        }

        private void 音乐收藏夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusic frm = new FormMusic();
            //frm.cuan = this.cuan;
            frm.Show();
        }

    }
}
