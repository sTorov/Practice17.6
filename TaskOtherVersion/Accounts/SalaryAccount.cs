namespace TaskOtherVersion.Accounts
{
    /// <summary>
    /// Зарплатный аккаунт
    /// </summary>
    internal class SalaryAccount : IAccount, IInfo
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Зарплатный аккаунт\nБаланс: {Balance}\nПроцентная ставка: {Interest}\n");
        }
    }
}
