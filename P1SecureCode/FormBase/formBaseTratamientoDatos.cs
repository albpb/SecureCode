using ComponenteAccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CustomControls;

namespace FormBase
{
    public partial class formBaseTratamientoDatos : Form
    {
        public formBaseTratamientoDatos()
        {
            InitializeComponent();
        }

        claseAccesoDatos classe = new claseAccesoDatos();

        public string _NomTaula;
        

        public string NomTaula
        {
            get { return _NomTaula; }
            set
            {
                _NomTaula = value;
            }
        }

        bool EsNou = false;

        DataSet dts = new DataSet();

        public DataRow selectedRow;

        private void DataBindingsTextBoxs()
        {
            foreach (Control c in this.Controls)
            {
                if (c is CustomControls.SWTextbox)
                {
                    CustomControls.SWTextbox ctr = (CustomControls.SWTextbox)c;
                    ctr.DataBindings.Clear();
                    ctr.DataBindings.Add("Text", dts.Tables[0], ctr.DBName);

                }
            }
        }
       

        private void UnBindingTextBoxs()
        {
            foreach (Control c in this.Controls)
            {
                if (c is CustomControls.SWTextbox)
                {
                    CustomControls.SWTextbox ctr = (CustomControls.SWTextbox)c;
                    ctr.DataBindings.Clear();
                    ctr.Text = "";
                }
            }
        }

        private void formBaseTratamientoDatos_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            inicialitzar();

            ConfigurarDataGrid();
        }

        public virtual void ConfigurarDataGrid()
        {

        }

        private void btNou_Click(object sender, EventArgs e)
        {
            EsNou = true;

            UnBindingTextBoxs();
        }

        private void btActualitzar_Click(object sender, EventArgs e)
        {
            if (EsNou)
            {
                DataRow dr = dts.Tables[0].NewRow();

                foreach (Control c in this.Controls)
                {
                    if (c is CustomControls.SWTextbox)
                    {
                        CustomControls.SWTextbox ctr = (CustomControls.SWTextbox)c;
                        dr[ctr.DBName] = ctr.Text;
                    }
                }

                dts.Tables[0].Rows.Add(dr);

            }
            dts = classe.Actualitzar();

            inicialitzar();
            EsNou = false;

        }
        private void inicialitzar()
        {
            dts = classe.PortarTaula(NomTaula);

            DataBindingsTextBoxs();

            dgvSpecies.DataSource = dts.Tables[0];
        }

        private void dgvSpecies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)dgvSpecies.CurrentRow.DataBoundItem;
            selectedRow = currentDataRowView.Row;
        }
    }
}
