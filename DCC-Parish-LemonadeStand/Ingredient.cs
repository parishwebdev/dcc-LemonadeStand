using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    
      abstract class Ingredient
    {
        /*
         1st Solid Comment:
         With the Base Class Ingredient it is easy to extend and add a new type of ingredient
         without adding modifiying any existing code
         */
        protected int ingredientQty;
        protected string ingredientName;
        protected double ingredientPrice;

        public string IngredientName
        {
            get { return ingredientName; }
            set { ingredientName = value; }
        }
        public int IngredientQty
        {
            get { return ingredientQty; }
            set { ingredientQty = value; }
        }
        public double IngedientPrice
        {
            get { return ingredientPrice; }
            set { ingredientPrice = value; }
        }
    }
}
