using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();

            /*UserInterface.DisplayPlayerInventory(g.Player.PlayerInvent.IngredientStock);
            Store.InitalizeStoreIngredients();

            UserInterface.DisplayWallet(g.Player);

            UserInterface.DisplayPurchaseMenu(Store.StoreIngredientInfo);
            string selection = UserInterface.GetInput();
            g.Player.BuyIngrediant(Int32.Parse(selection), Store.StoreIngredientInfo);

            UserInterface.DisplayPlayerInventory(g.Player.PlayerInvent.IngredientStock);
            UserInterface.DisplayWallet(g.Player);*/

            /*Store.InitalizeStoreIngredients();
            Console.WriteLine(Store.StoreIngredientInfo.Count);*/




            //Weather w = new Weather(g.rand);
            //w.CreateInitalWeather(7, g.rand);

            //Console.WriteLine("actual weather: ");
            //for (int i = 0; i < w.ActualWeather.Count; i++)
            //{
            //    Console.WriteLine(i+1 + ") " +  w.ActualWeather[i].CurrentCondition + " " + w.ActualWeather[i].CurrentTemp);
            //}
            //w.GenerateForecast(g.rand);
            //Console.WriteLine("Forecast weather: ");
            //for (int j = 0; j < w.Forecast.Count; j++)
            //{
            //    Console.WriteLine(j+1 + ") " + w.Forecast[j].CurrentCondition + " " + w.Forecast[j].CurrentTemp);
            //}

            //w.DisplayForecastByNumDays(1);
            //w.DisplayForecastByNumDays(7);

            Console.ReadLine();
        }
    }
}
