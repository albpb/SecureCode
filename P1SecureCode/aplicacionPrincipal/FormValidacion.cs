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
using System.IO;

namespace aplicacionPrincipal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        hashing hs = new hashing();
        claseAccesoDatos ddbb = new claseAccesoDatos();
        attCredenciales frmCredenciales;
        appPrinc frmPrincipal;
        DataSet dts = new DataSet();


        string valorUserBBDD, valorPassBBDD, valorSaltBBDD, valorNivelUser, passActual;

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Funciona
            {
                this.Hide();
                bntLogin_Click(sender,e);
            }
        }

        bool palabraPassIgual = false;

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
                    valorSaltBBDD = dts.Tables[0].Rows[0]["Salt"].ToString();
                    valorNivelUser = dts.Tables[0].Rows[0]["AccessLevel"].ToString();

                    passActual = hs.hashingPass(valorSaltBBDD, txtPass.Text.ToString());
                    if (passActual == valorPassBBDD)
                    {
                        palabraPassIgual = true;
                    }
                }

                if (!tablaConDatos)
                {

                    if (txtUser.Text.ToString() == valorUserBBDD && palabraPassIgual)
                    {
                        this.Hide();
                        frmPrincipal = new appPrinc(valorUserBBDD, valorNivelUser);
                        frmPrincipal.ShowDialog();
                        frmPrincipal.lblNombreUsuario.Text = valorUserBBDD;
                    }
                    else if (txtUser.Text.ToString() == valorUserBBDD && txtPass.Text.ToString() == "12345aA" &&valorPassBBDD == "12345aA")
                    {
                        this.Hide();
                        frmCredenciales = new attCredenciales(valorUserBBDD, valorPassBBDD);
                        frmCredenciales.ShowDialog();
                        frmCredenciales.lblValorUser.Text = valorUserBBDD;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("No se ha encontrado el archivo. \n"+ex.Message);
            }
            catch (Exception ex)
            {
                tablaConDatos = true;
                MessageBox.Show(ex.Message);
                MessageBox.Show("Credenciales Incorrectas");
                txtUser.Clear();
                txtUser.Focus();
                txtPass.Clear();
            }
        }
    }
}
