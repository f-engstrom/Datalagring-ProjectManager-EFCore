namespace Datalagring_ProjectManager_EFCore.Models
{
    internal class PaymentAccount
    {
        public int Id { get; protected set; }
        public int EmployeeId { get; protected set; }

        public string ClearingNr { get; protected set; }
        public string AccountNr { get; protected set; }
        public string Bank { get; protected set; }

        public PaymentAccount(string clearingNr, string accountNr, string bank)
        {
            
            this.ClearingNr = clearingNr;
            this.AccountNr = accountNr;
            this.Bank = bank;
        }
    }
}