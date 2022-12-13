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
                _colorfons = value;

                panel1.BackColor = System.Drawing.ColorTranslator.FromHtml(value);

            }
        }
        private string _img;

        public string Imagen
        {
            get { return _img; }
            set
            {
                value = @"..\..\..\Img\icons\" + value;
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


        public SWLauchForm()
        {
            InitializeComponent();

        }

        public SWLauchForm(string colorFons, string imagen, string clase, string label, string form)
        {
            InitializeComponent();

            ColorFons = colorFons;
            Imagen = imagen;
            Clase = clase;
            Label = label;
            Form = form;

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

            dllBD = Activator.CreateInstance(tipus);

            //el mostrem assumint que es tracta d’un form

            // i per això fem un cast amb (Form)

            ((Form)dllBD).Show();
        }
    }
}
