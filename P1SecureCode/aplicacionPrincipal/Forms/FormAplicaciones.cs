﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using ComponenteAccesoDatos;

namespace aplicacionPrincipal.Forms
{
    public partial class FormAplicaciones : Form
    {
        public FormAplicaciones()
        {
            InitializeComponent();
        }
        string valorUserBBDD, valorNivelUser;
        int valorNivelJedi;
        claseAccesoDatos ddbb = new claseAccesoDatos();
        DataSet dts = new DataSet();
        string querry = "SELECT * FROM UserOptions WHERE AccessLevel <= ";

        private void flpnlMain_Paint_1(object sender, PaintEventArgs e)
        {
            valorNivelJedi = int.Parse(valorNivelUser.ToString());

            querry += valorNivelJedi;

            dts = ddbb.PortarPerConsulta(querry);

            foreach (DataRow row in dts.Tables[0].Rows)
            {
                string text = row["Texto"].ToString();
                string clase = row["Clase"].ToString();
                string form = row["Form"].ToString();
                string color = row["Color"].ToString();
                string taula = row["Taula"].ToString();

                string imagen = row["Icono"].ToString();

                SWLauchForm launchform = new SWLauchForm(color, imagen, clase, text, form, taula);

                flpnlMain.Controls.Add(launchform);
            }
        }
    }
}
