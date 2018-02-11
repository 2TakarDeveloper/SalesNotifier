using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SalesNotifier.Entity;

namespace SalesNotifier.Static
{
    public static class Globals
    {
        public static string FilePath { get; set; }
        public static List<SalesData> Tempdata { get; set; }
        public static List<SalesData> StorageData
        {
            get
            {
                if (File.Exists(FilePath))
                    return JsonConvert.DeserializeObject<List<SalesData>>(File.ReadAllText(FilePath));
                StorageData= new List<SalesData>();
                return StorageData;
            }
            set => File.WriteAllText(FilePath, JsonConvert.SerializeObject(value));
        }
    }
}
