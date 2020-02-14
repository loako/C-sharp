//Anton Brottare 11/11-2017
//Updated 28/11-2017
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
    public partial class MainForm : Form
    {

        Party party;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Sets the GUI to the default state
        /// </summary>
        private void InitializeGUI()
        {
            numGuestsTextBox.Text = String.Empty;
            costPerPersonTextBox.Text = String.Empty;
            fNameTextBox.Text = String.Empty;
            lNameTextBox.Text = String.Empty;
            totalGuestsDisplayLabel.Text = String.Empty;

            guestList.Items.Clear();

            totalCostDisplayLabel.Text = "0.0";

            invGuestsLabel.Enabled = false;
            partyBox.Enabled = true;



        }

        private void createListBtn_Click(object sender, EventArgs e)
        {
            bool maxNumOk = CreateParty();

            if (!maxNumOk)
            {
                return;
            }
            bool amountOk = ReadCostPerPerson();

            if (maxNumOk && amountOk)
            {
                invGuestsLabel.Enabled = true;
                UpdateGUI();
            }
        }

        private bool CreateParty()
        {
            int maxNumber = 0;
            bool ok = true;

            if(int.TryParse(numGuestsTextBox.Text, out maxNumber)&& (maxNumber > 0))
            {
                party = new Party(maxNumber);
                MessageBox.Show($"Party list with space for {maxNumber} guests created!", "Success!");
            }
            else
            {
                MessageBox.Show("Inbalid Total Number Please try again!", "Error");
                ok = false;
            }
            return ok;
        }

        private bool ReadCostPerPerson()
        {
            double amount = 0.0;
            if (double.TryParse(costPerPersonTextBox.Text, out amount)&& (amount > 0))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid cost per person!", "Error");
                return false;
            }
        }

        /// <summary>
        /// Updates the gui with the current state of all variables.
        /// </summary>
        private void UpdateGUI()
        {
            guestList.Items.Clear();
            string[] listOfGuests = party.GetGuestList();
            if(listOfGuests != null)
            {
                for (int i = 0; i< listOfGuests.Length; i++)
                {
                    string str = $"{i + 1,4}{listOfGuests[i],-20}";
                    guestList.Items.Add(str);
                }
            }
            else
            {
                return;
            }

            double costPerPerson;
            Double.TryParse(costPerPersonTextBox.Text, out costPerPerson);
            party.CostPerCapita = costPerPerson;
            double totalCost = party.CalcTotalCost();
            totalCostDisplayLabel.Text = totalCost.ToString("0.00");
            totalGuestsDisplayLabel.Text = listOfGuests.Length.ToString();


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (TrimNames())
            {
                bool ok = party.AddNewGuest(fNameTextBox.Text, lNameTextBox.Text);
                if (!ok)
                {
                    MessageBox.Show("This list is full! New guest not added!", "Error");
                }
                else
                {
                    UpdateGUI();
                }
            }
        }
        private bool TrimNames()
        {
            if ((!ValidateText(fNameTextBox.Text)) || (!ValidateText(lNameTextBox.Text)))
            {
                return false;
            }
            fNameTextBox.Text = fNameTextBox.Text.Trim();
            lNameTextBox.Text = lNameTextBox.Text.Trim();
            return true;
        }
        private bool ValidateText( string text)
        {
            text = text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please provide both firstname and lastname of the guest", "Error");
                return false;
            }
            return true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            int selectedIndex = guestList.SelectedIndex;
            if (selectedIndex >= 0)
            {
                party.DeleteGuest(selectedIndex);
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("No guest selected", "Error");
            }
        }
    }
}
