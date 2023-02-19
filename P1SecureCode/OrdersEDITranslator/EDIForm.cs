using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersEDITranslator
{
    public partial class EDIForm : Form
    {
        public EDIForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "EDI files (*.edi)|*.edi";
            openFileDialog.ShowDialog();

            directoryTB.Text = openFileDialog.FileName;
            writePreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EDITRanslator translator = new EDITRanslator(directoryTB.Text);

            translator.translateEDI();

            MessageBox.Show("S'han pujat les dades");
        }

        private void writePreview()
        {
            string text = "";
            foreach (string line in System.IO.File.ReadLines(directoryTB.Text))
            {
                text += line + Environment.NewLine;
            }
            TBEDIpreview.Text = text;
        }

    }
}
