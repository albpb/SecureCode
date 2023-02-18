using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ConsoleForms
{
    public partial class FormUploud : Form
    {
        public FormUploud()
        {
            InitializeComponent();
        }
        string fileContent = string.Empty;
        string filePath = string.Empty;
        private void bt_BuscarArxiu_Click(object sender, EventArgs e)
        {
            filePath = string.Empty;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "edi files (*.edi)|*.edi";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }

                if (filePath != "")
                {
                    bt_VisualitzarDades.Enabled = true;
                    btCarregarDadesBD.Enabled = true;
                    bt_BuscarArxiu.BackColor = Color.Green;
                }
                else
                {
                    bt_BuscarArxiu.BackColor = Color.Red;
                    bt_VisualitzarDades.Enabled = false;
                    btCarregarDadesBD.Enabled = false;
                    //Array.Clear(info, 0, info.Length);
                }
            }

            lb_RutaArxiu.Text = filePath;
        }

        private void bt_VisualitzarDades_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fileContent);
        }

        private void btCarregarDadesBD_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(filePath);

            try
            {
                string filePath2 = "Recursos/credencialsFTP.xml";

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ConformanceLevel = ConformanceLevel.Document;
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;
                settings.DtdProcessing = DtdProcessing.Ignore;

                XmlReader reader = XmlReader.Create(filePath2, settings);
                reader.ReadToFollowing("ip");
                string ipFTP = reader.ReadElementContentAsString();
                reader.ReadToFollowing("username");
                string usernameFTP = reader.ReadElementContentAsString();
                reader.Close();

                XmlReader reader2 = XmlReader.Create(filePath2, settings);
                reader2.ReadToFollowing("password");
                string passwordFTP = reader2.ReadElementContentAsString();
                reader2.Close();

                if (passwordFTP == "" || ipFTP == "" || usernameFTP == "")
                {
                    throw new Exception("No es pot conectar al servidor FTP perque les dades no son correctes.");
                }
                else
                {
                    FtpWebRequest ftpRequest2;
                    ftpRequest2 = (FtpWebRequest)WebRequest.Create("ftp://" + ipFTP + "/" + fileName);
                    ftpRequest2.Credentials = new NetworkCredential(usernameFTP, passwordFTP);
                    ftpRequest2.Method = WebRequestMethods.Ftp.UploadFile;

                    byte[] content = File.ReadAllBytes(filePath);
                    ftpRequest2.ContentLength = content.Length;
                    Stream stream = ftpRequest2.GetRequestStream();
                    stream.Write(content, 0, content.Length);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Proceso Finalizado");
            bt_VisualitzarDades.Enabled = false;
            btCarregarDadesBD.Enabled = false;
        }

        private void Form_SubirFicherosFTP_Load(object sender, EventArgs e)
        {
            bt_VisualitzarDades.Enabled = false;
            btCarregarDadesBD.Enabled = false;
        }

        private void Form_SubirFicherosFTP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btModificarDatosXML_Click(object sender, EventArgs e)
        {
            string filePath3 = "Recursos/credencialsFTP.xml";

            string textIP, textUsuario, textPassword, textCarpeta;

            textIP = "";
            textCarpeta = "";
            textPassword = "";
            textUsuario = "";

            //Configuracio XMLReader
            XmlReaderSettings settings2 = new XmlReaderSettings();
            settings2.ConformanceLevel = ConformanceLevel.Document;
            settings2.IgnoreWhitespace = true;
            settings2.IgnoreComments = true;
            settings2.DtdProcessing = DtdProcessing.Ignore;

            //Leemos los campos que nos interesan y guardamos sus valores en unas variables
            using (XmlReader reader = XmlReader.Create(filePath3, settings2))
            {
                reader.ReadToFollowing("ip");
                textIP = reader.ReadElementContentAsString();
                reader.ReadToFollowing("username");
                textUsuario = reader.ReadElementContentAsString();
                reader.Close();
            }

            //Utilizamos un segundo reader porque con el primero peta al leer mas de dos campos
            using (XmlReader reader2 = XmlReader.Create(filePath3, settings2))
            {
                reader2.ReadToFollowing("password");
                textPassword = reader2.ReadElementContentAsString();
                reader2.ReadToFollowing("rutaCarpeta");
                textCarpeta = reader2.ReadElementContentAsString();
                reader2.Close();
            }

            //En este if, else if, en caso de que algun textbox no este vacio cambiara el valor de la varible por el del textbox
            if (tb_IP.Text != null)
            {
                textIP = tb_IP.Text;
            }
            else if (tbUsuarioFTP.Text != null)
            {
                textUsuario = tbUsuarioFTP.Text;
            }
            else if (tbContraseña.Text != null)
            {
                textPassword = tbContraseña.Text;
            }
            else if (tbCarpeta.Text != null)
            {
                textCarpeta = tbCarpeta.Text;
            }

            //Configuracion XMLWriter
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            //Usamos el XMLWriter para creear el archivo entero ya que no permite modifcar cada elemento de manera individual
            //y añadimos cada variable a su elmento
            using (FileStream writer = new FileStream(@"Recursos/credencialsFTP.xml", FileMode.OpenOrCreate))
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(writer, settings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("FTP");
                    xmlWriter.WriteElementString("ip", textIP);
                    xmlWriter.WriteStartElement("credentials");
                    xmlWriter.WriteElementString("username", textUsuario);
                    xmlWriter.WriteElementString("password", textPassword);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteElementString("rutaCarpeta", textCarpeta);

                    xmlWriter.WriteEndDocument();
                    xmlWriter.Close();

                    writer.Flush();
                }
            }
        }

        private void tb_IP_Validating_1(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;

            errorProvider1.SetError(txt, null);
            errorProvider2.SetError(txt, null);
            errorProvider3.SetError(txt, null);
            errorProvider4.SetError(txt, null);

            if (txt.Text.Contains(" "))
            {
                errorProvider1.SetError(txt, "No puede contener espacios en blanco");
                errorProvider2.SetError(txt, "No puede contener espacios en blanco");
                errorProvider3.SetError(txt, "No puede contener espacios en blanco");
                errorProvider4.SetError(txt, "No puede contener espacios en blanco");
                btModificarDatosXML.Enabled = false;
            }
            else
            {
                btModificarDatosXML.Enabled = true;
            }
        }
    }
}
