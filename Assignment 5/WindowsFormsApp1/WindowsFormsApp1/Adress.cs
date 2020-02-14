using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Adress
    {
        private string m_street;
        private string m_zipCode;
        private string m_city;
        private Countries m_country;

        public Adress()
        {
            m_street = String.Empty;
            m_zipCode = String.Empty;
            m_city = String.Empty;

        }
        
        public Adress(string street, string zip, string city, Countries country)
        {

        }

        public Adress(string street, string zip, string city):
            this(street, zip, city, Countries.Sverige)
        {

        }
    }

   
}
