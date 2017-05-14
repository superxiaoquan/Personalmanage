using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication
{
    public partial class FormRead : Form
    {
        DBDataContext db = new DBDataContext();
        public int cuan;
        Point mouseOff;//鼠标移动位置变量  
        bool leftFlag;//标签是否为左键 
        public FormRead()
        {
            InitializeComponent();
            Load += FormRead_Load;

            
        }

        private void FormRead_Load(object sender, EventArgs e)
        {
            
            BoundItems1();
            BoundItems2();
            Rend();
        
        }
        public void  Rend()
        {
            if (dataGridView2.Rows.Count < 4)
            {
                skinLabel8.Text = "0"; skinLabel9.Text = "小金刚";
                pictureBox2.BringToFront();
            }
            else if (dataGridView2.Rows.Count <= 10 && dataGridView2.Rows.Count >= 4)
            {
                skinLabel8.Text = "1"; skinLabel9.Text = "小书童";
                pictureBox1.BringToFront();
            }
            else if (dataGridView2.Rows.Count <= 30)
            {
                skinLabel8.Text = "2"; skinLabel9.Text = "书生!";
                pictureBox3.BringToFront();
            }
            else if (dataGridView2.Rows.Count <= 80)
            {
                skinLabel8.Text = "3"; skinLabel9.Text = "书鬼"; 
                pictureBox4.BringToFront();
            }
            else if (dataGridView2.Rows.Count <= 180)
            {
                skinLabel8.Text = "4"; skinLabel9.Text = "书仙";
                pictureBox7.BringToFront();
            }
            else if (dataGridView2.Rows.Count <= 360)
            {
                skinLabel8.Text = "5"; skinLabel9.Text = "书帝";
                pictureBox5.BringToFront();
            }
            else
            {
                skinLabel8.Text = "5"; skinLabel9.Text = "书神";
                pictureBox6.BringToFront();
            }
        }
        private void BoundItems1()
        {

            dataGridView1.DataSource = db.rending
                .Where(item =>item.IsFinish ==false)
                .Where(item => item.TypeId == Convert.ToInt32(cuan))
                .Select(item => new
                {
                    
                    书名 = item.BookName,
                    作者 = item.BookWriter       
                    
                }).ToList();
        }
        private void BoundItems2()
        {

            dataGridView2.DataSource = db.rending
                .Where(item => item.IsFinish == true)
                .Where(item => item.TypeId == Convert.ToInt32(cuan))
                .Select(item => new
                {

                    书名 = item.BookName,
                    作者 = item.BookWriter,
                    阅完时间=item.FinishTime

                }).ToList();
            dataGridView2.Columns[2].Visible = false;
        }
        bool flagRegister;
        private void skinButton1_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text!=null&&TextBox1.Text!="")
            {
                string strConnect = "server=HOMEMIC-0MRSFD3;user id=sa;password=123456;database=DB;";
                SqlConnection conConnection = new SqlConnection(strConnect);
                conConnection.Open();
                string cmd = "select BookName from rending";
                SqlCommand com = new SqlCommand(cmd, conConnection);
                SqlDataReader readerUser = com.ExecuteReader();

                while (readerUser.Read())
                {
                    if (TextBox1.Text == readerUser["BookName"].ToString().Trim())
                    {
                        MessageBox.Show("书籍已存在或书名不能为空", "提示");
                        return;
                    }
                    else if (TextBox1.Text != readerUser["BookName"].ToString().Trim())
                    {
                        flagRegister = true;
                    }
                }
                conConnection.Close();
                if (flagRegister == true)
                {
                    SqlConnection con = new SqlConnection(strConnect);
                    con.Open();
                    string cnm = "insert into rending(BookName,BookWriter,IsFinish,TypeId) values ('" + TextBox1.Text + "'," + "'" + TextBox2.Text + "'," + "'" + false + "'," + "'" + cuan + "') ";
                    SqlCommand comm = new SqlCommand(cnm, con);
                    comm.ExecuteNonQuery();
                    con.Close();
                    BoundItems1();
                }
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            
        }

        private void FormRead_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOff = new Point(-e.X, -e.Y); //得到变量的值  
            leftFlag = true;                  //点击左键按下时标注为true;  
        }

        private void FormRead_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置  
                Location = mouseSet;
            }  
        }

        private void FormRead_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;  
            }  
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var Name = Convert.ToString(dataGridView2.SelectedRows[0].Cells[0].Value);
                var item = db.rending.FirstOrDefault(t => t.BookName == Name);
                db.rending.DeleteOnSubmit(item);
                db.SubmitChanges();
                BoundItems2();
            }
            Rend();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var Name = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
                var item = db.rending.FirstOrDefault(t => t.BookName == Name);
                db.rending.DeleteOnSubmit(item);
                db.SubmitChanges();
                BoundItems1();
            }
        }

        private void 已读ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var Name = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
                var item = db.rending.FirstOrDefault(t => t.BookName == Name);
                item.IsFinish = true;
                item.FinishTime = System.DateTime.Now;
                db.SubmitChanges();
                BoundItems1();
                BoundItems2();
            }
            Rend();
        }

        private void skinLabel5_Click(object sender, EventArgs e)
        {
            this.Close();
  
        }

        private void skinLabel8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
       
        private DataTable CreateDateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("Volume1");
            DataRow dr;


            dr = dt.NewRow();
            dr["Date"] = string.Format("{0:Y}", System.DateTime.Now.AddMonths(-2));
            int number2 = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {

                if (string.Equals(string.Format("{0:Y}", dataGridView2.Rows[i].Cells[2].Value), string.Format("{0:Y}", System.DateTime.Now.AddMonths(-2)))) number2++;
            }
            dr["Volume1"] = number2;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Date"] = string.Format("{0:Y}", System.DateTime.Now.AddMonths(-1));
            int number1 = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {

                if (string.Equals(string.Format("{0:Y}", dataGridView2.Rows[i].Cells[2].Value), string.Format("{0:Y}", System.DateTime.Now.AddMonths(-1)))) number1++;
            }
            dr["Volume1"] = number1;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Date"] = string.Format("{0:Y}", System.DateTime.Now);
            int number = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {

                if (string.Equals(string.Format("{0:Y}", dataGridView2.Rows[i].Cells[2].Value), string.Format("{0:Y}", System.DateTime.Now))) number++;
            }
            dr["Volume1"] = number;
            dt.Rows.Add(dr);
            return dt;
        }
        private void chartData_Click(object sender, EventArgs e)
        {
            DataTable dt=default(DataTable);
            dt=CreateDateTable();
           chartData.DataSource = dt;
           chartData.Series[0].XValueMember = "Date";
           chartData.Series[0].YValueMembers = "Volume1";

           chartData.DataBind();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
