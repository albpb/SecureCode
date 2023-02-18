
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
            this.lb_infoBT3 = new System.Windows.Forms.Label();
            this.label1lb_infoBT2 = new System.Windows.Forms.Label();
            this.lb_infoBT1 = new System.Windows.Forms.Label();
            this.btCarregarDadesBD = new System.Windows.Forms.Button();
            this.bt_VisualitzarDades = new System.Windows.Forms.Button();
            this.bt_BuscarArxiu = new System.Windows.Forms.Button();
            this.lb_RutaArxiu = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_infoBT3
            // 
            this.lb_infoBT3.AutoSize = true;
            this.lb_infoBT3.Location = new System.Drawing.Point(313, 410);
            this.lb_infoBT3.Name = "lb_infoBT3";
            this.lb_infoBT3.Size = new System.Drawing.Size(361, 20);
            this.lb_infoBT3.TabIndex = 11;
            this.lb_infoBT3.Text = "Clicar al boton para subir el archivo al servidor FTP";
            // 
            // label1lb_infoBT2
            // 
            this.label1lb_infoBT2.AutoSize = true;
            this.label1lb_infoBT2.Location = new System.Drawing.Point(313, 232);
            this.label1lb_infoBT2.Name = "label1lb_infoBT2";
            this.label1lb_infoBT2.Size = new System.Drawing.Size(548, 20);
            this.label1lb_infoBT2.TabIndex = 10;
            this.label1lb_infoBT2.Text = "Clicar al boton para visualizar los datos del archivo previamente seleccionado";
            // 
            // lb_infoBT1
            // 
            this.lb_infoBT1.AutoSize = true;
            this.lb_infoBT1.Location = new System.Drawing.Point(313, 64);
            this.lb_infoBT1.Name = "lb_infoBT1";
            this.lb_infoBT1.Size = new System.Drawing.Size(412, 20);
            this.lb_infoBT1.TabIndex = 9;
            this.lb_infoBT1.Text = "Clicar en el boton para buscar archivos con extension .edi";
            // 
            // btCarregarDadesBD
            // 
            this.btCarregarDadesBD.Location = new System.Drawing.Point(97, 364);
            this.btCarregarDadesBD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCarregarDadesBD.Name = "btCarregarDadesBD";
            this.btCarregarDadesBD.Size = new System.Drawing.Size(182, 112);
            this.btCarregarDadesBD.TabIndex = 8;
            this.btCarregarDadesBD.Text = "Subir archivo en el servidor FTP";
            this.btCarregarDadesBD.UseVisualStyleBackColor = true;
            this.btCarregarDadesBD.Click += new System.EventHandler(this.btCarregarDadesBD_Click);
            // 
            // bt_VisualitzarDades
            // 
            this.bt_VisualitzarDades.Location = new System.Drawing.Point(97, 186);
            this.bt_VisualitzarDades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_VisualitzarDades.Name = "bt_VisualitzarDades";
            this.bt_VisualitzarDades.Size = new System.Drawing.Size(182, 112);
            this.bt_VisualitzarDades.TabIndex = 7;
            this.bt_VisualitzarDades.Text = "Visualizar Datos Archivo";
            this.bt_VisualitzarDades.UseVisualStyleBackColor = true;
            this.bt_VisualitzarDades.Click += new System.EventHandler(this.bt_VisualitzarDades_Click);
            // 
            // bt_BuscarArxiu
            // 
            this.bt_BuscarArxiu.Location = new System.Drawing.Point(97, 18);
            this.bt_BuscarArxiu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_BuscarArxiu.Name = "bt_BuscarArxiu";
            this.bt_BuscarArxiu.Size = new System.Drawing.Size(182, 112);
            this.bt_BuscarArxiu.TabIndex = 6;
            this.bt_BuscarArxiu.Text = "Buscar Archivo";
            this.bt_BuscarArxiu.UseVisualStyleBackColor = true;
            this.bt_BuscarArxiu.Click += new System.EventHandler(this.bt_BuscarArxiu_Click);
            // 
            // lb_RutaArxiu
            // 
            this.lb_RutaArxiu.AutoSize = true;
            this.lb_RutaArxiu.Location = new System.Drawing.Point(317, 109);
            this.lb_RutaArxiu.Name = "lb_RutaArxiu";
            this.lb_RutaArxiu.Size = new System.Drawing.Size(0, 20);
            this.lb_RutaArxiu.TabIndex = 12;
            // 
            // btModificarDatosXML
            // 
            this.btModificarDatosXML.Location = new System.Drawing.Point(97, 508);
            this.btModificarDatosXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btModificarDatosXML.Name = "btModificarDatosXML";
            this.btModificarDatosXML.Size = new System.Drawing.Size(112, 62);
            this.btModificarDatosXML.TabIndex = 13;
            this.btModificarDatosXML.Text = "Modificar Datos XML";
            this.btModificarDatosXML.UseVisualStyleBackColor = true;
            this.btModificarDatosXML.Click += new System.EventHandler(this.btModificarDatosXML_Click);
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(226, 581);
            this.tb_IP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(169, 26);
            this.tb_IP.TabIndex = 14;
            this.tb_IP.Validating += new System.ComponentModel.CancelEventHandler(this.tb_IP_Validating_1);
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(97, 584);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(123, 20);
            this.lbIP.TabIndex = 15;
            this.lbIP.Text = "IP Servidor FTP:";
            // 
            // lbUsuarioFTP
            // 
            this.lbUsuarioFTP.AutoSize = true;
            this.lbUsuarioFTP.Location = new System.Drawing.Point(97, 622);
            this.lbUsuarioFTP.Name = "lbUsuarioFTP";
            this.lbUsuarioFTP.Size = new System.Drawing.Size(163, 20);
            this.lbUsuarioFTP.TabIndex = 16;
            this.lbUsuarioFTP.Text = "Usuario Servidor FTP:";
            // 
            // tbUsuarioFTP
            // 
            this.tbUsuarioFTP.Location = new System.Drawing.Point(266, 622);
            this.tbUsuarioFTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsuarioFTP.Name = "tbUsuarioFTP";
            this.tbUsuarioFTP.Size = new System.Drawing.Size(169, 26);
            this.tbUsuarioFTP.TabIndex = 17;
            this.tbUsuarioFTP.Validating += new System.ComponentModel.CancelEventHandler(this.tb_IP_Validating_1);
            // 
            // lbPasswordFTP
            // 
            this.lbPasswordFTP.AutoSize = true;
            this.lbPasswordFTP.Location = new System.Drawing.Point(461, 581);
            this.lbPasswordFTP.Name = "lbPasswordFTP";
            this.lbPasswordFTP.Size = new System.Drawing.Size(191, 20);
            this.lbPasswordFTP.TabIndex = 18;
            this.lbPasswordFTP.Text = "Contraseña Servidor FTP:";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(658, 581);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(169, 26);
            this.tbContraseña.TabIndex = 19;
            this.tbContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.tb_IP_Validating_1);
            // 
            // lbCarpeta
            // 
            this.lbCarpeta.AutoSize = true;
            this.lbCarpeta.Location = new System.Drawing.Point(461, 625);
            this.lbCarpeta.Name = "lbCarpeta";
            this.lbCarpeta.Size = new System.Drawing.Size(224, 20);
            this.lbCarpeta.TabIndex = 20;
            this.lbCarpeta.Text = "Carpeta descarga de archivos:";
            // 
            // tbCarpeta
            // 
            this.tbCarpeta.Location = new System.Drawing.Point(692, 622);
            this.tbCarpeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCarpeta.Name = "tbCarpeta";
            this.tbCarpeta.Size = new System.Drawing.Size(169, 26);
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
            // Form_SubirFicherosFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 672);
            this.Controls.Add(this.tbCarpeta);
            this.Controls.Add(this.lbCarpeta);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.lbPasswordFTP);
            this.Controls.Add(this.tbUsuarioFTP);
            this.Controls.Add(this.lbUsuarioFTP);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.btModificarDatosXML);
            this.Controls.Add(this.lb_RutaArxiu);
            this.Controls.Add(this.lb_infoBT3);
            this.Controls.Add(this.label1lb_infoBT2);
            this.Controls.Add(this.lb_infoBT1);
            this.Controls.Add(this.btCarregarDadesBD);
            this.Controls.Add(this.bt_VisualitzarDades);
            this.Controls.Add(this.bt_BuscarArxiu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_SubirFicherosFTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subir ficheros servidor FTP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SubirFicherosFTP_FormClosing);
            this.Load += new System.EventHandler(this.Form_SubirFicherosFTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lb_infoBT3;
        private System.Windows.Forms.Label label1lb_infoBT2;
        private System.Windows.Forms.Label lb_infoBT1;
        private System.Windows.Forms.Button btCarregarDadesBD;
        private System.Windows.Forms.Button bt_VisualitzarDades;
        private System.Windows.Forms.Button bt_BuscarArxiu;
        private System.Windows.Forms.Label lb_RutaArxiu;
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
    }
}