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
            OutputText("Wallet: $" + DoubleToString(player.Wallet));
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
            purchaseMenu += " " + (supplier.Count + 1) + ") - Go Back";
            OutputText(purchaseMenu);
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

        public static void DisplayWeatherByNumDays(int numDaysToDisplay, List<Weather> weather)
        {
            for (int j = 0; j < numDaysToDisplay; j++)
            {
                OutputText(weather[j].CurrentCondition + " " + weather[j].CurrentTemp);
            }
        }
        public static void DisplaySingleWeather(Weather weather)
        {
            OutputText(weather.CurrentCondition + " " + weather.CurrentTemp);
        }


    }
}
