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
    public partial class formTaulaForanea_Users : formBaseTratamientoDatos
    {
        public formTaulaForanea_Users()
        {
            InitializeComponent();
        }

        public override void ConfigurarDataGrid()
        {
            dgvSpecies.Columns[1].HeaderText = "Code User";
            dgvSpecies.Columns[2].HeaderText = "Name User";
            dgvSpecies.Columns[0].Visible = false;
            dgvSpecies.Columns[3].Visible = false;
            dgvSpecies.Columns[4].Visible = false;
            dgvSpecies.Columns[10].Visible = false;
        }
    }
}
