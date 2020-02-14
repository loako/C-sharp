// Anton Brottare 28/11-2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_3
{
    class FuelCalculator
    {
        private double Fuel;
        private double CurrentOdo;
        private double PreviousOdo;
        private double Price;
        private double Distance;
        private double KMLConsumption;
        private double litPerMetricMile;
        private double LKMConsumption;

        /// <summary>
        /// Setter for current fuel
        /// </summary>
        public void SetCurrentFuelReading(double CurrentFuel)
        {
            if (CurrentFuel > 0.0)
            {
                this.Fuel = CurrentFuel;
            }
        }
        /// <summary>
        /// Setter for current odometer
        /// </summary>
        public void SetCurrentOdoReading(double CurrentOdo)
        {
            if (CurrentOdo > 0.0)
            {
                this.CurrentOdo = CurrentOdo;
            }
        }
        /// <summary>
        /// Getter for current Odometer
        /// </summary>
        public double getCurrentOdo()
        {
            return this.CurrentOdo;
        }


        /// <summary>
        /// Setter for previous Odometer
        /// </summary>
        public void SetPreviousOdoReading(double PreviousOdo)
        {
            if (PreviousOdo > 0.0)
            {
                this.PreviousOdo = PreviousOdo;
            }
             
        }
        /// <summary>
        /// Setter for fuelprice
        /// </summary>
        public void SetLiterPrice(double LiterPrice)
        {
            if (LiterPrice > 0.0)
            {
                this.Price = LiterPrice;
            }
        }

        /// <summary>
        /// Calculates L/KM consumption
        /// </summary>
        public double CalcLKMConsumption()
        {
            Distance = CurrentOdo - PreviousOdo;
            LKMConsumption = Fuel/Distance;
            return Math.Round(LKMConsumption,2);
        }

        /// <summary>
        /// Calculates KM/L consumption
        /// </summary>
        public double CalcKMLConsumption()
        {

            KMLConsumption = Distance/Fuel;
            return Math.Round(KMLConsumption, 2);
        }


        /// <summary>
        /// Calculates L/MetricMile consumption
        /// </summary>
        public double LitPerMetricMile()
        {
            const double kmToMileFactor = 0.621371192;
            litPerMetricMile = LKMConsumption / kmToMileFactor;
            return Math.Round(litPerMetricMile,2);
        }
        /// <summary>
        /// Calculates L/SweMile consumption
        /// </summary>
        public double LitPerSwedishMile()
        {
            double literPerSwedMil = LKMConsumption * 10;
            return Math.Round(literPerSwedMil,2);
        }

        /// <summary>
        /// Calculates price/KM
        /// </summary>
        public double CalcPricePerKm()
        {
            if (Price != 0)
            {
                double CostPerKm = LKMConsumption * Price;
                return Math.Round(CostPerKm, 2);
            }
            else
            {
                return 0;
            }
        }


    }
}
