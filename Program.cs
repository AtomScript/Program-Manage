using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace ProgramManage
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {  //Pega o nome do processo deste programa
            string nomeProcesso = Process.GetCurrentProcess().ProcessName;

            //Busca os processos com este nome que estão em execução
            Process[] processos = Process.GetProcessesByName(nomeProcesso);

            var patheprogram = Directory.GetCurrentDirectory();

            //Se já houver um aberto
            if (processos.Length > 1)
            {
                //Mostra mensagem de erro e finaliza
                Application.Exit();
            }
            //Caso contrário continue normalmente
            else if(File.Exists(patheprogram + "/" + "FunctionsQuery.dll"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Está faltando uma dll. Certifique-se de que todas as dlls estão no mesmo diretorio que o programa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
