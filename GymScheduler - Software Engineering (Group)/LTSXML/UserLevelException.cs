using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTSXML
{
    public class UserLevelException : Exception
    {
        /// <summary>
        /// Throws exception with message "Invalid user level"
        /// </summary>
        public UserLevelException() : base("Invalid user level") { }
    }
}
