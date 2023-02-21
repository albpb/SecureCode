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
    public partial class FactoryForm : Form
    {
        public FactoryForm()
        {
            InitializeComponent();
        }
        FormsEntities data;
        List<Factories> factoriesList;
        bool isNew = false;

        private void LoadData()
        {
            data = new FormsEntities();

            factoriesList = data.Factories.ToList();

            DGVFactories.DataSource = factoriesList;


            DGVFactories.Columns["codeFactory"].HeaderText = "Código";
            DGVFactories.Columns["DescFactory"].HeaderText = "Descripción";

            DGVFactories.Columns[0].Visible = false;
            DGVFactories.Columns["Orders"].Visible = false;

            BindData();
        }

        private void BindData()
        {
            TBCodi.DataBindings.Clear();
            TBCodi.DataBindings.Add("Text", factoriesList, TBCodi.Tag.ToString());

            TBDesc.DataBindings.Clear();
            TBDesc.DataBindings.Add("Text", factoriesList, TBDesc.Tag.ToString());
        }

        private void BindRemoval()
        {
            TBCodi.DataBindings.Clear();
            TBCodi.Clear();
            TBCodi.Text = "";

            TBDesc.DataBindings.Clear();
            TBDesc.Clear();
            TBDesc.Text = "";
        }

        private void Factories_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                Factories factory = new Factories
                {
                    codeFactory = TBCodi.Text,
                    DescFactory = TBDesc.Text
                };
                data.Factories.Add(factory);
                isNew = false;
            }

            data.SaveChanges();

            LoadData();
        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            BindRemoval();
        }
    }
}
