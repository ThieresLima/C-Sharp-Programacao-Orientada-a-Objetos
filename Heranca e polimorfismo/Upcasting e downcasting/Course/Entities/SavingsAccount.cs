namespace Course.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interesrRate) 
            : base(number, holder, balance)
        {
            InterestRate = interesrRate;
        }

        public void UpDateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
