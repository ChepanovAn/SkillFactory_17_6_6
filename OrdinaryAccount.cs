using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_17_6_6
{
    public class OrdinaryAccount : Account, ICalculator
    {
        public OrdinaryAccount(double balance) : base("Обычный", balance) { }

        public void calculate()
        {
            Console.WriteLine("ordinary");
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance >= 1000)
                Interest -= Balance * 0.4;
        }
    }
}
