namespace APLICATIVO_FINANCEIRO.ViewController
{
    public class ValidacaoUtil
    {
        public static bool ValidarEmail (string email) {
            if (email.Contains ("@") && email.Contains (".")) {
                return true;
            }
            return false;
        }

        public static bool VerificaSenha (string senha, string confirmacaoSenha) {
            if (senha.Equals(confirmacaoSenha)) {
                return true;
            }
            return false;
        }

        public static bool TamanhoSenha (string senha) {
            if (senha.Length < 6) {
                return false;
            }
            return true;
        }
    }
}