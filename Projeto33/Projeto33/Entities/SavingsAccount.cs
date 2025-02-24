namespace Projeto33.Entities
{
    internal class SavingsAccount : Account
    {
        public double interestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            interestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * interestRate;
        }
    }
}
