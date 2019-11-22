using Reciclagem.InterFaces;

namespace Reciclagem.Models
{
    public class Garrafa : MaterialLixo, IPlastico
    {
        public bool LixoVermelho () {
            System.Console.WriteLine($"Jogue o(a) {this.GetType().Name} na cor VERMELHA");
            return true;
        }
    }
}