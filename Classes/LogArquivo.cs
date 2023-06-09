using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starpatch.Classes
{
    public static class LogArquivo
    {
        public static void Gravar(string texto)
        {
            //Gravando o erro no log
            string arquivoLog = Environment.CurrentDirectory + @"\Log\" + DateTime.Now.ToString("ddMMyyyy") + ".txt";

            //cria o caminho
            Directory.CreateDirectory(Path.GetDirectoryName(arquivoLog));

            using (StreamWriter sw = new StreamWriter(arquivoLog, true))
            {
                sw.WriteLine(texto);
            }
        }
    }
}
