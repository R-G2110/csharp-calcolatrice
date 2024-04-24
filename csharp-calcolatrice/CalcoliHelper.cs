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
        //public static int AbsoluteValue(int a)
        //{
        //    return Math.Abs(a);
        //}
        public static int AbsoluteValue(int a)
        {
            if (a < 0) return -a;
            return a;
        }
        // Metodo per il valore assoluto di un numero double
        //public static double AbsoluteValue(double a)
        //{
        //    return Math.Abs(a);
        //}
        public static double AbsoluteValue(double a)
        {
            if (a < 0) return -a;
            return a;
        }
        // Metodo per trovare il minimo tra due numeri interi
        //public static int Minimum(int a, int b)
        //{
        //    return Math.Min(a, b);
        //}
        public static int Minimum(int a, int b)
        {
            return (a < b) ? a : b;
        }
        // Metodo per trovare il minimo tra due numeri double
        //public static double Minimum(double a, double b)
        //{
        //    return Math.Min(a, b);
        //}
        public static double Minimum(double a, double b)
        {
            return (a < b) ? a : b;
        }
        // Metodo per trovare il massimo tra due numeri interi
        //public static int Maximum(int a, int b)
        //{
        //    return Math.Max(a, b);
        //}
        public static int Maximum(int a, int b)
        {
            return (a > b) ? a : b;
        }
        // Metodo per trovare il massimo tra due numeri double
        //public static double Maximum(double a, double b)
        //{
        //    return Math.Max(a, b);
        //}
        public static double Maximum(double a, double b)
        {
            return (a > b) ? a : b;
        }
        // Metodo per l'elevamento a potenza di due numeri interi
        //public static double Power(int baseNumero, int esponente)
        //{
        //    // Gestione del caso speciale in cui la base e l'esponente sono pari a zero
        //    if (baseNumero == 0 && esponente == 0)
        //    {
        //        // Ritorna 1, seguendo l'approccio informatico
        //        return 1;
        //    }
        //    else if (esponente == 0)
        //    {
        //        // Qualsiasi numero elevato a 0 è pari a 1
        //        return 1;
        //    }
        //    else if (esponente < 0)
        //    {
        //        // Gestione dell'elevamento a potenza con esponente negativo
        //        return 1.0 / Math.Pow(baseNumero, Math.Abs(esponente));
        //    }
        //    else
        //    {
        //        // Operazione default
        //        return Math.Pow(baseNumero, esponente);
        //    }
        //}
        public static double Power(int baseNumero, int esponente)
        {
            if (baseNumero == 0 && esponente == 0) return 1;  
            if (esponente == 0) return 1;
            if (esponente < 0) return 1.0 / Power(baseNumero, -esponente);  

            double result = 1;
            for (int i = 0; i < esponente; i++)
            {
                result *= baseNumero;
            }
            return result;
        }
    }
}
