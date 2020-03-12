using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace TabbedUI03
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xpTaskBarBox1_ItemClick(object sender, Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs e)
        {
            Form frm;
            switch (e.XPTaskBarItem.Name)
            {
                case "XPTaskBarItem0":
                     frm = new Form2
                    {
                        MdiParent = this
                    };
                    frm.Show();
                    break;
                case "XPTaskBarItem6":
                    frm = new Form3
                    {
                        MdiParent = this
                    };
                    frm.Show();
                    break;

            }





        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ((IRecordsMoveable)this.ActiveMdiChild).MoveFirst();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ((IRecordsMoveable)this.ActiveMdiChild).MovePrevious();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ((IRecordsMoveable)this.ActiveMdiChild).MoveNext();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ((IRecordsMoveable)this.ActiveMdiChild).MoveLast();
        }
    }
}
