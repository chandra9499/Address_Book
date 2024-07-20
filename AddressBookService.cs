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
        void removeContact(string name);
        void updateContact(String name);
        void allPersonInAddressBook();

    }
    
}
