using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Project
{
    class CalculatorModel : ICalculatorModel
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
