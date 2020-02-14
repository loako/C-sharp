//Anton Brottare 11/11-2017
//Updated 28/11-2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_4
{
    class Party
    {

        private double costPerCapita;
        private string[] guestList;


        public Party ( int maxNumOfGuests)
        {
            guestList = new string[maxNumOfGuests];

        }

        public double CostPerCapita
        {
            get { return costPerCapita; }
            set
            {
                if (value >= 0)
                {
                    costPerCapita = value;
                }
            }

        }

        private int NumOfGuests()
        {
            int numGuests = 0;
            
            for (int i=0;i<guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    numGuests++;
                }
            }
            return numGuests;
        }

        private int FindVacantPos()
        {
            int vacantPos = -1;
            for (int index = 0; index< guestList.Length; index++)
            {
                if (string.IsNullOrEmpty(guestList[index]))
                {
                    vacantPos = index;
                    break;
                }
            }
            return vacantPos;
        }

        public bool AddNewGuest (string firstName, string lastName)
        {
            bool ok = true;
            int vacantPos = FindVacantPos();
            if(vacantPos != -1)
            {
                guestList[vacantPos] = FullName(firstName, lastName);
            }
            else
            {
                ok = false;
            }
            return ok;

        
            
        }

        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + ", " + firstName; 
        }

        public string[] GetGuestList()
        {
            int size = NumOfGuests();

            if ( size <= 0)
            {
                return null;
            }

            string[] guests = new string[size];

            for (int i = 0, j=0; i<guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    guests[j++] = guestList[i];
                }

            }
            return guests;

        }
        /// <summary>
        /// Calculates the total cost of the party
        /// </summary>
        /// <returns></returns>
        public double CalcTotalCost()
        {
            double totalCost = costPerCapita * NumOfGuests(); 
            return totalCost;
        }
        /// <summary>
        /// Deletes guests, loses sync after deleting one guest though...
        /// </summary>
        public bool DeleteGuest(int pos)
        {
            bool ok = true;
            int position = pos;
            
            guestList[position] = String.Empty;
            return ok;
        }
    }
}
