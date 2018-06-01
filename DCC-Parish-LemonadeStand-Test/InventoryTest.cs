using System;
using System.Collections.Generic;
using DCC_Parish_LemonadeStand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DCC_Parish_LemonadeStand_Test
{
    [TestClass]
    public class InventoryTest
    {
        /*
        [TestMethod]
        public void Subtract_From_Player_IngredientStock_From_Recipe()
        {
            //Arrange
            InventoryUnitTesting inventory = new InventoryUnitTesting();
            int expectedResult = 26;
            //Act
            inventory.RemoveFromInventory();
            int actualResult = inventory.IngredientStock[0].IngredientQty;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Store_Ingredient_To_Player_Stock_From_Supplier()
        {
            //Arrange
            InventoryUnitTesting inventory = new InventoryUnitTesting();
            int selection = 2;
            List<Ingredient> store = new List<Ingredient>();

            store.Add(new Lemon { IngredientName = "Lemons", IngedientPrice = 2.15, IngredientQty = 30 });
            store.Add(new Sugar { IngredientName = "Sugar", IngedientPrice = 1.60, IngredientQty = 25 });
            store.Add(new IceCube { IngredientName = "IceCubes", IngedientPrice = 2.25, IngredientQty = 250 });
            store.Add(new Cup { IngredientName = "Cups", IngedientPrice = 1.55, IngredientQty = 50 });
            int expectedResult = 50;
            //Act
            inventory.StoreItemInInventory(selection,store);
            int actualResult = inventory.IngredientStock[1].IngredientQty;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Update_Ingredient_Recipe_By_Amount()
        {
            //Arrange
            InventoryUnitTesting inventory = new InventoryUnitTesting();
            int ingredientSelection = 3;
            int amount = 6;

            int expectedResult = 6;
            //Act
             inventory.AddItemToRecipe(ingredientSelection,amount);
            int actualResult = inventory.RecipeStock[2].IngredientQty;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Check_Stock_Return_False()
        {
            //Arrange
            InventoryUnitTesting inventory = new InventoryUnitTesting();
            inventory.IngredientStock[0].IngredientQty = 2;
            bool expectedResult = false;
            //Act
            bool actualResult = inventory.StockAvailability();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        
        [TestMethod]
        public void Check_Stock_Return_True()
        {
            //Arrange
            InventoryUnitTesting inventory = new InventoryUnitTesting();
            bool expectedResult = true;
            //Act
            bool actualResult = inventory.StockAvailability();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [TestMethod]
        public void Subtract_From_Wallet_From()
        {
            //Arrange
            InventoryUnitTesting inventory = new InventoryUnitTesting();

            List<Ingredient> store = new List<Ingredient>();

            store.Add(new Lemon { IngredientName = "Lemons", IngedientPrice = 2.15, IngredientQty = 30 });
            store.Add(new Sugar { IngredientName = "Sugar", IngedientPrice = 1.60, IngredientQty = 25 });
            store.Add(new IceCube { IngredientName = "IceCubes", IngedientPrice = 2.25, IngredientQty = 250 });
            store.Add(new Cup { IngredientName = "Cups", IngedientPrice = 1.55, IngredientQty = 50 });

            double expectedResult = 17.85;
            int ingredientSelection = 1;
            //Act
            inventory.PayForIngredient(ingredientSelection,store);
            double actualResult = inventory.Wallet;
            //Arrange
            Assert.AreEqual(expectedResult, actualResult);
        }
        */


    }
}
