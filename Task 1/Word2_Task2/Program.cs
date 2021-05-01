using System;

namespace Word2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;
            x += y - x++ * z; 
            z = --x - y * 5; 
            y /= x + 5 % z; 
            z = x++ + y * 5; 
            x = y - x++ * z;
            Console.WriteLine($"X = {x}, Y = {y}, Z = {z}");

        }
    }
}
