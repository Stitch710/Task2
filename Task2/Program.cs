using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол-во линий");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                for (string i = "*"; i.Length <= n; i += "*")
                    Console.WriteLine(i);
            else
                Console.WriteLine("введите коректное значение");
        }
    }
}
