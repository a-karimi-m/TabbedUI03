using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbedUI03
{
    interface IRecordsMoveable
    {
        void MoveFirst();
        void MovePrevious();
        void MoveNext();
        void MoveLast();
    }
}
