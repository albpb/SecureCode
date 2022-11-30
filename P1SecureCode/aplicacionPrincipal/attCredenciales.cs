using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponenteAccesoDatos;
using System.Security.Cryptography;
using aplicacionPrincipal;

namespace aplicacionPrincipal
{
    public partial class attCredenciales : Form
    {
        public attCredenciales()
        {
            InitializeComponent();
        }
        public attCredenciales(string user, string pass)
        {
            InitializeComponent();
            valorUserBBDD = user;
            valorPassBBDD = pass;
        }

        claseAccesoDatos ddbb = new claseAccesoDatos();
        DataSet dts = new DataSet();
        Random rdm = new Random();
        appPrinc frmPrincipal;

        string valorUserBBDD, valorPassBBDD;
        string querry = "select * from Users where 1=1 and Login = '";
        int salBH;
        string salbbdd;

        private void attCredenciales_Load(object sender, EventArgs e)
        {
            lblValorUser.Text =  valorUserBBDD;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //coger el user y pass del form pasado
            querry = querry + valorUserBBDD + "'";

            dts = ddbb.PortarPerConsulta(querry);

            //nueva contraseña
            if (txtPass.Text== txtPassConfirm.Text)
            {
                valorPassBBDD = txtPassConfirm.Text.ToString();
            }
            else
            {
                MessageBox.Show("Contraseñas no coinciden");
            }

            //HASHEAR Sal
            salBH = rdm.Next(0, 100);
            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(salBH.ToString()));
                string strHash = BitConverter.ToString(hashedBytes);
                salbbdd = strHash;
            }
            //guardar salAH na BBDD
            //HASHEAR Pass
            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(valorPassBBDD + salbbdd));
                string strHash = BitConverter.ToString(hashedBytes);
                valorPassBBDD = strHash;
            }
            //guardar Senha na BBDD

            //salbbdd = dts.Tables[0].Rows[0]["Salt"].ToString();
            //valorPassBBDD = dts.Tables[0].Rows[0]["Password"].ToString();

            dts = ddbb.Actualitzar();

            MessageBox.Show("Credenciales Actualizadas.");
            this.Hide();
            frmPrincipal = new appPrinc(valorUserBBDD);
            frmPrincipal.ShowDialog();
            frmPrincipal.lblNombreUsuario.Text = valorUserBBDD;

        }
    }
}
