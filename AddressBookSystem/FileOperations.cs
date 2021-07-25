using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class FileOperations
    {
        static string filePath = @"C:\Users\Radhika\source\repos\AddressBookSystem\AddressBookSystem\AddressText.txt";
        public static void WriteInFile(Dictionary<string, List<AddrBook>> addressBook)
        {
            string nullValue = "";
            File.WriteAllText(filePath,nullValue);
            foreach (KeyValuePair<string, List<AddrBook>> kvp in addressBook)
            {
                //Append key in file
                File.AppendAllText(filePath, "The Address Book is : " + kvp.Key + Environment.NewLine);
                foreach (var member in kvp.Value)
                {
                    //Append Values or Contacts in file
                    File.AppendAllText(filePath, member.ToString() + Environment.NewLine);
                }
                //Enter a new line to File
                File.AppendAllText(filePath, Environment.NewLine);
                Console.WriteLine("\n******The Content written in the file*********\n");
                //Calling the readaddressbook to read the data in file
                ReadAddressBook();
            }

        }
        public static void ReadAddressBook()
        {
            try
            {
                string text;
                if (File.Exists(filePath))
                {
                    text = File.ReadAllText(filePath);

                    if (text.Length != 0)
                    {
                        Console.WriteLine(text);
                    }
                }
                else
                {
                    Console.WriteLine("File does not contain text");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

