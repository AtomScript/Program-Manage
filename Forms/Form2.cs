using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Management;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Be.Windows.Forms;
using System.Globalization;

namespace ProgramManage
{
    public partial class Viewer : Form
    {
        private HexBox hexBox;
        Form4 instanciaDoForm4;
        private System.ComponentModel.Design.ByteViewer byteviewer;

        public Viewer(Form4 frm4)
        {
            InitializeComponent();
            instanciaDoForm4 = frm4;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            hexBox = new HexBox()
            {
                Top = ph1.Top,
                Width = ph1.Width,
                Height = ph1.Height,
                Left = ph1.Left,
                Visible = true,
                UseFixedBytesPerLine = true,
                BytesPerLine = 16,
                ColumnInfoVisible = true,
                LineInfoVisible = true,
                StringViewVisible = true,
                VScrollBarVisible = true,
                BackColor = Color.FromArgb(30, 25, 45),
                ForeColor = Color.White,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(hexBox);
            this.Controls.Remove(ph1);

            try
            {
                string ProcessIdp = instanciaDoForm4.labelProc.Text;
                int ProcessIdps = Convert.ToInt32(ProcessIdp);
                string wmiQueryString = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + ProcessIdps;
                using (var searcher = new ManagementObjectSearcher(wmiQueryString))
                {
                    using (ManagementObjectCollection results = searcher.Get())
                    {
                        foreach (ManagementObject mo in results)
                        {
                            try
                            {
                                string filepath = Convert.ToString(mo["ExecutablePath"]);
                                var source = new FileByteProvider(filepath);
                                hexBox.ByteProvider = source;
                                hexBox.Refresh();


                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
            catch { }
        }
        private void HexBox_CopiedHex(object sender, EventArgs e)
        {
            var hex = Clipboard.GetText();
            var hexHex = hex.Split(' ');
            var hexArr = new byte[hexHex.Length];
            for (var i = 0; i < hexHex.Length; i++)
            {
                hexArr[i] = byte.Parse(hexHex[i], NumberStyles.AllowHexSpecifier);
            }
            File.WriteAllBytes(@"C:\00_Work\test.bin", hexArr);
        }
    }
}
