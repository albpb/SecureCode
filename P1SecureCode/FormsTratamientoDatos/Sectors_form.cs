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

        }
    }
}
