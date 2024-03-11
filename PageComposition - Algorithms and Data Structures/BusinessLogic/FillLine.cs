using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{

    public class FillLine : Line
    {

        internal FillLine(FillPage page) : base(page)
        {
        }

        internal override int Length() //Measures length of all valid words and spaces
        {
            if (content.Count >= 1)
            {
                int result = 0;
                foreach (String word in content)
                {
                    result += word.Length; //Measures word length
                    result += 1; //Accounts for the space character
                }
                return result-2; //accounts for the extra space at the end of the content
            }
            else
            {
                return 0; //consider 1 word lines
            }
        }

        internal override bool Overflow()
        {
            return this.WrapOverflow();
        }

        internal bool WrapOverflow()
        {
            return Length() >= ((FillPage)page).wrap; //Returns true if length is greater than or equal to the wrap
        }

        internal override void IntoText(StringBuilder text)
        {
            foreach (String word in content)
            {                
                text.Append(word.ToString());
                text.Append(" ");
            }
        }

    }
}
