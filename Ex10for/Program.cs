using System;

namespace Ex10for
{
    class Program
    {
        static void Main(string[] args)
        {
            int piramides = 10;
            int num = 10;
            int i;
            int j;
            string a = "";

            for (i = 1; i <= piramides; i++)
            {
                a = "";
                for (j = 1; j <= num; j++)
                {
                    a += "*";
                    Console.WriteLine(a);
                }
            }
        }
    }
}
