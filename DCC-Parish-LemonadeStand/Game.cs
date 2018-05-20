using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Game
    {
        public Random rTemp;
        private Player player = new Player();
        private List<int> numberGameDays = new List<int> { 7, 14, 30 };
        private string gameInstructions = "Instruction for game in beginning";
        public int numberDaysLength;

        public string GameInstructions
        {
            get { return gameInstructions; } set { gameInstructions = value; }
        }
        public List<int> NumberGameDays { get { return numberGameDays; } set { numberGameDays = value;} }

        public int NumberDaysLength { get { return numberDaysLength; } set{ numberDaysLength = value;} }

        public Game()
        {
            rTemp = new Random();
        }

        public void SetupGame()
        {
            UserInterface.OutputText(GameInstructions);
            player.RetrievePlayerName();
            RetrieveNumDayInput();
        }
        public void RunGame()
        {

        }

        private int RetrieveNumDayInput()
        {
            UserInterface.OutputText(UserInterface.DisplayDayNum(numberGameDays));
            NumberDaysLength = Int32.Parse(UserInterface.GetInput());
            return numberDaysLength;
        }

    }
}
