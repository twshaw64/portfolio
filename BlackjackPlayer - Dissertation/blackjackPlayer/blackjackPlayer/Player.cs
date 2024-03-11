using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace blackjackPlayer
{
    class Player
    {
        #region Player Methods
        private static List<Player> playerList = new List<Player>();//List of Players

        public static void AddPlayer(Player player) //Adds Players to playerList
        {
            playerList.Add(player);
        }

        public static Player[] GetPlayers() //Accesses list of Players
        {
            return playerList.ToArray();
        }

        public static void AddToHand(Player player, string card) //Adds dealt card to selected Player's hand
        {
            player.hand.Add(card);
        }

        public static void AddToSHand(Player player, string card) //Adds dealt card to selected Player's 2nd/split hand
        {
            player.splitHand.Add(card);
        }

        public static string PrintHand(Player player) //Returns selected Player's hand and bet as string
        {
            string hand = player.playerName + "'s hand: \r\n";
            foreach (string str in player.hand)
            {
                hand += str + "  ";
            }
            hand += "bet: " + player.bet + "\r\n";
            return hand;
        }

        public static string PrintSHand(Player player) //Returns selected Player's 2nd/Split hand and bet as string
        {
            string hand = "\r\n" + player.playerName + "'s split hand \r\n";
            foreach (string str in player.splitHand)
            {
                hand += str + "  ";
            }
            hand += "bet " + player.splitBet;
            return hand;
        }

        public static string DealerPrintHand(Player player) //Prints first card of Dealer's hand (second card is 'face down')
        {
            return "Dealer's Hand: \r\n" + player.hand[0] + "\r\n";
        }

        public static void PrintAllHands(Player[] players) //Prints the hand of all Players
        {
            Console.WriteLine(); //formatting
            for (int i = 0; i < players.Length - 1; i++) //Prints hands and split hands of all players except dealer
            {
                Console.WriteLine(PrintHand(players[i]));
                if (GetSBet(players[i]) != 0)
                {
                    PrintSHand(players[i]);
                }
            }

            Console.WriteLine(DealerPrintHand(players[players.Length - 1])); //Prints dealer's hand
        }

        public static void PrintAllHandsEnd(Player[] players) //Prints the hand of all Players
        {

            for (int i = 0; i < players.Length; i++) //Prints hands and split hands of all players except dealer
            {
                Console.WriteLine(PrintHand(players[i]) + "chips: " + players[i].chips);
                if (GetSBet(players[i]) != 0)
                {
                    PrintSHand(players[i]);
                }
            }
        }

        public static void InitialBet(Player player, int bet) //Sets Player's bet
        {
            player.chips -= bet;
            player.bet = bet;
        }

        public static void DoubleBet(Player player) //Doubles player's bet
        {
            player.chips -= player.bet;
            player.bet += player.bet;
        }

        public static void DoubleSBet(Player player) //Doubles player's bet
        {
            player.chips -= player.bet;
            player.splitBet += player.splitBet;
        }

        public static void SplitBet(Player player)
        {
            player.chips -= player.bet;
            player.splitBet = player.bet;
        }

        public static void StandoffBet(Player player)
        {
            player.chips += player.bet;
        }

        public static void StandoffSBet(Player player)
        {
            player.chips += player.bet;
        }

        public static void WinBet(Player player) //Adds bet winnings to chips and resets bet
        {
            player.chips += (player.bet + player.bet);
        }

        public static void WinSBet(Player player) //Adds split bet winnings to chips and resets bet
        {
            player.chips += (player.splitBet + player.splitBet);
        }

        public static int GetBet(Player player) //Returns Player's bet as int
        {
            return player.bet;
        }

        public static int GetSBet(Player player) //Returns Player's bet as int
        {
            return player.splitBet;
        }

        public static bool ChipCheck(Player player, int bet) //Checks if a Player has sufficient chips to make a bet
        {
            if (player.chips >= bet) { return true; }
            else { return false; }
        }

        public static void AddChips(Player player, int winnings) //Adds chips to a Player's chip pool
        {
            player.chips += winnings;
        }

        public static int GetChips(Player player, bool bjpTok) //Returns chips as int
        {
            return player.chips;
        }

        public static string GetChips(Player player) // Returns chips as string
        {
            return player.chips.ToString();
        }

        public static string GetName(Player player) //Returns Player name as string
        {
            return player.playerName;
        }

        public static bool SplitCheck(Player player) //Assesses whether a player can split their hand
        {
            string card1 = player.hand[0];
            string card2 = player.hand[1];
            char suit1 = card1[card1.Length - 1];
            char suit2 = card2[card2.Length - 1];

            if (card1.Remove(card1.Length - 1, 1) == card2.Remove(card2.Length - 1, 1) && player.chips > player.bet)
            {
                return true;
            }

            return false;
        }

        public static bool DoubleCheck(Player player) //Assesses whether a player can double down with their hand
        {
            int hand = HandAssess(player);
            if (hand == 9 | hand == 10 | hand == 11 && player.chips > player.bet)
            {
                return true;
            }

            return false;
        }

        public static bool SDoubleCheck(Player player) //Assesses whether a player can double down with their splitHand
        {
            int hand = SplitHandAssess(player);
            
            hand = SplitHandAssess(player);
            if (hand == 9 | hand == 10 | hand == 11 && player.chips > player.splitBet)
            {
                return true;
            }

            return false;
        }

        public static void SplitHand(Player player) //Moves second card in players hand to their splitHand, then places an equal bet on that hand
        {
            player.splitHand.Add(player.hand[1]);
            player.hand.RemoveAt(1);
            SplitBet(player);
        }

        public static void GoBust(Player player) //Makes bust token true
        {
            player.bustTok = true;
        }

        public static void SplitGoBust(Player player) //Makes split bust token true
        {
            player.splitBustTok = true;
        }

        public static bool BustCheck(Player player) //returns bust token
        {
            return player.bustTok;
        }

        public static bool SplitBustCheck(Player player) //returns bust token
        {
            return player.splitBustTok;
        }

        public static void RematchReset(Player[] pArr) //sets bust tokens and bets back to default values
        {
            for (int i = 0; i < pArr.Count(); i++)
            {
                pArr[i].bustTok = false;
                pArr[i].splitBustTok = true;
                pArr[i].bet = 0;
                pArr[i].splitBet = 0;
                pArr[i].hand.Clear();
                pArr[i].splitHand.Clear();
            }
        }

        public static int HandAssess(Player player) //Returns value of hand, ignoring suits
        {
            int aceCount = 0;
            int hand = 0;
            int parseChk = 0;
            string trim;
            foreach (string str in player.hand)
            {
                trim = str.Remove(str.Length - 1, 1);
                if (int.TryParse(trim, out parseChk)) //Number card handling
                {
                    hand += parseChk;
                }
                else
                {
                    switch (trim) //J/Q/K handling
                    {
                        case ("A"):
                            {
                                aceCount += 1;
                                break;
                            }
                        case "J":
                            {
                                hand += 10;
                                break;
                            }
                        case "Q":
                            {
                                hand += 10;
                                break;
                            }
                        case "K":
                            {
                                hand += 10;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
            }
            for (int i = 0; i < aceCount; i++) //Ace Handling
            {
                if (hand + 11 > 21)
                {
                    hand += 1;
                }
                else
                {
                    hand += 11;
                }
            }

            return hand;
        }

        public static int SplitHandAssess(Player player) //Returns value of hand, ignoring suits
        {
            int aceCount = 0;
            int hand = 0;
            int parseChk = 0;
            string trim;
            foreach (string str in player.splitHand)
            {
                trim = str.Remove(str.Length - 1, 1);
                if (int.TryParse(trim, out parseChk)) //Number card handling
                {
                    hand += parseChk;
                }
                else
                {
                    switch (trim) //J/Q/K handling
                    {
                        case "A":
                            {
                                aceCount += 1;
                                break;
                            }
                        case "J":
                            {
                                hand += 10;
                                break;
                            }
                        case "Q":
                            {
                                hand += 10;
                                break;
                            }
                        case "K":
                            {
                                hand += 10;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
            }
            for (int i = 0; i < aceCount; i++) //Ace Handling
            {
                if (hand + 11 > 21)
                {
                    hand += 1;
                }
                else
                {
                    hand += 11;
                }
            }

            return hand;
        }

        public static void BasicTurn(Player player, bool confirm) //Turn where Hit and Stand are possible actions
        {
            while (confirm == false)
            {
                Console.WriteLine(PrintHand(player) + "\r\n" + GetName(player) + " do you want to hit(h) or stand(s)? \r\n");

                switch (Console.ReadLine())
                {
                    case "h": //add one card to hand, and assess hand total
                        {
                            Console.WriteLine(GetName(player) + " hits \r\n");
                            AddToHand(player, Dealer.Draw());
                            
                            if (HandAssess(player) > 21) //check if hand is larger than 21
                            {
                                GoBust(player);
                                confirm = true;
                            }
                            if (DoubleCheck(player)) //checks if next turn is double turn
                            {
                                DoubleTurn(player, confirm);
                                break;
                            }
                            break;
                        }
                    case "s": //end turn with current hand
                        {
                            Console.WriteLine(GetName(player) + " stands \r\n"); //Player draws no more cards and ends turn
                            confirm = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid input \r\n");
                            break;
                        }
                }
            }
        }

        public static void BasicSTurn(Player player, bool confirm) //Same as BasicTurn, but modifies the split variations of Player members
        {
            while (confirm == false)
            {
                Console.WriteLine(PrintSHand(player) + "\r\n" + GetName(player) + " do you want to hit(h) or stand(s)? \r\n");

                switch (Console.ReadLine())
                {
                    case "h": //add one card to hand, and assess hand total
                        {
                            Console.WriteLine(GetName(player) + " hits \r\n");
                            AddToSHand(player, Dealer.Draw());
                            PrintSHand(player);

                            if (SplitHandAssess(player) > 21) //check if hand is larger than 21
                            {
                                SplitGoBust(player);
                                confirm = true;
                            }
                            if (SDoubleCheck(player)) //checks if next turn is double turn
                            {
                                DoubleSTurn(player, confirm);
                                break;
                            }
                            break;
                        }
                    case "s": //end turn with current hand
                        {
                            Console.WriteLine(GetName(player) + " stands \r\n"); //Player draws no more cards and ends turn
                            confirm = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid input \r\n");
                            break;
                        }
                }
            }
        }

        public static void SplitTurn(Player player, bool confirm) //Turn where Hit, Stand and Split are possible actions
        {
            while (confirm == false)
            {
                Console.WriteLine(PrintHand(player) + "\r\n" + GetName(player) + " do you want to hit(h), stand(s) or split(sp)? \r\n");

                switch (Console.ReadLine())
                {
                    case "h":
                        {
                            Console.WriteLine(GetName(player) + " hits \r\n");
                            AddToHand(player, Dealer.Draw());

                            if (HandAssess(player) > 21) //check if hand is larger than 21
                            {
                                GoBust(player);
                                confirm = true;
                            }

                            if (DoubleCheck(player)) //checks if next turn is double turn
                            {
                                DoubleTurn(player, confirm);
                                break;
                            }
                            else
                            {
                                BasicTurn(player, confirm);
                            }
                            break;
                        }
                    case "s":
                        {
                            Console.WriteLine(GetName(player) + " stands \r\n"); //Player draws no more cards and ends turn
                            confirm = true;
                            break;
                        }
                    case "sp":
                        {
                            SplitPhase(player, confirm);
                            confirm = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid input \r\n");
                            break;
                        }
                }
            }
        }

        public static void DoubleTurn(Player player, bool confirm) //Turn where Hit, Stand and Double are possible actions
        {
            while (confirm == false)
            {
                Console.WriteLine(PrintHand(player) + "\r\n" + GetName(player) + " do you want to hit(h), stand(s) or double(s)? \r\n");

                switch (Console.ReadLine())
                {
                    case "h":
                        {
                            Console.WriteLine(GetName(player) + " hits \r\n");
                            AddToHand(player, Dealer.Draw());

                            if (HandAssess(player) > 21) //check if hand is larger than 21
                            {
                                GoBust(player);
                                confirm = true;
                            }
                            break;
                        }
                    case "s":
                        {
                            Console.WriteLine(GetName(player) + " stands \r\n"); //Player draws no more cards and ends turn
                            confirm = true;
                            break;
                        }
                    case "d":
                        {
                            DoubleBet(player);
                            Console.WriteLine(GetName(player) + " doubles \r\nNew bet: " + GetBet(player)); //Player doubles bet, only recieves one more card

                            AddToHand(player, Dealer.Draw());

                            if (HandAssess(player) > 21) //check if hand is larger than 21
                            {
                                GoBust(player);
                            }
                            confirm = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid input \r\n");
                            break;
                        }
                }
            }
        }

        public static void DoubleSTurn(Player player, bool confirm) //Turn where Hit, Stand and Double are possible actions
        {
            while (confirm == false)
            {
                Console.WriteLine(PrintHand(player) + "\r\n" + GetName(player) + " do you want to hit(h), stand(s) or double(d)? \r\n");

                switch (Console.ReadLine())
                {
                    case "h":
                        {
                            Console.WriteLine(GetName(player) + " hits \r\n");
                            AddToSHand(player, Dealer.Draw());
                            PrintSHand(player);

                            if (SplitHandAssess(player) > 21) //check if hand is larger than 21
                            {
                                SplitGoBust(player);
                                confirm = true;
                            }
                            break;
                        }
                    case "s":
                        {
                            Console.WriteLine(GetName(player) + " stands \r\n"); //Player draws no more cards and ends turn
                            confirm = true;
                            break;
                        }
                    case "d":
                        {
                            DoubleSBet(player);
                            Console.WriteLine(GetName(player) + " doubles \r\n New bet: " + GetSBet(player)); //Player doubles bet, only recieves one more card

                            AddToSHand(player, Dealer.Draw());
                            PrintSHand(player);

                            if (SplitHandAssess(player) > 21) //check if hand is larger than 21
                            {
                                SplitGoBust(player);
                            }
                            confirm = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid input \r\n");
                            break;
                        }
                }
            }
        }

        public static void SplitDoubleTurn(Player player, bool confirm) //Turn where Hit, Stand, Double and Split are possible actions
        {
            while (confirm == false)
            {
                Console.WriteLine(PrintHand(player) + "\r\n" + GetName(player) + " do you want to hit(h), stand(s), double(d) or split(sp)? \r\n");
                switch (Console.ReadLine())
                {
                    case "h":
                        {
                            Console.WriteLine(GetName(player) + " hits \r\n");
                            AddToHand(player, Dealer.Draw());

                            if (HandAssess(player) > 21) //check if hand is larger than 21
                            {
                                GoBust(player);
                                confirm = true;
                            }
                            break;
                        }
                    case "s":
                        {
                            Console.WriteLine(GetName(player) + " stands \r\n"); //Player draws no more cards and ends turn
                            confirm = true;
                            break;
                        }
                    case "d":
                        {
                            DoubleBet(player);
                            Console.WriteLine(GetName(player) + " doubles \r\n New bet: " + GetBet(player)); //Player doubles bet, only recieves one more card

                            AddToHand(player, Dealer.Draw());

                            if (HandAssess(player) > 21) //check if hand is larger than 21
                            {
                                GoBust(player);
                            }
                            confirm = true;
                            break;
                        }
                    case "sp":
                        {
                            SplitPhase(player, confirm);
                            confirm = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid input \r\n");
                            break;
                        }
                }
            }
        }

        static void SplitPhase(Player player, bool confirm) //Completes turns for both hands of a Player who decided to Split
        {
            player.splitBustTok = false;
            Console.WriteLine(GetName(player) + " splits \r\n"); //Player splits their two cards into two seperate hands, placing an equal bet on the new hand
            SplitHand(player);

            Console.WriteLine("Hand One: \r\n"); //Hand one turn
            if (DoubleCheck(player))
            {
                DoubleTurn(player, confirm);
            }
            else
            {
                BasicTurn(player, confirm);
            }

            Console.WriteLine("Hand Two: \r\n"); //Hand two turn
            if (SDoubleCheck(player))
            {
                DoubleSTurn(player, confirm);
            }
            else
            {
                BasicSTurn(player, confirm);
            }
        }

        public static void HumTurn(Player player, int spdbCheck) //Gives Players choice of Hit, Stand, Double or Split, depending on hand
        {
            bool confirm = false;
            switch (spdbCheck)
            {
                case 0: //Neither
                    {
                        BasicTurn(player, confirm); //hit or stand
                        break;
                    }
                case 1: //Split
                    {
                        SplitTurn(player, confirm);
                        break;
                    }
                case 2: //Double
                    {
                        DoubleTurn(player, confirm);
                        break;
                    }
                case 3: //Split Double
                    {
                        SplitDoubleTurn(player, confirm);
                        break;
                    }
            }
        }

        #endregion

        #region BJP Methods

        public static void BJPTurn(Player bjp, Player dealer) //Completes BJP's turn
        {
            Console.WriteLine(PrintHand(bjp));            

            #region Pair Check

            bool pairBool = (SplitCheck(bjp)); //if both cards in hand are the same, bjp can split
            bool splitBool = false; //represents if BJP has decided to split
            bool softHand = false; //if the hand has an ace, it is soft
            string dcard = dealer.hand[0]; //dealer's card
            dcard = dcard.Remove(dcard.Length - 1, 1); //removes suit from end of dcard
            char decision = ' ';

            while (decision != 's') //repeat until either bust or stand
            {
                for(int i = 0; i < bjp.hand.Count; i++) //check hand for ace
                {
                    string trim = bjp.hand[i];
                    trim = trim.Remove(trim.Length - 1, 1);
                    if(trim == "A")
                    {
                        softHand = true;
                        break;
                    }
                }

                if (pairBool == true) //method to decide action for a pair hand
                {
                    pairBool = false; //bjpPair only runs once. if another turn is taken by the BJP, it will use the bjpHard/bjpSoft method. as it wouldn't be able to split after turn 1
                    decision = bjpPair(bjp.hand[0], dcard);
                }
                else
                {
                    #endregion

                    #region Hard/Soft Check

                    if (softHand == false) //calls hard or soft method, depending on if the hand contains an ace
                    { decision = bjpHard(HandAssess(bjp), dcard); }
                    else
                    { decision = bjpSoft(HandAssess(bjp), dcard); }
                }
                #endregion

                #region Move Logic
                
                //if bjp doesn't have enough chips to double or split, hit instead
                if (decision == 'd' || decision == 'p')
                {
                    if(bjp.chips < bjp.bet)
                    {
                        decision = 'h';
                    }    
                }

                MoveLogic(bjp, decision); //logic for hit/stand/double/switch functionality

                #endregion

                #region Bust Check

                if (bjp.bustTok == true)
                { break; }

            }

            #endregion

            #region Split Logic
            //enabled in MoveLogic
            if (bjp.splitBustTok) //same logic as above while loop, but for split hand
            {
                softHand = false;
                char splitDecision = ' ';
                while (splitDecision != 's') //while split hand is not standing or bust, loop split move method
                {
                    for (int i = 0; i < bjp.hand.Count; i++) //check hand for ace
                    {
                        string trim = bjp.splitHand[0];
                        trim = trim.Remove(trim.Length - 1, 1);
                        if (trim == "A")
                        {
                            softHand = true;
                        }
                    }
                    if (softHand)
                    { splitDecision = bjpSoft(SplitHandAssess(bjp), dcard); }
                    else
                    { splitDecision = bjpHard(SplitHandAssess(bjp), dcard); }
                    //if bjp doesn't have enough chips to double, hit instead
                    if (decision == 'd')
                    {
                        if (bjp.chips < bjp.splitBet)
                        {
                            decision = 'h';
                        }
                    }
                    SplitMoveLogic(bjp, splitDecision);
                    if (bjp.splitBustTok == true)
                    { break; }
                }
            }
        }
        #endregion

        #region Pair Switch
        public static char bjpPair(string hand, string dcard) //switches based on player hand, and then dealer hand, if necessary, to select the appropriate move
        {
            hand = hand.Remove(hand.Length - 1, 1); //removes suit from end of card
            switch (hand)
            {
                case "2":
                case "6":
                    switch (dcard)
                    {
                        case "8":
                        case "9":
                        case "10":
                        case "A":
                            { return 'h'; }
                        default:
                            { return 'p'; }
                    }
                case "3":
                    switch (dcard)
                    {
                        case "9":
                        case "10":
                        case "A":
                            { return 'h'; }
                        default:
                            { return 'p'; }
                    }
                case "4":
                    {
                        switch (dcard)
                        {
                            case "4":
                            case "5":
                            case "6":
                                { return 'h'; }
                            default:
                                { return 'p'; }
                        }
                    }
                case "5":
                    {
                        switch (dcard)
                        {
                            case "10":
                            case "A":
                                { return 'h'; }
                            default:
                                { return 'd'; }
                        }
                    }
                case "7":
                    switch (dcard)
                    {
                        case "9":
                        case "A":
                            { return 'h'; }
                        case "10":
                            { return 's'; }
                        default:
                            { return 'p'; }
                    }
                case "8":
                case "A":
                    { return 'p'; }
                case "9":
                    {
                        switch (dcard)
                        {
                            case "7":
                            case "10":
                            case "A":
                                { return 's'; }
                            default:
                                { return 'p'; }
                        }
                    }
                case "10":
                    { return 's'; }
                default:
                    { return 's'; } //should be unreachable
            }
        }
        #endregion

        #region Hard Switch
        public static char bjpHard(int hand, string dcard) //switches based on player hand, and then dealer hand, if necessary, to select the appropriate move
        {
            switch (hand)
            {
                case 5:
                case 6:
                case 7:
                case 8:
                    { return 'h'; }
                case 9:
                    {
                        switch (dcard)
                        {
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                                { return 'd'; }
                            default:
                                { return 'h'; }

                        }
                    }
                case 10:
                    {
                        switch (dcard)
                        {
                            case "10":
                            case "A":
                                { return 'h'; }
                            default:
                                { return 'd'; }
                        }
                    }
                case 11:
                    { return 'd'; }
                case 12:
                    switch (dcard)
                    {
                        case "3":
                        case "4":
                        case "5":
                            { return 's'; }
                        default:
                            { return 'h'; }
                    }
                case 13:
                case 14:
                case 15:
                case 16:
                    {
                        switch (dcard)
                        {
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                                { return 's'; }
                            default:
                                { return 'h'; }
                        }
                    }
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                    {
                        return 's';
                    }
                default:
                    { return 's'; } //should be unreachable 
                }
        }
        #endregion

        #region Soft Switch
        public static char bjpSoft(int hand, string dcard) //switches based on player hand, and then dealer hand, if necessary, to select the appropriate move
        {
            switch (hand)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                    { return 'h'; }
                case 18:
                    switch (dcard)
                    {
                        case "9":
                        case "10":
                            { return 'h'; }
                        default:
                            { return 's'; }
                    }
                case 9:
                case 10:
                case 11:
                    { return 'd'; }
                case 19:
                case 20:
                case 21:
                    { return 's'; }
                default:
                    { return 's'; } //should be unreachable
            }
        }
        #endregion

        #region Move Logic //logic for hit/stand/double/switch functionality
        public static bool MoveLogic(Player bjp, char decision)
        {
            switch (decision) // h = hit, s = stand, d = double, p = pair/split
            {
                case 'h':
                    {
                        Console.WriteLine(bjp.playerName + " Hits\r\n");
                        AddToHand(bjp, Dealer.Draw());
                        Console.WriteLine(PrintHand(bjp));
                        int handValue = HandAssess(bjp);
                        if (handValue > 21) //check if hand is larger than 21
                        {
                            GoBust(bjp);
                        }
                        break;
                    }
                case 's':
                    {
                        Console.WriteLine(bjp.playerName + " Stands\r\n");
                        Console.WriteLine(PrintHand(bjp));
                        break;
                    }
                case 'd':
                    {
                        DoubleBet(bjp);
                        Console.WriteLine(GetName(bjp) + " doubles \r\n New bet: " + GetBet(bjp)); //Player doubles bet, only recieves one more card

                        AddToHand(bjp, Dealer.Draw());
                        int handValue = HandAssess(bjp);
                        if (handValue > 21) //check if hand is larger than 21
                        {
                            GoBust(bjp);
                        }
                        decision = 's';
                        break;
                    }
                case 'p':
                    {
                        bjp.splitBustTok = false;
                        Console.WriteLine(bjp.playerName + " Splits\r\n");
                        SplitHand(bjp); //copies 2nd card from hand into splitHand, then removes it from hand
                        return true;
                    }
            }
            return false;
        }

        #endregion

        #region Split Move Logic

        public static void SplitMoveLogic(Player bjp, char decision)
        {
            switch (decision) // h = hit, s = stand, d = double, p = pair/split
            {
                case 'h':
                    {
                        Console.WriteLine(bjp.playerName + " Hits\r\n");
                        AddToSHand(bjp, Dealer.Draw());
                        Console.WriteLine(PrintSHand(bjp));
                        int handValue = SplitHandAssess(bjp);
                        if (handValue > 21) //check if hand is larger than 21
                        {
                            SplitGoBust(bjp);
                        }
                        break;
                    }
                case 's':
                    {
                        Console.WriteLine(bjp.playerName + " Stands\r\n");
                        Console.WriteLine(PrintSHand(bjp));
                        break;
                    }
                case 'd':
                    {
                        DoubleSBet(bjp);
                        Console.WriteLine(GetName(bjp) + " doubles \r\n New bet: " + GetSBet(bjp)); //Player doubles bet, only recieves one more card

                        AddToSHand(bjp, Dealer.Draw());
                        int handValue = SplitHandAssess(bjp);
                        if (handValue > 21) //check if hand is larger than 21
                        {
                            SplitGoBust(bjp);
                        }
                        break;
                    }
            }
        }

        #endregion

        #region Bet Logic
        public static void BJPBet(Player bjp)
        {
            //Decides size of bet based on the amount of chips the BJP has

            char betSize = BJPBetSize(bjp.chips);
            int tempBet = bjp.chips;
            //low bet = 1/10, mid bet = 1/5, high = 1/3
            switch (betSize)
            {
                case 'l':
                    {
                        tempBet = tempBet / 10;
                        break;
                    }
                case 'm':
                    {
                        tempBet = tempBet / 5;
                        break;
                    }
                case 'h':
                    {
                        tempBet = tempBet / 3;
                        break;
                    }
            }

            if (tempBet < 2) //2 chips is the minimum bet
            { tempBet = 2; }

            InitialBet(bjp, tempBet);
        }

        #endregion

        #region Bet Size
        public static char BJPBetSize(int chips)
        {
            if (chips < 25)
            { return 'l'; }
            else
            if (chips < 40)
            { return 'm'; }
            else
            { return 'h'; }
        }

        #endregion

        #endregion

        #region Dealer Methods

        public static void DealerTurn(Player dealer) //Completes dealer's turn
        {
            Console.WriteLine(DealerPrintHand(dealer) + "\r\nDealer's face down card is... "); //Dealer flips face down card
            Console.ReadKey();
            Console.WriteLine("\r\n" + dealer.hand[1] + "\r\n");
            Console.ReadKey();

            if (HandAssess(dealer)> 16) //If Dealer's hand totals 17 or more, they must stand, otherwise they must hit. (S17)
            {
                Console.WriteLine("Dealer Stands");
            }
            else
            {
                Console.WriteLine("Dealer Hits ");
                AddToHand(dealer, Dealer.Draw());
                PrintHand(dealer);

                if (HandAssess(dealer) > 21) //check if hand is larger than 21
                {
                    GoBust(dealer);
                }
            }
        }

        #endregion

        #region Player Constructor

        private int playerID;
        private string playerName;
        private bool humTok;
        private bool bustTok;
        private List<string> hand;
        private int chips;
        private List<string> splitHand;
        private int bet;
        private int splitBet;
        private bool splitBustTok;


        //Specification for a Player Object
        public Player(int playerID, string playerName, bool humTok, out string error)
        {
            //Exception handling for Player creation
            //Populates error string with any error messages, then outputs them in a messagebox after the method is completed
            error = "";
            if (playerName.Trim() == "")
            {error += "Please Enter a Name";}

            if (error != "")
            {
                throw new Exception(error);
            }

            this.playerID = playerID;
            this.playerName = playerName;
            this.humTok = humTok;
            bustTok = false;
            hand = new List<string>();
            chips = 20;
            bet = 0;
            splitHand = new List<string>();
            splitBet = 0;
            splitBustTok = true;
        }
        #endregion

        #region BJP Constructor
        //Specification for a BJP Player Object
        public Player(int playerID, string playerName, out string error)
        {
            //Exception handling for BJP Player creation
            //Populates error string with any error messages, then outputs them in a messagebox after the method is completed
            error = "";

            if (error != "")
            {
                throw new Exception(error);
            }

            this.playerID = playerID;
            this.playerName = playerName;
            humTok = false;
            bustTok = false;
            hand = new List<string>();
            chips = 20;
            bet = 0;
            splitHand = new List<string>();
            splitBet = 0;
            splitBustTok = true;
        }
        #endregion

        #region Dealer Constructor
        //Specification for a Dealer Player Object
        public Player(int playerID, string playerName, out string error, bool dTok)
        {
            //Exception handling for BJP Player creation
            //Populates error string with any error messages, then outputs them in a messagebox after the method is completed
            error = "";

            if (error != "")
            {
                throw new Exception(error);
            }

            this.playerID = playerID;
            this.playerName = playerName;
            humTok = false;
            bustTok = false;
            hand = new List<string>();
            chips = 1000000;
            bet = 0;
            splitHand = new List<string>();
            splitBet = 0;
            splitBustTok = true;
        }
        #endregion

        public override string ToString()
        {
            return "\r\n" + playerName + "\r\nChips: " + chips + "\r\n";
        }
    }
}
