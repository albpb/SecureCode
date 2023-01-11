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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;
using System.Data.SqlClient;

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

        private void Users_form_Load(object sender, EventArgs e)
        {
            crystalReportViewer.Visible = false;
        }

        private void bt_ActualizarTarjetaIdentificación_Click(object sender, EventArgs e)
        {
            crystalReportViewer.Visible = true;
            //crystalReportViewer.ReportSource = Environment.CurrentDirectory + "\\UserReport.rpt";
            //

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("UserReport.rpt");

            crystalReportViewer.ReportSource = cryRpt;
            crystalReportViewer.Refresh();

            //
            // Lo de abajo no funciona, estamos en pruebas, no tocar lo de arriba.
            //

            string cnx = "";
            ConnectionStringSettings conf2 = ConfigurationManager.ConnectionStrings["aplicacionPrincipal.Properties.Settings.SecureCoreG4ConnectionString"];

            if (conf2 != null)
            {
                cnx = conf2.ConnectionString;
            }

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cnx);
            string server = builder.DataSource;
            string database = builder.InitialCatalog;
            string user = builder.UserID;
            string passwd = builder.Password;

            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            crConnectionInfo.ServerName = server;
            crConnectionInfo.DatabaseName = database;
            crConnectionInfo.UserID = user;
            crConnectionInfo.Password = passwd;

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            Tables CrTables = cryRpt.Database.Tables;
            foreach (Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            //Para enviar a la impresora, en caso de que la tuviésemos configurada.
            //cryRpt.PrintOptions.PrinterName = "";
            //cryRpt.PrintToPrinter(1, false, 0, 0);
        }
    }
}
