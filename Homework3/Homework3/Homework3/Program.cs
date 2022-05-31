// See https://aka.ms/new-console-template for more information
using Homework3.Db;

ContactsContext contactsContext = new ContactsContext();

Contact contactOne = new Contact("victor","notanemail","cell","555555",100,"test users",DateTime.Now);
contactsContext.Contacts.Add(contactOne);
contactsContext.SaveChanges();