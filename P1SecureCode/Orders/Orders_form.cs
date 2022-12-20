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
namespace Orders
{
    public partial class Orders_form : formBaseTratamientoDatos
    {
        public Orders_form(string taula)
        {
            NomTaula = taula;
            InitializeComponent();
        }
        public override void ConfigurarDataGrid()
        {
            dgvSpecies.Columns[0].Visible = false;

        }
    }
}
