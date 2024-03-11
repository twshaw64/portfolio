using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTSXML
{
    public class UserDetailException : Exception
    {
        /// <summary>
        /// Throw UserDetailException with message "One or more of the values entered are incorrect"
        /// </summary>
        public UserDetailException() : base("One or more of the values entered are incorrect") { }
        /// <summary>
        /// Throw UserDetailException with message pMessage
        /// </summary>
        /// <param name="pMessage">Exception Message</param>
        public UserDetailException(string pMessage) : base(pMessage) { }
    }
}
