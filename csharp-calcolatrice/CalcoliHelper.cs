namespace csharp_calcolatrice
{
    internal class CalcoliHelper
    {
        // Metodo per la somma di due numeri interi
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        // Metodo per la somma di due numeri double
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        // Metodo per la differenza tra due numeri interi
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        // Metodo per la differenza tra due numeri double
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        // Metodo per la moltiplicazione di due numeri interi
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        // Metodo per la moltiplicazione di due numeri double
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        // Metodo per il valore assoluto di un numero intero
        public static int AbsoluteValue(int a)
        {
            return Math.Abs(a);
        }
        // Metodo per il valore assoluto di un numero double
        public static double AbsoluteValue(double a)
        {
            return Math.Abs(a);
        }

    }
}
