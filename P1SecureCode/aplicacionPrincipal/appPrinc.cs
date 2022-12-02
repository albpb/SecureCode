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
    public partial class appPrinc : Form
    {
        public appPrinc()
        {
            InitializeComponent();
        }
        public appPrinc(string user, string nivel)
        {
            InitializeComponent();
            valorUserBBDD = user;
            valorNivelUser = nivel;
        }
        string valorUserBBDD, valorNivelUser;
        int valorNivelJedi, quantBnt;

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            valorNivelJedi = int.Parse(valorNivelUser.ToString());

            //Fecha actual
            string fechaActual = DateTime.Now.ToString("D");
            lblFecha.Text = fechaActual;
            lblNombreUsuario.Text = valorUserBBDD;

            if (valorNivelJedi == 1)
            {
                valorNivelJedi = 50;
                quantBnt = 5;
            } else if (valorNivelJedi == 2)
            {
                valorNivelJedi = 70;
                quantBnt = 7;
            }
            else if (valorNivelJedi == 3)
            {
                valorNivelJedi = 100;
                quantBnt = 10;
            }
            else if (valorNivelJedi == 4)
            {
                valorNivelJedi = 30;
                quantBnt = 3;
            }
            else
            {
                valorNivelJedi = 20;
                quantBnt = 2;
            }

            lblNv.Text = valorNivelJedi.ToString();

            //Tabla de botones
            for (int i = 0; i < quantBnt; i++)
            {
                Button bnt = new Button();

                flpnlMain.Controls.Add(bnt);
                bnt.BackColor = Color.White;
                bnt.Width = 80;
                bnt.Height = 50;
                //bnt.Click += (sender, e) =>
                //{
                //    txt_password.Text = txt_password.Text + bnt.Text;
                //};

            }
        }
    }
}
