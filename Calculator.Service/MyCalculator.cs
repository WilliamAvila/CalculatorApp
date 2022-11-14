namespace Calculator.Service
{
    public enum Operator
    {
        PLUS = '+',
        MINUS = '-',
        MULTIPLY = '*',
        DIVIDE = '/',
        MOD = '%'
    }

    public class MyCalculator : ICalculator
    {
        char operationSymbol;
        IEnumerable<double> argumentList;

        public MyCalculator(char operationSymbol, IEnumerable<double> argumentList)
        {
            this.operationSymbol = operationSymbol;
            this.argumentList = argumentList;
        }


        public double Calculate()
        {
            double res = 0;
            switch (this.operationSymbol)
            {
                case (char)Operator.PLUS:
                {
                    res = this.Add();
                    break;
                }
                case (char)Operator.MULTIPLY:
                { 
                    res = this.Multiply();
                    break;
                }
                case (char)Operator.MINUS:
                {
                    res = this.Substract();
                    break;
                }
                case (char)Operator.DIVIDE:
                {
                    res = this.Divide();
                    break;
                }
                case (char)Operator.MOD:
                {
                    res = this.Mod();
                    break;
                }
                default: break;
            }
            return res;
        }

        public double Add()
        {
            return this.argumentList.Sum(x => x);
        }
        public double Substract()
        {
            return this.argumentList.ElementAt(0) - this.argumentList.ElementAt(1);
        }
        public double Multiply()
        {
            return this.argumentList.ElementAt(0) * this.argumentList.ElementAt(1);
        }
        public double Divide()
        {
            return this.argumentList.ElementAt(0) /this.argumentList.ElementAt(1);
        }
        public double Mod()
        {
            return this.argumentList.ElementAt(0) % this.argumentList.ElementAt(1);
        }
        public IEnumerable<double> ArgumentList { get =>this.argumentList; set => this.argumentList = value; }
        public char OperationSymbol { get => this.operationSymbol; set => this.operationSymbol = value; }
    }
}