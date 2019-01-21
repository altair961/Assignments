using AreaCalculator.Interfaces;
using System;
using System.Linq;

namespace AreaCalculator.Implementations
{
    public class AreaCalculatorCommands : IAreaCalculatorCommands
    {
        public const double PI = 3.14159265358979;

        public double CalculateArea(double radius)
        {
            return PI * radius;
        }

        public double CalculateArea(double a, double b, double c)
        {
            var isTriangleRightAngled = IsTriangleRightAngled(a, b, c);

            if (isTriangleRightAngled)
            {
                double[] sides = new double[] { a, b, c };
                var hypotenuse = sides.Max();
                var cathetuses = sides.Where(x => x != hypotenuse).ToArray();

                return 0.5 * cathetuses[0] * cathetuses[1];
            }

            else
            {
                var perimeter = a + b + c;
                var halfPerimeter = perimeter * 0.5;

                return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            }
        }

        public bool IsTriangleRightAngled(double a, double b, double c)
        {
            var largestNumber = Math.Max(Math.Max(a, b), c);

            double[] sides = new double[] { a, b, c };
            var hypotenuse = sides.Max();

            var cathetuses = sides.Where(x => x != hypotenuse).ToArray();

            var doesPythagoreanTheoremApply = (hypotenuse * hypotenuse) == (cathetuses[0] * cathetuses[0]) + (cathetuses[1] * cathetuses[1]);

            if (doesPythagoreanTheoremApply)
            {
                return true;
            }
            else return false;
        }
    }
}