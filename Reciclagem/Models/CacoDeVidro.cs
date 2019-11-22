using Reciclagem.InterFaces;

namespace Reciclagem.Models
{
    public class CacoDeVidro : MaterialLixo, IVidro
    {
        public bool LixoVerde() {
            System.Console.WriteLine($"Joque o(a) {this.GetType().Name} na cor VERDE");
            return true;
        }
    }
}