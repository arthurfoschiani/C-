using System;

namespace Ex7for
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num = 0;

            for (i = 1; i <= 100; i ++)
            {
                num += 1;
                if ((num % 4) == 0)
                {
                    Console.WriteLine("pi");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}