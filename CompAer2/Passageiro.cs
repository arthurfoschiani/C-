using System;

namespace CompAer2
{
    class Passageiro
    {
        string nome;
        int numPassagem;
        DateTime data;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNumPassagem(int numPassagem)
        {
            this.numPassagem = numPassagem;
        }
        public int getNumPassagem()
        {
            return this.numPassagem;
        }
        public void setData(DateTime data)
        {
            this.data = data;
        }
        public DateTime getData()
        {
            return this.data;
        }
    }
}
