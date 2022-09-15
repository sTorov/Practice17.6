using Task.Accounts;
using System.Text;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var salaryAccount1 = new SalaryAccount(101) { Balance = 900 };
            Calculator.CalculateInterest(salaryAccount1);
            salaryAccount1.ViewBalanceAndInterest();

            var regualrAccount1 = new RegularAccount(201) { Balance = 900 };
            Calculator.CalculateInterest(regualrAccount1);
            regualrAccount1.ViewBalanceAndInterest();

            Console.WriteLine("----------\n");

            var salaryAccount2 = new SalaryAccount(1024) { Balance = 100000 };
            Calculator.CalculateInterest(salaryAccount2);
            salaryAccount2.ViewBalanceAndInterest();

            var regualrAccount2 = new RegularAccount(3311) { Balance = 100000 };
            Calculator.CalculateInterest(regualrAccount2);
            regualrAccount2.ViewBalanceAndInterest();

        }
    }
}