using TaskOtherVersion.Accounts;

namespace TaskOtherVersion
{
    /// <summary>
    /// Класс для расчётов
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Метод для расчета процентной ставки
        /// </summary>
        /// <param name="account"></param>
        public static void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}
