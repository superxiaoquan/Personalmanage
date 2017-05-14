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
    public partial class FormEdit : Form
    {
        DBDataContext db = new DBDataContext();
        public int cuan;
        public TimeTable TimeTable { get; set; }
        public FormEdit()
        {
            InitializeComponent();
            Load+=FormEdit_Load;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            BoundType();
            BoundTimeTable();
        }

        private void BoundTimeTable()
        {
            if (TimeTable == null) return;
            try
            {
            txtTitle.Text = TimeTable.Title;
            txtAddress.Text = TimeTable.Address;
            cboType.SelectedValue = TimeTable.TtpeId;
            dtBeginTime.Value = Convert.ToDateTime(TimeTable.BeginTime);
            dtEndTime.Value = Convert.ToDateTime(TimeTable.EndTime);
            txtContent.Rtf = TimeTable.MainContent;
            cbStatus.Checked = Convert.ToBoolean(TimeTable.IsFinished);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void BoundType()
        {
            cboType.DataSource = db.Type.ToList();
            cboType.DisplayMember = "Name";
            cboType.ValueMember = "Id";
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(TimeTable==null)
            {
                db.TimeTable.InsertOnSubmit(new TimeTable
                {
                Title = txtTitle.Text,
                Address = txtAddress.Text,
                TtpeId = Convert.ToInt32(cboType.SelectedValue),
                BeginTime = dtBeginTime.Value,
                EndTime = dtEndTime.Value,
                MainContent = txtContent.Rtf,
                IsFinished = cbStatus.Checked,
                typeId=Convert.ToInt32(cuan)
                });
            }
            else
            {
                var item = db.TimeTable.FirstOrDefault(t => t.Id == TimeTable.Id);
                item.Title = txtTitle.Text;
                item.Address = txtAddress.Text;
                item.TtpeId = Convert.ToInt32(cboType.SelectedValue);
                item.BeginTime = dtBeginTime.Value;
                item.EndTime = dtEndTime.Value;
                item.MainContent = txtContent.Rtf;
                item.IsFinished = cbStatus.Checked;
            }
            db.SubmitChanges();
            timer1.Start();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0) { this.Opacity -= 0.05; }
            else{Close();}
        }
    }
}
