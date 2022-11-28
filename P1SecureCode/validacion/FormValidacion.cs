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
using actualizacionPass;
using aplicacionPrincipal;

namespace validacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        claseAccesoDatos ddbb = new claseAccesoDatos();
        attCredenciales frmCredenciales = new attCredenciales();
        appPrinc frmPrincipal = new appPrinc();
        DataSet dts = new DataSet();

        string querry = "select Login, Password from Users where 1=1 and Login = '";
        string valorUserBBDD, valorPassBBDD;

        private void bntLogin_Click(object sender, EventArgs e)
        {
            ddbb.Connectar();

            querry = querry + txtUser.Text.ToString() + "'";

            ddbb.PortarTaula(querry);

            valorUserBBDD = dts.Tables[0].Rows[0]["Login"].ToString();
            valorPassBBDD = dts.Tables[0].Rows[0]["Password"].ToString();

            if (valorUserBBDD == txtUser.Text.ToString() && valorPassBBDD == txtPass.Text.ToString())
            {
                //entrar
                if (valorPassBBDD == "12345aA")
                {
                    this.Hide();
                    frmCredenciales.ShowDialog();
                    frmCredenciales.lblValorUser.Text = valorUserBBDD;
                }
                else
                {
                    this.Hide();
                    frmPrincipal.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }

        }
    }
}
