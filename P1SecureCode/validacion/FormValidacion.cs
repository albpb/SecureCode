using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ComponenteAccesoDatos;
//using actualizacionPass;

namespace validacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //claseAccesoDatos funcionesDDBB = new claseAccesoDatos();
        
        private void bntLogin_Click(object sender, EventArgs e)
        {
            //Contraseña Inicial
            if (txtPass.Text == "12345aA")
            {
                this.Hide();
                Form Form1 = new Form();
                Form1.ShowDialog();
            }
            else
            {
                //Abrir form de app principal
            }

        }
    }
}
