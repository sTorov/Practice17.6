using Task.Accounts;

namespace Task
{
    /// <summary>
    /// Класс для расчётов
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Метод для расчета процентной ставки для полученного аккаунта
        /// </summary>
        /// <param name="account"></param>
        public static void CalculateInterest(Account account)
        {
            account.CalculateInterest();
        }
    }
}
