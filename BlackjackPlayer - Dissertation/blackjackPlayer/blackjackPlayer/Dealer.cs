using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static blackjackPlayer.Program;
namespace blackjackPlayer
{
    class Dealer
    {
        static List<string> deck = new List<string>();
        private static Random rng = new Random();

        public static void Initialise(int deckNo)
        {
            for (int i = 0; i < deckNo; i++)
            {
                StreamReader reader = new StreamReader("deckInput.csv"); //load deck
                string line;
                while ((line = reader.ReadLine()) != null) //populate deck
                {
                    deck.Add(line);
                }
                reader.Close();
            }
            Shuffle(deck); //shuffle deck
        }

        public static void Shuffle(List<string> list) //Shuffles deck
        {
            int deckSize = list.Count; //deckSize starts at 52*deckNo, iterates down to 1
            while (deckSize > 1)
            {
                //chooses random number, swaps card from random position with card from iterator position
                deckSize--;
                int rPos = rng.Next(deckSize + 1); //generates 'random' int within the range 0-n
                string rCard = list[rPos]; //card from rPos in the deck is placed in rCard
                list[rPos] = list[deckSize]; //card from position deckSize is placed into position rPos
                list[deckSize] = rCard; //card from rPos (rCard) is placed into position deck size
            }
        }

        public static string Draw() //Returns card at top of deck, and deletes it from deck
        {
            if (manInput)
            {
                while (true)
                {
                    Console.WriteLine("Please input card (Format: 'ValueSuit' e.g. '2C')");
                    string input = Console.ReadLine().Trim();
                    if (deck.Contains(input.ToUpper()))
                    {
                        return input.ToUpper();
                    }
                    if (input.ToLower() == "card") //break out of loop and execute the regular draw method
                    { break; }
                    Console.WriteLine("Error: Input does not match format. Enter 'card' for a random card."); //Not actually random, just from the top of the deck
                }
            }
            string card = deck[0];
            deck.RemoveAt(0);
            return card;
        }
    }
}
