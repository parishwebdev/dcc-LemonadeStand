using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    public class DayUnitTesting
    {
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
        //Create Method for removefrominventory next in seperate files or remember to change back all publics to private
       
    }
}
