using Reciclagem.InterFaces;

namespace Reciclagem.Models
{
    public class Pilhas : MaterialLixo, IIndefinido
    {
        public bool LixoCinza () {
            System.Console.WriteLine($"Jogue o(a) {this.GetType().Name} na cor CINZA");
            return true;
        }
    }
}