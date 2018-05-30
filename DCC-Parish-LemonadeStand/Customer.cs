using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Customer
    {

        private List<Customer> customers = new List<Customer>();
        private bool buyLemonDrink;
        private int customerCap;

        public List<Customer> Customers { get { return customers; } set { customers = value; } }
        public bool BuyLemonDrink { get { return buyLemonDrink; } set { buyLemonDrink = value; } }
        public int CustomerCap { get { return customerCap; } set { customerCap = value; } }

        public Customer(Weather currentWeather, Random rand)
        {
            BuyLemonDrink = false;
        }
        
        public List<Customer> ChooseToBuyLemonade(Weather weather, Random rand, List<Customer> customersWhoBuy, Inventory playerInvt)
        {
            for (int i = 0; i < customersWhoBuy.Count; i++)
            {
                customersWhoBuy[i].BuyLemonDrink = WeatherInfluenceChoice(weather, rand);
            }
            for (int q = 0; q < customersWhoBuy.Count; q++)
            {
                customersWhoBuy[q].BuyLemonDrink = PriceInfluenceChoice(weather, rand, playerInvt);
            }

            return customersWhoBuy;
        }

        public bool WeatherInfluenceChoice(Weather weather, Random rand)
        {
            int weatherInfluencer = Convert.ToInt32(weather.CurrentTemp / 3);

            return false;
        }
        public bool WeatherProbilityChecker(int weatherInfluencer, Random rand)
        {
            int probLimit = 12;
            if (rand.Next(0, weatherInfluencer) > probLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PriceInfluenceChoice(Weather weather, Random rand, Inventory playerInvt)
        {
            int priceInfluencer = Convert.ToInt32(weather.CurrentTemp * (playerInvt.PricePerCup / 10));

            if(rand.Next(0,priceInfluencer) < 5)
            {
                return true;
            }

            return false;
        }

        public List<Customer> RemoveTheDissatifiedCustomers(List<Customer> daysCustomers)
        {

            for (int i = 0; i < daysCustomers.Count; i++)
            {
                if (BuyLemonDrink == false)
                {
                    daysCustomers.Remove(daysCustomers[i]);
                }
            }
            return daysCustomers;

        }

        public List<Customer> NumberOfPotentialCustomers(Weather weather, Random r)
        {
            CustomerCap = 100;
            if (weather.CurrentCondition == "sunny")
            {
                Customers = CustomerGenerator(CustomerCap, weather, r);
            }
            else if (weather.CurrentCondition == "cloudy")
            {
                Customers = CustomerGenerator(CustomerCap * (2/3), weather, r);
            }
            else if (weather.CurrentCondition == "rain")
            {
                Customers = CustomerGenerator(CustomerCap * (1/3), weather, r);
            }
            return Customers;
        }
        public List<Customer> CustomerGenerator(double customerGenNum, Weather day, Random r)
        {
            List<Customer> tempCustList = new List<Customer>() { };
            for (int i = 0; i < customerGenNum; i++)
            {
                tempCustList.Add(new Customer(day, r));
            }
            return tempCustList;
        }

    }
}
