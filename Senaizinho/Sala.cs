namespace Senaizinho
{
    public class Sala
    {
        public int numSala;
        public int capacidadeAtual;
        public int capacidadeTotal;
        public string[] alunos;
        public void Alocar(string aluno)
        {
            capacidadeAtual--;
        }
        public void Remover(string aluno)
        {
            capacidadeAtual++;
        }
    }
}