using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Repository
{
    internal class ContactDetails
    {
        public Dictionary<string, Person> contactDetailDictionary = new Dictionary<string, Person>();
        public void AddPersonDetails(Person contactDetails)
        {
            contactDetailDictionary.Add(contactDetails.FirstName, contactDetails); // keys is mobileno. & contactDetails is a instance(object) 
        }

        public void Edit_Person_Details(Person contactDetails)
        {
            bool temp = contactDetailDictionary.ContainsKey(contactDetails.FirstName);
            if (temp)
            {
                contactDetailDictionary[contactDetails.FirstName] = contactDetails;
            }
            else
            {
                Console.WriteLine("User does not exist.");
            }
        }
        public void DisplayContact()
        {
            foreach (var item in contactDetailDictionary)
            {
                Console.WriteLine("First Name is : " + item.Value.FirstName);
                Console.WriteLine("Last Name is : " + item.Value.LastName);
                Console.WriteLine("Mobile Number is : " + item.Value.MobileNumber);
                Console.WriteLine("Email ID is : " + item.Value.Email);
                Console.WriteLine("Address is : " + item.Value.Address);
                Console.WriteLine("City is : " + item.Value.City);
                Console.WriteLine("State is : " + item.Value.State);
                Console.WriteLine("Zip Code is : " + item.Value.zip);
                Console.WriteLine();
            }
        }
    }
}
