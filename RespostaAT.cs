using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimproV
{
    public class RespostaAT : IRespostaAT
    {
        public List<Fatura> ListaFaturas { get; set; }

        public RespostaAT()
        {
            ListaFaturas = new List<Fatura>();
        }
    }
}
