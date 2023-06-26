using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimproV.Interfaces
{
    public interface ILinhaComerciante
    {
        string NIF { get; set; }
        string Nome { get; set; }
        int QtDocumentos { get; set; }
    }
}
