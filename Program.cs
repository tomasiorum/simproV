using System;
namespace SimproV
{
    internal static class SimproV
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Controller controller = new Controller();
            controller.IniciarPrograma();
        }
    }
}