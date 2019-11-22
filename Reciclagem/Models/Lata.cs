using Reciclagem.InterFaces;

namespace Reciclagem.Models
{
    public class Lata : MaterialLixo, IMetal
    {
        public bool LixoAmarelo () {
            System.Console.WriteLine($"Jogue o(a) {this.GetType().Name} na cor AMARELA");
            return true;
        }
    }
}