using System;
using static System.Console;

namespace C_Part1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Exercie 01
            WriteLine($"{"Type",-10} {"Byte(s) of memory",-12} {"Min",21} {"Max",36}");
            WriteLine("-------------------------------------------------------------------------------------------");
            WriteLine($"{"sbyte",-10} {sizeof(sbyte),-2} {sbyte.MinValue,36} {sbyte.MaxValue,36}");
            WriteLine($"{"byte",-10} {sizeof(byte),-2} {byte.MinValue,36} {byte.MaxValue,36}");
            WriteLine($"{"short",-10} {sizeof(short),-2} {short.MinValue,36} {short.MaxValue,36}");
            WriteLine($"{"ushort",-10} {sizeof(ushort),-2} {ushort.MinValue,36} {ushort.MaxValue,36}");
            WriteLine($"{"int",-10} {sizeof(int),-2} {int.MinValue,36} {int.MaxValue,36}");
            WriteLine($"{"uint",-10} {sizeof(uint),-2} {uint.MinValue,36} {uint.MaxValue,36}");
            WriteLine($"{"long",-10} {sizeof(long),-2} {long.MinValue,36} {long.MaxValue,36}");
            WriteLine($"{"ulong",-10} {sizeof(ulong),-2} {ulong.MinValue,36} {ulong.MaxValue,36}");
            WriteLine($"{"float",-10} {sizeof(float),-2} {float.MinValue,36} {float.MaxValue,36}");
            WriteLine($"{"double",-10} {sizeof(double),-2} {double.MinValue,36} {double.MaxValue,36}");
            WriteLine($"{"decimal",-10} {sizeof(decimal),-2} {decimal.MinValue,36} {decimal.MaxValue,36}");
            WriteLine("-------------------------------------------------------------------------------------------");
            ReadLine();

            // Exercie 02
            int max = 500;
            byte i;

            if (byte.MaxValue >= 500)
            {
                for (i = 0; i < max; i++)
                {
                    WriteLine(i);
                }
            }
            else
            {
                WriteLine($"The byte i maximum is : {byte.MaxValue}, will be always < {max}, the loop will be never end...!!!");
            }
            ReadLine();

            // Exercie 03
            calculateFactorielle();
            ReadLine();
        }

        private static void calculateFactorielle()
        {
            int n;
            int result = 1;

            for (n = 0; n < 10; n++)
            {
                WriteLine($"{n}! = {result}");
                result = result * (n+1);
            }
        }
    }
}
