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
        internal void ShowListaComerciantes(List<Fatura> listaComerciantes)
        {
            FrmListaFaturas frmLista = new FrmListaFaturas();
            frmLista.ShowDialog();
            Console.WriteLine("Lista de Comerciantes");
        }
    }
}
