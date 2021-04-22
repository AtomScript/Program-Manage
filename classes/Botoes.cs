using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramManage
{
    class Botoes
    {
        public Button btnDefault1 = new Button();
        public Button gerarBotao(string text, string NameText, bool values)
        {
            Button btnDefault = new Button();
            btnDefault.Text = text; 
            btnDefault.Name = NameText;
            btnDefault.Visible = values;
            btnDefault.Dock = DockStyle.None;
            btnDefault.Size = new System.Drawing.Size(70, 40);
            return btnDefault;
        }
    }
}
