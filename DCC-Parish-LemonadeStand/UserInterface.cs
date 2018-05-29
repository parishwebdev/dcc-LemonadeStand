using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    static class UserInterface
    {
        //Basic Input Methods
        public static void OutputText(string messageText)
        {
            Console.WriteLine(messageText);
        }
        public static string GetInput()
        {
            string result = Console.ReadLine();
            return result;
        }
        //Displaying Specfics
        public static void DisplayDayNum(List<int> dayNums)
        {
            string result = "How many days do you want to play? ";
            for (int i = 0; i < dayNums.Count; i++)
            {
                result += "(" + dayNums[i] + ") days ";
            }

            OutputText(result);
        }
        public static void DisplayPlayerInventory(List<Ingredient> inventory)
        {
            string result = "Inventory: ";
            for (int i = 0; i < inventory.Count; i++)
            {
                result += inventory[i].IngredientName + " - " + inventory[i].IngredientQty + " "; 
            }
            OutputText(result);
        }

        public static void DisplayWallet(Player player)
        {
            OutputText("Wallet: $" + DoubleToString(player.PlayerInvent.Wallet));
        }
        private static string DoubleToString(double doubleToConvert)
        {
            return doubleToConvert.ToString();
        }


        public static void DisplayPurchaseMenu(List<Ingredient> supplier)
        {
            string purchaseMenu = "Purchase Menu: ";
            for (int i = 0; i < supplier.Count; i++)
            {
                purchaseMenu += (i+1) + ") " + supplier[i].IngredientName + " - $" + supplier[i].IngedientPrice + " ";
            }
            purchaseMenu += " " + (supplier.Count + 1) + ") - Display Player Inventory";
            purchaseMenu += " " + (supplier.Count + 2) + ") - Go Back";
            OutputText(purchaseMenu);
        }
        public static void DisplayRecipeMenu(List<Ingredient> recipe)
        {
            string recipeMenu = "Recipe Menu: ";
            for (int i = 0; i < recipe.Count; i++)
            {
                recipeMenu += (i + 1) + " - " + recipe[i].IngredientName + " " + recipe[i].IngredientQty + " | ";
            }
            recipeMenu += " " + (recipe.Count + 1) + " - Set Price Per Cup | ";
            recipeMenu += " " + (recipe.Count + 2) + " - Reset Recipe | ";
            recipeMenu += " " + (recipe.Count + 3) + " - Go Back";
            OutputText(recipeMenu);
        }
        public static void DisplayRecipe(List<Ingredient> recipeList)
        {
            string recipe = "";
            for (int i = 0; i < recipeList.Count; i++)
            {
                recipe +=  recipeList[i].IngredientName + " " + recipeList[i].IngredientQty + " | ";
            }
            OutputText(recipe);
        }

        public static void DisplayStringMenu(List<String> menu,string menuName)
        {
            string mainMenu = menuName + " Menu: ";
            for (int i = 0; i < menu.Count; i++)
            {
                mainMenu += (i+1) + ") " + menu[i] + " ";
            }
            OutputText(mainMenu);
        }


        public static void DisplayWeatherByNumDays(int numDaysToDisplay, List<Weather> weather, int dayCounter)
        {

                if ( (weather.Count - dayCounter) < numDaysToDisplay)
                {
                    for (int j =  dayCounter; j < numDaysToDisplay; j++)
                    {
                        OutputText(weather[j].CurrentCondition + " " + weather[j].CurrentTemp);
                    }
                }
                else
                {
                    for (int j = 0; j < numDaysToDisplay; j++)
                    {
                        OutputText(weather[j].CurrentCondition + " " + weather[j].CurrentTemp);
                    }
                }
        }
        public static void DisplayCurrentWeather(Weather weather, int dayCounter)
        {
            OutputText(weather.CurrentCondition + " " + weather.CurrentTemp);
        }
        public static void DisplayNextWeather(List<Weather> weatherList, int dayCounter)
        {
            if (dayCounter < weatherList.Count-1) {
                OutputText(weatherList[dayCounter+1].CurrentCondition + " " + weatherList[dayCounter+1].CurrentTemp);
            }
            else
            {
                OutputText("Last day, no forecast for tomorrow");
            }
        }

        public static int RetrieveIngredientRecipe(int ingredientSelected, List<Ingredient> ingredients)
        {
            UserInterface.OutputText("Please amount of " + ingredients[ingredientSelected - 1].IngredientName + " to add per pitcher: ");
            int userIngrediantQuantity = Int32.Parse(UserInterface.GetInput());
            return userIngrediantQuantity;
        }


        public static void DisplayDayResults(Player player, double moneyEarned)
        {
           OutputText("Today's Results: " + player.PlayerName +  " made $" + moneyEarned + " \r\n" +
                "Current inventory: \r\n$" + player.PlayerInvent.Wallet);
            for (int i = 0; i < player.PlayerInvent.IngredientStock.Count; i++)
            {
                OutputText(player.PlayerInvent.IngredientStock[i].IngredientQty + " " + player.PlayerInvent.IngredientStock[i].IngredientName);
            }
        }
        public static void DisplayGameResults(Player player)
        {
            OutputText(player.PlayerName + "'s game score is: " + player.Score);
        }

    }
}
