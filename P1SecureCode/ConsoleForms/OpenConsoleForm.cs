using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleForms
{
    public partial class OpenConsoleForm : Form
    {
        public OpenConsoleForm()
        {
            InitializeComponent();
        }
        private void pictureBox_btOpenConsole_MouseClick(object sender, MouseEventArgs e)
        {
            //ProcessStartInfo startInfo = new ProcessStartInfo("ConsolaProyecto.exe");
            //Process.Start(startInfo);

            Process myprocess = Process.Start("ConsolaProyecto.exe");

            this.Hide();

            while (!myprocess.HasExited)
            {
                if (!myprocess.HasExited)
                {
                    myprocess.Refresh();
                    Thread.Sleep(2000);
                }
                else
                {
                    myprocess.CloseMainWindow();
                    myprocess.Close();
                }
            }

            this.Show();
        }

        private void Form_ObrirConsola_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
