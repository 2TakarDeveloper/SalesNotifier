using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesNotifier.Entity;
using SalesNotifier.Static;

namespace SalesNotification.Core
{
    public class NotificationManager
    {
        public static List<SalesData> GetThreshHoldData()
        {
            var datas = Globals.StorageData.Where(r => 
                r.ClosingPrice <= r.SupportRange1.SupportRange.UpperLimit
                && r.ClosingPrice>=r.SupportRange1.SupportRange.LowerLimit
                ||
                ( r.ClosingPrice <= r.SupportRange2.SupportRange.UpperLimit
                && r.ClosingPrice >= r.SupportRange2.SupportRange.LowerLimit
                )
            ).ToList();


            return datas;
        }

    }
}
