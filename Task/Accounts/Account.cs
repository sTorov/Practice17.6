namespace Task.Accounts
{
    /// <summary>
    /// Базовый класс аккаунта
    /// </summary>
    public abstract class Account
    {
        /// <summary>
        /// Баланс учетной записи
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// Процентная ставка
        /// </summary>
        public double Interest { get; set; }

        /// <summary>
        /// ID аккаунта
        /// </summary>
        public int ID { get; set; }

        public Account(int id)
        {
            ID = id;
        }

        /// <summary>
        /// Просмотр баланса и рассчитаной процентной ставки
        /// </summary>
        public virtual void ViewBalanceAndInterest()
        {
            Console.WriteLine($"Баланс: {Balance}\nПроцентная ставка: {Interest}\n");
        }

        /// <summary>
        /// Метод для расчета процентной ставки
        /// </summary>
        public abstract void CalculateInterest();
    }
}
