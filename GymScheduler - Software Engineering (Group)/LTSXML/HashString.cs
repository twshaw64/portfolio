using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LTSXML
{
    public class HashString
    {
        public string HashedString(string pPlainText)
        {

            int i;
            string encrypted = "";
            int hashedchar;
            int outofbounds;
            char[] character = pPlainText.ToCharArray();
            for (i = 0; i < character.Length; i++)
            {

                hashedchar = (character[i] + 10);
                if (hashedchar < 33)
                {
                    hashedchar += 33;
                }
                else if (hashedchar > 127)
                {
                    outofbounds = hashedchar - 127;
                    hashedchar -= (outofbounds + i);
                }
                encrypted += (char)hashedchar;


            }
            return encrypted;
            throw new NotImplementedException();
        }

    }
}
