using SimproV.Interfaces;
using SimproV.Models;
using System;

namespace SimproV.Views
{
    public class ViewMain
    {

        private Model model;
        private FrmMain janela;
        private FrmListaComerciantes frmListaFaturas;

        //public IRespostaAT respostaAT;
        public ILogin login;
        public ISubmeterComerciante submeterComerciante;
        public IRespostaAT respostaAT;
        // FrmMain
        // Botão para solicitar as faturas no menu principal
        public delegate void SolicitarComerciantes();
        /*
         * SolicitacaoListaFaturas(sender) - A fonte do evento ( Objecto que faz a publicação )
         * PrecisoDeFaturas(Receiver) - 
         */
        public event SolicitarComerciantes PrecisoComerciantes;
        public event EventHandler UtilizadorPediuListaComerciantes;
        public event EventHandler UtilizadorClicouEmSair;


        //FrmListaFaturas
        public event EventHandler UtilizadorConfirmouComerciante;
        public delegate void SolicitarSubmissaoComerciante(ISubmeterComerciante submeterComerciante);
        public event SolicitarSubmissaoComerciante SubmeterComercianteAT;


        internal ViewMain(Model m)
        {
            model = m;
        }

        public void AtivarInterface()
        {
            janela = new FrmMain();
            janela.Vista = this;

            janela.ShowDialog();
        }
        public void GetListaComerciantes()
        {
            // Apresenta/atualiza a lista de comerciante/qt fatuaras recebidas do Model, com o seletor de atividade para cada um
            frmListaFaturas = new FrmListaComerciantes();
            frmListaFaturas.Vista = this;
            PrecisoComerciantes();
        }
        public void ShowListaComerciantes(IRespostaAT respostaAT)
        {
            frmListaFaturas = new FrmListaComerciantes();
            frmListaFaturas.Vista = this;
            this.respostaAT = respostaAT;
            frmListaFaturas.ShowListaComerciantes();
        }
        public void Sair(EventArgs e)
        {
            UtilizadorClicouEmSair(this, e);
        }
        public void Encerrar()
        {
            janela.Sair();
        }
        public void PrecisoListaComerciantes(object origem, EventArgs e)
        {
            UtilizadorPediuListaComerciantes(origem, e);

        }
        public void UtilizadorConfirmaComerciante(object origem, EventArgs e)
        {
            UtilizadorConfirmouComerciante(origem, e);
        }
        public void SubmeterComerciante()
        {
            SubmeterComercianteAT(submeterComerciante);
        }
    }

}
