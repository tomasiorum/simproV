
using System.Collections.Generic;

namespace SimproV
{
    class Model
    {
        private View view;
        public delegate void NotificarListaDeComerciantes();
        public event NotificarListaDeComerciantes ListaDeComerciantes;
        public Model(View v)
        {
            view = v;
        }
        /// <summary>
        /// Retorna a lista de nifs enomes comerciantes com faturas pendentes
        /// </summary>
        /// <param name="listadefaturas"></param>
        public void GetComerciantes()
        {

        }
        public void SolicitarListaFaturas(ref IRespostaAT respostaAT,ref ILogin login)
        {
           
            AutoridadeTributaria at = new AutoridadeTributaria(login);
            try
            {
                 respostaAT = at.Processar();
            } catch (ExceptionErroLigacao )
            {
                throw new ExceptionErroLigacao(at.GetMensagemErro());
            }

            ListaDeComerciantes();
        }
        public void SubmeterComercianteAT()
        {
            //AutoridadeTributaria at = new AutoridadeTributaria();
            try
            {
                //respostaAT = at.Processar();
            }
            catch (ExceptionErroLigacao)
            {
                //throw new ExceptionErroLigacao(at.GetMensagemErro());
            }

        }
    }
}

