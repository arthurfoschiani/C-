using System;
using System.Collections.Generic;
using System.IO;
using PIZZARIA.ViewModel;

namespace PIZZARIA.Repositorio
{
    public class UsuarioRepositorio
    {
        // List<UsuarioViewModel> listaDeUsuario = new List<UsuarioViewModel>();
        /// <summary>Método responsável por armazenar um usuário</summary>
        public UsuarioViewModel Inserir (UsuarioViewModel usuario) {
            int contador = 0;
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            if (listaDeUsuarios != null) {
                contador = listaDeUsuarios.Count;
            }
            usuario.Id = contador + 1;
            usuario.DataCriacao = DateTime.Now;
            //insere o objeto usuário dentro da lista
            // listaDeUsuario.Add(usuario);
            StreamWriter sw = new StreamWriter("usuarios.csv", true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao}");
            sw.Close();

            return usuario;
        }
        /// <summary>Retorna lista de usuário</summary>
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
                    usuarioViewModel.Senha = dadosDeCadaUsuario[3];
                    usuarioViewModel.DataCriacao = DateTime.Parse(dadosDeCadaUsuario[4]);
                    listaDeUsuario.Add(usuarioViewModel);
                }
            }
            return listaDeUsuario;
        }//Fim listar

        /// <summary>Verifica se o usuário é válido</summary>
        /// <param name="email">E-mail do Usuário</param>
        /// <param name="senha">Senha do Usuário</param>
        /// <returns>Retorna o usuário caso ele seja encontrado ou null calso não exista</returns>
        internal UsuarioViewModel BuscarUsuario(string email, string senha)
        {
            List<UsuarioViewModel> listaDeUsuario = Listar();
            foreach (var item in listaDeUsuario)
            {
                if (item.Email.Equals(email) && item.Senha.Equals(senha)) {
                    return item;
                }
            }
            return null;
        }
    }
}