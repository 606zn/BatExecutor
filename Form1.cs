using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatExecutor
{
    public partial class Main : Form
    {
        /* BatExecutor v 0.01
         * VS 2019, Net framework 4.5, WinForms
         */
        public Main()
        {
            InitializeComponent();
        }


        private void Execute_Click(object sender, EventArgs e)
        {
            if (batbox.Text != "")
            {
                File.WriteAllText(Application.StartupPath + "\\BatExecutor.bat", batbox.Text);
                Process.Start(Application.StartupPath + "\\BatExecutor.bat");
            }

            else
            {
                MessageBox.Show("Нет скрипта для выполнения.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void Openbat_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "bat files | *.bat",
                InitialDirectory = Application.StartupPath
            };
            ofd.ShowDialog();
            string pth = ofd.FileName;
            if (pth != "")
            {
                new FileInfo(pth);
                StreamReader sr = new StreamReader(pth, System.Text.Encoding.Default);
                batbox.Text = "";
                while (!sr.EndOfStream)
                {
                    string text = sr.ReadLine() + Environment.NewLine;
                    batbox.AppendText(text);
                }
                sr.Close();
            }

        }

        private void Savebat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "bat files | *.bat";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                File.WriteAllText(sfd.FileName, batbox.Text);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void batbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
