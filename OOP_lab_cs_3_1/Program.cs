using System;

class Program
{
    static void Main()
    {
        double x; // вхідний параметр
        double y; // результат обчислення виразу
        double A; // проміжний результат - функціонально стала частина виразу
        double B; // проміжний результат - функціонально змінна частина виразу

        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());

        A = (2 + x) / Math.Pow(x, 2) + 1;

        // спосіб 1: розгалуження в скороченій формі
        if (x < 0)
        {
            B = Math.Pow(x, 3) - 2 * Math.Pow(x, 4);
        }
        else if (0 <= x && x <= 2)
        {
            B = Math.Pow(Math.Abs(x) + Math.Exp(x), 3);
        }
        else
        {
            B = 4 * Math.Cos(Math.Pow(x, 2) - 2);
        }

        y = A + B;

        Console.WriteLine();
        Console.WriteLine($"1) y = {y}");

        // спосіб 2: розгалуження в повній формі
        if (x < 0)
        {
            B = Math.Pow(x, 3) - 2 * Math.Pow(x, 4);
        }
        else if (x > 2)
        {
            B = 4 * Math.Cos(Math.Pow(x, 2) - 2);
        }
        else
        {
            B = Math.Pow(Math.Abs(x) + Math.Exp(x), 3);
        }

        y = A + B;

        Console.WriteLine($"2) y = {y}");

        Console.ReadLine();
    }
}