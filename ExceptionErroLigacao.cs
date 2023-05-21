using System;
using System.Runtime.Serialization;

namespace SimproV
{
    [Serializable]
    //Esta classe de exceção pertence ao componente Model
    public class ExceptionErroLigacao : Exception
    {
        public ErrosLigacao siteEmBaixo;

        public ExceptionErroLigacao()
        {
        }
        public ExceptionErroLigacao(ErrosLigacao erro)
        {
            this.siteEmBaixo = erro;
        }

        public ExceptionErroLigacao(string message) : base(message)
        {
        }

        public ExceptionErroLigacao(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionErroLigacao(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }

}
