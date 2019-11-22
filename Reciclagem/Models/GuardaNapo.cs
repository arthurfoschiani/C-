using Reciclagem.InterFaces;

namespace Reciclagem.Models
{
    public class GuardaNapo : MaterialLixo, IOrganico
    {
        public bool LixoPreto () {
            System.Console.WriteLine($"Jogue o(a) {this.GetType().Name} na cor PRETA");
            return true;
        }
    }
}