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

using System.IO;
using System.Collections;


namespace CustomControls
{
    public partial class SWLauchForm : UserControl
    {
        private string _colorfons;

        public string ColorFons
        {
            get
            {
                return _colorfons;
            }
            set
            {
                value = value.Trim();
                _colorfons = value;

                panel1.BackColor = Color.FromName(value);

            }
        }
        private string _img;

        public string Imagen
        {
            get { return _img; }
            set
            {
                if (DesignMode) return;
                // si intentamos coger el directorio de la base de datos, las barras (/) se bugean y por tanto decidi hacerlo así
                // pero tambien esto da problemas en el FormFTP
                value = @"..\Img\icons\" + value;
                _img = value;

                img.Image = Image.FromFile(value);

            }
        }
        private string _clase;

        public string Clase
        {
            get { return _clase; }
            set { _clase = value; }
        }


        private string _text;

        public string Label
        {
            get { return _text; }
            set
            {
                _text = value;
                label1.Text = value;
            }
        }


        private string _form;

        public string Form
        {
            get { return _form; }
            set { _form = value; }
        }

        private string _taula;

        public string Taula
        {
            get { return _taula; }
            set { _taula = value; }
        }

        public SWLauchForm()
        {
            InitializeComponent();

        }

        public SWLauchForm(string colorFons, string imagen, string clase, string label, string form, string taula)
        {
            InitializeComponent();

            ColorFons = colorFons;
            Imagen = imagen;
            Clase = clase;
            Label = label;
            Form = form;
            Taula = taula;

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Assembly ensamblat =
            Assembly.LoadFrom(_clase);

            //Declarem les variables

            Object dllBD;

            Type tipus;

            //recuperem el tipus de la classe que volem instanciar

            // form tiene que tener el formato Clase.Form
            tipus = ensamblat.GetType(_form);

            //instanciem l’objecte

            Object[] args = { _taula };
            dllBD = Activator.CreateInstance(tipus, args);

            //el mostrem assumint que es tracta d’un form

            // i per això fem un cast amb (Form)

            ((Form)dllBD).Show();
        }
    }
}
