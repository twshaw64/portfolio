using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{

    public abstract class Line
    {
        internal List<String> content = new List<String>();

        internal Page page;

        internal Line(Page page)
        {
            this.page = page;
        }

        internal abstract int Length();

        internal abstract bool Overflow();

        internal int Add(String word) //adds a word to line
        {
            content.Add(word);
            if (!Overflow()) //if length is shorter than wrap
            {
                return 1;
            }
            else
            {
                content.RemoveAt(content.Count - 1); // removes element responsible for overflow from list
                if (word.Length > ((FillPage)page).wrap)
                {
                    return 2;
                }
                return 0; //this code is reached at the end of a line
            }
        }

        internal abstract void IntoText(StringBuilder text);

        public override String ToString()
        {
            StringBuilder text = new StringBuilder();
            this.IntoText(text);
            return text.ToString();
        }
    }
}
