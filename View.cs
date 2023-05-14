using System;
using System.Collections.Generic;

namespace SimproV
{
    public class View
    {

        private Model model;
        private Form1 janela;
        private string nif;
        private string senha;


        public event System.EventHandler UtilizadorClicouEmListaFaturas;

        public delegate void SolicitacaoListaFaturas(ref List<Fatura> listaFaturas,ref string nif, ref string senha);
        public event SolicitacaoListaFaturas PrecisoDeFaturas;

        internal View(Model m)
        {
            model = m;
        }

        public void AtivarInterface()
        {
            janela = new Form1();
            janela.View = this;
            // A API WinForms desenha as janelas e botões automaticamente
            janela.ShowDialog();
            // Temos que conectar o objetos do Model e do Controller
            // Desenhar janelas e botões ocorre no código automático da API WinForms
            // A animação do clique do botão é gerada pelo código da API WinForms
        }
        public string GetNIF()
        {
            return this.nif;

        }
        public string GetSenha()
        {
            return this.senha;

        }
        public void NovaListaFaturas()
        {
            // Apresenta/atualiza a lista de comerciante/qt fatuaras recebidas do Model, com o seletor de atividade para cada um
            List<Fatura> lista = new List<Fatura>();
            PrecisoDeFaturas(ref lista, ref janela.View.nif, ref janela.View.senha);
        }

        public void ClassificouFaturas()
        {
            // Quando o utilizador selecionou uma atividade(classificou) as faturas de um comerciante
            
        }
        public void CliqueEmListaFaturas(object origem, EventArgs e,string nif, string senha)
        {
            this.nif = nif;
            this.senha = senha;

            List<Fatura> faturas = new List<Fatura>();
            UtilizadorClicouEmListaFaturas(origem, e);

        }
    }

}
