using System.Collections.Generic;

namespace Reciclagem.Models
{
    public class Dicio
    {
        public static Dictionary<int, MaterialLixo> Materiais = new Dictionary<int, MaterialLixo> () {
            { 1, new CacoDeVidro () },
            { 2, new Folha () },
            { 3, new Garrafa () },
            { 4, new GuardaNapo () },
            { 5, new Lata () },
            { 6, new Pilhas () }
        };
    }
}