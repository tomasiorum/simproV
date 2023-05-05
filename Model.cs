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
        private Controller controller;
        private View view;
        private ListaFaturas listapendentes;

        public Model(Controller c, View v)
        {
            controller = c;
            view = v;
        }

        public ListaFaturas ListaPendentes()
        {
            // Retorna a lista de nifs enomes comerciantes com faturas pendentes
            return listapendentes;
        }
    }
}
