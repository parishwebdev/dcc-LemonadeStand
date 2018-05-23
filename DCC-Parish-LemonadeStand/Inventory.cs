using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Inventory
    {
        List<Ingredient> ingredientStock = new List<Ingredient>();

        public List<Ingredient> IngredientStock
        {
            get { return ingredientStock; }
        }

        public Inventory()
        {
            InitializeStockIngredients();
        }

        private void InitializeStockIngredients()
        {
            ingredientStock.Add(new Lemon { IngredientName = "Lemons", IngredientQty = 0 });
            ingredientStock.Add(new Sugar { IngredientName = "Sugar", IngredientQty = 0 });
            ingredientStock.Add(new Cup { IngredientName = "Cups", IngredientQty = 0 });
            ingredientStock.Add(new IceCube { IngredientName = "IceCubes", IngredientQty = 0 });
        }

        
        public void StoreItemInInventory(int ingredientSelection, List<Ingredient> input)
        {
            if (IngredientStock[ingredientSelection].IngredientName == input[ingredientSelection].IngredientName)
            {
                IngredientStock[ingredientSelection].IngredientQty += input[ingredientSelection].IngredientQty;
            }
            
        }


    }
}
