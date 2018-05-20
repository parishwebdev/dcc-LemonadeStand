using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Inventory
    {
        private int sugarStockQty;
        private int lemonStockQty;
        private int icecubeStockQty;
        private int cupsStockQty;

        public int SugarQty
        {
            get { return sugarStockQty; }
            set { sugarStockQty = value; }
        }
        public int LemonQty
        {
            get { return lemonStockQty; }
            set { lemonStockQty = value; }
        }
        public int IceCubeQty
        {
            get { return icecubeStockQty; }
            set { icecubeStockQty = value; }
        }
        public int CupsQty
        {
            get { return cupsStockQty; }
            set { cupsStockQty = value; }
        }
    }
}
