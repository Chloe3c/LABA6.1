//Даны основание и высота двух равнобедренных трапеций.Найти сумму их периметров.(Определить функцию для расчета периметра равнобедренной трапеции по ее основанию и высоте).
class Program
{
    static void Main()
    {
        double a = 10; 
        double b = 6;
        double h = 4; 

        double perimeter = CalculateTrapezoidPerimeter(a, b, h);
        Console.WriteLine($"Периметр равнобедренной трапеции: {perimeter}");
    }

    static double CalculateTrapezoidPerimeter(double a, double b, double h)
    {
        double d = (a - b) / 2;
        double l = Math.Sqrt(h * h + d * d);
        double perimeter = a + b + 2 * l;

        return perimeter;
    }
}