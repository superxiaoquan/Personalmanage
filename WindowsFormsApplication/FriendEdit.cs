using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FriendEdit : Form
    {
        DBDataContext db = new DBDataContext();
        public int cuan;
        public FE FE { get; set; }
        public FriendEdit()
        {
            InitializeComponent();
            Load += FriendEdit_Load;
        }


        private void skinTextBox3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void FriendEdit_Load(object sender, EventArgs e)
        {
            BoundTimeTable();
        }

        private void BoundTimeTable()
        {
            comboBox1.SelectedIndex = 0;
            if (FE == null) return;
            try
            {
                skinTextBox1.Text = FE.name;
                skinTextBox2.Text = FE.professin;
                skinTextBox4.Text = FE.sex;
                comboBox1.SelectedItem = FE.kind;
                skinTextBox3.Text = FE.ContactWay;
                skinDateTimePicker1.Text= Convert.ToString(FE.birthday);
                txtContent.Rtf = FE.hobby;
               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if(skinDateTimePicker1.Text=="")
            {
                skinDateTimePicker1.Text = Convert.ToString(System.DateTime.Now);
            }
            
            

            if (FE == null)
            {
                db.FE.InsertOnSubmit(new FE
                {
                    name = skinTextBox1.Text,
                    sex = skinTextBox4.Text,
                    professin=skinTextBox2.Text,
                    birthday = Convert.ToDateTime(skinDateTimePicker1.Text),
                    ContactWay=skinTextBox3.Text,
                    hobby = txtContent.Rtf,
                    kind =comboBox1.SelectedItem.ToString(),
                    typeId = Convert.ToInt32(cuan)
                });
            }
            else
            {
                var item = db.FE.FirstOrDefault(t => t.Id == FE.Id);
                  item.name = skinTextBox1.Text;
                   item. sex = skinTextBox4.Text;
                   item. professin=skinTextBox2.Text;
                    item.birthday = Convert.ToDateTime(skinDateTimePicker1.Text);
                    item.kind = comboBox1.SelectedItem.ToString();
                    item.hobby = txtContent.Rtf;
                    item.ContactWay = skinTextBox3.Text;
            }
            db.SubmitChanges();
            
            timer1.Start();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0) { this.Opacity -= 0.05; }
            else { Close(); }
        }

        private void skinDateTimePicker1_SelectedValueChange(object sender, string Item)
        {

        }



    }
}
