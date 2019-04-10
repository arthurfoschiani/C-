using System;

namespace Atividade5 {
    class Program {
        static void Main (string[] args) {
            int[] valores = new int[3];

            for (int i = 0; i < valores.Length; i++) {
                System.Console.WriteLine ($"Digite o {i + 1}º valor:");
                valores[i] = int.Parse (Console.ReadLine ());
            }
            Array.Sort (valores);
            System.Console.WriteLine ("Os numeros em ordem são:");
            for (int j = 0; j < valores.Length; j++) {
                System.Console.WriteLine ($"{valores[j]}");
            }
        }
    }
}