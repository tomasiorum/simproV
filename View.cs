using System;
using System.Collections.Generic;

namespace SimproV
{
    public class View
    {
        
        private Model model;
        private FrmMain janela;
        private FrmListaFaturas frmListaFaturas;

        public IRespostaAT respostaAT;
        public ILogin login;
        public ISubmeterComerciante submeterComerciante;

        // FrmMain
        public delegate void SolicitacaoListaFaturas(ref IRespostaAT respostaAT,ref ILogin login);
        public event System.EventHandler UtilizadorClicouEmListaFaturas;
        public event EventHandler UtilizadorClicouEmSair;
        public event SolicitacaoListaFaturas PrecisoDeFaturas;


        //FrmListaFaturas
        public delegate void SolicitarSubmissaoComerciante(ILogin login, ISubmeterComerciante submeterComerciante);
        public event System.EventHandler UtilizadorConfirmouComerciante;
        public event SolicitarSubmissaoComerciante SubmeterComercianteAT;


        internal View(Model m)
        {
            model = m;
        }

        public void AtivarInterface()
        {
            janela = new FrmMain();
            janela.View = this;

            janela.ShowDialog();
        }
        public void NovaListaFaturas()
        {
            // Apresenta/atualiza a lista de comerciante/qt fatuaras recebidas do Model, com o seletor de atividade para cada um
            frmListaFaturas = new FrmListaFaturas();
            frmListaFaturas.View = this;
            PrecisoDeFaturas(ref respostaAT, ref janela.View.login);
        }
        public void ShowListaComerciantes()
        {
            frmListaFaturas = new FrmListaFaturas();
            frmListaFaturas.View = this;
            frmListaFaturas.ShowListaComerciantes(respostaAT);
        }
        public void CliqueEmSair(EventArgs e)
        {
            UtilizadorClicouEmSair(this, e);
        }
        public void Encerrar()
        {
            janela.Encerrar();
        }
        public void CliqueEmListaFaturas(object origem, EventArgs e,ILogin login)
        {
            this.login = new Login(login);


            this.respostaAT = new RespostaAT();
            
            UtilizadorClicouEmListaFaturas(origem, e);

        }
        public void UtilizadorConfirmaComerciante(object origem, EventArgs e, ILogin login, ISubmeterComerciante submeterComerciante )
        {
            //Todo Chamar com o ILogin e ISubmeterComerciante
            UtilizadorConfirmouComerciante(origem, e);
        }
        public void SubmeterComerciante()
        {
            SubmeterComercianteAT(frmListaFaturas.View.login, frmListaFaturas.View.submeterComerciante);
        }
    }

}
