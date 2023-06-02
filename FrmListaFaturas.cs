using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimproV
{
    public partial class FrmListaFaturas : Form
    {
        public FrmListaFaturas()
        {
            InitializeComponent();
        }

        // Mostrar a lista faturas
        internal void ShowListaComerciantes(RespostaAT respostaAT)
        {
           
            this.dgListaFaturas.AutoGenerateColumns = false;
            dgListaFaturas.DataSource = respostaAT.ListaFaturas;
            this.ShowDialog();
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
