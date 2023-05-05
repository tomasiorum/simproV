using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimproV
{
    public class View
    {
        private Controller controller;
        private Model model;
        private ListaFaturas faturas;

        internal View(Controller c, Model m)
        {
            controller = c;
            model = m;
        }

        public void AtivarInterface()
        {
            // Temos que conectar o objetos do Model e do Controller
            // Desenhar janelas e botões ocorre no código automático da API WinForms
            // A animação do clique do botão é gerada pelo código da API WinForms
        }

        public void NovaListaFaturas()
        {
            // Apresenta/atualiza a lista de comerciante/qt fatuaras recebidas do Model, com o seletor de atividade para cada um
        }

        public void ClassificouFaturas()
        {
            // Quando o utilizador selecionou uma atividade(classificou) as faturas de um comerciante
        }
    }

}
