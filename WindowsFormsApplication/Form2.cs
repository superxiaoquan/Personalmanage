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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int cuan;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            FormMain frm = new FormMain();
            frm.cuan = this.cuan;
            frm.Show();
            timer1.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
    
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timer1.Stop();
        }

    }
}
