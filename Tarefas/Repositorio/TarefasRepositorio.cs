using System;
using System.Collections.Generic;
using System.IO;
using Tarefas.ViewModel;

namespace Tarefas.Repositorio
{
    public class TarefasRepositorio
    {
        List<TarefasViewModel> listaDeTarefas = new List<TarefasViewModel>();

        public TarefasViewModel Inserir (TarefasViewModel tarefas) {
            int contador = 0;
            List<TarefasViewModel> listaDeTarefas = ListarTarefas();
            if (listaDeTarefas != null) {
                contador = listaDeTarefas.Count;
            }
            tarefas.Id = contador + 1;
            tarefas.DataCriacao = DateTime.Now;
            StreamWriter SW = new StreamWriter ("tarefas.csv", true);
            SW.WriteLine($"{tarefas.Id};{tarefas.IdUsuario};{tarefas.Nome};{tarefas.Descricao};{tarefas.Tipo};{tarefas.DataCriacao}");
            SW.Close();
            return tarefas;
        }

        public List<TarefasViewModel> ListarTarefas() {
            List<TarefasViewModel> listaDeTarefas = new List<TarefasViewModel>();
            TarefasViewModel tarefasViewModel;
            if (!File.Exists("tarefas.csv")) {
                return null;
            }
            string[] tarefas = File.ReadAllLines("tarefas.csv");
            foreach (var item in tarefas)
            {
                if (item != null) {
                    string[] dadosDeCadaTarefa = item.Split(";");
                    tarefasViewModel = new TarefasViewModel();
                    tarefasViewModel.Id = int.Parse(dadosDeCadaTarefa[0]);
                    tarefasViewModel.IdUsuario = int.Parse(dadosDeCadaTarefa[1]);
                    tarefasViewModel.Nome = dadosDeCadaTarefa[2];
                    tarefasViewModel.Descricao = dadosDeCadaTarefa[3];
                    tarefasViewModel.Tipo = dadosDeCadaTarefa[4];
                    tarefasViewModel.DataCriacao = DateTime.Parse(dadosDeCadaTarefa[5]);
                    listaDeTarefas.Add(tarefasViewModel);
                }
            }
            return listaDeTarefas;
        }
    }
}