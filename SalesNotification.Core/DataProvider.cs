using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesNotifier.Entity;
using SalesNotifier.Static;

namespace SalesNotification.Core
{
    public class DataProvider
    {
        public static void UpdateData()
        {
            List<SalesData> tempStorage=Globals.StorageData;
            foreach (var data in Globals.Tempdata)
            {
                var oldData = tempStorage.FirstOrDefault(r => r.Name == data.Name);
                if (oldData != null)
                {
                    oldData.LastUpdate = data.LastUpdate;
                    oldData.ClosingPrice = data.ClosingPrice;
                }
                else
                {
                    tempStorage.Add(data);
                }
                    
            }
            Globals.StorageData = tempStorage;
        }

    }
}
