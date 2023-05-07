using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimproV
{
    public partial class Form1 : Form
    {
        View view;
        public Form1()
        {
            InitializeComponent();
        }
        public View View { get => view; set => view = value; }

        private void btnSolicitarFaturas_Click(object sender, EventArgs e)
        {
            view.CliqueEmListaFaturas(sender, e);
        }
    }
}
