using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Service
{
    public interface ICalculator
    {

        IEnumerable<double>ArgumentList { get; set; }
        char OperationSymbol { get; set; }
        double Calculate();
    }
}
