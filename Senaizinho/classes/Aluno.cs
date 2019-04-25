using System;
namespace Senaizinho_2_Manha
{
    public class Aluno
    {
        public string Nome {get; set;}
        public DateTime dataNascimento {get; set;}
        public string curso {get; set;}
        public int numeroSala {get; set;}
        // Construtor Padrão
        // public Aluno ()
        public Aluno (string nome) {
            this.Nome = nome;
        }
        // public Aluno (string nome, DateTime dataNascimento) {

        // }
    }
}