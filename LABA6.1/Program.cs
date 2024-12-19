class Program
{
    static double CalculatePerimeter(double a, double b, double h)
    {
        double c = Math.Sqrt(h * h + Math.Pow(Math.Abs(a - b) / 2, 2)); 
        double perimeter = a + b + 2 * c; 
        return perimeter;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину первого основания первой трапеции (a1):");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите длину второго основания первой трапеции (b1):");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту первой трапеции (h1):");
        double h1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите длину первого основания второй трапеции (a2):");
        double a2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите длину второго основания второй трапеции (b2):");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту второй трапеции (h2):");
        double h2 = Convert.ToDouble(Console.ReadLine());
        double perimeter1 = CalculatePerimeter(a1, b1, h1);
        double perimeter2 = CalculatePerimeter(a2, b2, h2);
        double totalPerimeter = perimeter1 + perimeter2;
        Console.WriteLine($"Периметр первой трапеции: {perimeter1:F2}");
        Console.WriteLine($"Периметр второй трапеции: {perimeter2:F2}");
        Console.WriteLine($"Сумма периметров двух трапеций: {totalPerimeter:F2}");
    }
}
