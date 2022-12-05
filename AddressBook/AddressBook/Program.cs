using AddressBook.Model;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            Person person = new Person();

            person.FirstName = "Rajesh";
            person.LastName = "Kumar";
            person.MobileNumber = 2555665566;
            person.Email = "rajesh55@gmail.com";
            person.Address = "kurawali mainpuri ";
            person.City = "mainpuri";
            person.zip = 205265;
            person.State = "Uttarpradesh";
        }
    }
}