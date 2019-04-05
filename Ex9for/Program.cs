using System;

namespace Ex9for
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            int i;
            int idadeMa;
            int idadeFe;
            int somaIM = 0;
            int somaIF = 0;
            int homens = 0;
            int mulheres = 0;
            float pesoMa;
            float pesoFe;
            float somaPM = 0;
            float somaPF = 0;
            float MediaIMa = 0;
            float MediaIFe = 0;
            float MediaPMa = 0;
            float MediaPFe = 0;

            Console.WriteLine("Bem Vindo!!");
            Console.WriteLine("------------------");


            for(i = 1; i <= 2; i++)
            {
                Console.WriteLine("Digite o sexo da pessoa {0} (F ou M)", i);
                sexo = Console.ReadLine().ToLower();
                if(sexo.Equals("m"))
                {
                    homens++;
                    Console.WriteLine("Digite a idade da pessoa {0}", i);
                    idadeMa = int.Parse(Console.ReadLine());
                    somaIM += idadeMa;
                    MediaIMa = somaIM / homens;

                    Console.WriteLine("Digite o peso da pessoa {0}", i);
                    pesoMa = float.Parse(Console.ReadLine());
                    somaPM += pesoMa;
                    MediaPMa = somaPM / homens;
                    
                }
                else if(sexo.Equals("f"))
                {
                    mulheres++;
                    Console.WriteLine("Digite a idade da pessoa {0}", i);
                    idadeFe = int.Parse(Console.ReadLine());
                    somaIF += idadeFe;
                    MediaIFe = somaIF / mulheres;

                    Console.WriteLine("Digite o peso da pessoa {0}", i);
                    pesoFe = float.Parse(Console.ReadLine());
                    somaPF += pesoFe;
                    MediaPFe = somaPF / mulheres;
                }
                else
                {
                    Console.WriteLine("Opção Inválida\nDigite 'F' para feminino ou 'M' para masculino.");
                    i = 2;
                }
            }
            Console.WriteLine("O total de homens é {0}", homens);
            Console.WriteLine("O total de mulheres é {0}", mulheres);
            Console.WriteLine("A média de idade dos homens é {0}", MediaIMa);
            Console.WriteLine("A média de idade das mulheres é {0}", MediaIFe);
            Console.WriteLine("A média de peso dos homens é {0}", MediaPMa);
            Console.WriteLine("A média de peso das mulheres é {0}", MediaPFe);
        }
    }
}
