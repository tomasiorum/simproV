using SimproV.Interfaces;

namespace SimproV
{
    public class LinhaComerciante : ILinhaComerciante
    {
        public string NIF { get; set; }
        public string Nome { get; set; }
        public int QtDocumentos { get; set; }
    }
}
