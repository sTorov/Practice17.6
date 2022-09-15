using TaskOtherVersion.Accounts;
using System.Text;

namespace TaskOtherVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var regularAccount = new RegularAccount() { Balance = 900 };
            Calculator.CalculateInterest(regularAccount);
            regularAccount.PrintInfo();

            var salaryAccount = new SalaryAccount() { Balance = 900 };
            Calculator.CalculateInterest(salaryAccount);
            salaryAccount.PrintInfo();
        }
    }
}