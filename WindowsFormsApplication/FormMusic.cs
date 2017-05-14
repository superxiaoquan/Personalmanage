using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;	//Path类用到
using System.Media;    //SoundPlayer命名空间
using System.Threading;

namespace WindowsFormsApplication
{
    public partial class FormMusic : Form
    {
        string strallpath,strName,strPath;
        double max, min, bai,what=0.0;
        Thread th1;//程序集线程变量
        public FormMusic()
        {
            InitializeComponent();
        }
        

        private void LastMusicButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormMusic_Load(object sender, EventArgs e)
        {
            
            th1 = new Thread(new ThreadStart(r));
            th1.IsBackground = true;
            th1.Start();//开启线程
        }
        private delegate void read_value();
        private void r()
        {
            read_value rv = new read_value(read);
            this.Invoke(rv);//调用委托对象
        }
        /// <summary>
        /// 读取保存的歌曲文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void read()
        {
            System.IO.FileStream fs = new System.IO.FileStream("C:\\Users\\Administrator\\Desktop\\temp.text", System.IO.FileMode.Open, System.IO.FileAccess.Read);//实例化
            System.IO.StreamReader sr =new System.IO.StreamReader(fs, Encoding.Default);
            while(!sr.EndOfStream)
            {
                strallpath = sr.ReadLine();
                strName = strallpath.Substring(strallpath.LastIndexOf("\\") + 1);//获取文件名
                strPath = strallpath.Replace(strName, "");//获取文件路径
                
                listBox1.Items.Add(strName);//添加到列表框
            }
            sr.Close();
            fs.Close();
            th1.Abort();//关闭线程
            this.listBox1.SelectedIndex = 0;
           
            axWindowsMediaPlayer1.URL = strPath + listBox1.SelectedItem.ToString();
        }
      
        private void AddMusicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "请选择音乐文件";      //打开对话框的标题
            open.Filter = "音乐文件(*.mp3)|*.mp3";    //设置文件格式筛选
            if (open.ShowDialog() == DialogResult.OK) 
            {
                //还原最大值最小值进度条
                max = 0.0;
                min = 0.0;
                bai = 0.0;
                trackBar1.Value = 0;
                timer_jc.Enabled = false;//关闭检测
                axWindowsMediaPlayer1.URL = open.FileName;//添加到播放器
                timer_jc.Enabled = true;//开始检测进度
                what = 1.0;
                pictureBox1.ImageLocation = @"C:\Users\Administrator\Desktop\素材\pause_on.png";

                strallpath = open.FileName;
                strName=strallpath.Substring(strallpath.LastIndexOf("\\")+1);//获取文件名
                strPath = strallpath.Replace(strName,"");//获取文件路径
                
                listBox1.Items.Add(strName);//将音频文件添加到里面
                listBox1.SelectedIndex = listBox1.Items.Count - 1;//选择添加歌曲文件
            };   //显示打开对话框
            
            

        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; //获得当前选中歌曲的索引
            index++;

            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            listBox1.SelectedIndex = index; //将改变后的索引重新赋值给我当前选中项的索引
            max = 0.0;
            min = 0.0;
            bai = 0.0;
            trackBar1.Value = 0;
            timer_jc.Enabled = false;//关闭检测

            axWindowsMediaPlayer1.URL = strPath + listBox1.SelectedItem.ToString();
            timer_jc.Enabled = true;
        }

        private void LastMusicButton_Click_1(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; //获得当前选中歌曲的索引
            index--;

            if (index < 0)
            {
                index = listBox1.Items.Count - 1;
            }
            listBox1.SelectedIndex = index; //将改变后的索引重新赋值给我当前选中项的索引
            max = 0.0;
            min = 0.0;
            bai = 0.0;
            trackBar1.Value = 0;
            timer_jc.Enabled = false;//关闭检测

            axWindowsMediaPlayer1.URL = strPath + listBox1.SelectedItem.ToString();
            timer_jc.Enabled = true;
        }
        /// <summary>
        /// 检测媒体播放进度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_jc_Tick(object sender, EventArgs e)
        {    
            max = axWindowsMediaPlayer1.currentMedia.duration; //获取文件长度
            min = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;//获取文件当前播放位置
            bai = min / max;//计算百分比
            trackBar1.Value = (int)(bai * 100);//添加到滑块条中

        }
        /// <summary>
        /// 当鼠标按下执行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            timer_jc.Enabled = false;//停止检测播放进度
            axWindowsMediaPlayer1.Ctlcontrols.pause();//暂停播放文件
        }
        /// <summary>
        /// 当鼠标放下执行操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            double now_value=trackBar1.Value*0.1*0.1*max;//还原播放进度
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = now_value;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer_jc.Enabled = true;//继续检测进度
        }
        /// <summary>
        /// 双击播放
        /// </summary>
        
        private void listBox1_DoubleClick_1(object sender, EventArgs e)
        { if (listBox1.SelectedIndex == -1) return;
            //还原最大值最小值进度条
            max = 0.0;
            min = 0.0;
            bai = 0.0;
            trackBar1.Value = 0;
            timer_jc.Enabled = false;//关闭检测
           
            axWindowsMediaPlayer1.URL = strPath+listBox1.SelectedItem.ToString();
            timer_jc.Enabled = true;
            what=1.0;
            pictureBox1.ImageLocation = @"C:\Users\Administrator\Desktop\素材\pause_on.png";
            // SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = listsongs[listBox1.SelectedIndex];
            //sp.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
           
            if (what == 1.0)
            {

                axWindowsMediaPlayer1.Ctlcontrols.pause();//停止播放
                pictureBox1.ImageLocation = @"C:\Users\Administrator\Desktop\素材\play_on.png";
                what = 0.0; return;

            }      
            if(what==0.0)
            {
               
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox1.ImageLocation = @"C:\Users\Administrator\Desktop\素材\pause_on.png";
                what = 1.0;
            }
        }
        /// <summary>
        /// 关闭窗口时执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseMusicBox_Click(object sender, EventArgs e)
        {
            //保存播放列表歌曲
            string save = "";
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                save += strPath+listBox1.Items[i].ToString() + "\r\n";
            }
            System.IO.FileStream fs = new System.IO.FileStream("C:\\Users\\Administrator\\Desktop\\temp.text", System.IO.FileMode.Create, System.IO.FileAccess.Write);//实例化一个文件流
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fs, Encoding.Default);
            sw.Write(save);//写到文件
            sw.Close();//关闭文件流
            fs.Close();

            this.Close();
        }
        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex==-1)
            {
                return;
            }
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void 清空列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //清空之前先提示是否确认
            if(MessageBox.Show("是否清空列表？")==DialogResult.OK)
            {
                listBox1.Items.Clear();//清空
            }
        }

        private void skinTrackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = skinTrackBar1.Value;//设置播放声音
        }
        

    }
}
