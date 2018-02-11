using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesNotifier.Entity
{
    public class Threshold
    {
        public int Serial { get; set; }
        public SupportRange SupportRange { get; set; }

        public Threshold()
        {
            SupportRange = new SupportRange();
        }

        public override string ToString()
        {
            return SupportRange.LowerLimit.ToString("N2");
        }
    }

    public class SupportRange
    {
        public double UpperLimit { get; set; }
        public double LowerLimit { get; set; }
    }


}
