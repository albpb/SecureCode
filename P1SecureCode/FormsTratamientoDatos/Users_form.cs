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
    public partial class Users_form : formBaseTratamientoDatos
    {
        public Users_form(string table)
        {
            NomTaula = table;
            InitializeComponent();

        }

        public override void ConfigurarDataGrid()
        {
            dgvSpecies.Columns["CodeUser"].HeaderText = "Codi de l'usuari";
            dgvSpecies.Columns["UserName"].HeaderText = "Nom del usuari";
            dgvSpecies.Columns["Photo"].HeaderText = "Foto de perfil";

            dgvSpecies.Columns[0].Visible = false;
            dgvSpecies.Columns["idUserCategory"].Visible = false;
            dgvSpecies.Columns["idUserRank"].Visible = false;
            dgvSpecies.Columns["idPlanet"].Visible = false;
            dgvSpecies.Columns["idSpecie"].Visible = false;
            dgvSpecies.Columns["Salt"].Visible = false;
            dgvSpecies.Columns["Login"].Visible = false;
            dgvSpecies.Columns["Password"].Visible = false;
        }
    }
}
