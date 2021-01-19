using Datalagring_ProjectManager_EFCore.Models;

namespace Datalagring_ProjectManager_EFCore
{
    internal class Employee
    {
        public int Id { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string SocialSecurityNumber { get; protected set; }
        public PaymentAccount PaymentAccount { get; protected set; }

        public Employee(string firstName, string lastName, string socialSecurityNumber, PaymentAccount paymentAccount)
        {
            
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SocialSecurityNumber = socialSecurityNumber;
            PaymentAccount = paymentAccount;
        }

        public Employee(int id, string firstName, string lastName, string socialSecurityNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }


    }
}