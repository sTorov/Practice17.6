namespace Task.Accounts
{
    /// <summary>
    /// Зарплатный аккаунт
    /// </summary>
    class SalaryAccount : Account
    {
        public SalaryAccount(int id) : base(id)
        {
        }

        public override void ViewBalanceAndInterest()
        {
            Console.WriteLine($"Зарплатный аккаунт {ID}");
            base.ViewBalanceAndInterest();
        }

        public override void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
