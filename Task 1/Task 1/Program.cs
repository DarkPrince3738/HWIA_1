using System;

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte SByteValue = 127;
            byte ByteValue = 255;
            short ShortValue = (sbyte)SByteValue;
            ushort UShortValue = (byte)ByteValue;
            int IntValue = (short)ShortValue;
            uint  UIntValue = (ushort)UShortValue;
            long LongValue = (int)IntValue;
            uint ULongValue = (uint)UIntValue;
            decimal DecimalValue = 105m;
            float FloatValue = 3051f;
            double DoubleValue = (float)FloatValue;
            Console.WriteLine($"LongValue = {LongValue} ULongValue = {ULongValue}");
            Console.WriteLine($"DecimalValue = {DecimalValue}");
            Console.WriteLine($"DoubleValue = {DoubleValue}");
        }
    }
}
