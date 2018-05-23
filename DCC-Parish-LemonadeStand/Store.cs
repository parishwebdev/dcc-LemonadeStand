using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    static class Store
    {
        static List<Ingredient> storeIngredientInfo = new List<Ingredient>();

        public static List<Ingredient> StoreIngredientInfo
        {
            get { return storeIngredientInfo; }
        }
        public static void InitalizeStoreIngredients()
        {
            storeIngredientInfo.Add(new Lemon { IngredientName = "Lemons",IngedientPrice = 2.15, IngredientQty = 30 });
            storeIngredientInfo.Add(new Sugar { IngredientName = "Sugar", IngedientPrice = 1.60, IngredientQty = 25 });
            storeIngredientInfo.Add(new Cup { IngredientName = "Cups", IngedientPrice = 1.55, IngredientQty = 50 });
            storeIngredientInfo.Add(new IceCube { IngredientName = "IceCubes", IngedientPrice = 2.25, IngredientQty = 250 });
        }

    }
}
