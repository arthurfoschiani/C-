using System;

namespace Ex3Clima
{
    class Program
    {
        static void Main(string[] args)
        {
            string clima;
            string resposta;

            Console.WriteLine("A previsão do tempo está...");
            clima = Console.ReadLine().ToLower();

            if(clima.Equals("frio"))
            {
                Console.WriteLine("Vamos a montanha.");
            }
            else if(clima.Equals("calor"))
            {
                Console.WriteLine("Vamos a praia.");
            }
            else if(clima.Equals("chuva"))
            {
                Console.WriteLine("Vamos para a Steam?");
                resposta = Console.ReadLine();

                if(resposta.Equals("não"))
                {
                    Console.WriteLine("Vamos para a Netflix");
                }
            }
            else
            {
                Console.WriteLine("Valor invalido \nDigite: Chuva, Frio ou Calor.");
            }
        }
    }
}
