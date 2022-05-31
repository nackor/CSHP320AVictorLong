using System;
using System.Collections.Generic;

namespace Homework3.Db
{
    public partial class Contact
    {
        public Contact(int ID, string Name, string Email, string PhoneType, string Number, int Age, string Note, DateTime Date)
        {
            ContactId = ID;
            ContactName = Name;
            ContactEmail = Email;
            ContactPhoneType = PhoneType;
            ContactPhoneNumber = Number;
            ContactAge = Age;
            ContactNotes = Note;
            ContactCreatedDate = Date;
        }
        public int ContactId { get; set; }
        public string ContactName { get; set; } = null!;
        public string? ContactEmail { get; set; }
        public string? ContactPhoneType { get; set; }
        public string? ContactPhoneNumber { get; set; }
        public int ContactAge { get; set; }
        public string? ContactNotes { get; set; }
        public DateTime ContactCreatedDate { get; set; }
    }
}
