using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2147483646;
            int b = 2;
            int plus = a + b;
            int minus = a - b;
            int mult = a * b;
            int div = a / b;
            Console.WriteLine($"a+b = {plus} a-b = {minus} a*b = {mult} a/b = {div}");
        }
    }
}
