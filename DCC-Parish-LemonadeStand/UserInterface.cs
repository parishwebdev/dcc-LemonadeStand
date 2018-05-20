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
        public static string DisplayDayNum(List<int> dayNums)
        {
            string result = "How many days do you want to play? ";
            for (int i = 0; i < dayNums.Count; i++)
            {
                result += "(" + dayNums[i] + ") days ";
            }

            return result;
        }
    }
}
