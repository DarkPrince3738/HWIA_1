using System;

namespace Word2_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415926535897931;
            int r = 5;
            int h = 2;
            double V = PI * r * r * h;
            double S = 2 * PI * r * r + 2 * PI * r * r;
            Console.WriteLine($"S = {S}, V = {V}");
        }
    }
}
