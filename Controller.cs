
using SimproV.Models;
using SimproV.Views;
using System;

namespace SimproV
{
    class Controller
    {
        ViewMain view;
        Model model;
        bool sair;

        public delegate void AtivacaoInterface(object origem);
        

        public Controller()
        {
            view = new ViewMain(model);
            model = new Model(view);
            sair = false;

            //FrmMain
            //Associar um evento com uma instância de um delegate que já existe
            view.PrecisoComerciantes += model.GetComerciantesAT;
            view.UtilizadorPediuListaComerciantes += UtilizadorPediuListaComerciantes;


            view.UtilizadorClicouEmSair += UtilizadorClicouEmSair;
            // Notifica a view que tem a lista de comerciantes
            model.JaTenhoListaComerciantes += view.ShowListaComerciantes;

            //FrmListaFaturas
            view.UtilizadorConfirmouComerciante += UtilizadorConfirmouComerciante;
            view.SubmeterComercianteAT += model.SubmeterComercianteAT;



        }
        private void ErroDeLigacao(ErrosLigacao forma)
        {
            // Todo Gravar log em ficheiro
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
        public void UtilizadorPediuListaComerciantes(object fonte, System.EventArgs args)
        {
            view.GetListaComerciantes();
        }
        public void UtilizadorConfirmouComerciante(object fonte, System.EventArgs args)
        {
            view.SubmeterComerciante();
           
        }
        private void UtilizadorClicouEmSair(object sender, EventArgs e)
        {
            sair = true;
            view.Encerrar();
        }
    }
}

