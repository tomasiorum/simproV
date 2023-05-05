using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimproV
{
    public class Controller
    {
        View view;
        Model model;

        public Controller()
        {
            view = new View(this, model);
            model = new Model(this, view);
        }

        public void IniciarPrograma()
        {
            //Implementar....
            view.AtivarInterface();
        }
        public void UtilizadorClicouemEntrar()
        {
            // Implementar...
            model.ListaPendentes();
        }

    }
}
