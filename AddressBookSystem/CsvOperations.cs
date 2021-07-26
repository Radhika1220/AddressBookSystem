using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class CsvOperations
    {
        static string jsonfilePath = @"C:\Users\Radhika\source\repos\AddressBookSystem\AddressBookSystem\JsonData.Json";
        static string csvfilePath = @"C:\Users\Radhika\source\repos\AddressBookSystem\AddressBookSystem\csvData.csv";
        public static void WriteInCSVFile(Dictionary<string, List<AddrBook>> addressBook)
        {
            //Writing into csv file
            try
            {
                string nullValue = "";
                //To check whether file exists or not
                if (File.Exists(csvfilePath))
                {
                    File.WriteAllText(csvfilePath, nullValue);
                    foreach (KeyValuePair<string, List<AddrBook>> kvp in addressBook)
                    {
                        //Opening a file in append mode to append the data in last
                        using var stream = File.Open(csvfilePath, FileMode.Append);
                        //writer stream 
                        using var writer = new StreamWriter(stream);
                        using var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
                        foreach (var value in kvp.Value)
                        {
                            //Create List to add Records 
                            List<AddrBook> list = new List<AddrBook>();
                            list.Add(value);
                            csvWriter.WriteRecords(list);
                        }
                        //Print a newline
                        csvWriter.NextRecordAsync();
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Calling the readcsvfile method to read the data
            ReadCSVFile();
        }
        public static void ReadCSVFile()
        {
            //reading in csv file
            try
            {
                if (File.Exists(csvfilePath))
                {
                    //Streamreader class
                    using (var reader = new StreamReader(csvfilePath))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        //GetRecords-get the all records in list
                        var records = csv.GetRecords<AddrBook>().ToList();
                        Console.WriteLine("\n*****Read data successfully from csv file********\n");
                        foreach (AddrBook addr in records)
                        {
                            if (addr.firstName == "firstName")
                            {
                                Console.WriteLine("\n");
                                continue;
                            }
                            //calling tostring method to print the data
                            Console.WriteLine(addr.ToString());
                        }
                        //Reading from csv file and Writing into json file
                        JsonSerializer jsonSerializer = new JsonSerializer();
                        using (StreamWriter stream = new StreamWriter(jsonfilePath))
                        using (JsonWriter jsonWriter = new JsonTextWriter(stream))
                        {
                           //Write the data in json file
                            jsonSerializer.Serialize(jsonWriter, records);

                        }

                        //Reading from Json File
                        List<AddrBook> jsonList = JsonConvert.DeserializeObject<List<AddrBook>>(File.ReadAllText(jsonfilePath));
                        Console.WriteLine("\n * ****Read data successfully from JSON file********\n");
                        foreach (var m in jsonList)
                        {
                            if (m.firstName == "firstName")
                            {
                                Console.WriteLine("\n");
                                continue;
                            }
                            Console.WriteLine(m.ToString());
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


  
