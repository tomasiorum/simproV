
using System;
using System.Collections.Generic;

namespace SimproV
{

    class Controller
    {
        View view;
        Model model;
        bool sair;

        public delegate void AtivacaoInterface(object origem);
        

        public Controller()
        {
            view = new View(model);
            model = new Model(view);
            sair = false;

            view.UtilizadorClicouEmListaFaturas += UtilizadorClicouEmListaFaturas;
            view.PrecisoDeFaturas += model.SolicitarListaFaturas;
            view.UtilizadorClicouEmSair += UtilizadorClicouEmSair;
            model.ListaDeComerciantes += view.ShowListaFaturas;

        }
        private void ErroDeLigacao(ErrosLigacao forma)
        {
            //view.AtivarViewLog();
            //model.RegistarLog(forma);
        }
        public void IniciarPrograma()
        {
            do
            {
                try
                {
                    view.AtivarInterface();
                }
                catch (ExceptionErroLigacao ex)
                {
                    ErroDeLigacao(ex.siteEmBaixo);
                }
            } while (!sair);
        }
        public void UtilizadorClicouEmListaFaturas(object fonte, System.EventArgs args)
        {
            view.NovaListaFaturas();
        }
        private void UtilizadorClicouEmSair(object sender, EventArgs e)
        {
            sair = true;
            view.Encerrar();
        }

    }
}

