﻿using System;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormUploud frmSF = new FormUploud();
            frmSF.Show();
            this.Hide();
        }

        private void bt_FormSubirFicheros_Click(object sender, EventArgs e)
        {
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
    }
}
