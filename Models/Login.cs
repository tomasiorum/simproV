using SimproV.Interfaces;

namespace SimproV.Models
{
    public class Login : ILogin
    {
        public string NIF { get;}
        public string Senha { get;}
        public Login(ILogin login)
        {
            this.NIF = login.NIF;
            this.Senha = login.Senha;
        }
        public Login(string nif, string senha)
        {
            this.NIF = nif;
            this.Senha = senha;
        }
    }
}
