namespace AreaCalculator.Interfaces
{
    public interface IAreaCalculatorCommands
    {
        double CalculateArea(double radius);
        double CalculateArea(double a, double b, double c);
        bool IsTriangleRightAngled(double a, double b, double c);
    }
}