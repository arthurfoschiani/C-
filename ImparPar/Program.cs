using System;

namespace ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolhaJogar;
            string escolha;
            string erro = "Opção Inválida,\nvocê digitou algo que não foi o mesmo que o pedido.";
            int PCnum;
            int soma;
            int modulo;

            Console.WriteLine("Bem vindo, Você deseja jogar ímpar ou par? (responda com SIM ou NÃO)");
            escolhaJogar = Console.ReadLine().ToLower();

            if(escolhaJogar.Equals("sim"))
            {
                Console.WriteLine("Então você vai ser IMPAR ou PAR? (responda com IMPAR ou PAR)");
                escolha = Console.ReadLine().ToLower();

                if(escolha.Equals("par"))
                {
                    Console.WriteLine("Então vou ser impar.");
                }
                else if(escolha.Equals("impar"))
                {
                    Console.WriteLine("Então vou ser par.");
                }
                else
                {
                    Console.WriteLine(erro);
                }

                
                Console.WriteLine("Escolha um número de 0 a 10.");
                string valor = Console.ReadLine();
                int resultado = 0;
                if(int.TryParse(valor, out resultado))
                {
                    Console.WriteLine(resultado);
                    
                    Random r = new Random();
                    PCnum = r.Next(0,10);

                    Console.WriteLine("Meu número é "+PCnum);

                    soma = resultado + PCnum;

                    Console.WriteLine("A soma dos números é "+soma);
                    
                    modulo = soma % 2;

                    
                if( modulo == 1)
                {
                    Console.WriteLine("O impar ganhou");
                    if ( escolha.Equals("par"))
                    {
                        Console.WriteLine("Então eu ganhei e você perdeu hehe");
                    }
                    else if( escolha.Equals("impar"))
                    {
                        Console.WriteLine("Então você ganhou e eu perdi :(");
                    }
                }
                else if( modulo == 0)
                {
                    Console.WriteLine("O par ganhou");
                    if ( escolha.Equals("par"))
                    {
                        Console.WriteLine("Então você ganhou e eu perdi :(");
                    }
                    else if( escolha.Equals("impar"))
                    {
                        Console.WriteLine("Então eu ganhei e você perdeu hehe");
                    }
                }

                }
                else{
                    Console.WriteLine(erro+" \nDigite um número não uma letra, bobinho.");
                }

                

            }
            else if(escolhaJogar.Equals("não"))
            {
                Console.WriteLine("Ta com medo de perder né?");
            }
            else{
                Console.WriteLine(erro);
            }

        }
    }
}
