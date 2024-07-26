using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_School.Models
{
    public class Person (string name, string lastName, string documentType, string documentNumber, string email, string phone)
    {
        protected Guid Id { get; set; } = Guid.NewGuid();
        protected string Name { get; set; } = name;
        protected string LastName { get; set; } = lastName;
        protected string DocumentType { get; set; } = documentType;
        protected string DocumentNumber { get; set; } = documentNumber;
        protected string Email { get; set; } = email;
        protected string Phone { get; set; } = phone;

        // Methods of access to properties
        public string GetName() => Name;
        public string GetLastName() => LastName;
        public string GetDocumentType() => DocumentType;
        public string GetDocumentNumber() => DocumentNumber;
        public string GetEmail() => Email;
        public string GetPhone() => Phone;
        public string SetName(string name) => Name = name;
        public string SetLastName(string lastName) => LastName = lastName;
        public string SetDocumentType(string documentType) => DocumentType = documentType;
        public string SetDocumentNumber(string documentNumber) => DocumentNumber = documentNumber;
        public string SetEmail(string email) => Email = email;
        public string SetPhone(string phone) => Phone = phone;

        public void ShowDetails()
        {
            Console.WriteLine(@$"
                Name: {Name}
                LastName: {LastName}
                DocumentType: {DocumentType}
                DocumentNumber: {DocumentNumber}
                Email: {Email}
                Phone: {Phone}
            ");
            Setting.FinishOption();
        }
    }
}