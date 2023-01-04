using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionPrincipal.Forms
{
    public partial class FormExit : Form
    {
        public FormExit()
        {
            InitializeComponent();
        }

        int valorNivelJedi;
        string valorUserBBDD, valorNivelUser;
        private void FormExit_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = valorUserBBDD;

            lblNv.Text = valorNivelJedi.ToString();
        }
    }

   
}
