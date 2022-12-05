using AddressBook.Model;
using AddressBook.Repository;
using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book  \n");
            Person person = new Person();

            person.FirstName = "Rajesh";
            person.LastName = "Kumar";
            person.MobileNumber = 2555665566;
            person.Email = "rajesh55@gmail.com";
            person.Address = "kurawali mainpuri ";
            person.City = "mainpuri";
            person.zip = 205265;
            person.State = "Uttarpradesh";

            Person person1 = new Person();
            person1.FirstName = "Sanjeev";
            person1.LastName = "Kumar";
            person1.MobileNumber = 55665665566;
            person1.Email = "sanjeev55@gmail.com";
            person1.Address = "etawah  ";
            person1.City = "etawah";
            person1.zip = 200601;
            person1.State = "Uttarpradesh";



            ContactDetails contactDetail = new ContactDetails();
            contactDetail.AddPersonDetails(person);
            contactDetail.AddPersonDetails(person1);
            contactDetail.DisplayContact();


        }
    }
        }
    
