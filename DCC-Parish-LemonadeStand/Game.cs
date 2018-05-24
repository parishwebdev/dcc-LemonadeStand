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
        private List<int> numberGameDays = new List<int> { 7, 14, 30 };
        private List<String> mainOptions = new List<String> {"Buy Ingredients Menu","Recipe Menu","Weather Menu","Start Selling"};
        private List<String> weatherOptions = new List<String> { "Today", "Tomorrow", "Week","Back to Main Menu"};
        private string gameInstructions = "Instruction for game in beginning";
        private int numberDaysLength;
        private List<Day> gameDays = new List<Day>();
        private List<Ingredient> supplier = Store.StoreIngredientInfo;
        private int dayCounter;

        private Weather weather;
        

        public  List<Ingredient> Supplier { get { return supplier; }  set { supplier = value; } }

        public int DayCounter { get { return dayCounter; } set { dayCounter = value; } }

        public List<String> WeatherOptions { get { return weatherOptions; } set { weatherOptions = value; } }

        public string GameInstructions { get { return gameInstructions; } set { gameInstructions = value; } }

        public List<int> NumberGameDays { get { return numberGameDays; } set { numberGameDays = value;} }

        public int NumberDaysLength { get { return numberDaysLength; } set{ numberDaysLength = value;} }

        public List<Day> GameDays { get { return gameDays; } set {  gameDays = value; } }
        
        public List<String> MainOptions { get { return mainOptions; } }

        public Player Player { get { return player; } set { player = value; } }

        public Game()
        {
            rand = new Random();
            SetupGame(rand);
            RunGame();
        }

        public void SetupGame(Random rand)
        {
            UserInterface.OutputText(GameInstructions);
            player.RetrievePlayerName();
            RetrieveNumDayInput();
            CreateGameDays(NumberDaysLength);
            Store.InitalizeStoreIngredients();
            weather = new Weather(NumberDaysLength,rand);
        }
        public void RunGame()
        {
            TraverseDay();
        }

        private void RetrieveNumDayInput()
        {
            UserInterface.DisplayDayNum(numberGameDays);
            NumberDaysLength = Int32.Parse(UserInterface.GetInput());
        }
        private int RetrieveMainMenuInput() {
            UserInterface.DisplayStringMenu(MainOptions,"Main");
            int selection = Int32.Parse(UserInterface.GetInput());
            return selection;
        }
        private int RetrievePurchaseMenuInput()
        {
            UserInterface.DisplayPurchaseMenu(Supplier);
            int selection = Int32.Parse(UserInterface.GetInput());
            return selection;
        }
        private int RetrieveWeatherMenuInput()
        {
            UserInterface.DisplayStringMenu(WeatherOptions,"Weather");
            int selection = Int32.Parse(UserInterface.GetInput());
            return selection;
        }
        private void CreateGameDays(int numDaysLength)
        {
            for (int i = 0; i < numDaysLength; i++)
            {
                GameDays.Add(new Day());
            }
        }
        public void TraverseDay()
        {
            for (int i = 0; i < GameDays.Count; i++)
            {
                DayCounter = i;
                MainMenu();
            }
        }
        public void MainMenu()
        {
            int selection = RetrieveMainMenuInput();
            switch (selection)
            {
                case 1:
                    PurchaseMenu();
                break;
                case 2:
                    //RecipeMenu()
                break;
                case 3:
                    WeatherMenu();
                break;
                case 4:
                    //Day method
                break;
            }
        }
        public void PurchaseMenu()
        {
            int selection = RetrievePurchaseMenuInput();

            while (selection != (Supplier.Count)+1)
            {
                Player.BuyIngrediant(selection, Supplier);

                UserInterface.DisplayPlayerInventory(Player.PlayerInvent.IngredientStock);
                UserInterface.DisplayWallet(Player);

                selection = RetrievePurchaseMenuInput();
                
            }
            if (selection == (Supplier.Count) + 1)
            {
                MainMenu();
            }
        }
        public void WeatherMenu()
        {
            int selection = RetrieveWeatherMenuInput();
            switch (selection)
                {
                    case 1:
                        UserInterface.DisplaySingleWeather(weather.ActualWeather[DayCounter]);
                        break;
                    case 2:
                        UserInterface.DisplaySingleWeather(weather.ActualWeather[DayCounter+1]);
                    break;
                    case 3:
                        UserInterface.DisplayWeatherByNumDays(7, weather.ActualWeather);
                        break;  
                    case 4:
                        MainMenu();
                        break;
                               
                }
            if (selection == 1 || selection == 2 || selection == 3)
            {
                WeatherMenu();
            }
            
        }

    }
}
