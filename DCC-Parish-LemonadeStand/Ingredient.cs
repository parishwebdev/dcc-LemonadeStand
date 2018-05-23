using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    abstract class Ingredient
    {

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
