﻿using ComponenteAccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void DataBindingsTextBoxs()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.DataBindings.Clear();
                    c.DataBindings.Add("Text", dts.Tables[0], c.Tag.ToString());
                }
            }
        }

        public void UnBindingTextBoxs()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.DataBindings.Clear();
                    c.Text = "";
                }
            }
        }

        private void formBaseTratamientoDatos_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            dts = classe.PortarTaula(NomTaula);

            DataBindingsTextBoxs();

            dgvSpecies.DataSource = dts.Tables[0];
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
                    if (c is TextBox)
                    {
                        dr[c.Tag.ToString()] = c.Text;
                    }
                }

                dts.Tables[0].Rows.Add(dr);

                dts = classe.Actualitzar();

                dgvSpecies.DataSource = dts.Tables[0];
            }

            EsNou = false;
        }
    }
}