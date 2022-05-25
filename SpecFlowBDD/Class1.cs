using System;

namespace SpecFlowBDD
{
    public class Calculator
    {
        public int firstNumber { get; set; }

        public int secondNumber { get; set; }

        public int Add()
        {
            return firstNumber + secondNumber;
        }

        public int Subtract()
        {
            return firstNumber - secondNumber;
        }
    }
}
