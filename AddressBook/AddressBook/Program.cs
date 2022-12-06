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

            ContactDetails contactDetailsRepo = new ContactDetails();

            Boolean flag = true;


            while (flag)
            {
                Console.WriteLine("Enter 1 for Add person Details ");
                Console.WriteLine("Enter 2 for displaying person details");
                Console.WriteLine("Enter 3 for Exit");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Please Add All the Details :");
                        Console.Write("Enter the First Name : ");
                        string first_Name = Console.ReadLine();
                        Console.Write("Enter the Last Name : ");
                        string last_Name = Console.ReadLine();
                        Console.Write("Enter the Mobile Number : ");
                        string mobile_Number = Console.ReadLine();
                        Console.Write("Enter the Email Id : ");
                        string email_Id = Console.ReadLine();
                        Console.Write("Enter the Address : ");
                        string address = Console.ReadLine();
                        Console.Write("Enter the City : ");
                        string city = Console.ReadLine();
                        Console.Write("Enter the State : ");
                        string state = Console.ReadLine();
                        Console.Write("Enter the Zip : ");
                        string zip = Console.ReadLine();
                        Person person1 = new Person()
                        {
                            FirstName = first_Name,
                            LastName = last_Name,
                            MobileNumber = int.Parse(mobile_Number),
                            Email = email_Id,
                            Address = address,
                            City = city,
                            State = state,
                            zip = int.Parse(zip),
                        };
                        contactDetailsRepo.AddPersonDetails(person1);

                        break;
                    case 2:
                        contactDetailsRepo.DisplayContact();
                        break;
                    default:
                        Console.WriteLine("Exiting the loop .");
                        flag = false;
                        break;
                }
            }
        }
    }
}






                  /*   Person person = new Person();

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
                contactDetail.DisplayContact();  */


        
    
        
    
