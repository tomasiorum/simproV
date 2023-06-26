using SimproV.Interfaces;
using SimproV.Views;

namespace SimproV.Models
{
    class Model
    {
        private ViewMain view;
        // Notificar o controller da lista de comerciantes
        // e por sua vez o controller à View
        public delegate void NotificarListaDeComerciantes(IRespostaAT respostaAT);
        public event NotificarListaDeComerciantes JaTenhoListaComerciantes;

        public Model(ViewMain v)
        {
            view = v;
        }
        /// <summary>
        /// Retorna a lista de nifs enomes comerciantes com faturas pendentes
        /// </summary>
        /// <param name="listadefaturas"></param>
        public void GetComerciantesAT()
        {
            IRespostaAT respostaAT = new RespostaAT();
            AutoridadeTributaria at = new AutoridadeTributaria(view.login);
            try
            {
                 respostaAT = at.Processar();
            } catch (ExceptionErroLigacao )
            {
                throw new ExceptionErroLigacao(at.GetMensagemErro());
            }

            // Notifico que já tenho a lista de comerciantes
            JaTenhoListaComerciantes(respostaAT);
        }
        public void SubmeterComercianteAT(ISubmeterComerciante submeterComerciante)
        {
            AutoridadeTributaria at = new AutoridadeTributaria(view.login);
            try
            {
               at.SubmeterComerciante(submeterComerciante.NIF, view.submeterComerciante.Atividade);
            }
            catch (ExceptionErroLigacao)
            {
                throw new ExceptionErroLigacao(at.GetMensagemErro());
            }

        }
    }
}

