
namespace ConsoleForms
{
    partial class FormUploud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1lb_infoBT2 = new System.Windows.Forms.Label();
            this.bt_BuscarArxiu = new System.Windows.Forms.Button();
            this.btModificarDatosXML = new System.Windows.Forms.Button();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbUsuarioFTP = new System.Windows.Forms.Label();
            this.tbUsuarioFTP = new System.Windows.Forms.TextBox();
            this.lbPasswordFTP = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lbCarpeta = new System.Windows.Forms.Label();
            this.tbCarpeta = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TBroute = new System.Windows.Forms.TextBox();
            this.lb_Informatiu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_VisualitzarDades = new System.Windows.Forms.PictureBox();
            this.btCarregarDadesBD = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_VisualitzarDades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCarregarDadesBD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1lb_infoBT2
            // 
            this.label1lb_infoBT2.AutoSize = true;
            this.label1lb_infoBT2.Location = new System.Drawing.Point(233, 206);
            this.label1lb_infoBT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1lb_infoBT2.Name = "label1lb_infoBT2";
            this.label1lb_infoBT2.Size = new System.Drawing.Size(52, 13);
            this.label1lb_infoBT2.TabIndex = 10;
            this.label1lb_infoBT2.Text = "Ver datos";
            // 
            // bt_BuscarArxiu
            // 
            this.bt_BuscarArxiu.Location = new System.Drawing.Point(365, 42);
            this.bt_BuscarArxiu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt_BuscarArxiu.Name = "bt_BuscarArxiu";
            this.bt_BuscarArxiu.Size = new System.Drawing.Size(34, 20);
            this.bt_BuscarArxiu.TabIndex = 6;
            this.bt_BuscarArxiu.Text = "...";
            this.bt_BuscarArxiu.UseVisualStyleBackColor = true;
            this.bt_BuscarArxiu.Click += new System.EventHandler(this.bt_BuscarArxiu_Click);
            // 
            // btModificarDatosXML
            // 
            this.btModificarDatosXML.BackColor = System.Drawing.Color.Ivory;
            this.btModificarDatosXML.Location = new System.Drawing.Point(520, 381);
            this.btModificarDatosXML.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btModificarDatosXML.Name = "btModificarDatosXML";
            this.btModificarDatosXML.Size = new System.Drawing.Size(129, 40);
            this.btModificarDatosXML.TabIndex = 13;
            this.btModificarDatosXML.Text = "Modificar Credenciales";
            this.btModificarDatosXML.UseVisualStyleBackColor = false;
            this.btModificarDatosXML.Click += new System.EventHandler(this.btModificarDatosXML_Click);
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(520, 227);
            this.tb_IP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(129, 20);
            this.tb_IP.TabIndex = 14;
            this.tb_IP.Validating += new System.ComponentModel.CancelEventHandler(this.tb_IP_Validating_1);
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(539, 206);
            this.lbIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(82, 13);
            this.lbIP.TabIndex = 15;
            this.lbIP.Text = "IP Servidor FTP";
            // 
            // lbUsuarioFTP
            // 
            this.lbUsuarioFTP.AutoSize = true;
            this.lbUsuarioFTP.Location = new System.Drawing.Point(558, 253);
            this.lbUsuarioFTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsuarioFTP.Name = "lbUsuarioFTP";
            this.lbUsuarioFTP.Size = new System.Drawing.Size(43, 13);
            this.lbUsuarioFTP.TabIndex = 16;
            this.lbUsuarioFTP.Text = "Usuario";
            // 
            // tbUsuarioFTP
            // 
            this.tbUsuarioFTP.Location = new System.Drawing.Point(527, 269);
            this.tbUsuarioFTP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbUsuarioFTP.Name = "tbUsuarioFTP";
            this.tbUsuarioFTP.Size = new System.Drawing.Size(114, 20);
            this.tbUsuarioFTP.TabIndex = 17;
            this.tbUsuarioFTP.Validating += new System.ComponentModel.CancelEventHandler(this.tb_IP_Validating_1);
            // 
            // lbPasswordFTP
            // 
            this.lbPasswordFTP.AutoSize = true;
            this.lbPasswordFTP.Location = new System.Drawing.Point(551, 296);
            this.lbPasswordFTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPasswordFTP.Name = "lbPasswordFTP";
            this.lbPasswordFTP.Size = new System.Drawing.Size(61, 13);
            this.lbPasswordFTP.TabIndex = 18;
            this.lbPasswordFTP.Text = "Contraseña";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(527, 314);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(114, 20);
            this.tbContraseña.TabIndex = 19;
            this.tbContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.tb_IP_Validating_1);
            // 
            // lbCarpeta
            // 
            this.lbCarpeta.AutoSize = true;
            this.lbCarpeta.Location = new System.Drawing.Point(535, 339);
            this.lbCarpeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCarpeta.Name = "lbCarpeta";
            this.lbCarpeta.Size = new System.Drawing.Size(106, 13);
            this.lbCarpeta.TabIndex = 20;
            this.lbCarpeta.Text = "Carpeta de descarga";
            // 
            // tbCarpeta
            // 
            this.tbCarpeta.Location = new System.Drawing.Point(510, 355);
            this.tbCarpeta.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbCarpeta.Name = "tbCarpeta";
            this.tbCarpeta.Size = new System.Drawing.Size(154, 20);
            this.tbCarpeta.TabIndex = 21;
            this.tbCarpeta.Validating += new System.ComponentModel.CancelEventHandler(this.tb_IP_Validating_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 450;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkRate = 450;
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.BlinkRate = 450;
            this.errorProvider3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.BlinkRate = 450;
            this.errorProvider4.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider4.ContainerControl = this;
            // 
            // TBroute
            // 
            this.TBroute.Enabled = false;
            this.TBroute.Location = new System.Drawing.Point(27, 42);
            this.TBroute.Name = "TBroute";
            this.TBroute.Size = new System.Drawing.Size(333, 20);
            this.TBroute.TabIndex = 22;
            // 
            // lb_Informatiu
            // 
            this.lb_Informatiu.AutoSize = true;
            this.lb_Informatiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Informatiu.Location = new System.Drawing.Point(23, 96);
            this.lb_Informatiu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Informatiu.Name = "lb_Informatiu";
            this.lb_Informatiu.Size = new System.Drawing.Size(133, 24);
            this.lb_Informatiu.TabIndex = 24;
            this.lb_Informatiu.Text = "Subir archivo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsoleForms.Properties.Resources.credentials_icon;
            this.pictureBox1.Location = new System.Drawing.Point(473, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // bt_VisualitzarDades
            // 
            this.bt_VisualitzarDades.Image = global::ConsoleForms.Properties.Resources.look_icon;
            this.bt_VisualitzarDades.Location = new System.Drawing.Point(231, 123);
            this.bt_VisualitzarDades.Name = "bt_VisualitzarDades";
            this.bt_VisualitzarDades.Size = new System.Drawing.Size(87, 77);
            this.bt_VisualitzarDades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_VisualitzarDades.TabIndex = 25;
            this.bt_VisualitzarDades.TabStop = false;
            this.bt_VisualitzarDades.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btCarregarDadesBD
            // 
            this.btCarregarDadesBD.Image = global::ConsoleForms.Properties.Resources.uploud_icon;
            this.btCarregarDadesBD.Location = new System.Drawing.Point(27, 123);
            this.btCarregarDadesBD.Name = "btCarregarDadesBD";
            this.btCarregarDadesBD.Size = new System.Drawing.Size(198, 190);
            this.btCarregarDadesBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btCarregarDadesBD.TabIndex = 23;
            this.btCarregarDadesBD.TabStop = false;
            this.btCarregarDadesBD.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormUploud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(733, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_VisualitzarDades);
            this.Controls.Add(this.lb_Informatiu);
            this.Controls.Add(this.btCarregarDadesBD);
            this.Controls.Add(this.TBroute);
            this.Controls.Add(this.tbCarpeta);
            this.Controls.Add(this.lbCarpeta);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.lbPasswordFTP);
            this.Controls.Add(this.tbUsuarioFTP);
            this.Controls.Add(this.lbUsuarioFTP);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.btModificarDatosXML);
            this.Controls.Add(this.label1lb_infoBT2);
            this.Controls.Add(this.bt_BuscarArxiu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormUploud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subir archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SubirFicherosFTP_FormClosing);
            this.Load += new System.EventHandler(this.Form_SubirFicherosFTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_VisualitzarDades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCarregarDadesBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1lb_infoBT2;
        private System.Windows.Forms.Button bt_BuscarArxiu;
        private System.Windows.Forms.Button btModificarDatosXML;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbUsuarioFTP;
        private System.Windows.Forms.TextBox tbUsuarioFTP;
        private System.Windows.Forms.Label lbPasswordFTP;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label lbCarpeta;
        private System.Windows.Forms.TextBox tbCarpeta;
        public System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.TextBox TBroute;
        private System.Windows.Forms.PictureBox btCarregarDadesBD;
        private System.Windows.Forms.Label lb_Informatiu;
        private System.Windows.Forms.PictureBox bt_VisualitzarDades;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}