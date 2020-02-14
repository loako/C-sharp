using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public enum FoodCategory
    {
         Fish,
         Meat,
         Seafood,
         Vegetarian
    }

    public class Recipe
    {
        private const int maxNumOfIngredients = 20;


        private string[] ingredientArray;
        private string name;
        private FoodCategory category;
        private string description;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public FoodCategory Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string[] Ingredients
        {
            get { return ingredientArray;}
            set { ingredientArray = value;}
        }

        public Recipe(int maxNumOfIngredients)
        {
            ingredientArray = new string[maxNumOfIngredients];
            DefaultValues();

        }
        /// <summary>
        /// Sets the default values of the recipe.
        /// </summary>
        public void DefaultValues ()
        {
            for (int index = 0; index < ingredientArray.Length; index++)
            {
                ingredientArray[index] = string.Empty;
            }
            name = string.Empty;
            category = FoodCategory.Fish;
            description = string.Empty;
        }

        public int FindVacantPosition()
        {
            for(int i = 0; i < ingredientArray.Length; i++)
            {
                if (String.IsNullOrEmpty(ingredientArray[i]))
                {
                    return i;
                }
                
            }
            
            return -1;

        }
        
        public bool AddIngredient(string value)
        {
            bool ok = false;
            int index = FindVacantPosition();
            if(index >= 0)
            {
                ingredientArray[index] = value;
                ok = true;
            }
            return ok;
        }

        public bool CheckIndex(int value)
        {
            if (value < ingredientArray.Length && value >= 0)
            {
                return true;
            }
            else
                return false;
        }

        public int GetCurrentNumOfIngredients()
        {
            int count = 0;
            for (int index =0; index < ingredientArray.Length; index++)
            {
                if (!string.IsNullOrEmpty(ingredientArray[index]))
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
            {
                descriptionText = "No Description!";
            }
            string textOut = string.Format("{0, -20} {1,4}    {2,-12}   {3,-15}",
            name, GetCurrentNumOfIngredients(), category.ToString(), descriptionText);
            return textOut;

        }

    }
}
