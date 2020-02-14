// Anton Brottare 28/11-2017
using System;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class MainForm : Form
    {
        //Decalare and create an instance of each calculator
       
        private FuelCalculator carMilage = new FuelCalculator();
        private BodyMassIndex BMICalc = new BodyMassIndex();
        private string name = String.Empty;
        private CalorieCalculator BMRCalc = new CalorieCalculator();

        public void InitializeGui()
        {
            FuelConsumtionKMLOutput.Text = String.Empty;
            CurrentOdoInput.Text = String.Empty;
            PrevOdoInput.Text = String.Empty;
            CurrentFuelInput.Text = String.Empty;
            PriceInput.Text = String.Empty;
            NameInput.Text = String.Empty;
            AgeInput.Text = String.Empty;
            WeightInput.Text = String.Empty;
            HeightInput.Text = String.Empty;
            FuelConsumtionSweOutput.Text = String.Empty;
            FuelConsumtionLKMOutput.Text = String.Empty;
            FuelConsumtionMetricOutput.Text = String.Empty;
            CostKmOutput.Text = String.Empty;
            YourBMIOutput.Text = String.Empty;
            WeigthCategoryOutput.Text = String.Empty;



            MetricRadio.Checked = true;
            FemaleRadio.Checked = true;
            ModeratelyRadio.Checked = true;
        }


        public MainForm()
        {
            InitializeComponent();
            InitializeGui();

        }

                
        private void button4_Click(object sender, EventArgs e)
        {
            BMRResult.ClearSelected();
        }

        private void BMICalcButton_Click(object sender, EventArgs e)
        {
           
            bool HeightOk = ReadInputHeight();
            bool WeightOk = ReadInputWeight();

            if (HeightOk && WeightOk)
            {
                ReadInputName();
                ReadInputUnit();
                UpdateBMIGUI();
            }
        }

        private bool ReadInputHeight()
        {
            double value = 0;
            if (double.TryParse(HeightInput.Text, out value) && value > 0.0)
            {
                BMICalc.SetHeight(value);
                return true;
            }
            else
            {
                MessageBox.Show("Invalid height input!", "Error!");
                return false;
            }
        }


        private bool ReadInputWeight()
        {
            double value = 0;
            if (double.TryParse(WeightInput.Text, out value) && value > 0.0)
            {
                BMICalc.SetWeight(value);
                return true;
            }
            else
            {
                MessageBox.Show("Invalid weight input!", "Error!");
                return false;
            }
        }


        private void ReadInputName()
        {
            NameInput.Text.Trim();
            if (string.IsNullOrEmpty(NameInput.Text))
            {
                name = "NoName";
                
                
            }
            else
            {
                name = NameInput.Text;
            }
        }

        private void ReadInputUnit()
        {
            if (MetricRadio.Checked)
            {
                BMICalc.setUnit(true);
                                
            }
            else
            {
                BMICalc.setUnit(false);
            }
        }

        private void UpdateBMIGUI()
        {
            BMIResultsGroup.Text = "Results for "+name;
            YourBMIOutput.Text = BMICalc.CalcBMI().ToString();
            WeigthCategoryOutput.Text = BMICalc.WeightCategoryPicker();

        }

        private void FuelCalcButton_Click(object sender, EventArgs e)
        {
            bool FuelOk = ReadInputFuel();
            bool CurrentOdoOk = ReadInputCurrentOdo();
            bool PrevOdoOk = ReadInputPreviousOdo();
            bool LiterPriceOk = ReadInputLiterPrice();

            if (FuelOk&&CurrentOdoOk&&PrevOdoOk&&LiterPriceOk)
            {
                UpdateFuelGUI();
            }
        }

        private bool ReadInputFuel()
        {
            double value = 0;
            if (double.TryParse(CurrentFuelInput.Text, out value) && value > 0.0)
            {
                carMilage.SetCurrentFuelReading(value);
                return true;
            }
            else
            {
                MessageBox.Show("Invalid fuel input!","Error!");
                return false;
            }
        }

        private bool ReadInputCurrentOdo()
        {
            double value = 0;
            if (double.TryParse(CurrentOdoInput.Text, out value) && value > 0.0)
            {
                carMilage.SetCurrentOdoReading(value);
                return true;
            }
            else
            {
                MessageBox.Show("Invalid current odometer input!", "Error!");
                return false;
            }
        }


        private bool ReadInputPreviousOdo()
        {
            double value = 0;
            if (double.TryParse(PrevOdoInput.Text, out value) && value >= 0.0)
            {
                if (carMilage.getCurrentOdo() > value)
                {
                    carMilage.SetPreviousOdoReading(value);
                    return true;
                }
                else
                {
                    MessageBox.Show("Previous odometer need to smaller than current odometer!", "Error!");
                    return false;

                }

            }
            else
            {
                MessageBox.Show("Invalid previous odometer input!", "Error!");
                return false;
            }
        }

        private bool ReadInputLiterPrice()
        {
            double value = 0;
            if (double.TryParse(PriceInput.Text, out value) && value >= 0.0)
            {
                carMilage.SetLiterPrice(value);
                return true;
            }
            else
            {
                MessageBox.Show("Invalid liter price input!", "Error!");
                return false;

            }
        }

        private void UpdateFuelGUI()
        {
            FuelConsumtionLKMOutput.Text = carMilage.CalcLKMConsumption().ToString("");
            FuelConsumtionKMLOutput.Text = carMilage.CalcKMLConsumption().ToString("");
            FuelConsumtionMetricOutput.Text = carMilage.LitPerMetricMile().ToString("");
            FuelConsumtionSweOutput.Text = carMilage.LitPerSwedishMile().ToString("");
            CostKmOutput.Text = carMilage.CalcPricePerKm().ToString("");

        }


        private void BMRCalcButton_Click(object sender, EventArgs e)
        {

            bool HeightOk = ReadInputHeightBMR();
            bool WeightOk = ReadInputWeightBMR();
            bool AgeOk = ReadInputAgeBMR();
            if (WeightOk && HeightOk && AgeOk)
            {
                ReadInputName();
                ReadActivityLevel();
                ReadInputUnitBMR();
                ReadGenderBMR();
                UpdateBMRGUI();                
                
            }

        }

        private bool ReadInputHeightBMR()
        {
            double value = 0;
            if (double.TryParse(HeightInput.Text, out value) && value > 0.0)
            {
                BMRCalc.SetHeight(value);
                return true;
            }
            else
            {
                MessageBox.Show("Invalid height input!", "Error!");
                return false;
            }
        }


        private bool ReadInputWeightBMR()
        {
            double value = 0;
            if (double.TryParse(WeightInput.Text, out value) && value > 0.0)
            {
                BMRCalc.SetWeight(value);
                return true;
            }
            else
            {
                MessageBox.Show("Invalid weight input!", "Error!");
                return false;
            }
        }

        private bool ReadInputAgeBMR()
        {
            int value = 0;
            if (int.TryParse(AgeInput.Text, out value) && value > 0)
            {
                BMRCalc.SetAge(value);
                return true;
            }
            else
            {
                MessageBox.Show("Invalid age input!", "Error!");
                return false;
            }
        }

        private void ReadInputUnitBMR()
        {
            if (MetricRadio.Checked)
            {
                BMRCalc.setUnit(true);

            }
            else
            {
                BMRCalc.setUnit(false);
            }
        }

        private void ReadActivityLevel()
        {
            if (SedentaryRadio.Checked)
            {
                BMRCalc.SetLevel(0);
            }
            else if (LightRadio.Checked)
            {
                BMRCalc.SetLevel(1);
            }
            else if (ModeratelyRadio.Checked)
            {
                BMRCalc.SetLevel(2);
            }
            else if (VeryRadio.Checked)
            {
                BMRCalc.SetLevel(3);
            }
            else if (ExtraRadio.Checked)
            {
                BMRCalc.SetLevel(4);
            }
        }

        private void ReadGenderBMR()
        {
            if (FemaleRadio.Checked)
            {
                BMRCalc.SetGender(false);

            }
            if(MaleRadio.Checked)
            {
                BMRCalc.SetGender(true);
            }
        }

 
        
        private void UpdateBMRGUI()
        {

            BMRResult.Items.Clear();
            BMRResult.Items.Add("Results for " + name);
            BMRResult.Items.Add("");
            BMRResult.Items.Add("Your BMR (calories/day)                " +BMRCalc.BMRCalculator().ToString());
            BMRResult.Items.Add("Calories to maintain your weight       " + BMRCalc.MaintainWeight().ToString());
            BMRResult.Items.Add("Calories to lose 0.5kg per week        " + BMRCalc.loseWeight(1).ToString());
            BMRResult.Items.Add("Calories to lose 1kg per week          " + BMRCalc.loseWeight(2).ToString());
            BMRResult.Items.Add("Calories to gain 0.5kg per week        " + BMRCalc.GainWeight(1).ToString());
            BMRResult.Items.Add("Calories to lose 1kg per week          " + BMRCalc.GainWeight(2).ToString());
            BMRResult.Items.Add("");
            BMRResult.Items.Add("Losing more than 1000 calories per day is to be avoided.");




        }

        private void BMRResult_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Get the currently selected item in the ListBox.
             SelectedItem.Text = BMRResult.SelectedItem.ToString();
        }


       
    }
}
