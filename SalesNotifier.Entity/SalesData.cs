using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesNotifier.Entity
{
    public class SalesData
    {
        
       
        public string Name { get; set; }
        public double ClosingPrice { get; set; }
        public DateTime LastUpdate { get; set; }
        public Threshold SupportRange1 { get; set; }
        public Threshold SupportRange2 { get; set; }

        public SalesData()
        {
            SupportRange1=new Threshold();
            SupportRange2 = new Threshold();
        }

    }
}
