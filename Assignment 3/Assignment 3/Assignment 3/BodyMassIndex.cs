// Anton Brottare 28/11-2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_3
{
    class BodyMassIndex
    {
        private double Height;
        private double Weight;
        private bool inMetric;

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

        public void setUnit(bool isTrue){
            if (isTrue==true)
            {
                inMetric = true;
            }
            else
            {
                inMetric = false;
            }
            }

        public double CalcBMI()
        {
            if (inMetric==true)
            {
                double CalculationHeight = Height / 100;
                double BMI = Weight / (CalculationHeight * CalculationHeight);
                return Math.Round(BMI, 1);
            }
            else
            {
                double calcWeight = 703 * Weight;
                double calcHeight = Height * Height;
                double BMI = calcWeight / calcHeight;
                return Math.Round(BMI, 1);
            }
        }
        
        public string WeightCategoryPicker()
        {

            double BMI = CalcBMI();
            if(BMI < 18.5 )
            {
                return "Underweight";
            }
            else if (BMI>18.5 && BMI<24.9)
            {
                return "Normal weight";
            }
            else if (BMI>24.9 && BMI<29.9)
            {
                return "OverWeight (Pre-obesity)";
            }
            else if (BMI>29.9 && BMI < 34.9 )
            {
                return "Obesity class I";
            }
            else if (BMI>34.9 && BMI <39.9)
            {
                return "Obesity class II";
            }
            else if (BMI>39.9)
            {
                return "Obesity class III";
            }
            else
            {
                ///This else exists solely because the compiler believes that it's possible to end up at a case that isn't one of the earlier ones.
                ///Something that isn't possible due to input control.
                return "error";
            }
        }

    }
}
