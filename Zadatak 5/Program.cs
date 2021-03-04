using System;

namespace Zadatak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            While();

            For();
            DoWhile();
        }

        private static void While()
        {
            int i = 0, sum = 0;

            while (i <= 100)
            {

                sum += i++;
            }

            Console.WriteLine($"Zbroj prvog {--i} brojevi: {sum}");
        }
        private static void For()
        {

            int i = 0, sum = 0;
            for (; i <= 100;)
            {
                sum += i++;
            }
            Console.WriteLine($"Zbroj prvih {--i} brojevi: {sum}");
        }
        private static void DoWhile()
        {
            int i = 1, sum = 0;
            do
            {
                sum += i++;
            } while (i <= 100);
            Console.WriteLine($"Zbroj prvih {--i} brojevi: {sum}");
        }
    }
}
