﻿
namespace aplicacionPrincipal
{
    partial class appPrinc
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNv = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.bntTablaS = new System.Windows.Forms.Button();
            this.bntHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bntExit = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(120, 31);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 63);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Home";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblNivel.Location = new System.Drawing.Point(0, 0);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNivel.Size = new System.Drawing.Size(230, 29);
            this.lblNivel.TabIndex = 3;
            this.lblNivel.Text = "Nivel de poder Jedi:";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.OliveDrab;
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.Settings);
            this.panelMenu.Controls.Add(this.bntTablaS);
            this.panelMenu.Controls.Add(this.bntHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 779);
            this.panelMenu.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNivel);
            this.panel1.Controls.Add(this.lblNv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 742);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 37);
            this.panel1.TabIndex = 11;
            // 
            // lblNv
            // 
            this.lblNv.AutoSize = true;
            this.lblNv.BackColor = System.Drawing.Color.Transparent;
            this.lblNv.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNv.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblNv.Location = new System.Drawing.Point(276, 0);
            this.lblNv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNv.Name = "lblNv";
            this.lblNv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNv.Size = new System.Drawing.Size(17, 18);
            this.lblNv.TabIndex = 5;
            this.lblNv.Text = "0";
            // 
            // Settings
            // 
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.Black;
            this.Settings.Image = global::aplicacionPrincipal.Properties.Resources.settings;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(0, 271);
            this.Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Settings.Size = new System.Drawing.Size(293, 74);
            this.Settings.TabIndex = 10;
            this.Settings.Text = "    Ajustes";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // bntTablaS
            // 
            this.bntTablaS.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntTablaS.FlatAppearance.BorderSize = 0;
            this.bntTablaS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntTablaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTablaS.ForeColor = System.Drawing.Color.Black;
            this.bntTablaS.Image = global::aplicacionPrincipal.Properties.Resources.menu_burger;
            this.bntTablaS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTablaS.Location = new System.Drawing.Point(0, 197);
            this.bntTablaS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntTablaS.Name = "bntTablaS";
            this.bntTablaS.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bntTablaS.Size = new System.Drawing.Size(293, 74);
            this.bntTablaS.TabIndex = 8;
            this.bntTablaS.Text = "    Aplicaciones";
            this.bntTablaS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTablaS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntTablaS.UseVisualStyleBackColor = true;
            this.bntTablaS.Click += new System.EventHandler(this.bntTablaS_Click);
            // 
            // bntHome
            // 
            this.bntHome.BackColor = System.Drawing.Color.OliveDrab;
            this.bntHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntHome.FlatAppearance.BorderSize = 0;
            this.bntHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHome.ForeColor = System.Drawing.Color.Black;
            this.bntHome.Image = global::aplicacionPrincipal.Properties.Resources.home;
            this.bntHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntHome.Location = new System.Drawing.Point(0, 123);
            this.bntHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntHome.Name = "bntHome";
            this.bntHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bntHome.Size = new System.Drawing.Size(293, 74);
            this.bntHome.TabIndex = 7;
            this.bntHome.Text = "    Inicio";
            this.bntHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntHome.UseVisualStyleBackColor = false;
            this.bntHome.Click += new System.EventHandler(this.bntHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 123);
            this.panelLogo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Java The Hutt";
            // 
            // bntExit
            // 
            this.bntExit.AutoSize = true;
            this.bntExit.BackColor = System.Drawing.Color.Transparent;
            this.bntExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.Location = new System.Drawing.Point(1094, 0);
            this.bntExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bntExit.Name = "bntExit";
            this.bntExit.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bntExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bntExit.Size = new System.Drawing.Size(41, 38);
            this.bntExit.TabIndex = 4;
            this.bntExit.Text = "X";
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblFecha);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.bntExit);
            this.panelHeader.Controls.Add(this.lblNombreUsuario);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(293, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1135, 123);
            this.panelHeader.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblFecha.Location = new System.Drawing.Point(856, 31);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 17);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "fecha";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblNombreUsuario.Location = new System.Drawing.Point(856, 58);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(36, 17);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "user";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(293, 123);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1135, 656);
            this.panelDesktop.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::aplicacionPrincipal.Properties.Resources.Logo_Java_theHutt;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1135, 656);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // appPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1428, 779);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "appPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion Java The Hutt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.appPrinc_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label bntExit;
        private System.Windows.Forms.Label lblNv;
        private System.Windows.Forms.Button bntTablaS;
        private System.Windows.Forms.Button bntHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

