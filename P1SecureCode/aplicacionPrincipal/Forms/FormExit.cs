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
        private string userName, valorPoder;

        public FormExit(string _user, string _poder)
        {
            userName = _user;
            valorPoder = _poder;
            InitializeComponent();
        }
        private void FormExit_Load(object sender, EventArgs e)
        {
            //lblUser.Text = Forms.lblNombreUsuario.Text;
            lblUser.Text = userName;
            lblNv.Text = valorPoder;

            //lblNv.Text = valorNivelJedi.ToString();
        }
    }

   
}
