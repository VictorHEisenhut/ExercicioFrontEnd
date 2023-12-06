using AgendaMVC.Models;

namespace AgendaMVC.Validations
{
    public class ContatoValidator
    {
        public static bool ValidarContato(Contato contato)
        {
            if (contato.Nome.Length > 40 || contato.Nome.Length < 3)
            {
                return false;
            }
            if (contato.Email.Length > 40 || contato.Email.Length < 3)
            {
                return false;
            }
            if (contato.Fone.Length > 40 || contato.Fone.Length < 3)
            {
                return false;
            }
            return true;
        }
    }
}
