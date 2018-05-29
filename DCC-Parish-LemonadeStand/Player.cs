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
        private Inventory playerInvent = new Inventory();
        
        public string PlayerName
        {
            get { return playerName; } set { playerName = value; }
        }

 
        
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
        
        public void ConfigureRecipe(int selection)
        {
            int ingrediantsToAdd = PlayerInvent.GetIngrediantQtyInput(selection);
            PlayerInvent.AddItemToRecipe(selection, ingrediantsToAdd);
        }



    }
}
