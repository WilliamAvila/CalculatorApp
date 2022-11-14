using Calculator.Service;
namespace Calculator.Service.Test
{
    [TestClass]
    public class CalculatorTest
    {
        MyCalculator calculator;
        List<double> arguments = new List<double>();
        public CalculatorTest()
        {
            arguments.Add(1);
            arguments.Add(2);
            calculator = new MyCalculator('+', arguments);
        }

        [TestMethod]
        public void shouldAddNumbers()
        {

            calculator.ArgumentList = arguments;
            calculator.OperationSymbol = '+';
            arguments[0] = 4;
            arguments[1] = 4;
            double res = calculator.Add();
            Assert.AreEqual(res, 8);
        }
        [TestMethod]
        public void shouldSubstractNumbers()
        {
            calculator.ArgumentList = arguments;
            calculator.OperationSymbol = '+';
            arguments[0] = 9;
            arguments[1] = 4;
            double res = calculator.Substract();
            Assert.AreEqual(res, 5);
        }
        [TestMethod]
        public void shouldMultiplyNumbers()
        {
            calculator.ArgumentList = arguments;
            calculator.OperationSymbol = '+';
            arguments[0] = 2;
            arguments[1] = 4;
            double res = calculator.Multiply();
            Assert.AreEqual(res, 8);
        }
        [TestMethod]
        public void shouldDividenumbers()
        {
            calculator.ArgumentList = arguments;
            calculator.OperationSymbol = '+';
            arguments[0] = 4;
            arguments[1] = 4;
            double res = calculator.Divide();
            Assert.AreEqual(res, 1);
        }
        [TestMethod]
        public void shoulModTwoNumbers()
        {
            calculator.ArgumentList = arguments;
            calculator.OperationSymbol = '+';
            arguments[0] = 4;
            arguments[1] = 4;
            double res = calculator.Mod();
            Assert.AreEqual(res,0);
        }


    }
}