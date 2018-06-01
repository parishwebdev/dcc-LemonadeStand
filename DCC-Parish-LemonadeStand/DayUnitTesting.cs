using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    public class DayUnitTesting
    {
        /*
        private List<String> weatherOptions = new List<String> { "Today", "Tomorrow", "Week", "Back to Main Menu" };

        public List<String> WeatherOptions { get { return weatherOptions; } }


        public double SetDayProfit(double dayWallet, double resultingWallet)
        {
            double profit;
            if (dayWallet == resultingWallet)
            {
                profit = 0.0; 
            }
            else
            {
                profit = resultingWallet - dayWallet;
            }
            return profit;
        }

        public int RetrieveWeatherMenuInput()
        {
            UserInterface.DisplayStringMenu(WeatherOptions, "Weather");
            string selection = UserInterface.GetInput();
            if (ValidateDayMenus(selection))
            {
                return Int32.Parse(selection);
            }
            else
            {
                return RetrieveWeatherMenuInput();
            }
        }

        public bool ValidateDayMenus(string input)
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
            return true;
        }
        */
    }
    
}
