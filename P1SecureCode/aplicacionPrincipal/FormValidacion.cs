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

        int contador = 0, segundos = 0, segundosMalos = 0;
        string valorUserBBDD, valorPassBBDD, valorSaltBBDD, valorNivelUser, passActual, valorNombre;
        bool intruso = false;

        private void tmalo_Tick(object sender, EventArgs e)
        {
            segundosMalos++;
            if (segundosMalos == 3)
            {
                Application.Exit();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 3)
            {
                this.Hide();
                frmPrincipal = new appPrinc(valorUserBBDD, valorNivelUser, valorNombre);
                frmPrincipal.ShowDialog();
                frmPrincipal.lblTitulo.Text = valorUserBBDD;
            }

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Funciona
            {
                bntLogin_Click(sender, e);
            }
        }

        bool palabraPassIgual = false;

        private void bntLogin_Click(object sender, EventArgs e)
        {
            string querry = "SELECT UserCategories.*,Users.* FROM UserCategories INNER JOIN Users ON UserCategories.idUserCategory = Users.idUserCategory " +
            "WHERE(Users.Login = '" + txtUser.Text + "')";


            dts = ddbb.PortarPerConsulta(querry);

            try
            {
                if (dts.Tables[0].Rows.Count == 0)
                {
                    throw new Exception("Credenciales incorrectas.");
                }
                else
                {
                    valorUserBBDD = dts.Tables[0].Rows[0]["Login"].ToString();
                    valorPassBBDD = dts.Tables[0].Rows[0]["Password"].ToString();
                    valorSaltBBDD = dts.Tables[0].Rows[0]["Salt"].ToString();
                    valorNivelUser = dts.Tables[0].Rows[0]["AccessLevel"].ToString();
                    valorNombre = dts.Tables[0].Rows[0]["UserName"].ToString();

                    passActual = hs.hashingPass(valorSaltBBDD, txtPass.Text.ToString());
                    if (passActual == valorPassBBDD)
                    {
                        palabraPassIgual = true;
                    }
                }


                if (txtUser.Text.ToString() == valorUserBBDD && palabraPassIgual)
                {
                    timer.Enabled = true;
                    //pctbLogin.Image = Image.FromFile(@"buena.png");
                    this.BackgroundImage = Image.FromFile(@"javaloginbueno.png");
                    lblInfo.Text = "Bienvenido!";
                    lblInfo.ForeColor = Color.Green;

                    timer.Start();
                    
                }
                else if (txtUser.Text.ToString() == valorUserBBDD && txtPass.Text.ToString() == "12345aA" && valorPassBBDD == "12345aA")
                {
                    this.Hide();
                    frmCredenciales = new attCredenciales(valorUserBBDD, valorNivelUser, valorNombre);
                    frmCredenciales.ShowDialog();
                    frmCredenciales.lblValorUser.Text = valorUserBBDD;
                }
                else if (txtUser.Text.ToString() == valorUserBBDD && !palabraPassIgual)
                {
                    contador++;
                    if (contador == 3)
                    {
                        //pctbLogin.Image = Image.FromFile(@"mala.png");
                        this.BackgroundImage = Image.FromFile(@"javaloginmalo.png");
                        intruso = true;
                        tmalo.Start();
                    }
                    if (intruso)
                    {
                        throw new Exception("Eres un intruso, vete de aqui!");
                    }
                    throw new Exception("(" + contador + ")" + " Contraseña incorrecta");
                }

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("No se ha encontrado el archivo. \n"+ex.Message);
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;

                txtUser.Clear();
                txtUser.Focus();
                txtPass.Clear();
            }
        }
    }
}
