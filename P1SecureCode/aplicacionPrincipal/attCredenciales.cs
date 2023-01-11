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

        hashing hs = new hashing();
        claseAccesoDatos ddbb = new claseAccesoDatos();
        DataSet dts = new DataSet();
        Random rdm = new Random();
        appPrinc frmPrincipal;

        string valorUserBBDD, valorPassBBDD, valorNivelUser;
        // Es incorrecto ya que no realiza el join a la categoria para coger el nivel
        //string querry = "select * from Users where 1=1 and Login = '";

        int salBH;
        string salbbdd;

        private void txtPassConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Funciona
            {
                button1_Click(sender, e);
            }
        }

        private void attCredenciales_Load(object sender, EventArgs e)
        {
            lblValorUser.Text =  valorUserBBDD;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT UserCategories.*,Users.* FROM UserCategories INNER JOIN Users ON UserCategories.idUserCategory = Users.idUserCategory " +
            "WHERE(Users.Login = '";
            //coger el user y pass del form pasado 
            query = query + valorUserBBDD + "')";

            dts = ddbb.PortarPerConsulta(query);

            valorNivelUser = dts.Tables[0].Rows[0]["AccessLevel"].ToString();

            //nueva contraseña
            if (txtPass.Text== txtPassConfirm.Text)
            {
                valorPassBBDD = txtPassConfirm.Text.ToString();

                //HASHEAR Sal
                salBH = rdm.Next(0, 100);
                salbbdd = hs.hashingConAleatorio(salBH);

                valorPassBBDD = hs.hashingPass(salbbdd, txtPassConfirm.Text.ToString());

                dts.Tables[0].Rows[0]["Salt"] = salbbdd;
                dts.Tables[0].Rows[0]["Password"] = valorPassBBDD;

                dts = ddbb.Actualitzar(dts, query);
                

                MessageBox.Show("Credenciales Actualizadas.");
                this.Hide();
                frmPrincipal = new appPrinc(valorUserBBDD, valorNivelUser);
                frmPrincipal.ShowDialog();
                frmPrincipal.lblTitulo.Text = valorUserBBDD;
            }
            else
            {
                MessageBox.Show("Contraseñas no coinciden");
            }

            
        }
    }
}
