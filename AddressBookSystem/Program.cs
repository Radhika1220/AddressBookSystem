﻿using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program

    {
     
        public static Dictionary<string, List<AddrBook>> addressBook = new Dictionary<string, List<AddrBook>>();

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book System!");
            Console.WriteLine("Enter the number of address books: ");
            int noOfAddressBook = Convert.ToInt32(Console.ReadLine());
            int noOfBooks = 0;
            while (noOfBooks < noOfAddressBook)
            {
                Console.WriteLine("Enter the address book name : ");
                string addressbookname = Console.ReadLine();
                AddrBook addrBook = new AddrBook();
                Console.WriteLine("Enter the no of contacts in the address book: ");
                int noOfContact = Convert.ToInt32(Console.ReadLine());

                while (noOfContact > 0)
                {
                    Console.WriteLine("Enter the details of contact to be added: ");

                    Console.Write("Enter First Name: ");
                    string FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    string LastName = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    string PhoneNumber = Console.ReadLine();

                    Console.Write("Enter Address : ");
                    string Addresses = Console.ReadLine();

                    Console.Write("Enter City : ");
                    string City = Console.ReadLine();

                    Console.Write("Enter State : ");
                    string State = Console.ReadLine();

                    Console.Write("Enter ZipCode: ");
                    string ZipCode = Console.ReadLine();

                    Console.Write("Enter EmailId: ");
                    string EmailId = Console.ReadLine();
                    addrBook.GetCustomer(FirstName, LastName, PhoneNumber, Addresses, City, State, ZipCode, EmailId);
                    noOfContact--;
                    Console.WriteLine(" ");
                    addrBook.ListingPeople();
                }
                Console.WriteLine("1.To modify the details");
                Console.WriteLine("2.To remove the details");
                Console.WriteLine("3.Exit!");
                switch (Console.ReadLine())
                {
                    case "1":
                        addrBook.Modify();
                        Console.WriteLine(" ");
                        addrBook.ListingPeople();
                        break;
                    case "2":
                        addrBook.RemovePeople();
                        Console.WriteLine(" ");
                        addrBook.ListingPeople();
                        break;
                    default:
                        Console.WriteLine("Enter valid option!");
                        break;

                }
                if (addressBook.ContainsKey(addressbookname))
                {
                    Console.WriteLine("Existing address book name");
                    return;
                }
                else
                {
                    addressBook.Add(addressbookname, addrBook.people);
                }


                noOfBooks++;
            } 
            Console.WriteLine("Enter City name which you want to person details");
            string cityname = Console.ReadLine();
            Console.WriteLine("Enter state name which you want to person details");
            string statename= Console.ReadLine();
           
            foreach (KeyValuePair<string, List<AddrBook>> contact in addressBook)
            {
                Console.WriteLine("The Contact List from {0} or {1}", cityname, statename);
                AddrBook addr = new AddrBook();
                addr.Search(contact.Value, cityname, statename);
            }
            foreach (KeyValuePair<string, List<AddrBook>> addr in addressBook)
            {
                Console.WriteLine("The address Books are:{0}", addr.Key);

            }

        }
    }
}




