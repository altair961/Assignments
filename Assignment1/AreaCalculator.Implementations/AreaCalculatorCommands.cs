using AreaCalculator.Interfaces;

namespace AreaCalculator.Implementations
{
    public class AreaCalculatorCommands : IAreaCalculatorCommands
    {
        public const double PI = 3.14159265358979;

        public double CalculateArea(double radius)
        {
            return PI * radius;
        }
    }
}