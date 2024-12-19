namespace UdemyUnitTest.App
{
    public class Calculator
    {
        private readonly ICalculatorService _calculatorService;

        public Calculator(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public int add(int a, int b)
        {
            return _calculatorService.add(a, b);
        }

        public int multip(int a, int b)
        {
            return _calculatorService.multip(a, b);
        }
    }
}
