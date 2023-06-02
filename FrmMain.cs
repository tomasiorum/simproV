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
            Login login = new Login(txtNIF.Text, txtSenha.Text);
            view.CliqueEmListaFaturas(sender, e,login);
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
