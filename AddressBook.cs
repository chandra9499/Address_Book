using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public interface AddressBook
    {
        void addContact();
        void removeContact();
        void allPersonInAddressBook();
    }
    class AddressBookImplimentation : AddressBook
    {
        public ArrayList list = new ArrayList();
        public void addContact()
        {
            // person is created 
            ContactPerson contactPerson = new ContactPerson();
            Console.WriteLine("enter your first name...");
            contactPerson.FirstName = Console.ReadLine();
            Console.WriteLine("enter your last name...");
            contactPerson.LastName = Console.ReadLine();
            Console.WriteLine("enter your phone number...");
            contactPerson.PhoneNumber =long.Parse(Console.ReadLine());
            Console.WriteLine("enter your email...");
            contactPerson.Email = Console.ReadLine();
            Console.WriteLine("enter your address...");
            contactPerson.Address = Console.ReadLine();
            Console.WriteLine("enter your zip code...");
            contactPerson.ZipCode = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your city...");
            contactPerson.City = Console.ReadLine();
            Console.WriteLine("enter your state...");
            contactPerson.State = Console.ReadLine();
            Console.WriteLine("enter your country...");
            contactPerson.Country = Console.ReadLine();
            list.Add(contactPerson);

            Console.WriteLine($"your contact informaion is saved :- {contactPerson.ToString()}");
        }
        public void removeContact()
        {
            
        }
        public void allPersonInAddressBook()
        {
            foreach (ContactPerson item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
