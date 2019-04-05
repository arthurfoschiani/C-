using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            int num;
            string resposta;
            bool replay = true;
            
            while (replay == true)
            {
                Console.WriteLine("Qual tabuada você deseja saber?");
                num = int.Parse(Console.ReadLine().ToLower());
                
                int cont = 1;
                
                while (cont <= 10 && cont >= 1)
                {
                    tabuada = num * cont;
                    Console.WriteLine("{0} X {1} = {2}", num, cont, tabuada);
                    cont++;
                }

                Console.WriteLine("Você deseja calcular outra tabuada?");
                resposta = Console.ReadLine().ToLower();
                replay = resposta.Equals("sim") ? true : false;
            }
        }
    }
}
