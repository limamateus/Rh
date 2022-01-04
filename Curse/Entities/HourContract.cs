using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curse.Entities
{
    class HourContract
    {
        public DateTime Date  { get; set; }

        public double valuePerHour { get; set; }

        public int hour { get; set; }
        

        public HourContract()
        {

        }

      public double totalValue()
        {

            return hour * valuePerHour;


        }

    }
}
