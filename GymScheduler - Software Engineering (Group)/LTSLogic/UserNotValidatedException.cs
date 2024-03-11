using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTSLogic
{
    public class UserNotValidatedException : Exception
    {
        /// <summary>
        /// Throws exception with the provided message
        /// </summary>
        /// <param name="pMessage"></param>
        public UserNotValidatedException(string pMessage) : base(pMessage) { }
        /// <summary>
        /// Throws exception with the message "The password provided for this username is incorrect"
        /// </summary>
        public UserNotValidatedException() : base("The password provided for this username is incorrect") { }
    }
}
