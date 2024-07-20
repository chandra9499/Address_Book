using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook
{
    public class AddressBookImplimentation : AddressBook
    {
        // to add all the person in the list
        List<ContactPerson> list = new List<ContactPerson>();
       
        public void addContact()
        {
            Regex regex;
            string pattern;
            string message;

            ContactPerson contactPerson = new ContactPerson();

            pattern = @"^[A-Z][a-z]{1,20}$";
            Console.WriteLine("enter your first name...");            
            regex = new Regex(pattern);
            message = "invalid first name start with capital ex:-Chandra , Amar";
            contactPerson.FirstName = isCheckRegex(regex, message);

 
            pattern = @"^[A-Z][a-z]{1,20}$";
            regex = new Regex(pattern);
            Console.WriteLine("enter your last name...");
            message = "invalid last name start with capital ex:-Kumar , C";
            contactPerson.LastName = isCheckRegex(regex, message);
           
            Console.WriteLine("enter your phone number...");
            pattern = @"[6-9]{1}[0-9]{9}$";
            regex = new Regex(pattern);
            message = "invalid phone number should have 10 digits";
            contactPerson.PhoneNumber = long.Parse(isCheckRegex(regex, message));

            Console.WriteLine("enter your email...");
            pattern = @"[\w\.\-]+[@][\w]+[\.][\w]{2,3}$";
            regex = new Regex(pattern);
            message = "invalid email address write proper email address ";
            contactPerson.Email = isCheckRegex(regex, message);
            
            Console.WriteLine("enter your address...");
            pattern = @"[\w\W]*$";
            regex = new Regex(pattern);
            message = "invalid user address";
            contactPerson.Address = isCheckRegex(regex, message);

            Console.WriteLine("enter your zip code...");
            pattern = @"[1-9]{1}[0-9]{5}$";
            regex = new Regex(pattern);
            message = "invalid area code should have six digits ex:-585101 , 560098";
            contactPerson.ZipCode =int.Parse(isCheckRegex(regex, message));

            Console.WriteLine("enter your city...");
            pattern = @"[a-zA-Z]$";
            regex = new Regex(pattern);
            message = "invalid city address";
            contactPerson.City = isCheckRegex(regex, message);

            Console.WriteLine("enter your state...");
            pattern = @"[a-zA-Z]$";
            regex = new Regex(pattern);
            message = "invalid state address";
            contactPerson.State = isCheckRegex(regex, message);

            Console.WriteLine("enter your country...");
            pattern = @"[a-zA-Z]$";
            regex = new Regex(pattern);
            message = "invalid country address";
            contactPerson.Country = isCheckRegex(regex, message);

            list.Add(contactPerson);

            Console.WriteLine($"your contact informaion is saved :- {contactPerson.ToString()}");
        }

        public string isCheckRegex(Regex regex ,String message) 
        {
            string variable;
            while (true)
            {
                variable = Console.ReadLine();
                if (regex.IsMatch(variable.ToString()))
                {
                    return variable;
                }

                try
                {
                    throw new InvalidCredentialsException(message);
                }
                catch (InvalidCredentialsException e)
                {
                    Console.WriteLine(e.ToString());
                }
                Console.WriteLine();
                Console.WriteLine(message +" enter again...");
            }            
            
        }

        public void removeContact(string name)
        {
            foreach (ContactPerson item in list)
            {
                if (item.FirstName.Equals(name))
                {
                    list.Remove(item);
                    Console.WriteLine($"{item.ToString()} person is removed from the list");
                    return;
                }
            }
            Console.WriteLine($"their is no record with the name :- {name}");
        }
        public void allPersonInAddressBook()
        {
            foreach (ContactPerson item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void updateContact(String name)
        {
            foreach (ContactPerson item in list)
            {
                if (item.FirstName.Equals(name))
                {
                    addContact();
                    return;
                }
            }
            Console.WriteLine($"their is no person by the name :- {name}");
        }
    }
}
