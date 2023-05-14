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
        }

        public void IniciarPrograma()
        {
            //Implementar....
            view.AtivarInterface();
        }
        public void UtilizadorClicouEmListaFaturas(object fonte, System.EventArgs args)
        {
            List<Fatura> listadefaturas = new List<Fatura>();
            string nif = view.GetNIF();
            string senha = view.GetSenha();
            // Implementar...
            model.SolicitarListaFaturas(ref listadefaturas,ref nif, ref senha);
        }

    }
}

