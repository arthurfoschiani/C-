using Tarefas.ViewModel;

namespace Tarefas.Utils
{
    public class ValidacaoUtil
    {
        public static bool ValidarEmail (string email) {
            if (email.Contains("@") && email.Contains(".")) {
                return true;
            }
            return false;
        }

        public static bool confirmaSenha (string senha, string confirmacaoSenha) {
            if (senha.Equals(confirmacaoSenha) && senha.Length >= 6) {
                return true;
            }
            return false;
        }
    }
}