using System;

namespace Naming.Task3
{
    public class Harshad
    {
        private const int Limit = 1000;
        
        private static void Main(string[] args)
        {
            PrintHarshadNumbers();
        }

        private static void PrintHarshadNumbers()
        {
            for (var i = 1; i <= Limit; i++)
            {
                if (i % Loop(i) == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Write("Press key...");
            Console.ReadKey();
        }

        private static int Loop(int number)
        {
            var sum = 0;
            
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
