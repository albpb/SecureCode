using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;


namespace SWLaunchForm
{
    public partial class SWLauchForm : UserControl
    {
        private string _colorfons;
        
        public string ColorFons
        {
            get {
                return _colorfons;
            }
            set { _colorfons = value; }
        }
        private string _img;

        public string Imagen
        {
            get { return _img; }
            set { _img = value; }
        }
        private string _clase;

        public string Clase
        {
            get { return _clase; }
            set { _clase = value; }
        }
        private string _form;

        public string Form
        {
            get { return _form; }
            set { _form = value; }
        }


        public SWLauchForm()
        {
            InitializeComponent();

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Assembly ensamblat =
            Assembly.LoadFrom(_clase+".dll");

            //Declarem les variables

            Object dllBD;

            Type tipus;

            //recuperem el tipus de la classe que volem instanciar

            tipus = ensamblat.GetType(_clase+"."+_form);

            //instanciem l’objecte

            dllBD = Activator.CreateInstance(tipus);

            //el mostrem assumint que es tracta d’un form

            // i per això fem un cast amb (Form)

            ((Form)dllBD).Show();
        }
    }
}
