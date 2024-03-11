using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTSXML
{
    class BookingTypeException : Exception
    {
        /// <summary>
        /// Throws exception with messaage "Not a valid booking type"
        /// </summary>
        public BookingTypeException() : base("Not a valid booking type") { }
        public BookingTypeException(string pMessage) : base(pMessage) { }
    }
}
