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
using aplicacionPrincipal;

namespace aplicacionPrincipal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        claseAccesoDatos ddbb = new claseAccesoDatos();
        attCredenciales frmCredenciales;
        appPrinc frmPrincipal;
        DataSet dts = new DataSet();


        string valorUserBBDD;
        string valorPassBBDD;

        private void bntLogin_Click(object sender, EventArgs e)
        {
            string querry = "SELECT UserCategories.*,Users.* FROM UserCategories INNER JOIN Users ON UserCategories.idUserCategory = Users.idUserCategory " +
            "WHERE(Users.Login = '" + txtUser.Text + "')";
            bool tablaConDatos = false;

            dts = ddbb.PortarPerConsulta(querry);

            try
            {
                if (dts.Tables[0].Rows.Count == 0)
                {
                    throw new Exception();
                }
                else
                {
                    valorUserBBDD = dts.Tables[0].Rows[0]["Login"].ToString();
                    valorPassBBDD = dts.Tables[0].Rows[0]["Password"].ToString();
                }

                if (!tablaConDatos)
                {
                    if (valorUserBBDD == txtUser.Text.ToString() && valorPassBBDD != txtPass.Text.ToString())
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }
                    else if (valorUserBBDD == txtUser.Text.ToString() && valorPassBBDD == txtPass.Text.ToString())
                    {
                        //entrar
                        if (valorPassBBDD == "12345aA") //funciona
                        {
                            this.Hide();
                            frmCredenciales = new attCredenciales(valorUserBBDD);
                            frmCredenciales.ShowDialog();
                            frmCredenciales.lblValorUser.Text = valorUserBBDD;
                        }
                        else
                        {
                            this.Hide();
                            frmPrincipal = new appPrinc(valorUserBBDD);
                            frmPrincipal.ShowDialog();
                            frmPrincipal.lblNombreUsuario.Text = valorUserBBDD;
                        }
                    }
                }
            }
            catch (Exception)
            {
                tablaConDatos = true;
                MessageBox.Show("Credenciales Incorrectas");
                txtUser.Clear();
                txtUser.Focus();
                txtPass.Clear();
            }
        }
    }
}
