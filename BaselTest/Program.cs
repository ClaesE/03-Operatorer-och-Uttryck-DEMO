﻿internal class Program
{
    private static void Main(string[] args)
    {
        double total;

        total = Multiply(2, 3, 4);

        Console.WriteLine(total);
        Console.ReadKey();
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Multiply(double a, double b, double c)
    {
        return a * b * c;
    }
}