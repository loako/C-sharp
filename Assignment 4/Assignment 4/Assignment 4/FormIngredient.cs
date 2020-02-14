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
    public partial class FormIngredient : Form
    {

        Recipe m_recipe;

        public FormIngredient(Recipe recipe)
        {
            InitializeComponent();

            m_recipe = recipe;
            if (string.IsNullOrEmpty(recipe.Name))
            {
                this.Text = "No Recipe Name";
            }
            else
            {
                this.Text = recipe.Name + "Add ingredients";
            }

            InitializeGui();
        }

        private void InitializeGui()
        {
            if (m_recipe.Ingredients == null) {
                m_recipe.Ingredients = new string[m_recipe.maxNumOfIngredients]]
        
                }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
