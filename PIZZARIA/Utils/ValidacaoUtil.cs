namespace PIZZARIA.Utils
{
    public class ValidacaoUtil
    {
        /// <summary> Retornar true caso o email possua @ e . e false se não possuir </summary>
        public static bool ValidarEmail (string email) {
            if (email.Contains("@") && email.Contains(".")) {
                return true;
            }
            return false;
        }

        /// <summary>Retorna true caso as senhas sejam iguais e contenha mais de 6 caracteres ou false caso contrário</summary>
        public static bool confirmaçãoSenha (string senha, string confirmaSenha) {
            if(senha.Equals(confirmaSenha) && senha.Length >= 6) {
                return true;
            }
            return false;
        }
    }
}