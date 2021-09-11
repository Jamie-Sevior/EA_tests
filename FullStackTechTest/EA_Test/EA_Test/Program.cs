using System;

namespace EA_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int length = 10;

            int[] output = new int[length];

            for (int counter = 0; counter < length; counter++)
            {
                output[counter] = (counter + 1);
                Console.WriteLine(output[counter]);
            }               

        }
    }
}
