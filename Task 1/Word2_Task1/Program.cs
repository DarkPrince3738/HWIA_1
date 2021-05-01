using System;

namespace Word2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstn = 64;
            int secondn = 2;
            int plus = firstn + secondn;
            int minus = firstn - secondn;
            int mul = firstn * secondn;
            int div = firstn / secondn;
            Console.WriteLine($"Plus = {plus}, Minus = {minus}, Mul = {mul}, Div = {div}");
        }
    }
}
