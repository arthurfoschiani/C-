using Reciclagem.InterFaces;

namespace Reciclagem.Models
{
    public class Folha : MaterialLixo, IPapel
    {
        public bool LixoAzul () {
            System.Console.WriteLine($"Jogue o(a) {this.GetType().Name} na cor AZUL");
            return true;
        }
    }
}