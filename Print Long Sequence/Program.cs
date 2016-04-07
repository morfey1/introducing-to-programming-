using System;

namespace Print_Long_Sequence
{
    class Program
    {
        static void Main()
        {
            for (int i = 2; i < 1000; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i * (-1));
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
 
