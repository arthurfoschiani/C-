using System;

namespace PIZZARIA.ViewModel
{
    public class UsuarioViewModel : BaseViewModel
    {
        public string Email {get; set;}
        public string senha {get; set;}
        public object Senha { get; internal set; }
    }
}