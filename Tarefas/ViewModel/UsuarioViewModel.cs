namespace Tarefas.ViewModel
{
    public class UsuarioViewModel : BaseViewModel
    {
        public string Email;
        public object Senha { get; internal set; }
    }
}