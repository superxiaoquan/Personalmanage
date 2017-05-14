using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using   System.Data.SqlClient;

namespace WindowsFormsApplication
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        bool flagrun;
            bool flagRegister;
            string strConnect = "server=HOMEMIC-0MRSFD3;user id=sa;password=123456;database=DB;";
        private void skinButton1_Click(object sender, EventArgs e)
        {
            
            if ((skinTextBox1.Text.Length >= 4) && (skinTextBox1.Text.Length <= 12) )
            {
                flagrun = true;
            }
            else
            {
                MessageBox.Show("用户名长度为4-12,请重新输入！", "提示"); return;
            }
            if (flagrun == true)
            {
                SqlConnection conConnection = new SqlConnection(strConnect);
                conConnection.Open();
                string cmd = "select username from login";
                SqlCommand com = new SqlCommand(cmd, conConnection);
                SqlDataReader readerUser = com.ExecuteReader();
                
                while (readerUser.Read())
                {
                    if (skinTextBox1.Text == readerUser["username"].ToString().Trim())
                    {
                        MessageBox.Show("用户名重复，请重新输入", "提示");
                        return;
                    }
                    else if (skinTextBox1.Text != readerUser["username"].ToString().Trim())
                    {
                        flagRegister = true;
                    }
                } conConnection.Close();
            }
           
            if (flagRegister == true)
            {
                SqlConnection conConnection = new SqlConnection(strConnect);
                conConnection.Open();
                string cmd = "insert into login(username,userpass) values ('" + skinTextBox1.Text + "'," + "'" + skinTextBox2.Text + "') ";
                SqlCommand com = new SqlCommand(cmd, conConnection);
                com.ExecuteNonQuery();
                conConnection.Close();
                MessageBox.Show("注册成功！点击确定，返回登录界面。", "提示");
                this.Close();


            }
}
        
        public bool UserFlag;
        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinTextBox1_Paint(object sender, PaintEventArgs e)
        {

        }     
    }
}
