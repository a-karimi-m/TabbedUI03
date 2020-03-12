using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabbedUI03
{
    public partial class Form2 : Form , IRecordsMoveable
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        void IRecordsMoveable.MoveFirst()
        {
            progressBar1.Value = 0;
        }

        void IRecordsMoveable.MoveLast()
        {
            progressBar1.Value = 100;
        }

        void IRecordsMoveable.MoveNext()
        {
            progressBar1.Value += 10;
        }

        void IRecordsMoveable.MovePrevious()
        {
            progressBar1.Value -= 10;
        }
    }
}
