using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Class
{
    class Calc
    {
        double _Number1;
        double _Number2;
        public Calc(double Number1,double Number2)
        {
            this._Number1 = Number1;
            this._Number2 = Number2;
        }


        private double Add()
        {
            return _Number1 + _Number2;
        }

        public void PrintAdd()
        {
            Console.WriteLine(Add());
        }

        private double Sub()
        {
            return _Number1 - _Number2;
        }

        public void PrintSub()
        {
            Console.WriteLine(Sub());
        }
        private double Div()
        {
            return _Number1 * _Number2;
        }
        public void PrintDiv()
        {
            Console.WriteLine(Div());
        }

        private double Multi()
        {
            if(_Number2==0)
            {
                _Number2 = 1;
            }
            return _Number1 / _Number2;
        }

        public void PrintMulti()
        {
            Console.WriteLine(Multi());
        }




    }
}
