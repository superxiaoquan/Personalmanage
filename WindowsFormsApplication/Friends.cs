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
   
    public partial class Friends : Form
    {
        DBDataContext db = new DBDataContext();
        public int cuan;
        public Friends()
        {
            InitializeComponent();
            Load += Friends_Load;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void skinDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Friends_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
           BoundItems();
        }
        private void BoundItems()
        {

            skinDataGridView1.DataSource = db.FE
                .Where(item => item.typeId == Convert.ToInt32(cuan))
                .Select(item => new
                {
                    // string.Format("{0:M}",item.birthday)//item.birthday
                    姓名 = item.name,
                    性别 = item.sex,
                    职业 = item.professin,
                    生日 = string.Format("{0:M}", item.birthday),
                    联系方式=item.ContactWay,
                    类别 = item.kind,

                }).ToList();
        }
        private void BoundItems1()
        {

            skinDataGridView1.DataSource = db.FE
                .Where(item => item.typeId == Convert.ToInt32(cuan))
                .Where(item => cboType.SelectedIndex == 0 ? true : item.kind == cboType.SelectedItem.ToString())
                .Select(item => new
                {
                    // string.Format("{0:M}",item.birthday)//item.birthday
                    姓名 = item.name,
                    性别 = item.sex,
                    职业 = item.professin,
                    生日 = string.Format("{0:M}", item.birthday),
                    联系方式 = item.ContactWay,
                    类别 = item.kind,

                }).ToList();
        }
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void skinLabel2_Click(object sender, EventArgs e)
        {

        }

        private void skinTextBox4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skinLabel5_Click(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            string consqlserver = "server=HOMEMIC-0MRSFD3;user id=sa;password=123456;database=DB;";

            SqlConnection con = new SqlConnection(consqlserver);
            con.Open();
            string sq = "select sex from FE where name='" + textBox1.Text + "'and  typeId='"+cuan+"' ";
            SqlCommand cmd = new SqlCommand(sq, con);
            skinTextBox1.Text = (string)cmd.ExecuteScalar();
            string sq1 = "select birthday from FE where name='" + textBox1.Text + "'and  typeId='" + cuan + "' ";
            SqlCommand cmd1 = new SqlCommand(sq1, con);           
            skinTextBox2.Text = string.Format("{0:M}",cmd1.ExecuteScalar());
            string sq2 = "select professin from FE where name='" + textBox1.Text + "'and  typeId='" + cuan + "' ";
            SqlCommand cmd2 = new SqlCommand(sq2, con);
            skinTextBox3.Text = (string)cmd2.ExecuteScalar();
            string sq3 = "select hobby from FE where name='" + textBox1.Text + "'and  typeId='" + cuan + "' ";
            SqlCommand cmd3 = new SqlCommand(sq3, con);
            txtContent.Rtf = (string)cmd3.ExecuteScalar();
            string sq4 = "select ContactWay from FE where name='" + textBox1.Text + "'and  typeId='" + cuan + "' ";
            SqlCommand cmd4 = new SqlCommand(sq4, con);
           skinTextBox4.Text = (string)cmd4.ExecuteScalar(); 
            con.Close();
            BoundItems1();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (skinDataGridView1.SelectedRows.Count > 0)
            {
                var id = Convert.ToString(skinDataGridView1.SelectedRows[0].Cells[0].Value);
                var item = db.FE.FirstOrDefault(t => t.name == id);
                FriendEdit frm = new FriendEdit { FE = item };
                frm.cuan = this.cuan;
                frm.ShowDialog();
            }
        }

        private void 添加好友ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FriendEdit frm = new FriendEdit { FE = null };
            frm.cuan = this.cuan;
            frm.ShowDialog();
  
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (skinDataGridView1.SelectedRows.Count > 0)
            {
                var name = Convert.ToString(skinDataGridView1.SelectedRows[0].Cells[0].Value);
                var item = db.FE.FirstOrDefault(t => t.name == name);
                db.FE.DeleteOnSubmit(item);
                db.SubmitChanges();
                BoundItems();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
