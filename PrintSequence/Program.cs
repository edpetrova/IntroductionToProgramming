using System;


namespace PrintSequence
{
    class Program
    {
        static void Main()
        {
            int a = 2;
            int b = -3;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);

                a = a + 2;
                b = b - 2;
            }
        }

    }
}