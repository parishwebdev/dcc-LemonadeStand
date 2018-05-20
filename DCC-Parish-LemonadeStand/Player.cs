using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Player
    {
        private string playerName;
        private double wallet;
        private double startingCash = 20.00;
        
        public string PlayerName
        {
            get { return playerName; } set { playerName = value; }
        }

        public double StartingWallet { get { return startingCash; } }
        public double Wallet { get { return wallet; } set { wallet = value; } }

        public Player()
        {

        }

        public string RetrievePlayerName()
        {
            UserInterface.OutputText("Enter your name: ");
            PlayerName = UserInterface.GetInput();
            return PlayerName;
        }
        
    }
}
