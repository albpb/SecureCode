using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using validacion;

namespace splash
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
    }
}
