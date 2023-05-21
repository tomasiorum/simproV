using System;
using System.Windows.Forms;

namespace SimproV
{
    public partial class FrmMain : Form
    {
        View view;
        public FrmMain()
        {
            InitializeComponent();
        }
        public View View { get => view; set => view = value; }

        private void btnSolicitarFaturas_Click(object sender, EventArgs e)
        {
            
            view.CliqueEmListaFaturas(sender, e,txtNIF.Text,txtSenha.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            view.CliqueEmSair(e);
        }
        public void Encerrar()
        {
            Application.Exit();
        }
    }
}
