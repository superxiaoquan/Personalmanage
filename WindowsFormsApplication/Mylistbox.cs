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
    public partial class Mylistbox : ListBox
    {
        public Mylistbox()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Focused && this.SelectedItem != null)
            {

                Rectangle itemRect = this.GetItemRectangle(this.SelectedIndex);

                e.Graphics.FillRectangle(Brushes.Green, itemRect);

            }

            for (int i = 0; i < Items.Count; i++)
            {

                e.Graphics.DrawString(this.GetItemText(this.Items[i]), this.Font,

                new SolidBrush(this.ForeColor), this.GetItemRectangle(i));

            }

            base.OnPaint(e);

        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {

            this.Invalidate();

            base.OnSelectedIndexChanged(e);

        }

        
    }
}
