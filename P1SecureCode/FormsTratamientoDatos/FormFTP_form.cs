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
            dgvSpecies.Columns["AccessLevel"].HeaderText = "Nivel de acceso";
            dgvSpecies.Columns[0].Visible = false;
        }
        private void BindingLaunchForm()
        {
            viewlabel.DataBindings.Add("Text", swTText, "Text");
        }

        private void FormFTP_form_Load(object sender, EventArgs e)
        {
            BindingLaunchForm();
        }

        private void swTImage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                img.Image = Image.FromFile(@"..\Img\icons\" + swTImage.Text);
            }
            catch (Exception)
            {

            }
        }

        private void swTColor_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromName(swTColor.Text.Trim());
        }
    }
}
