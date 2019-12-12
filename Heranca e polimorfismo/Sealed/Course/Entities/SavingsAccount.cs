namespace Course.Entities
{
    sealed class SavingsAccount : Account // N permite que a classe seja herdada.
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

        public sealed override void WithDraw(double amount) // N permite que o metodo WithDraw seja sobreposto.
        {
            //Balance -= amount;
            base.WithDraw(amount);
            Balance -= 2;
        }
    }
}
