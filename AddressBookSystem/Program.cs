using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    /// <summary>
    /// UC1-Address Book System
    /// </summary>

    class Addr
    {
        //main Method-Calling the method present in AddrBook class by using switch case
        static void Main(string[] args)
        {
<<<<<<< HEAD

=======
>>>>>>> UC5-AddingMultipleEntries
            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
<<<<<<< HEAD
            switch(Console.ReadLine())
=======
            switch (Console.ReadLine())
>>>>>>> UC5-AddingMultipleEntries
            {
                case "1":
                    Sample.AddrBook.GetCustomer();
                    Sample.AddrBook.ListingPeople();
                    break;
                case "2":
                    Sample.AddrBook.GetCustomer();
                    Sample.AddrBook.Modify();
                    Sample.AddrBook.ListingPeople();
                    break;
                case "3":
                    Sample.AddrBook.GetCustomer();
                    Sample.AddrBook.ListingPeople();
                    break;
                case "4":
                    Sample.AddrBook.GetCustomer();
                    Sample.AddrBook.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }



        }
    }
}




