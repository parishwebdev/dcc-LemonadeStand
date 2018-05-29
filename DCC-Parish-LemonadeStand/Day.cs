﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Day
    {
        private List<String> mainOptions = new List<String> { "Buy Ingredients Menu", "Recipe Menu", "Weather Menu", "Start Selling" };
        private List<String> weatherOptions = new List<String> { "Today", "Tomorrow", "Week", "Back to Main Menu" };
        private List<Ingredient> supplier = Store.StoreIngredientInfo;
        private Weather weather;
        private Random rand;
        private Player player;


        public List<String> MainOptions { get { return mainOptions; } }
        public List<String> WeatherOptions { get { return weatherOptions; } }
        public List<Ingredient> Supplier { get { return supplier; } set { supplier = value; } }
        public Player Player { get { return player; } set { player = value; } }
        public Weather Weather { get { return weather; } set { weather = value; } }

        public Day(Random rand, Player player,Weather weather)
        {
            this.rand = rand;
            this.player = player;
            this.weather = weather;
        }

        public void RunDay(int currentDay)
        {
            DayMainMenu(currentDay);
        }

        //Menus
        public void DayMainMenu(int currentDay)
        {
            int selection = RetrieveMainMenuInput(currentDay);
            switch (selection)
            {
                case 1:
                    PurchaseMenu(currentDay);
                    break;
                case 2:
                    RecipeMenu(currentDay);
                    break;
                case 3:
                    WeatherMenu(currentDay);
                    break;
                case 4:
                    SellLemonade();
                    //Console.Clear();
                    break;
            }
        }
        public void SellLemonade()
        {
            //new Customer()
            int numberOfCustomers = 50;//numofcustmers
            Player.PlayerInvent.InventoryAlter(numberOfCustomers);//numofcustmers
            

        }
        public void PurchaseMenu(int dayCounter)
        {
            int selection = RetrievePurchaseMenuInput();
            switch (selection)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Player.PlayerInvent.BuyIngrediant(selection, Supplier);
                    InventoryStatus();
                break;
                case 5:
                    InventoryStatus();
                break;
                case 6:
                    Console.Clear();
                    DayMainMenu(dayCounter);
                break;
            }
            if (selection == 1 || selection == 2 || selection == 3 || selection == 4 || selection == 5)
            {
                PurchaseMenu(dayCounter); 
            }
        }
        private void InventoryStatus()
        {
            UserInterface.DisplayPlayerInventory(Player.PlayerInvent.IngredientStock);
            UserInterface.DisplayWallet(player);
        }
        public void RecipeMenu(int dayCounter)
        {
            int selection = RetrieveRecipeMenuInput();

            switch (selection)
            {
                case 1:
                case 2:
                case 3:
                    Player.ConfigureRecipe(selection);
                break;
                case 4:
                    UserInterface.DisplayRecipe(Player.PlayerInvent.RecipeStock);
                    Player.PlayerInvent.ConfigurePricePerCup();
                break;
                case 5:
                    Player.PlayerInvent.InitalizeRecipeIngredients();
                break;
                case 6:
                    Console.Clear();
                    DayMainMenu(dayCounter);
                break;
            }
            if (selection == 1 || selection == 2 || selection == 3 || selection == 4 || selection == 5)
            {
                RecipeMenu(dayCounter);
            }

        }
        public void WeatherMenu(int dayCounter)
        {
            int selection = RetrieveWeatherMenuInput();
            switch (selection)
            {
                case 1:
                    UserInterface.DisplayCurrentWeather(Weather.ActualWeather[dayCounter],dayCounter);
                    break;
                case 2:
                    UserInterface.DisplayNextWeather(Weather.ActualWeather,dayCounter);
                    break;
                case 3:
                    UserInterface.DisplayWeatherByNumDays(Weather.ActualWeather.Count, Weather.ActualWeather,dayCounter);
                    break;
                case 4:
                    Console.Clear();
                    DayMainMenu(dayCounter);
                    break;

            }
            if (selection == 1 || selection == 2 || selection == 3)
            {
                WeatherMenu(dayCounter);
            }

        }


        //methods for input

        private int RetrieveMainMenuInput(int dayCounter)
        {
            UserInterface.DisplayStringMenu(MainOptions, "(Day " + (dayCounter + 1 ).ToString() + ") Main");
            int selection = Int32.Parse(UserInterface.GetInput());
            return selection;
        }
        private int RetrievePurchaseMenuInput()
        {
            UserInterface.DisplayPurchaseMenu(Supplier);
            int selection = Int32.Parse(UserInterface.GetInput());
            return selection;
        }
        private int RetrieveRecipeMenuInput()
        {
            UserInterface.DisplayRecipeMenu(Player.PlayerInvent.RecipeStock);
            int selection = Int32.Parse(UserInterface.GetInput());
            return selection;
        }
        private int RetrieveWeatherMenuInput()
        {
            UserInterface.DisplayStringMenu(WeatherOptions, "Weather");
            int selection = Int32.Parse(UserInterface.GetInput());
            return selection;
        }

        

    }
}
