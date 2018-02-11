using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ExcelDataReader;
using SalesNotifier.Entity;

namespace SalesNotifier.Parser
{
    public class ExcelParser
    {
        public static void ExcelReader(string path)
        {
            string filePath = path;
            Static.Globals.Tempdata=new List<SalesData>();
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                {
              
                    do
                    {
                        reader.Read();
               
                        
                            while (reader.Read())
                            {
                                try
                                {
                                    SalesData data = new SalesData()
                                    {
                                        LastUpdate = DateTime.Parse(reader.GetValue(0).ToString()),
                                        Name = reader.GetValue(1).ToString(),
                                        ClosingPrice = reader.GetDouble(2)
                           
                                    };

                                    Static.Globals.Tempdata.Add(data);
                                }
                                catch (Exception e)
                                {
                                    //
                                }
                            }
                          

                    } while (reader.NextResult());
                }
            }

        }
    }
}
