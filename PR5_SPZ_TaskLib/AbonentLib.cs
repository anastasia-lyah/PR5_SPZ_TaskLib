using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_SPZ_TaskLib
{
    public class Abonent
    {
        public string Number;
        public string Name;
        public string Tariff;
        public double Balance;
        public DateTime ActivationDate;
        public bool HasInternet;
        public bool HasDigitalTV;
        public TimeSpan timeExistence
        {
            get
            {
                return GetTimeExistence();
            }
        }
        public TimeSpan GetTimeExistence()
        {
            return DateTime.Now - ActivationDate;
        }
    }
}
