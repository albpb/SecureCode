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
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            data.SaveChanges();
            orderList = data.Orders.ToList();
        }
    }
}
