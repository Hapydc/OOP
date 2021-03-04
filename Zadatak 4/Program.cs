using System;

namespace Zadatak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite godinu: ");
            int year = int.Parse(Console.ReadLine());


            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Godina je prijestupna");
            }
            else
            {
                Console.WriteLine("Godina nije prijestupna");
            }
        }
    }
}
