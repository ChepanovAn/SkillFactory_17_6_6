using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_17_6_6
{
   public class SalaryAccount : Account, ICalculator
    {
        public SalaryAccount(double balance) : base("Зарплатный", balance) { }

        public void calculate()
        {
            Console.WriteLine("salary");
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }
    }
}
