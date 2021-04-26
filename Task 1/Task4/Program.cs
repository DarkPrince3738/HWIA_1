using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayF = 11;
            int monthF = 12;
            int yearF = 1990; 
            int dayM = 03;
            int monthM = 07;
            int yearM = 1991; 
            int dayS = 08;
            int monthS = 08;
            int yearS = 2002; 
            int dayMY = 22;
            int monthMY = 02;
            int yearMY = 2016;
            Console.WriteLine($"Father's Birth Date {dayF}.{monthF}.{yearF}");
            Console.WriteLine($"Mother's Birth Date {dayM}.{monthM}.{yearM}");
            Console.WriteLine($"Sister's Birth Date {dayS}.{monthS}.{yearS}");
            Console.WriteLine($"My Birth Date {dayMY}.{monthMY}.{yearMY}");
        }
    }
}
