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
    public partial class formTaulaSimple_Species : formBaseTratamientoDatos
    {
        
        public formTaulaSimple_Species(string taula)
        {
            NomTaula = taula;
            InitializeComponent();
        }
        
        public override void ConfigurarDataGrid()
        {
            dgvSpecies.Columns[1].HeaderText = "Codi Especie";
            dgvSpecies.Columns[2].HeaderText = "Descripció Especie";
            dgvSpecies.Columns[0].Visible = false;
        }

        private void formTaulaSimple_Species_Load(object sender, EventArgs e)
        {
            ConfigurarDataGrid();
        }
    }
}
