using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkForms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        FormsEntities data;
        List<Orders> orderList;
        List<Factories> factoryList;
        List<Priority> priorityList;

        private void LoadData()
        {
            data = new FormsEntities();

            orderList = data.Orders.ToList();
            factoryList = data.Factories.ToList();
            priorityList = data.Priority.ToList();
            

            DGVFactories.DataSource = orderList;
            DGVFactories.Columns[0].Visible = false;

            DGVFactories.Columns["codeOrder"].HeaderText = "Código";
            DGVFactories.Columns["dateOrder"].HeaderText = "Fecha";

            DGVFactories.Columns["idPriority"].Visible = false;
            DGVFactories.Columns["idFactory"].Visible = false;
            DGVFactories.Columns["Factories"].Visible = false;
            DGVFactories.Columns["Priority"].Visible = false;


            BindData();
        }

        private void BindData()
        {
            TBCodi.Clear();
            TBCodi.DataBindings.Add("Text", orderList, TBCodi.Tag.ToString());

            TBDesc.Clear();
            TBDesc.DataBindings.Add("Text", orderList, TBDesc.Tag.ToString());

            TB_id.Clear();
            TB_id.DataBindings.Add("Text", orderList, TB_id.Tag.ToString());

            CBFactory.SelectionLength = 0;

            CBFactory.DataSource = factoryList;
            CBFactory.DisplayMember = "descFactory";
            CBFactory.ValueMember = "idFactory";

            CBFactory.DataBindings.Add("SelectedValue", orderList, "idFactory");

            CBPriority.DataSource = priorityList;
            CBPriority.DisplayMember = "descPriority";
            CBPriority.ValueMember = "idPriority";

            CBPriority.DataBindings.Add("SelectedValue", orderList, "idPriority");

        }

        private void Factories_Load(object sender, EventArgs e)
        {
            LoadData();
            crystalReportViewer.Visible = false;
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            data.SaveChanges();

            orderList = data.Orders.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = TB_id.Text;
            crystalReportViewer.Visible = true;

            ReportDocument cryRpt = new ReportDocument();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            crConnectionInfo.ServerName = "sqlserver.S2AM.sdslab.cat";
            crConnectionInfo.DatabaseName = "secureCoreG4";
            crConnectionInfo.UserID = "G4";
            crConnectionInfo.Password = "12345aAG4";

            cryRpt.Load("Recursos/CrystalReport1.rpt");

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            Tables CrTables = cryRpt.Database.Tables;
            foreach (Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            cryRpt.RecordSelectionFormula = "{Orders.idOrder} = " + valor;
            crystalReportViewer.ReportSource = cryRpt;
            crystalReportViewer.Refresh();
        }
    }
}
