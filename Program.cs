using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_17_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdinaryAccount ordinaryAccount = new OrdinaryAccount(11001);
            ordinaryAccount.calculate();
            Console.WriteLine(ordinaryAccount.Interest);

            SalaryAccount salaryAccount = new SalaryAccount(120);
            salaryAccount.calculate();
            Console.WriteLine(salaryAccount.Interest);
        }
    }
}
