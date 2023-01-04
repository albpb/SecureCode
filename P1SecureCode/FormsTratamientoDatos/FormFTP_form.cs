using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormBase;

namespace FormsTratamientoDatos
{
    public partial class FormFTP_form : formBaseTratamientoDatos
    {
        public FormFTP_form(string taula)
        {
            NomTaula = taula;
            InitializeComponent();
            
        }

        public override void ConfigurarDataGrid()
        {
            dgvSpecies.Columns["AccessLevel"].HeaderText = "Nivell Accés";
            dgvSpecies.Columns[0].Visible = false;
        }
        private void BindingLaunchForm()
        {
            swLauchForm1.DataBindings.Add("Label", swTText, "Text");
            swLauchForm1.DataBindings.Add("ColorFons", swTColor, "Text");
        }

        private void FormFTP_form_Load(object sender, EventArgs e)
        {
            BindingLaunchForm();
        }

        private void swTImage_Validated(object sender, EventArgs e)
        {
            try
            {
                swLauchForm1.Imagen = swTImage.Text;
            }
            catch (Exception)
            {
                swLauchForm1.Imagen = "form_test.png";
                MessageBox.Show("Imagen no encontrada");
            }
        }

    }
}
