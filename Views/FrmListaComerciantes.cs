using SimproV.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimproV.Views
{
    public partial class FrmListaComerciantes : Form
    {
        ViewMain view;
        public FrmListaComerciantes()
        {
            InitializeComponent();
        }
        public ViewMain Vista { get => view; set => view = value; }
        // Mostrar a lista faturas
        internal void ShowListaComerciantes()
        {
            this.dgListaFaturas.AutoGenerateColumns = false;
            dgListaFaturas.DataSource = view.respostaAT.LinhasComerciantes;

            this.ShowDialog();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgListaFaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            view.submeterComerciante = new SubmeterComerciante();
            int row = e.RowIndex;
            view.submeterComerciante.NIF = dgListaFaturas.Rows[row].Cells[0].Value.ToString();
            // Todo falta tratar esta excepção
            view.submeterComerciante.Atividade = dgListaFaturas.Rows[row].Cells[3].Value == null ? "" : dgListaFaturas.Rows[row].Cells[3].Value.ToString();
            view.UtilizadorConfirmaComerciante(sender, e);


        }
    }
}
