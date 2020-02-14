using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class RecipeManager
    {
        private Recipe[] recipeList;
        
        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];
            
        }

        private int FindVacantPosition()
        {
            for (int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] == null)
                {
                    return index;
                }
                
            }
            return -1;
        }

        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
            {
                return recipeList[index];
            }
            else
                return null;
        }

        public bool CheckIndex(int value)
        {
            if (value < recipeList.Length && value >= 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool Add(Recipe newRecipe)
        {
            bool ok = false;
            int index = FindVacantPosition();
            if (index >= 0)
            {
                recipeList[index] = newRecipe;
                ok = true;
            }
            return ok;
        }

        public bool Add(string name, FoodCategory category, string[] ingredients)
        {
            bool bok = false;

            int index = FindVacantPosition();

            if(index >= 0)
            {
                Recipe recipe = new Recipe(ingredients.Length);
                recipe.Name = name;
                recipe.Ingredients = ingredients;
                recipe.Category = category;

                recipeList[index] = recipe;
                bok = true;

            }
            return bok;
        }

        public int CurrentNumOfItems()
        {
            int count = 0;
            for (int index = 0; index < recipeList.Length; index++)
            {
                if(recipeList[index] != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
