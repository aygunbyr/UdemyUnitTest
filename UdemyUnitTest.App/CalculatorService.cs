using System;

namespace UdemyUnitTest.App
{
    public class CalculatorService : ICalculatorService
    {
        public int add(int a, int b)
        {
            //if (a == 0 || b == 0)
            //{
            //    return 0;
            //}
            //return a + b;
            return 0;
        }

        public int multip(int a, int b)
        {
            if(a == 0)
            {
                throw new Exception("a=0 olamaz");
            }
            return a * b;
        }
    }
}
