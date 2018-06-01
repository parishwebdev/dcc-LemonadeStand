using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    public class InventoryUnitTesting
    {
        /*
        List<Ingredient> ingredientStock;
        List<Ingredient> recipeStock;
        private double wallet = 20.00;
        public double Wallet { get { return wallet; } set { wallet = value; } }

        public List<Ingredient> IngredientStock
        {
            get { return ingredientStock; }
            set { ingredientStock = value; }
        }
        public List<Ingredient> RecipeStock
        {
            get { return recipeStock; }
            set { recipeStock = value; }
        }

        public InventoryUnitTesting()
        {
            InitializeStockIngredients();
            InitalizeRecipeIngredients();
        }

        public void InitializeStockIngredients()
        {
            ingredientStock = new List<Ingredient>();

            ingredientStock.Add(new Lemon { IngredientName = "Lemons", IngredientQty = 30 });
            ingredientStock.Add(new Sugar { IngredientName = "Sugar", IngredientQty = 25 });
            ingredientStock.Add(new IceCube { IngredientName = "IceCubes", IngredientQty = 250 });
            ingredientStock.Add(new Cup { IngredientName = "Cups", IngredientQty = 50 });
        }

        public void InitalizeRecipeIngredients()
        {
            recipeStock = new List<Ingredient>();

            recipeStock.Add(new Lemon { IngredientName = "Lemons", IngredientQty = 4 });
            recipeStock.Add(new Sugar { IngredientName = "Sugar", IngredientQty = 5 });
            recipeStock.Add(new IceCube { IngredientName = "IceCubes", IngredientQty = 6 });
        }

        public void RemoveFromInventory()
        {
            for (int i = 0; i < RecipeStock.Count; i++)
            {
                IngredientStock[i].IngredientQty -= RecipeStock[i].IngredientQty;
            }
        }

        public void StoreItemInInventory(int ingredientSelection, List<Ingredient> supplier)
        {
            if (IngredientStock[ingredientSelection - 1].IngredientName == supplier[ingredientSelection - 1].IngredientName)
            {
                IngredientStock[ingredientSelection - 1].IngredientQty += supplier[ingredientSelection - 1].IngredientQty;
            }
            else
            {
                UserInterface.OutputText("Invalid Ingredient");
            }

        }

        public void AddItemToRecipe(int ingrediantSelection, int amount)
        {
            for (int i = 0; i <= RecipeStock.Count; i++)
            {
                if (i == ingrediantSelection)
                {
                    RecipeStock[i - 1].IngredientQty = 0;
                    RecipeStock[i - 1].IngredientQty += amount;
                }
            }
        }

        public bool StockAvailability()
        {
            for (int i = 0; i < RecipeStock.Count; i++)
            {
                if (IngredientStock[i].IngredientQty < RecipeStock[i].IngredientQty)
                {
                    return false;
                }
            }
            return true;
        }

        public void PayForIngredient(int ingredientSelection, List<Ingredient> supplier)
        {
            Wallet -= supplier[ingredientSelection - 1].IngedientPrice;
        }
        */
    }
}
