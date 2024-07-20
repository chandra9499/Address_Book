using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        public static void createAddressBookAccount() 
        {
            AddressBook addressBook = new AddressBookImplimentation();
            Console.WriteLine("wlecome to address book");
            while (true)
            {

                Console.WriteLine("enter the choice..");
                Console.WriteLine("1.add \n2.remove \n3.update \n4. logout \n5. allpersonrecord");
                string name = string.Empty;
                int choice = int.Parse(Console.ReadLine());
                if (choice == 4)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("");
                        addressBook.addContact();
                        break;
                    case 2:
                        Console.WriteLine("enter the your first name : - ");
                        name = Console.ReadLine();
                        addressBook.removeContact(name);
                        break;
                    case 3:
                        Console.WriteLine("enter the your first name");
                        name = Console.ReadLine();
                        addressBook.updateContact(name);
                        break;
                    case 5:
                       
                        addressBook.allPersonInAddressBook();
                        break;
                    default:
                        Console.WriteLine("invalid choice.");
                        break;

                }

            }
        }
        static void Main(string[] args)
        {
            createAddressBookAccount();
        }
    }
}
