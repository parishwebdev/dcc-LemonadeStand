using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Inventory
    {
        List<Ingredient> ingredientStock;
        List<Ingredient> recipeStock;
        double pricePerCup;
        private double wallet = 20.00;

        public List<Ingredient> IngredientStock
        {
            get { return ingredientStock; }
        }
        public List<Ingredient> RecipeStock
        {
            get { return recipeStock; } set { recipeStock = value; }
        }

        public double PricePerCup { get { return pricePerCup;} set { pricePerCup = value; } }
        public double Wallet { get { return wallet; } set { wallet = value; } }

        public Inventory()
        {
            InitializeStockIngredients();
            InitalizeRecipeIngredients();
        }

        private void InitializeStockIngredients()
        {
            ingredientStock = new List<Ingredient>();

            ingredientStock.Add(new Lemon { IngredientName = "Lemons", IngredientQty = 0 });
            ingredientStock.Add(new Sugar { IngredientName = "Sugar", IngredientQty = 0 });
            ingredientStock.Add(new IceCube { IngredientName = "IceCubes", IngredientQty = 0 });
            ingredientStock.Add(new Cup { IngredientName = "Cups", IngredientQty = 0 });
        }

        public void InitalizeRecipeIngredients()
        {
            recipeStock = new List<Ingredient>();

            recipeStock.Add(new Lemon { IngredientName = "Lemons", IngredientQty = 0 });
            recipeStock.Add(new Sugar { IngredientName = "Sugar", IngredientQty = 0 });
            recipeStock.Add(new IceCube { IngredientName = "IceCubes", IngredientQty = 0 });
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

        public void ConfigurePricePerCup()
        {
            UserInterface.OutputText("Please enter price per cup(select value between 25¢ and $1.50)");
            string input = UserInterface.GetInput();
            double price = Double.Parse(input);
            if (price > 1.5 || price < .25)
            {
                UserInterface.OutputText("Please enter price in the correct range");
                ConfigurePricePerCup();
            }
            else
            {
                PricePerCup = price;
            }
        }


        public void AddItemToRecipe(int ingrediantSelection, int amount)
        {
            for (int i = 0; i <= RecipeStock.Count; i++)
            {
                if (i == ingrediantSelection){
                     RecipeStock[i-1].IngredientQty = 0;
                     RecipeStock[i-1].IngredientQty += amount;
                }
            }
        }

        public int GetIngrediantQtyInput(int selection)
        {
            int userIngrediantQuantity = 0;
            userIngrediantQuantity = UserInterface.RetrieveIngredientRecipe(selection, RecipeStock);

            if (userIngrediantQuantity == 0)
            {
                UserInterface.OutputText("Not a valid amount");
                return 0;
            }
            else
            {
                if (ValidateStockQty(userIngrediantQuantity, selection))
                {
                    return userIngrediantQuantity;
                }
                else
                {
                    UserInterface.OutputText("Not enough " + RecipeStock[selection].IngredientName + " currently in your inventory");
                    return GetIngrediantQtyInput(selection);
                }
            }
        }


        private bool ValidateStockQty(int amount, int selection)
        {
            for (int i = 0; i < IngredientStock.Count; i++)
            {
                if (i == selection)
                {
                    if (amount > IngredientStock[i].IngredientQty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        public void InventoryAlter(int customersWhoBought)
        {
            while (StockAvailability() == true && customersWhoBought > 0)
            {
                Wallet += PricePerCup;
                RemoveFromInventory();
                ingredientStock[3].IngredientQty--;
                customersWhoBought--;
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
        private void RemoveFromInventory()
        {
            for (int i = 0; i < RecipeStock.Count; i++)
            {
                IngredientStock[i].IngredientQty -= RecipeStock[i].IngredientQty;
            }
        }

        private bool VerifyIngrediantPurchase(int ingredientSelection, List<Ingredient> supplier)
        {
            if (Wallet < supplier[ingredientSelection - 1].IngedientPrice)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void PayForIngredient(int ingredientSelection, List<Ingredient> supplier)
        {
            Wallet -= supplier[ingredientSelection - 1].IngedientPrice;
        }
        public void BuyIngrediant(int ingredientSelection, List<Ingredient> supplier)
        {
            if (VerifyIngrediantPurchase(ingredientSelection, supplier))
            {
                StoreItemInInventory(ingredientSelection, supplier);
                PayForIngredient(ingredientSelection, supplier);
            }
            else
            {
                UserInterface.OutputText("Not enough money to buy this ingredient");
            }
        }

    }
}
