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
        
        private void bntLogin_Click(object sender, EventArgs e)
        {
            //Contraseña Inicial
            if (txtPass.Text == "12345aA")
            {
                //Abrir form de actualizacion de password
            }
            else
            {
                //Abrir form de app principal
            }

        }
    }
}
