using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTSXML
{
    public class ReportException : Exception
    {
        public ReportException(string pMessage) : base(pMessage) { }
    }
}
