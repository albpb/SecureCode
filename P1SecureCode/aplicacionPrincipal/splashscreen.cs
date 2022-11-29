using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionPrincipal
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }
        //Formulario de login
        frmLogin formularioLogin;
        private void timer1_Tick_1(object sender, EventArgs e) //despues de 10 segundos abrir otro formulario de login
        {
            pgbar.Increment(1);
            lblPorcentaje.Text = pgbar.Value.ToString() + "%";

            if (pgbar.Value == pgbar.Maximum)
            {
                timer1.Stop();
                this.Hide();
                formularioLogin = new frmLogin();
                formularioLogin.ShowDialog();
            }

        }

        private void splashscreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.O) //Funciona
            {
                timer1.Stop();
                this.Hide();
                formularioLogin = new frmLogin();
                formularioLogin.ShowDialog();
            }
        }
    }
}
