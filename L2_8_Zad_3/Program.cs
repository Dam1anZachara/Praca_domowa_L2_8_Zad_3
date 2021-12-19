using System;

namespace L2_8_Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = 10000;
            int fibSeqOne = 0;
            int fibSeqTwo = 1;

            Console.WriteLine("Ciąg Fibonacciego:");

            for (int i = 0; fibSeqTwo < endNumber; i++)
            {
                fibSeqTwo = fibSeqOne + fibSeqTwo;
                fibSeqOne = fibSeqTwo - fibSeqOne;
                Console.WriteLine(fibSeqOne);
            }
        }
    }
}
