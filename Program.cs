using System;
using System.Runtime.InteropServices;

namespace It_s_easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
            Console.ReadKey();
        }
    }
}
