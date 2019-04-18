namespace Senaizinho
{
    public class Sala
    {
        public int numeroSala;
        public int capacidadeAtual;
        public int capacidadeTotal;
        public string[] alunos;

        public string AlocarAluno(string nomeAluno) {
            capacidadeAtual--;
            if (capacidadeAtual >= 0) {

                alunos[capacidadeAtual] = nomeAluno;
                return $"Aluno {nomeAluno} alocado com sucesso!";
            } else {
                capacidadeAtual = 0;
                return $"Capacidade da sala {numeroSala} excedida!";
            }
        }

        public string ExibirAlunos() {
            string nomesAlunos = "";
            foreach (var item in alunos)
            {
                if(item != null) {
                    nomesAlunos += item + " ";
                }
            }
            return nomesAlunos;
        }
        public string Remover(string aluno)
        {
            capacidadeAtual ++;
            if (capacidadeAtual >= 1)
            {
                alunos[capacidadeAtual] = aluno;
                return $"O aluno {aluno} removido";
            } else
            {
                capacidadeAtual = 0;
                return "não alunos na sala para serem removidos";
            }

        }
    }
}