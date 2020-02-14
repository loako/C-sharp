//Anton Brottare 28/11-2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        ItemManager itemManager = new ItemManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }
        /// <summary>
        /// Sets the default values of the gui
        /// </summary>
        public void InitializeGui()
        {
            unitCombo.Items.AddRange(Enum.GetNames(typeof(UnitTypes)));
            unitCombo.SelectedIndex = (int)UnitTypes.piece;
        }
        /// <summary>
        /// Updates the gui
        /// </summary>
        public void UpdateGUI()
        {
            listItems.Items.Clear();
            string[] listOfItems = itemManager.GetItemsInfoStrings();
            if (listOfItems != null)
            {
                for(int i = 0; i < listOfItems.Length; i++)
                {
                    string str = $"{i +1,4}  {listOfItems[i],-20}";
                    listItems.Items.Add(str);
                }
            }
        }
       
       
        private void addButton_Click(object sender, EventArgs e)
        {
            bool success = false;

            ShoppingItem item = ReadInput(out success);
            if (success)
            {
                itemManager.AddItem (item);
                UpdateGUI();
            }
        }

        /// <summary>
        /// Creates a new shoppingitem and calls the appropriate methods for reading amount, description and unit input.
        /// </summary>
        private ShoppingItem ReadInput(out bool success)
        {
            success = false;

            ShoppingItem item = new ShoppingItem();
            item.Description = ReadDescription(out success);
            if (!success)
            {
                return null;
            }

            item.Amount = ReadAmount(out success);
            if (!success)
            {
                return null;
            }

           item.Unit = ReadUnit(out success);
            return item;
        }

               
        private double ReadAmount(out bool success)
        {
            double amount = 0.0;
            success = false;
            if (!double.TryParse(amountTxt.Text, out amount))
            {
                GiveMessage("Wrong amount!");
                amountTxt.Focus();
                amountTxt.SelectionStart = 0;
                amountTxt.SelectionLength = amountTxt.TextLength;
            }
            else
            {
                success = true;
            }
            return amount;
        }

        private string ReadDescription(out bool success)
        {
            string description = descTxt.Text;
            success = false;
            if (string.IsNullOrEmpty(descTxt.Text))
            {
                GiveMessage("Empty description!");
                descTxt.Focus();
                descTxt.SelectionStart = 0;
                descTxt.SelectionLength = amountTxt.TextLength;
            }
            else
            {
                success = true;
            }
            return description;
        }

        private UnitTypes ReadUnit(out bool success)
        {
            
            UnitTypes unit = (UnitTypes)unitCombo.SelectedIndex; 
            
            
                success = true;
            
            return unit;
        }

        /// <summary>
        /// Displays error messages with the error passed from the calling method.
        /// </summary>
        private void GiveMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
