using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace blackjackPlayer
{
    class Dealer
    {
        static void Main(string[] args)
        {
        }
        public static void Initiate(int deckNo)
        {
            List<int> deck = new List<int>(); //create deck
            for (int i = 1; i <= (deckNo*52); i++) //populate deck
            {
                deck.Add(i);
            }
            deck.Shuffle(); //shuffle deck

            Dictionary<int, string> cardDict = new Dictionary<int, string>(); //dictionary to convert card id to a more understandable string
            StreamReader reader = new StreamReader("cardDictInput.csv"); //load dictionary definitions
            string line;
            while ((line = reader.ReadLine()) != null) //populate dictionary
            {
                string[] values = line.Split(',');
                {
                    cardDict.Add(int.Parse(values[0]), values[1]);
                }
            }
            reader.Close();
        }
        public static int Draw()
        {
            return 0;
        }
    }
    public static class Extensions
    {
        private static Random rng = new Random();
        public static void Shuffle(this List<int> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
