using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BusinessLogic
{

    public abstract class Page
    {
        internal List<Line> content;

        internal Line currentLine;

        internal int wrap;

        internal abstract bool Overflow();

        internal int LineCount()
        {
            return this.content.Count();
        }

        internal void Add(List<String> words) //adds word to a line (from list)
        {
            if (PageInput.fillSet)
            {
                var wordSort = words;
                words = wordSort.OrderByDescending(str => str.Length).ToList();                
                for (int i = 0; i < words.Count; i++)
                {
                    this.Add(words[0]); //add word to line
                    int spaceLeft = (wrap); //variable to check space left on line
                    spaceLeft -= (words[0].Length + 1); //length + 1 is to account for the space
                    words.RemoveAt(0); //remove from list
                    if ((words[0].Length > (spaceLeft)) && spaceLeft > 0) //if the next word can't fit on the line
                    {
                        for (int j = 0; j < (words.Count - 1); j++)
                        {
                            if (words[j].Length <= spaceLeft) //this will result in the largest word that can fit
                            {
                                this.Add(words[j]); //add to line
                                spaceLeft -= (words[j].Length + 1); //length + 1 is to account for the space
                                words.RemoveAt(j); //remove from list
                                j = 0;                                
                            }
                        }
                    }
                }
            }

            foreach (String w in words)
            {
                this.Add(w);
            }
        }

        internal void Add(String word) //adds word to a line (from string)
        {
            int add = currentLine.Add(word);
            if (add == 0) //if word can't be added to current line
            {
                AddLine();              //create new line and add it there
                Add(word);
            }
            if (add == 2) //if word can't be added to current line
            {
                AddLine();              //create new line and add it there
                currentLine.content.Add(word);
            }
        }

        internal abstract void AddLine();

        internal void IntoText(StringBuilder text)
        {
            foreach (Line line in content) //builds line
            {
                line.IntoText(text);    //content
                try
                {
                    text.Remove((text.Length - 1), 1);
                }
                catch
                {
                    continue;
                }
                text.Append("\r\n");    //return character
            }
        }

        public void ToFile(String fileName)
        {
            StringBuilder outText = new StringBuilder();
            IntoText(outText);

            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.Write(outText.ToString());
                }
            }
            catch (Exception e)
            {
                String message = "Failed to write output file: " + e.Message;
                Console.WriteLine(message);
                throw new Exception(message);
            }
        }

        public override String ToString()
        {
            StringBuilder outText = new StringBuilder();
            IntoText(outText);
            return outText.ToString();
        }

    }
}
