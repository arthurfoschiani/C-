using System;
using System.Collections.Generic;
using Reciclagem.InterFaces;
using Reciclagem.Models;

namespace Reciclagem
{
    enum MateriaisEnum : uint {
        CACO_DE_VIDRO,
        FOLHA_SULFITE,
        GARRAFA_PET,
        GUARDANAPO,
        LATA_DE_REFRIGERANTE,
        PILHAS
    }
    class Program
    {
        static void Main(string[] args)
        {
            var opcoesFormacao = new List<string> () {
                "    - 0                       ",
                "    - 1                       ",
                "    - 2                         ",
                "    - 3                          ",
                "    - 4                ",
                "    - 5                              ",
            };

            bool querSair = false;
            string barraMenu = "==========================================";
            string[] itensMenuFormacao = Enum.GetNames (typeof (MateriaisEnum));
            int opcaoFormacaoSelecionada = 0;

            do {
                bool formacaoEscolhida = false;

                do {
                    Console.Clear ();
                    System.Console.WriteLine (barraMenu);
                    System.Console.WriteLine ("                RECICLAGEM                ");
                    System.Console.WriteLine ("  Escolha o meterial que será reciclado:  ");
                    System.Console.WriteLine (barraMenu);

                    for (int i = 0; i < opcoesFormacao.Count; i++) {
                        string titulo = TratarTituloMenu (itensMenuFormacao[i]);
                        if (opcaoFormacaoSelecionada == i) {
                            DestacarOpcao (opcoesFormacao[i].Replace ("-", ">").Replace("_", " ").Replace (i.ToString (), titulo));
                        } else {
                            System.Console.WriteLine (opcoesFormacao[i].Replace (i.ToString (), titulo));
                        }
                    }

                    var tecla = Console.ReadKey (true).Key;

                    switch (tecla) { 
                        case ConsoleKey.UpArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;

                            break;
                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;
                    }

                } while (!formacaoEscolhida);

                switch (opcaoFormacaoSelecionada)
                {
                    case 0:
                        var lixo = Dicio.Materiais[opcaoFormacaoSelecionada + 1];
                        Mostrar((IVidro) lixo);
                        Console.ReadLine();
                    break;
                    case 1:
                        lixo = Dicio.Materiais[opcaoFormacaoSelecionada + 1];
                        Mostrar((IPapel) lixo);
                        Console.ReadLine();
                    break;
                    case 2:
                        lixo = Dicio.Materiais[opcaoFormacaoSelecionada + 1];
                        Mostrar((IPlastico) lixo);
                        Console.ReadLine();
                    break;
                    case 3:
                        lixo = Dicio.Materiais[opcaoFormacaoSelecionada + 1];
                        Mostrar((IOrganico) lixo);
                        Console.ReadLine();
                    break;
                    case 4:
                        lixo = Dicio.Materiais[opcaoFormacaoSelecionada + 1];
                        Mostrar((IMetal) lixo);
                        Console.ReadLine();
                    break;
                    case 5:
                        lixo = Dicio.Materiais[opcaoFormacaoSelecionada + 1];
                        Mostrar((IIndefinido) lixo);
                        Console.ReadLine();
                    break;
                }

            } while (!querSair);

        }
        public static string TratarTituloMenu (string titulo) {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());
        }

        public static void DestacarOpcao (string opcao) {
            Console.BackgroundColor = ConsoleColor.White;
            System.Console.WriteLine (opcao);
            Console.ResetColor ();
        }

        public static void Mostrar (IIndefinido materiais) {
            Console.ForegroundColor = ConsoleColor.Gray;
            materiais.LixoCinza();
            Console.ResetColor ();
        }

        public static void Mostrar (IMetal materiais) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            materiais.LixoAmarelo();
            Console.ResetColor ();
        }

        public static void Mostrar (IOrganico materiais) {
            Console.ForegroundColor = ConsoleColor.White;
            materiais.LixoPreto();
            Console.ResetColor ();
        }

        public static void Mostrar (IPapel materiais) {
            Console.ForegroundColor = ConsoleColor.Blue;
            materiais.LixoAzul();
            Console.ResetColor ();
        }

        public static void Mostrar (IPlastico materiais) {
            Console.ForegroundColor = ConsoleColor.Red;
            materiais.LixoVermelho();
            Console.ResetColor ();
        }

        public static void Mostrar (IVidro materiais) {
            Console.ForegroundColor = ConsoleColor.Green;
            materiais.LixoVerde();
            Console.ResetColor ();
        }
    }
}
