using System.Collections.Generic;

namespace SimproV
{
    class Model
    {
        private View view;
        
        public Model(View v)
        {
            view = v;
        }
        /// <summary>
        /// Retorna a lista de nifs enomes comerciantes com faturas pendentes
        /// </summary>
        /// <param name="listadefaturas"></param>
        public void SolicitarListaFaturas(ref List<Fatura> listadefaturas)
        {
        }
    }
}

