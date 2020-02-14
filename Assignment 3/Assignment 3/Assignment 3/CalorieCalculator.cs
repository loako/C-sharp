// Anton Brottare 28/11-2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    class CalorieCalculator
    {
        private double Height;
        private double Weight;
        private bool inMetric;
        private bool isMale;
        private double activityLevel;
        private int Age;


        public void SetHeight(double Height)
        {
            if (Height > 0.0)
            {
                this.Height = Height;
            }
        }

        public void SetWeight(double Weight)
        {
            if (Weight > 0.0)
            {
                this.Weight = Weight;
            }
        }

        public void setUnit(bool isTrue)
        {
            if (isTrue == true)
            {
                inMetric = true;
            }
            else
            {
                inMetric = false;
            }
        }

        public void SetGender(bool isTrue)
        {
            if (isTrue == true)
            {
                isMale = true;
            }
            else
            {
                isMale = false;
            }


        }

        public void SetLevel(int number)
        {
            switch (number)
            {
                case (0):
                    {
                        activityLevel = 1.2;
                        break;
                    }
                case (1):
                    {
                        activityLevel = 1.375;

                        break;
                    }
                case (2):
                    {
                        activityLevel = 1.550;

                        break;
                    }
                case (3):
                    {
                        activityLevel = 1.725;

                        break;
                    }
                case (4):
                    {
                        activityLevel = 1.9;

                        break;
                    }

            }
        }
        public void SetAge(int Age)
        {
            if (Age > 0)
            {
                this.Age = Age;
            }
        }

        public double BMRCalculator()
        {
            if (inMetric == false)
            {
                convertToMetric();
            }
            double BMR = 10 * Weight + 6.25 * Height - 5*Age;
            if(isMale == true)
            {
                BMR = BMR + 5;
            }
            else
            {
                BMR = BMR - 161;
            }
            return Math.Round(BMR,1);
        }

        public double MaintainWeight()
        {
            double BMR = BMRCalculator();
            double MaintainVal = BMR * activityLevel;
            return MaintainVal;
        }

        public double loseWeight(int factor)
        {
            double loseWeightVal;

                loseWeightVal = MaintainWeight() - 500*factor;
            return loseWeightVal;
 
        }

        public double GainWeight(int factor)
        {
            double loseWeightVal;

            loseWeightVal = MaintainWeight() + 500 * factor;
            return loseWeightVal;

        }

        public void convertToMetric()
        {
            Height = Height * 2.54;
            Weight = Weight * 0.45359237;
        }

    }
    }

