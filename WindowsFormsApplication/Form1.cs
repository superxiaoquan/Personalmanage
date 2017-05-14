using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using   System.Data.SqlClient;

namespace WindowsFormsApplication
{
  
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            string consqlserver = "server=HOMEMIC-0MRSFD3;user id=sa;password=123456;database=DB;";
            
            SqlConnection con = new SqlConnection(consqlserver);
            con.Open();
            string sql = "select * from login where username='" + textBox1.Text + "' and userpass='" + textBox2.Text + "'";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader sread = com.ExecuteReader();
             
            if (textBox1.Text == "")
            {
                MessageBox.Show("用户名不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (sread.Read())
                {
                    MessageBox.Show("登录成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    con.Open();
                    this.Hide();
                    string sq = "select ID from login where username='"+textBox1.Text+"'";
                    SqlCommand cmd = new SqlCommand(sq, con);
                    Form2 MySplashForm = new Form2(); 
                    MySplashForm.cuan=(int)cmd.ExecuteScalar();
                    MySplashForm.ShowDialog();
                    con.Close();

                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void skinButton1_Click1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("用户名不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text.ToLower() == "yang" && textBox2.Text == "111")
                {
                    MessageBox.Show("登录成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                    Form2 MySplashForm = new Form2();
                    MySplashForm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                        Form3 SplashForm = new Form3();
                        SplashForm.ShowDialog();
        }





       }

}
