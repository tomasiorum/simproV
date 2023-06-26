using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimproV.BD
{
    public class Utente
    {
        public string Nome { get; set; }
        public string NIF { get; set; }
        public string Senha { get; set; }

    }
    public class ListaUtentes
    {
        List<Utente> Utentes { get; set; }
    }
}
