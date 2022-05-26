using System;
using System.Collections.Generic;

namespace AddressBookProject
{
    public class AddressBook
    {
        // dictionary:
        public Dictionary<string, Contact> AddressBookDictionary = new Dictionary<string, Contact>();

        // method:
        public void AddContact(Contact name)
        {
            AddressBookDictionary.Add(name.Email, name);
        }

        public void GetByEmail(Contact email)
        {
            // AddressBookDictionary.Find(email);
        }
    }
}