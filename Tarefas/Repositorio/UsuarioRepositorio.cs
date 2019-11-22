using System;
using System.Collections.Generic;
using System.IO;
using Tarefas.ViewModel;

namespace Tarefas.Repositorio
{
    public class UsuarioRepositorio
    {
        List<UsuarioViewModel> listaDeUsuario = new List<UsuarioViewModel> ();

        public UsuarioViewModel Colocar (UsuarioViewModel usuario) {
            int contador = 0;
            List<UsuarioViewModel> listaDeUsuario = Listar();
            if (listaDeUsuario != null) {
                contador = listaDeUsuario.Count;
            }
            usuario.Id = contador + 1;
            usuario.DataCriacao = DateTime.Now;
            StreamWriter sw = new StreamWriter ("usuarios.csv", true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Tipo};{usuario.DataCriacao};{usuario.Senha}");
            sw.Close();

            return usuario;
        }

        public List<UsuarioViewModel> Listar() {
            List<UsuarioViewModel> listaDeUsuario = new List<UsuarioViewModel>();
            UsuarioViewModel usuarioViewModel;
            if (!File.Exists("usuarios.csv")) {
                return null;
            }
            string[] usuarios = File.ReadAllLines("usuarios.csv");
            foreach (var item in usuarios)
            {
                if (item != null) {
                    string[] dadosDeCadaUsuario = item.Split(";");
                    usuarioViewModel = new UsuarioViewModel();
                    usuarioViewModel.Id = int.Parse(dadosDeCadaUsuario[0]);
                    usuarioViewModel.Nome = dadosDeCadaUsuario[1];
                    usuarioViewModel.Email = dadosDeCadaUsuario[2];
                    usuarioViewModel.Tipo = dadosDeCadaUsuario[3];
                    usuarioViewModel.DataCriacao = DateTime.Parse(dadosDeCadaUsuario[4]);
                    usuarioViewModel.Senha = dadosDeCadaUsuario[5];
                    listaDeUsuario.Add(usuarioViewModel);
                }
            }
            return listaDeUsuario;
        }

        internal UsuarioViewModel BuscarUsuario (string email, string senha) {
            List<UsuarioViewModel> listaDeUsuario = Listar();

            foreach (var item in listaDeUsuario) {
                if (item.Email.Equals(email) && item.Senha.Equals(senha)) {
                    return item;
                }
            }
            return null;
        }
    }
}