namespace TaskOtherVersion.Accounts
{
    /// <summary>
    /// Обычный аккаунт
    /// </summary>
    internal class RegularAccount : IAccount, IInfo
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Обычный аккаунт\nБаланс: {Balance}\nПроцентная ставка: {Interest}\n");
        }
    }
}
