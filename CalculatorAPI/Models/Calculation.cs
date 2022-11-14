using System.ComponentModel.DataAnnotations;

namespace CalculatorAPI.Model
{
    public class Calculation
    {
    
        [Required]
        public IEnumerable<double> ArgumentList { get; set; }

        public Calculation(IEnumerable<double> argumentList)
        {
            ArgumentList = argumentList;
        }

        [Required]
        public char operationSymbol { get; set; }

    }
}
