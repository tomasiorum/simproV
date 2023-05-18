using SimproV.Models;
using System.Collections.Generic;

namespace SimproV
{
    class Model
    {
        private View view;
        public delegate void NotificarListaDeComerciantes();
        //public event NotificarListaDeComerciantes ListaDeComerciantes;
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
        public void SolicitarListaFaturas(ref List<Fatura> listadeformas,ref string nif, ref string senha)
        {
           
            AutoridadeTributaria at = new AutoridadeTributaria(nif,senha);
            try
            {
                at.Processar();
            } catch (ExceptionErroLigacao )
            {
                throw new ExceptionErroLigacao(at.GetMensagemErro());
            }

           // ListaDeComerciantes();
        }
    }
}

