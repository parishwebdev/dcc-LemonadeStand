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
        private double score;
        public double Score
        {
            get { return score; }
            set { score = value; }
        }

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
            string output = UserInterface.GetInput();
            if (ValidateNameInput(output))
            {
                PlayerName = output;
                return PlayerName;

            }
            else
            {
                return RetrievePlayerName();
            }
        }
        private Boolean ValidateNameInput(string input)
        {
            if (input == "" || input == null)
            {
                UserInterface.OutputText("Please enter a value in: ");
                return false;
            }
            if (int.TryParse(input, out int n))
            {
                UserInterface.OutputText("Please don't enter a number in: ");
                return false;
            }

            return true;
        }

        public void ConfigureRecipe(int selection)
        {
            int ingrediantsToAdd = PlayerInvent.GetIngrediantQtyInput(selection);
            PlayerInvent.AddItemToRecipe(selection, ingrediantsToAdd);
        }



    }
}
