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
    public partial class Species_form : formBaseTratamientoDatos
    {
        
        public Species_form(string taula)
        {
            NomTaula = taula;
           
            InitializeComponent();
        }
        
        public override void ConfigurarDataGrid()
        {
            dgvSpecies.Columns[1].HeaderText = "Código";
            dgvSpecies.Columns[2].HeaderText = "Descripción";
            dgvSpecies.Columns[0].Visible = false;
        }

    }
}
