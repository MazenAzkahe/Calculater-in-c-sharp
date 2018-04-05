using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc(5, 6);
            calc.PrintAdd();
            calc.PrintSub();
            calc.PrintDiv();
            calc.PrintMulti();
            Console.ReadKey();



        }
    }
}
