using System;

namespace Data
{
    public class CalculatorModel : ICalculatorModel
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }


}
