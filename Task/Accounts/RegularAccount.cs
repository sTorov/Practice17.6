namespace Task.Accounts
{
    /// <summary>
    /// Обычный аккаунт
    /// </summary>
    class RegularAccount : Account
    {
        public RegularAccount(int id) : base(id)
        {
        }

        public override void ViewBalanceAndInterest()
        {
            Console.WriteLine($"Обычный аккаунт {ID}");
            base.ViewBalanceAndInterest();
        }

        public override void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }
}
