using System.Collections.Generic;

namespace SimproV
{

    class Controller
    {
        View view;
        Model model;

        public delegate void AtivacaoInterface(object origem);
        

        public Controller()
        {
            view = new View(model);
            model = new Model(view);

            view.UtilizadorClicouEmListaFaturas += UtilizadorClicouEmListaFaturas;
            view.PrecisoDeFaturas += model.SolicitarListaFaturas;

            model.ListaDeComerciantes += view.NovaListaFaturas;

        }

        public void IniciarPrograma()
        {
            //Implementar....
            view.AtivarInterface();
        }
        public void UtilizadorClicouEmListaFaturas(object fonte, System.EventArgs args)
        {
            view.NovaListaFaturas();
        }

    }
}

