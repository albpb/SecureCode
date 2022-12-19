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

namespace UsersCat
{
    public partial class UserCat_form : formBaseTratamientoDatos
    {
        public UserCat_form(string taula)
        {
            NomTaula = taula;
            InitializeComponent();
        }
        public override void ConfigurarDataGrid()
        {
            dgvSpecies.Columns[1].HeaderText = "Codi Categoria";
            dgvSpecies.Columns[2].HeaderText = "Descripció Categoria";
            dgvSpecies.Columns[3].HeaderText = "Nivell Accés";
            dgvSpecies.Columns[0].Visible = false;
        }
    }
}
