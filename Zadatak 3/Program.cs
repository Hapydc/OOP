using System;

namespace Zadatak_3
{
    class Program
    {
      
        
            static void Main(string[] args)
            {
                char repeat;
                do
                {
                    Console.Clear();

                    Console.Write("Prvi broj: ");
                    // why do we use double?
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Drugi broj: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.Write("Unesite operaciju (+, -, *, /): ");
                    string op = Console.ReadLine();
                    
                    switch (op)
                    {
                        case "+":
                            Console.WriteLine($"{a} {op} {b} = {a + b}");
                            break;
                        case "-":
                            Console.WriteLine($"{a} {op} {b} = {a - b}");
                            break;
                        case "*":
                            Console.WriteLine($"{a} {op} {b} = {a * b}");
                            break;
                        case "/":
                            Console.WriteLine($"{a} {op} {b} = {a / b}");
                            break;
                        default:
                            Console.WriteLine("Kriva operacija!");
                            break;
                    }

                    Console.WriteLine("Nastavi (y/n)?");
                    repeat = Console.ReadKey().KeyChar;
                } while (repeat == 'y');
            }
        }
    }

