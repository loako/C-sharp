using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitializeGui();
        }



        private void InitializeGui()
        {
            categoryCombo.Items.AddRange(new object[] {
                        "Fish",
                        "Meat",
                        "Seafood",
                        "Vegetarian"});
            categoryCombo.SelectedIndex = 0;
        }

        private const int maxNumOfIngredients = 20;
        private const int maxNumofElements = 50;

        Recipe currRecipe = new Recipe(maxNumOfIngredients);

        RecipeManager recipeMngr = new RecipeManager(maxNumofElements);


        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            FormIngredient dialog = new FormIngredient(currRecipe);
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                if(currRecipe.GetCurrentNumOfIngredients() <= 0)
                {
                    MessageBox.Show("No ingredients specified!");
                    recipeMngr.Add(currRecipe);
                    UpdateGui();
                }
            }
        }

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            currRecipe.Category = (FoodCategory)categoryCombo.SelectedIndex;
            currRecipe.Name = nameOfRecipeBox.Text;
            currRecipe.Description = descriptionBox.Text;

            recipeMngr.Add(currRecipe);

            UpdateGui();
            currRecipe.DefaultValues();

        }

        public void UpdateGui()
        {
            
        }
    }
}
