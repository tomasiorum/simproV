using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// <param name="listadependentes"></param>
        public void SolicitarListaFaturas(ref List<Fatura> listadependentes)
        {
        }
    }
}

