using EscolaDeRock.InterFaces;

namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IMelodia, IHarmonia, IPercussao
    {
        public bool TocarSolo() {
            System.Console.WriteLine("Tocando solo como um(a) {0}", this.GetType().Name);
            return true;
        }

        public bool TocarAcordes() {
            System.Console.WriteLine("Tocando acordes como um(a) {0}", this.GetType().Name);
            return true;
        }

        public bool ManterRitmo() {
            System.Console.WriteLine("Mantendo ritmo como um(a) {0}", this.GetType().Name);
            return true;
        }
    }
}