using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace blackjackPlayer
{
    class Program
    {
        #region Main Variables

        static int deckNo = 2;
        static int humNo = 0;
        static int bjpNo = 1;
        static string playerName = "";
        static string error = "";
        static Player tempPlayer = null;
        static int bet = 0;
        static int natCheck = 0; //4 states: 0 - no nat, 1 - pNat, 2 - dNat, 3 pdNat
        static List<int> natList = new List<int>();
        static int spdbCheck = 0; //4 states: 0 - neither, 1 - split, 2 - double, 3 - both
        public static bool manInput = false; //enables manual card input when set to true

        #endregion

        static void Main(string[] args) 
        {
            #region Game Options
            bool confirm = false;

            //Setting number of BJP Players
            while (confirm != true)
            {
                bjpNo = 1;
                Console.WriteLine("How many CPU Players? (default: 1)");
                try { bjpNo = int.Parse(Console.ReadLine()); }
                catch { }; //if the input is an integer, the value is put into 'bjpNo'
                Console.WriteLine(bjpNo + " CPU Player(s)? y/n");
                if (Console.ReadLine() == "y") //make better ||"Y"||"yes"||"YES"
                {
                    confirm = true;
                }
            }
            confirm = false;

            //Setting number of Human Players
            while (confirm != true)
            {
                humNo = 0;
                Console.WriteLine("\r\nHow many Human Players? (default: 0)");
                try { humNo = int.Parse(Console.ReadLine()); }
                catch { }; //if the input is an integer, the value is put into 'humNo'
                Console.WriteLine(humNo + " Human Player(s)? y/n");
                if (Console.ReadLine() == "y") //make better ||"Y"||"yes"||"YES"
                {
                    confirm = true;
                }
            }
            confirm = false;

            //Choosing whether to use manual (practise/debug) card input or regular shuffled card input
            while (confirm != true)
            {
                manInput = false;
                Console.WriteLine("\r\nRegular mode or Practice mode? r/p (default: regular)");

                string response = Console.ReadLine();
                if (response.ToLower() == "p")
                {
                    Console.WriteLine("Practise Mode? y/n");
                    if (Console.ReadLine() == "y") //make better ||"Y"||"yes"||"YES"
                    {
                        manInput = true;
                        confirm = true;
                    }
                }
                else
                {
                    Console.WriteLine("Regular Mode? y/n");
                    {
                        if (Console.ReadLine() == "y") //make better ||"Y"||"yes"||"YES"
                        {
                            confirm = true;
                        }
                    }
                }                
            }
            confirm = false;

            //Setting number of decks
            while (confirm != true)
            {
                deckNo = 2;
                Console.WriteLine("\r\nHow many Decks would you like to use? (default: 2)");
                try { deckNo = int.Parse(Console.ReadLine()); }
                catch { }; //if the input is an integer, the value is put into 'deckNo'
                Console.WriteLine(deckNo + " Deck(s)? y/n");
                if (Console.ReadLine() == "y") //make better ||"Y"||"yes"||"YES"
                {
                    confirm = true;
                }
            }
            confirm = false;

            #endregion

            #region Player Creation

            for (int i = 1; i < (humNo + 1); i++) //take names for, and create, human players
            {
                while (confirm != true)
                {
                    Console.WriteLine("\r\nPlease enter a name for Player " + i + " (default: Player " + i +")");
                    playerName = Console.ReadLine();
                    if (playerName.Trim() == "")
                    {
                        playerName = "Player " + i;
                    }
                    Console.WriteLine(playerName + "? y/n");
                    if (Console.ReadLine() == "y") //make better ||"Y"||"yes"||"YES"
                    {
                        confirm = true;
                    }
                    string count = i.ToString();
                    tempPlayer = new Player(i, playerName, true, out error);
                    Player.AddPlayer(tempPlayer);
                }
                confirm = false;
            }
            for (int i = 1; i < (bjpNo + 1); i++) //creates CPU players
            {
                tempPlayer = new Player(i + humNo, "CPU " + i, out error);
                Player.AddPlayer(tempPlayer);
            }

            tempPlayer = new Player((humNo+bjpNo+1), "Dealer", out error, true); //creates dealer's player
            Player.AddPlayer(tempPlayer);

            #endregion

            #region Game Setup

            bool rematch = false; //do while for infinite rematches
            do
            {
                rematch = false;
                Dealer.Initialise(deckNo); //Loads and shuffles deck
                Player[] players = Player.GetPlayers(); //Populates array with list of players

                #endregion

                #region Initial Bet

                for (int i = 0; i < humNo; i++) //Takes bets for all human players (human players are at the start of the array)
                {
                    while (confirm == false)
                    {
                        Console.WriteLine(players[i].ToString());
                        Console.WriteLine("\r\n" + Player.GetName(players[i]) + ", place your bet (default/minimum 2 chips)");
                        try { bet = int.Parse(Console.ReadLine()); }
                        catch { }; //if the input is an integer, the value is put into 'bet'
                        Console.WriteLine(bet + " chips? y/n");
                        if (Console.ReadLine() == "y") //make better ||"Y"||"yes"||"YES"
                        {
                            if (Player.ChipCheck(players[i], bet) == true)
                            {
                                Player.InitialBet(players[i], bet);
                                confirm = true;
                            }
                            else
                            {
                                Console.WriteLine("\r\nNot enough chips, please place a lower bet \r\n \r\n" + players[i]);
                            }
                        }
                    }
                    confirm = false;
                }

                for (int i = humNo; i < players.Length - 1; i++) //Take bets for BJP players
                {
                    Player.BJPBet(players[i]); //Makes bet based on chip count
                }

                #endregion

                #region Initial Draw

                foreach (Player currentPlayer in players) //Adds two cards to each player's hand
                {
                    Player.AddToHand(currentPlayer, Dealer.Draw());
                }
                foreach (Player currentPlayer in players)
                {
                    Player.AddToHand(currentPlayer, Dealer.Draw());
                }

                Player.PrintAllHands(players);

                Console.WriteLine("Press any key to continue...\r\n");
                Console.ReadKey();

                #endregion

                #region Natural Check

                for (int i = 0; i < players.Length; i++)
                {
                    if (Player.HandAssess(players[i]) == 21) //If any hands are natural 21s, add Player ID to natList, change nat token(s) to true, and skip to bet evaluation
                    {
                        natList.Add(i);

                        if (i != players.Length - 1)
                        {
                            if (natCheck == 0 || natCheck == 1)
                            {
                                natCheck = 1;
                            }
                            else
                            {
                                natCheck = 3;
                            }
                        }
                        else
                        {
                            if (natCheck == 0)
                            {
                                natCheck = 2;
                            }
                            else
                            {
                                natCheck = 3;
                            }
                        }
                    }
                }

                switch (natCheck)
                {
                    default:
                        {
                            Console.WriteLine("\r\nNatCheck Error \r\n"); //Expand
                            break;
                        }
                    case 1: //pNat - Player(s) recieves 3x their bet (2x bet profit)
                        {
                            for (int i = 0; i < natList.Count; i++)
                            {
                                playerName = Player.GetName(players[natList[i]]);
                                bet = Player.GetBet(players[natList[i]]) * 3; //bet x3
                                Console.WriteLine("Natural 21! \r\n" + playerName + " wins 2x their bet! \r\n" + playerName + " + " + bet);
                                Player.AddChips(players[natList[i]], bet);
                            }
                            break;
                        }
                    case 2: //dNat - Dealer collects all bets
                        {
                            Console.WriteLine("\r\nDealer Natural 21! \r\nDealer collects all bets! \r\n");
                            break;
                        }
                    case 3: //pdNat - Player recieves 1x their bet (0 profit), Dealer collects all other bets
                        {
                            for (int i = 0; i < natList.Count; i++)
                            {
                                playerName = Player.GetName(players[natList[i]]);
                                bet = Player.GetBet(players[natList[i]]);
                                Console.WriteLine("\r\nNatural 21! \r\n" + playerName + "wins 1x their bet! \r\n" + playerName + " + " + bet);
                                Player.AddChips(players[natList[i]], bet);
                            }
                            Console.WriteLine("\r\nDealer collects all remaining bets!\r\n");
                            break;
                        }
                    case 0:
                        {
                            #endregion

                            #region Human Player Turns

                            for (int i = 0; i < humNo; i++)
                            {
                                if ((Player.DoubleCheck(players[i]))) //Players can only double if their hands add up to 9, 10 or 11
                                { spdbCheck = 2; }
                                if (Player.SplitCheck(players[i])) //Players can only split if the cards in their hand are the same number or suit
                                { spdbCheck += 1; }

                                Player.HumTurn(players[i], spdbCheck); //Gives Players choice of Hit, Stand, Double or Split, depending on hand

                                Player.PrintAllHands(players);

                                Console.WriteLine("Press any key to continue...\r\n");
                                Console.ReadKey();
                            }

                            #endregion

                            #region BJP Player Turns

                            for (int i = humNo; i < players.Length - 1; i++) //loops all bjp players
                            {
                                Player.BJPTurn(players[i], players[players.Length - 1]); //calls method to execute bjp turn logic
                            }
                            
                            Console.WriteLine("Press any key to continue...\r\n");
                            Console.ReadKey();

                            #endregion

                            #region Dealer Turn

                            Player.DealerTurn(players[players.Length - 1]);

                            #endregion

                            #region Hand Comparison and Bet Evaluation

                            Console.WriteLine("Press any key to continue...\r\n");
                            Console.ReadKey();

                            int dTotal = Player.HandAssess(players[players.Length - 1]);

                            if (dTotal < 22)
                            {
                                List<Player> stdoffList = new List<Player>(); 
                                List<Player> sStdoffList = new List<Player>();
                                List<Player> winnerList = new List<Player>();
                                List<Player> sWinnerList = new List<Player>();
                                for (int i = 0; i < players.Length - 1; i++)
                                {
                                    // Stand off check - in the event of a stand off, all players recieve their bet back (nothing won or lost)
                                    if ((Player.BustCheck(players[i]) != true && Player.HandAssess(players[i]) == dTotal))
                                    {
                                        stdoffList.Add(players[i]);
                                    }
                                    if ((Player.SplitBustCheck(players[i]) != true && Player.SplitHandAssess(players[i]) == dTotal))
                                    {
                                        sStdoffList.Add(players[i]);
                                    }
                                    // Hand comparison - checks if player hands are below 21, and higher than the dealer's hand
                                    if ((Player.BustCheck(players[i]) != true && Player.HandAssess(players[i]) > dTotal))
                                    {
                                        winnerList.Add(players[i]);
                                        
                                    }
                                    if ((Player.SplitBustCheck(players[i]) != true && Player.SplitHandAssess(players[i]) > dTotal)) //error : shows if dealer goes bust
                                    {
                                        sWinnerList.Add(players[i]);
                                    }
                                }
                                if (winnerList.Count()>0 || sWinnerList.Count()>0)
                                {
                                    for (int i = 0; i < winnerList.Count(); i++)
                                    {
                                        Console.WriteLine("\r\n" + Player.GetName(players[i]) + " has beat the dealer, and won " + ((Player.GetBet(players[i]) * 2) + " chips\r\n"));
                                        Player.WinBet(players[i]);
                                    }
                                    for (int i = 0; i < sWinnerList.Count(); i++)
                                    {
                                        Console.WriteLine("\r\n" + Player.GetName(players[i]) + " has beat the dealer, and won " + ((Player.GetSBet(players[i]) * 2) + " chips\r\n"));
                                        Player.WinSBet(players[i]);
                                    }
                                }
                                else
                                {
                                    if(stdoffList.Count()>0 || sStdoffList.Count()>0)
                                    {
                                        for (int i = 0; i < stdoffList.Count(); i++)
                                        {
                                            Console.WriteLine("\r\n" + Player.GetName(players[i]) + " is in a stand off with the dealer! They have their bets returned.");
                                            Player.StandoffBet(players[i]);
                                        }
                                        for (int i = 0; i < sStdoffList.Count(); i++)
                                        {
                                            Console.WriteLine("\r\n" + Player.GetName(players[i]) + " is in a stand off with the dealer! They players have their bets returned.");
                                            Player.StandoffSBet(players[i]);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("The dealer has won, and collects bets");
                                    }                                        
                                }
                            }
                            else
                            {
                                Console.WriteLine("\r\nDealer has gone Bust!\r\n");
                                for (int i = 0; i < players.Length - 1; i++)
                                {
                                    if (Player.BustCheck(players[i]) != true)
                                    {
                                        Console.WriteLine("\r\n" + Player.GetName(players[i]) + " has beat the dealer, and won " + ((Player.GetBet(players[i]) * 2) + " chips\r\n"));
                                        Player.WinBet(players[i]);
                                    }

                                    if (Player.SplitBustCheck(players[i]) != true)
                                    {
                                        Console.WriteLine("\r\n" +Player.GetName(players[i]) + " has beat the dealer, and won " + ((Player.GetSBet(players[i]) * 2) + " chips\r\n"));
                                        Player.WinSBet(players[i]);
                                    }
                                }
                            }

                            break;
                        }
                }

                #endregion

                #region End of Game Breakdown and Menus

                Player.PrintAllHandsEnd(players);
                Console.WriteLine("\r\nThese are the current standings, would you like to play again? y/n");
                if (Console.ReadLine() == "y")
                {
                    Player.RematchReset(players);
                    natCheck = 0;
                    rematch = true;
                }
            }
            while (rematch == true);

            #endregion
        }
    }
}
