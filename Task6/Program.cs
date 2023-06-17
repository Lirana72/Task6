using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputD = "Введите  число";
            Console.WriteLine(InputD);
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine(a % 2 == 0 ? "Четное" : "Не четное");

            Console.WriteLine("");
        }
    }
}
