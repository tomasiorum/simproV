using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimproV
{
    public class Login : ILogin
    {
        public string NIF { get; set; }
        public string Senha { get; set; }
        public Login(Login login)
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
