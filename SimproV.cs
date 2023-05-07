using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimproV
{
    class SimproV
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo
        /// </summary>
        [STAThread]
        static void Main()
        {
            Controller controller = new Controller();
            controller.IniciarPrograma();
        }
    }
}
