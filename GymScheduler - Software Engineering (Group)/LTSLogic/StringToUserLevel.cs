using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTSXML;

namespace LTSLogic
{
    public class StringToUserLevel
    {
        public static UserLevel StringToEnum(string pInput)
        {
            switch (pInput)
            {
                case "Gym Member": return UserLevel.GymMember;
                case "Personal Trainer": return UserLevel.PersonalTrainer;
                case "Society": return UserLevel.Society;
                case "Manager": return UserLevel.Manager;
                default: throw new UserLevelException();
            }
        }
    }
}
