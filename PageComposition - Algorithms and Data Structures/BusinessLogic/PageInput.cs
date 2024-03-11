using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{

    public enum Format { Fill, FillSoft, FillAdjust, LineMoment, FillSet };

    public class PageInput
    {
        public Format format;

        public int wrap = 0;

        public int wrapSoft = 0;

        public int columnMoment = 0;

        public List<String> words;

        internal static bool fillAdjust = false;

        internal static bool fillSet = false;

        public PageInput()
        {
            words = new List<String>();
        }

        public PageInput(Format format, int wrap, int wrapSoft, int columnMoment, List<String> words) //defining input params
        {
            this.format = format;
            this.wrap = wrap;
            this.wrapSoft = wrapSoft;
            this.columnMoment = columnMoment;
            this.words = words;
        }

        public Page Compose() // creates page based on params and returns it
        {
            switch (format)
            {
                case Format.Fill:
                    {
                        FillPage page = new FillPage(wrap);
                        page.Add(words);
                        return page;
                    }
                case Format.FillSoft:
                    {
                        FillPage page = new FillPage(wrap); //creates page that conforms to fill
                        page.Add(words);

                        var lineCount = 0; //used to check if fillSoft is conformed to
                        while (lineCount == 0)
                        {
                            lineCount = page.LineCount();
                            if(lineCount <= 1)
                            {
                                return page;
                            }
                            double softInitiate = Math.Ceiling(Convert.ToDouble(lineCount) / 2); //checks the halfway point of the page - decides where fillSoft starts

                            var wordSoft = new List<String>();

                            for (int i = (int)softInitiate; i < page.content.Count; i++) //for each line in page
                            {
                                foreach (var word in page.content[i].content) //for each word in the line
                                {
                                    wordSoft.Add(word); //adds the bottom half of the page to a seperate list
                                }
                            }

                            FillPage pageSoft = new FillPage(wrapSoft); //creates seperate page to apply fillSoft to the bottom half
                            pageSoft.Add(wordSoft); //apply softwrap to second page
                            

                            FillPage pageFinal = new FillPage(wrap); //new page to combine fill and fillSoft parts

                            for (int i = 0; i < softInitiate; i++) //adds fill half to final page
                            {
                                pageFinal.content.Add(page.content[i]);
                            }
                            for (int i = 0; i < pageSoft.content.Count; i++) //adds fillSoft half to final page
                            {
                                pageFinal.content.Add(pageSoft.content[i]);
                            }

                            int lineCountCheck = page.LineCount();
                            if (!(lineCount == lineCountCheck)) //if the linecount is the same now as it was before, fillSoft is properly applied
                            {
                                lineCount = 0; //loops round again if page isn't formatted correctly
                            }
                            else
                            {
                                return pageFinal; //returns page if formatted correctly
                            }
                        }
                        return null; // this code should not be reached
                    }
                case Format.FillAdjust:
                    {                        
                        fillAdjust = true;
                        FillPage page = new FillPage(wrap);
                        page.Add(words);

                        for (int i = 0; i <= page.content.Count; i++) //for each word
                        {
                            if (page.content.Count == 1) //if there's only 1 word, don't do anything
                            {
                                break;
                            }

                            int lineLength = (page.content[i].ToString()).Length; //length of line
                            int spaces = (page.content[i].content.Count - 1); //amount of words - 1
                            int spacesNeeded = wrap - lineLength; //space left on line

                            if (lineLength != page.wrap && spacesNeeded > 0) //if spaces are needed on the line
                            {
                                while(spacesNeeded >= spaces) //while spaces are distributed equally but there are more spaces needed
                                {
                                    for (int j = 0; j < spaces; j++) //amount of words - 1
                                    {
                                        if(page.content[i].content[j] != page.content[i].content.Last()) //add space after every word but the last
                                        {
                                            page.content[i].content[j] += " ";
                                        }
                                        spacesNeeded--;
                                    }
                                }
                                List<int> vowelCount = new List<int>(page.content[i].content.Count - 1); //each gap between two words
                                for (int j = 0; j < page.content[i].content.Count - 1; j++)                                
                                {
                                    int vowels = 0;
                                    string vowel = "aeiou";
                                    
                                    foreach (char c in page.content[i].content[j]) //vowels in current word
                                    {
                                        if (vowel.Contains(c))
                                        {
                                            vowels++;
                                        }
                                    }
                                    foreach (char c in page.content[i].content[j+1]) //vowels in next word
                                    {
                                        if (vowel.Contains(c))
                                        {
                                            vowels++;
                                        }
                                    }
                                    vowelCount.Add(vowels);
                                }
                                int maxIndex = vowelCount.IndexOf(vowelCount.Max()); //index of gap with most vowels
                                for (int k = 0; k < 0; k--)
                                {
                                    page.content[i].content[maxIndex] += " ";
                                    spacesNeeded--;
                                }
                            }
                        }

                        return page;
                    }
                case Format.LineMoment:
                    {
                        return null;
                    }
                case Format.FillSet:
                    {
                        fillSet = true;
                        FillPage page = new FillPage(wrap);                        
                        page.Add(words);
                        return page;
                    }
                default:
                    {
                        throw new Exception("Unknown format.");
                    }
            }
        }
    }

}
