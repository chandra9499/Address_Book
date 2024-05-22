using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBookImplimentation();
            while (true) {

                Console.WriteLine("enter the choice..");
                Console.WriteLine("1.add \n 2.all\n3.break");

                int choice = int.Parse(Console.ReadLine());
                if (choice == 3)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        addressBook.addContact();
                        break;
                    case 2:
                        addressBook.allPersonInAddressBook();
                        break;
                    default:
                        Console.WriteLine("invalid choice.");
                        break;

                }

            }
        }
    }
}
