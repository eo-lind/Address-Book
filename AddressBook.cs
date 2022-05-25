using System;
using System.Collections.Generic;

namespace AddressBookProject
{
    public class AddressBook{
        // dictionary:

        public Dictionary<string, Contact> AddressBookDictionary = new Dictionary<string, Contact>();

        public void AddContact(Contact name)
        {
            AddressBookDictionary.Add(name.Email, name);
        }
    }
}