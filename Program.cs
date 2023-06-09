using starpatch.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace starpatch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(tratarExcecao);
            Application.Run(new FrmPrincipal());
        }

        private static void tratarExcecao(object sender, ThreadExceptionEventArgs t)
        {
            Mensagem.Erro($"ERRO: {t.Exception}");
        }
    }
}
