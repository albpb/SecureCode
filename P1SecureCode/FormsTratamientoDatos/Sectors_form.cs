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
    public partial class Sectors_form : formBaseTratamientoDatos
    {
        public Sectors_form(string table)
        {
            NomTaula = table;
            InitializeComponent();
        }

        public override void ConfigurarDataGrid()
        {
            dgvSpecies.Columns["CodeSector"].HeaderText = "Codi del sector";
            dgvSpecies.Columns["DescSector"].HeaderText = "Descripció";
            dgvSpecies.Columns["Remarks"].HeaderText = "Nota";

            dgvSpecies.Columns[0].Visible = false;
            dgvSpecies.Columns["idRegion"].Visible = false;

        }
    }
}
