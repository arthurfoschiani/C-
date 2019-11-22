using System;
using System.Collections.Generic;
using System.IO;
using APLICATIVO_FINANCEIRO.ViewModel;

namespace APLICATIVO_FINANCEIRO.Repositório
{
    public class UsuarioRepositorio
    {
        List<UsuarioViewModel> listaDeUsuario = new List<UsuarioViewModel> ();

        public static UsuarioViewModel Colocar (UsuarioViewModel usuario) {
            int contador = 0;

            List<UsuarioViewModel> listaDeUsuario = Listar();
            if (listaDeUsuario != null) {
                contador = listaDeUsuario.Count;
            }
            usuario.Id = contador + 1;
            StreamWriter sw = new StreamWriter ("ArquivosCSV/usuarios.csv", true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataDeNascimento:dd/MM/yyyy}");
            sw.Close();

            return usuario;
        }

        public static List<UsuarioViewModel> Listar() {
            List<UsuarioViewModel> listaDeUsuario = new List<UsuarioViewModel>();
            UsuarioViewModel usuarioViewModel;
            if (!File.Exists("ArquivosCSV/usuarios.csv")) {
                return null;
            }
            string[] usuarios = File.ReadAllLines("ArquivosCSV/usuarios.csv");
            foreach (var item in usuarios)
            {
                if (item != null) {
                    string[] dadosDeCadaUsuario = item.Split(";");
                    usuarioViewModel = new UsuarioViewModel();
                    usuarioViewModel.Id = int.Parse(dadosDeCadaUsuario[0]);
                    usuarioViewModel.Nome = dadosDeCadaUsuario[1];
                    usuarioViewModel.Email = dadosDeCadaUsuario[2];
                    usuarioViewModel.Senha = dadosDeCadaUsuario[3];
                    usuarioViewModel.DataDeNascimento = DateTime.Parse(dadosDeCadaUsuario[4]);
                    listaDeUsuario.Add(usuarioViewModel);
                }
            }
            return listaDeUsuario;
        }

        internal static UsuarioViewModel BuscarUsuario (string email, string senha) {
            List<UsuarioViewModel> listaDeUsuario = Listar();

            foreach (var item in listaDeUsuario) {
                if(item != null){
                if (item.Email.Equals(email) && item.Senha.Equals(senha)) {
                    return item;
                }
                }
            }
            return null;
        }
    }
}