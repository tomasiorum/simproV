using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimproV
{
    public partial class FrmListaFaturas : Form
    {
        View view;
        public FrmListaFaturas()
        {
            InitializeComponent();
        }
        public View View { get => view; set => view = value; }
        // Mostrar a lista faturas
        internal void ShowListaComerciantes(IRespostaAT respostaAT)
        {

            this.dgListaFaturas.AutoGenerateColumns = false;
            dgListaFaturas.DataSource = respostaAT.ListaFaturas;
            this.ShowDialog();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgListaFaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string nif = dgListaFaturas.Rows[row].Cells[0].Value.ToString();
            view.UtilizadorConfirmaComerciante(sender, e);
           
        }
    }
}
