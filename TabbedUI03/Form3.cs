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
    public partial class Form3 : Form,IRecordsMoveable
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        void IRecordsMoveable.MoveFirst()
        {
            throw new NotImplementedException();
        }

        void IRecordsMoveable.MoveLast()
        {
            throw new NotImplementedException();
        }

        void IRecordsMoveable.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IRecordsMoveable.MovePrevious()
        {
            throw new NotImplementedException();
        }
    }
}
