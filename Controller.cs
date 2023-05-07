namespace SimproV
{

    class Controller
    {
        View view;
        Model model;

        public delegate void AtivacaoInterface(object origem);
        //public event AtivacaoInterface AtivarInterface;

        public Controller()
        {
            view = new View(model);
            model = new Model(view);

            view.UtilizadorClicouEmListaFaturas += UtilizadorClicouEmListaFaturas;
            //view.PrecisoDeListaFaturas += model.SolicitarListaFaturas;
        }

        public void IniciarPrograma()
        {
            //Implementar....
            view.AtivarInterface();
        }
        public void UtilizadorClicouEmListaFaturas(object fonte, System.EventArgs args)
        {
            // Implementar...
           // model.SolicitarListaFaturas();
        }

    }
}

