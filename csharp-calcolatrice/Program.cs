using System.Data;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-- Calcolatrice (Sum, Subtract, Multiply, AbsoluteValue, Minimum, Maximum) --");
            // Esempi di utilizzo dei metodi della classe CalcoliHelper
            {
                int a = 5, b = 3;
                Console.WriteLine("\nSomma tra 2 numeri interi:");
                Console.WriteLine($"{a} + {b} = {CalcoliHelper.Sum(a, b)}");
            }
            {
                double a = 5.5, b = 3.7;
                Console.WriteLine("\nSomma tra 2 numeri double:");
                Console.WriteLine($"{a} + {b} = {CalcoliHelper.Sum(a, b)}");
            }
            {
                int a = 10, b = 4;
                Console.WriteLine("\nDifferenza tra 2 numeri interi:");
                Console.WriteLine($"{a} - {b} = {CalcoliHelper.Subtract(a, b)}");
            }
            {
                double a = 10.5, b = 4.2;
                Console.WriteLine("\nDifferenza tra 2 numeri double:");
                Console.WriteLine($"{a} - {b} = {CalcoliHelper.Subtract(a, b)}");
            }
            {
                int a = 5, b = 3;
                Console.WriteLine("\nMoltiplicazione tra 2 numeri interi:");
                Console.WriteLine($"{a} * {b} = {CalcoliHelper.Multiply(a, b)}");
            }
            {
                double a = 5.5, b = 3.7;
                Console.WriteLine("\nMoltiplicazione tra 2 numeri double:");
                Console.WriteLine($"{a} * {b} = {CalcoliHelper.Multiply(a, b)}");
            }
            {
                int a = -7;
                Console.WriteLine("\nValore assoluto di un numero intero:");
                Console.WriteLine($"|{a}| = {CalcoliHelper.AbsoluteValue(a)}");
            }
            {
                double a = -7.5;
                Console.WriteLine("\nValore assoluto di un numero double:");
                Console.WriteLine($"|{a}| = {CalcoliHelper.AbsoluteValue(a)}");
            }
            {
                int a = 5, b = 3;
                Console.WriteLine($"\nIl minimo tra due numeri interi ({a} e {b}) è {CalcoliHelper.Minimum(a, b)}");
            }
            {
                double a = 5.5, b = 3.7;
                Console.WriteLine($"\nIl minimo tra due numeri double ({a} e {b}) è {CalcoliHelper.Minimum(a, b)}");
            }
            {
                int a = 5, b = 3;
                Console.WriteLine($"\nIl massimo tra due numeri interi ({a} e {b}) è {CalcoliHelper.Maximum(a, b)}");
            }
            {
                double a = 5.5, b = 3.7;
                Console.WriteLine($"\nIl massimo tra due numeri double ({a} e {b}) è {CalcoliHelper.Maximum(a, b)}");
            }
            Console.WriteLine("\nBonus con vari casistiche:");
            {
                int b = 2, e = 3;
                Console.WriteLine($"{b}^{e} = {CalcoliHelper.Power(b, e)}");
            }
            {
                int b = 3, e = 0;
                Console.WriteLine($"{b}^{e} = {CalcoliHelper.Power(b, e)}");
            }
            {
                int b = 0, e = 0;
                Console.WriteLine($"{b}^{e} = {CalcoliHelper.Power(b, e)}");
            }
            {
                int b = 2, e = -2;
                Console.WriteLine($"{b}^{e} = {CalcoliHelper.Power(b, e)}");
            }
        }
    }
}
