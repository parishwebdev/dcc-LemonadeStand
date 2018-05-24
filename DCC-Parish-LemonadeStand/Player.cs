using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Player
    {
        private string playerName;
        private double wallet = 20.00;
        private Inventory playerInvent = new Inventory();
        
        public string PlayerName
        {
            get { return playerName; } set { playerName = value; }
        }

 
        public double Wallet { get { return wallet; } set { wallet = value; } }

        public Inventory PlayerInvent
        {
            get { return playerInvent; }
            set { playerInvent = value; }
        }

        public Player()
        {
            
        }

        public string RetrievePlayerName()
        {
            UserInterface.OutputText("Enter your name: ");
            PlayerName = UserInterface.GetInput();
            return PlayerName;
        }

        private bool VerifyIngrediantPurchase(int ingredientSelection, List<Ingredient> supplier)
        {
            if (Wallet < supplier[ingredientSelection-1].IngedientPrice)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void PayForIngredent(int ingredientSelection, List<Ingredient> supplier)
        {
            Wallet -= supplier[ingredientSelection - 1].IngedientPrice;
        }
        public void BuyIngrediant(int ingredientSelection, List<Ingredient> supplier)
        {
            if(VerifyIngrediantPurchase(ingredientSelection,supplier))
            {
                playerInvent.StoreItemInInventory(ingredientSelection,supplier);
                PayForIngredent(ingredientSelection, supplier);
            }
            else
            {
                UserInterface.OutputText("Not enough money to buy this ingredient");
            }
        }
        
    }
}
