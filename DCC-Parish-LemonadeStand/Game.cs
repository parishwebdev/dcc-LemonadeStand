using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Game
    {
        private Random rand;

        private Player player = new Player();
        private List<string> numberGameDays = new List<string> { "7", "14", "30" };
        
        private string gameInstructions = "Instruction for game in beginning";
        private int numberDaysLength;
        private List<Day> gameDays = new List<Day>();
        private Weather weather;
        private double gameProfit;

        public Random Rand { get{ return rand; } set { rand = value ;} }

        public string GameInstructions { get { return gameInstructions; } set { gameInstructions = value; } }

        public List<string> NumberGameDays { get { return numberGameDays; } set { numberGameDays = value;} }

        public int NumberDaysLength { get { return numberDaysLength; } set{ numberDaysLength = value;} }

        public List<Day> GameDays { get { return gameDays; } set {  gameDays = value; } }
        public double GameProfit { get { return gameProfit; } set { gameProfit = value; } }

        public Player Player { get { return player; } }
        public Weather Weather { get { return weather; } }

        public Game()
        {
            rand = new Random();
            SetupGame();
            RunGame();
        }

        public void SetupGame()
        {
            UserInterface.OutputText(GameInstructions);
            player.RetrievePlayerName();
            RetrieveNumDayInput();
            weather = new Weather(NumberDaysLength,Rand);
            CreateGameDays(NumberDaysLength);
            Store.InitalizeStoreIngredients();
            
        }
        public void RunGame()
        {
            TraverseDays();
        }
        private void RetrieveNumDayInput()
        {
            UserInterface.DisplayDayNum(numberGameDays);
            string choice = UserInterface.GetInput();
            if (ValidateGameDays(choice, NumberGameDays))
            {
                NumberDaysLength = Int32.Parse(choice);
            }
            else
            {
                RetrieveNumDayInput();
            }
            
        }
        private bool ValidateGameDays(string input, List<string> list)
        {
            if (input == "" || input == null)
            {
                UserInterface.OutputText("Please enter a value in: ");
                return false;
            }
            if (int.TryParse(input, out int n) == false)
            {
                UserInterface.OutputText("Please enter a number in: ");
                return false;
            }
            if (NumberGameDays.Contains(input) == false)
            {
                UserInterface.OutputText("Please enter the corrert number in: ");
                return false;
            }
            return true;
        }

        private void CreateGameDays(int numDaysLength)
        {
            for (int i = 0; i < numDaysLength; i++)
            {
                GameDays.Add(new Day(Rand,Player,Weather));
            }
        }
        public void TraverseDays()
        {
            for (int i = 0; i < GameDays.Count; i++)
            {
                GameDays[i].RunDay(i);
                GameProfit += GameDays[i].DayProfit;
            }
            SetGameScore(GameProfit, Player);
            UserInterface.DisplayGameResults(Player);
        }

        private void SetGameScore(double gameProfit, Player player)
        {
            player.Score = gameProfit;
        }
    }
}
