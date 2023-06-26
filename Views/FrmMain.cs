using SimproV.Models;
using System;
using System.Windows.Forms;

namespace SimproV.Views
{
    public partial class FrmMain : Form
    {
        ViewMain view;
        public FrmMain()
        {
            InitializeComponent();
        }
        public ViewMain Vista { get => view; set => view = value; }

        private void btnPedirListaComerciantes_Click(object sender, EventArgs e)
        {
            view.login = new Login(txtNIF.Text, txtSenha.Text);
            view.PrecisoListaComerciantes(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            view.Sair(e);
        }
        public void Sair()
        {
            Application.Exit();
        }
    }
}
