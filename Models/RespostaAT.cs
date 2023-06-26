using SimproV.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimproV.Models
{
    public class RespostaAT : IRespostaAT
    {
        public List<ILinhaComerciante> LinhasComerciantes { get;set; }

        public RespostaAT()
        {
            LinhasComerciantes = new List<ILinhaComerciante>();
        }
    }
}
