using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTSXML;

namespace LTSLogic
{
    public class ValidateLogin
    {
        private UserDetails User;
        private string password;
        public ValidateLogin(string pUsername, string pPassword)
        {
            User = UserDetails.Load(pUsername);
            password = pPassword;
        }
        
        /// <summary>
        /// Returns populated UserDetails object if user is successfully validated, throws exception if not
        /// </summary>
        /// <exception cref="UserNotValidatedException"></exception>"
        /// <exception cref="UserLevelException"></exception>
        
        public UserDetails Validate()
        {
            string hashedPassword = new HashString().HashedString(password);
            if (User.HashedPassword == hashedPassword) return User;
            throw new UserNotValidatedException();
        }

    }

}
