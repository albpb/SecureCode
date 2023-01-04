using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aplicacionPrincipal;

using CustomControls;
using ComponenteAccesoDatos;

namespace aplicacionPrincipal
{
    public partial class appPrinc : Form
    {
        //campos
        private Button bntActual;
        private Random rdn;
        private int tempIndex;
        private Form activeForm;

        //constructor
        public appPrinc()
        {
            InitializeComponent();
        }

        //constructor actual
        public appPrinc(string user, string nivel)
        {
            InitializeComponent();
            valorUserBBDD = user;
            valorNivelUser = nivel;
        }

        //Variables necesarias
        string valorUserBBDD, valorNivelUser;
        int valorNivelJedi;
        claseAccesoDatos ddbb = new claseAccesoDatos();
        DataSet dts = new DataSet();
        string querry = "SELECT * FROM UserOptions WHERE AccessLevel <= ";

        //bnt X
        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void ActivateButton(object bntSender)
        {
            if (bntSender != null)
            {
                if (bntActual != (Button)bntSender)
                {
                    DisableButton();
                    bntActual = (Button)bntSender;
                    bntActual.BackColor = Color.White;
                    bntActual.Font = new System.Drawing.Font("Lato", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBnt in panelMenu.Controls)
            {
                if (previousBnt.GetType() == typeof(Button))
                {
                    previousBnt.BackColor = Color.OliveDrab;
                    previousBnt.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object bntSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(bntSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bntHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.inicioApp(), sender);
        }

        private void bntTablaS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAplicaciones(), sender);
        }

        //private void bntTablaF_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        private void Settings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormExit(),sender);
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
