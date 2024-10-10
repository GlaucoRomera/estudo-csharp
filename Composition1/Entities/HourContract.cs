using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition1.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(DateTime date, double Value, int duration)
        {
            Date = date;
            ValuePerHour = Value;
            Hours = duration;
            
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }

    
}
