using System;


namespace CurrentDateAndTime
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString().ToString());
            Console.WriteLine(DateTime.Now.ToShortTimeString().ToString());
        }
    }
}
