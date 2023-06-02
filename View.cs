using System;
using System.Collections.Generic;

namespace SimproV
{
    public class View
    {
        
        private Model model;
        private FrmMain janela;

        private RespostaAT respostaAT;
        private Login login;

        public event System.EventHandler UtilizadorClicouEmListaFaturas;
        public event EventHandler UtilizadorClicouEmSair;

        public delegate void SolicitacaoListaFaturas(ref RespostaAT respostaAT,ref Login login);
        public event SolicitacaoListaFaturas PrecisoDeFaturas;

        internal View(Model m)
        {
            model = m;
        }

        public void AtivarInterface()
        {
            janela = new FrmMain();
            janela.View = this;
            // A API WinForms desenha as janelas e botões automaticamente
            janela.ShowDialog();
            // Temos que conectar o objetos do Model e do Controller
            // Desenhar janelas e botões ocorre no código automático da API WinForms
            // A animação do clique do botão é gerada pelo código da API WinForms
        }
        public void NovaListaFaturas()
        {
            // Apresenta/atualiza a lista de comerciante/qt fatuaras recebidas do Model, com o seletor de atividade para cada um
            FrmListaFaturas frmListaFatura = new FrmListaFaturas();

            PrecisoDeFaturas(ref respostaAT, ref janela.View.login);

            

        }
        public void ShowListaComerciantes()
        {
            FrmListaFaturas frmListaFaturas = new FrmListaFaturas();
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
        public void ClassificouFaturas()
        {
            // Quando o utilizador selecionou uma atividade(classificou) as faturas de um comerciante
            
        }
        public void CliqueEmListaFaturas(object origem, EventArgs e,Login login)
        {
            this.login = new Login(login);


            this.respostaAT = new RespostaAT();
            
            UtilizadorClicouEmListaFaturas(origem, e);

        }
    }

}
