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
    }
    class AddressBookImplimentation : AddressBook
    {
        public ArrayList list = new ArrayList();
        public void addContact()
        {
           
        }

        public void removeContact()
        {
            
        }
    }
}
