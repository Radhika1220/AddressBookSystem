﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    /// <summary>
<<<<<<< HEAD
    /// Address book
    /// </summary>
    class AddrBook
    {
        //Creating a static list 
        public static List<Person> People = new List<Person>();
        //Getter and setter methods
=======
    /// Address Book System
    /// </summary>
    class AddrBook
    {
        //Creating a list to add the details
        public static List<Person> people = new List<Person>();
>>>>>>> UC5-AddingMultipleEntries
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Addresses { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
            public string PhoneNum { get; set; }
            public string EmailId { get; set; }
        }
<<<<<<< HEAD
        //Getting details from user
=======
        //Getting the user details
>>>>>>> UC5-AddingMultipleEntries
        public static void GetCustomer()
        {
            for (int i = 0; i < 2; i++)
            {
                Person person = new Person();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Address : ");
                person.Addresses = Console.ReadLine();

                Console.Write("Enter City : ");
                person.City = Console.ReadLine();

                Console.Write("Enter State : ");
                person.State = Console.ReadLine();

                Console.Write("Enter ZipCode: ");
                person.ZipCode = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                person.PhoneNum = Console.ReadLine();

                Console.Write("Enter EmailId: ");
                person.EmailId = Console.ReadLine();

                people.Add(person);
            }
        }
<<<<<<< HEAD
        //Printing the details
=======
        //Print the details
>>>>>>> UC5-AddingMultipleEntries
        public static void PrintCustomer(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Address : " + person.Addresses);
            Console.WriteLine("City : " + person.City);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("ZipCode : " + person.ZipCode);
            Console.WriteLine("Phone Number: " + person.PhoneNum);
            Console.WriteLine("Email Id: " + person.EmailId);
            Console.WriteLine("-------------------------------------------");
        }
        //Modify the details
        public static void Modify()
        {
            if (people.Count != 0)
            {
                Console.WriteLine("Enter the contact to modify:");
                string Modified = Console.ReadLine();
                foreach (var person in people)
                {
                    if (person.FirstName.ToUpper() == Modified.ToUpper())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to modify the property: ");
                            Console.WriteLine("Enter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Phone Number ");
                            Console.WriteLine("Enter 4 to Change Address ");
                            Console.WriteLine("Enter 5 to Change City ");
                            Console.WriteLine("Enter 6 to Change State ");
                            Console.WriteLine("Enter 7 to Change Pincode ");
                            Console.WriteLine("Enter 8 to Exit ");
                            int Check = Convert.ToInt32(Console.ReadLine());
                            switch (Check)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New First Name: ");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the New Last Name: ");
                                    person.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    person.PhoneNum = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New Address: ");
                                    person.Addresses = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New City: ");
                                    person.City = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New State: ");
                                    person.State = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Pin Code: ");
                                    person.ZipCode = Console.ReadLine();
                                    break;
                                case 8:
                                    return;

                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter the valid name!");
                    }

                }
            }
        }
        //Removing the detail
        public static void RemovePeople()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string Remove = Console.ReadLine();
            foreach(var person in People.ToList())
            {
                if(person.FirstName.ToUpper()==Remove.ToUpper())
                {
                    People.Remove(person);
                    Console.WriteLine("Contact is deleted");
                }
                else
                {
                    Console.WriteLine("Contact is not present");
                }
            }
        }
        //Listing the user entered details or modified details
        public static void ListingPeople()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Your address book is empty.");
                Console.ReadKey();
              return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in people)
            {
                PrintCustomer(person);
            }
            Console.ReadKey();
        }
        //Remving the field uid==ding remove method present in list collection
        public static void RemovePeople()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string Remove = Console.ReadLine();
            foreach (var person in people.ToList())
            {
                if (person.FirstName.ToUpper() == Remove.ToUpper())
                {
                    people.Remove(person);
                    Console.WriteLine("Contact is deleted");
                }
                else
                {
                    Console.WriteLine("Contact is not present");
                }
            }
        }
    }
}

