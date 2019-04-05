using System;

namespace Ex4Balada
{
    class Program
    {
        static void Main(string[] args)
        {
            string disponibilidade;
            int idade;
            string matine;
            string vip;
            string erro = "Valor invalido\nUse como resposta sim ou não.";

            Console.WriteLine("Você está disponível a noite do dia 01 de abril?");
            disponibilidade = Console.ReadLine().ToLower();
            if(disponibilidade.Equals("sim"))
            {
                Console.WriteLine("Quantos anos você tem?");
                idade = int.Parse(Console.ReadLine().ToLower());
                if(idade < 18)
                {
                    Console.WriteLine("Você não pode entrar por conta de ser menor de idade, gostaria de ir para a matinê?");
                    matine = Console.ReadLine().ToLower();
                    if(matine.Equals("sim"))
                    {
                        Console.WriteLine("Você tem VIP/pagou?");
                        vip = Console.ReadLine().ToLower();
                        if(vip.Equals("sim"))
                        {
                            Console.WriteLine("Pode entrar - SEXTOUUUUUUUUU");
                        }
                        else if(vip.Equals("não"))
                        {
                            Console.WriteLine("Me desculpe, mas você não pode entrar porque não pagou.");
                        }
                         else
                        {
                            Console.WriteLine(erro);
                        }
                    }
                    else if(matine.Equals("não"))
                    {
                        Console.WriteLine("Então me desculpe, obrigado por vir!");
                    }
                     else
                    {
                        Console.WriteLine(erro);
                    }
                }
                else
                {
                    Console.WriteLine("Você tem VIP/pagou?");
                    vip = Console.ReadLine().ToLower();
                    if(vip.Equals("sim"))
                    {
                        Console.WriteLine("Pode entrar - SEXTOOOOOOOOUU");
                    }
                    else if(vip.Equals("não"))
                    {
                        Console.WriteLine("Me desculpe, mas você não pode entrar porque não pagou.");
                    }
                     else
                    {
                        Console.WriteLine(erro);
                    }
                }
            }
            else if(disponibilidade.Equals("não"))
            {
                Console.WriteLine("Tudo bem, deixa para a próxima!");
            }
            else
            {
                Console.WriteLine(erro);
            }
        }
    }
}
