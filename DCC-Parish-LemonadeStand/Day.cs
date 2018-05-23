using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Day
    {
        Weather w;
        //result variables

        public Weather W
        {
            get { return w; }
            set { w = value; }
        }
        public Day(Random rand)
        {
            w = new Weather(rand);
        }
        


        /* Methods for Generating Customers */
    }
}
