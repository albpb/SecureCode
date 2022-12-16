using System;
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

namespace aplicacionPrincipal
{
    public partial class appPrinc : Form
    {

        public appPrinc()
        {
            InitializeComponent();
        }
        public appPrinc(string user, string nivel)
        {
            InitializeComponent();
            valorUserBBDD = user;
            valorNivelUser = nivel;
        }
        string valorUserBBDD, valorNivelUser;
        int valorNivelJedi;

        claseAccesoDatos ddbb = new claseAccesoDatos();
        DataSet dts = new DataSet();

        string querry = "SELECT * FROM UserOptions WHERE AccessLevel <= ";


        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            valorNivelJedi = int.Parse(valorNivelUser.ToString());
           

            //Fecha actual
            string fechaActual = DateTime.Now.ToString("D");
            lblFecha.Text = fechaActual;
            lblNombreUsuario.Text = valorUserBBDD;

            lblNv.Text = valorNivelJedi.ToString();

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
