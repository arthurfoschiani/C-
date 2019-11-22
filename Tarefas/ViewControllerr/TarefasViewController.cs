using System;
using System.Collections.Generic;
using Tarefas.Repositorio;
using Tarefas.Utils;
using Tarefas.ViewModel;

namespace Tarefas.ViewControllerr
{
    public class TarefasViewController
    {
        static TarefasRepositorio tarefasRepositorio = new TarefasRepositorio ();

        public static void cadastrarTarefas (UsuarioViewModel usuario) {
            string descricao, nome, tipoString = "";
            int tipo;

            do {
                System.Console.WriteLine ("Digite o Nome da Tarefa:");
                nome = Console.ReadLine ();
                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome Inválido");
                }
            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.WriteLine ("Insira e descrição da tarefa:");
                descricao = Console.ReadLine ();
                if (string.IsNullOrEmpty (descricao)) {
                    System.Console.WriteLine ("Descrição Inválido");
                }
            } while (string.IsNullOrEmpty (descricao));

            do {
                MenusUtil.menuStatus ();
                tipo = int.Parse(Console.ReadLine());
            } while (tipo != 1 && tipo != 2 && tipo != 3);
            if (tipo == 1) {
                tipoString = "Para Fazer";
            }
            else if (tipo == 2) {
                tipoString = "Fazendo";
            }
            else if (tipo == 3) {
                tipoString = "Feito";
            }

            TarefasViewModel tarefasViewModel = new TarefasViewModel();
            tarefasViewModel.IdUsuario = usuario.Id;
            tarefasViewModel.Nome = nome;
            tarefasViewModel.Descricao = descricao;
            tarefasViewModel.Tipo = tipoString;

            tarefasRepositorio.Inserir (tarefasViewModel);

            System.Console.WriteLine("Cadastro realizado com sucesso!");
        }

        public static void ListarTarefas (UsuarioViewModel usuario) {
            List<TarefasViewModel> listaDeTarefas = tarefasRepositorio.ListarTarefas();
            foreach (var item in listaDeTarefas) {
                if (item != null) {
                    if (item.IdUsuario.Equals(usuario.Id)) {
                        System.Console.WriteLine($"Id da Tarefa: {item.Id} - Id do Usuário: {item.IdUsuario} - Nome: {item.Nome} - Descrição: {item.Descricao} - Status: {item.Tipo} - Data da Criação: {item.DataCriacao}");
                    }
                }
            }
        }
    }
}