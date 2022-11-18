using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //boleanas de validacion
        bool user = false, pass = false;
        //consulta para verificar si existen
        string consulta = "select * from Users where 1=1";
        
        private void bntLogin_Click(object sender, EventArgs e)
        {
            string consultaDeValidacion = consulta + " and Login = '" + txtUser.Text + "' AND Password is not null";

            //Validacion para usuario
            if (txtUser.Text == "leandro")
            {
                user = true;
            }

            //Validacion para pass
            if (txtPass.Text == "senha")
            {
                pass = true;

            }

            //si usuario incorrecto
            if (user.Equals(false) && pass)
            {
                MessageBox.Show("Usuario Incorrecto");
            }

            //si pass incorrecto
            if (user && pass.Equals(false))
            {
                MessageBox.Show("Contraseña incorrecta");
            }

            //Puede acceder
            if (user && pass)
            {
                //llamar pantalla principal
            }
            //················································································································································
            //verificacion en ddbb:
            if (user.Equals(false) || pass.Equals(false))
            {
                //cerrar programa
            }
            else
            {
                if (user && pass)
                {
                    //entrar programa
                }
                else
                {

                }
                //Verificar primero login
            }
        }
    }
}
