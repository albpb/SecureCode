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
using System.Security.Cryptography;
using aplicacionPrincipal;

namespace aplicacionPrincipal
{
    public partial class attCredenciales : Form
    {
        public attCredenciales()
        {
            InitializeComponent();
        }
        public attCredenciales(string user)
        {
            InitializeComponent();
            valorUserBBDD = user;
        }

        claseAccesoDatos ddbb = new claseAccesoDatos();
        DataSet dts = new DataSet();
        Random rdm = new Random();
        string valorUserBBDD;

        string valorPassBBDD, valorSalBBDD, salAH;

        private void attCredenciales_Load(object sender, EventArgs e)
        {
            lblValorUser.Text =  valorUserBBDD;
        }

        string querry = "select Login, Password, Salt from Users where 1=1 and Login = '";
        int salBH;

        private void button1_Click(object sender, EventArgs e)
        {
            //coger el user y pass del form pasado
            querry = querry + txtPass.Text.ToString() + "'";

            dts = ddbb.PortarTaula(querry);

            //para identificar el usuario que va cambiar la contraseña
            //valorUserBBDD = dts.Tables[0].Rows[0]["Login"].ToString();
            //contraseña para cambiar
            valorPassBBDD = dts.Tables[0].Rows[0]["Password"].ToString();
            //sal para añadir a la base de datos
            valorSalBBDD = dts.Tables[0].Rows[0]["Salt"].ToString();

            //HASHEAR Sal
            salBH = rdm.Next(0, 100);
            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(salBH.ToString()));
                string strHash = BitConverter.ToString(hashedBytes);
                salAH = strHash;
            }
            //guardar salAH na BBDD

            //HASHEAR Pass
            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(valorPassBBDD + salBH.ToString()));
                string strHash = BitConverter.ToString(hashedBytes);
                valorPassBBDD = strHash;
            }
            //guardar Senha na BBDD

            ddbb.Actualitzar();
        }
    }
}
