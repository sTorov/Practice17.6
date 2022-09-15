namespace TaskOtherVersion.Accounts
{
    /// <summary>
    /// Интерфейс аккаунта
    /// </summary>
    public interface IAccount
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
        /// Метод для расчета процентной ставки
        /// </summary>
        void CalculateInterest();
    }
}
