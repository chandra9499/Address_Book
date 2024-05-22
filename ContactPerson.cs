using System;


namespace AddressBook
{
    public class ContactPerson
    {
        private string firstName;
        private string lastName;      
        private long phoneNumber;
        private string email;
        private string address;
        private int zipCode;
        private string city;
        private string state;
        private string country;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public long PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string City { get { return city; }   set { city = value; } }
        public string State { get { return state; } set { state = value; } }
        public int ZipCode { get {   return zipCode; } set { zipCode = value; } }
        public string Country { get { return country; } set { country = value; } }

        public ContactPerson()
        {
            
        }
        public ContactPerson(string firstName, string lastName, long phoneNumber, string email, string address, string city, string state, int zipCode, string country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.country = country;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
