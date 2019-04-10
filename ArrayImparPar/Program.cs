using System;

namespace ArrayImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 7, 3, 9, 4, 5, 6 };
            int impar = 0;

            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] % 2 == 1)
                {
                    impar++;
                }
            }
            Console.WriteLine(impar);
        }
    }
}
