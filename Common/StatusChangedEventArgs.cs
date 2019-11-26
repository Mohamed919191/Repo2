using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class StatusChangedEventArgs : EventArgs
    {

        public string NewStatus { get; set; }


    }
}
