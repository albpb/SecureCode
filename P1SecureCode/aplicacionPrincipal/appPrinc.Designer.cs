
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntExit = new System.Windows.Forms.Label();
            this.lblApps = new System.Windows.Forms.Label();
            this.flpnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNv = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(163, 20);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(13, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(90, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha de hoy";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(13, 58);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNivel.Size = new System.Drawing.Size(135, 15);
            this.lblNivel.TabIndex = 3;
            this.lblNivel.Text = "Nivel de poder Jedi:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.lblNv);
            this.panel1.Controls.Add(this.bntExit);
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.lblNivel);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 82);
            this.panel1.TabIndex = 5;
            // 
            // bntExit
            // 
            this.bntExit.AutoSize = true;
            this.bntExit.BackColor = System.Drawing.Color.Transparent;
            this.bntExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.Location = new System.Drawing.Point(893, 0);
            this.bntExit.Name = "bntExit";
            this.bntExit.Padding = new System.Windows.Forms.Padding(6);
            this.bntExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bntExit.Size = new System.Drawing.Size(31, 30);
            this.bntExit.TabIndex = 4;
            this.bntExit.Text = "X";
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // lblApps
            // 
            this.lblApps.AutoSize = true;
            this.lblApps.BackColor = System.Drawing.Color.Transparent;
            this.lblApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApps.Location = new System.Drawing.Point(12, 95);
            this.lblApps.Name = "lblApps";
            this.lblApps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblApps.Size = new System.Drawing.Size(400, 24);
            this.lblApps.TabIndex = 4;
            this.lblApps.Text = "Aplicaciones permitidas al nivel de Poder Jedi:";
            // 
            // flpnlMain
            // 
            this.flpnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpnlMain.BackColor = System.Drawing.Color.Beige;
            this.flpnlMain.Location = new System.Drawing.Point(0, 122);
            this.flpnlMain.Name = "flpnlMain";
            this.flpnlMain.Size = new System.Drawing.Size(924, 406);
            this.flpnlMain.TabIndex = 6;
            // 
            // lblNv
            // 
            this.lblNv.AutoSize = true;
            this.lblNv.BackColor = System.Drawing.Color.Transparent;
            this.lblNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNv.Location = new System.Drawing.Point(145, 58);
            this.lblNv.Name = "lblNv";
            this.lblNv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNv.Size = new System.Drawing.Size(15, 15);
            this.lblNv.TabIndex = 5;
            this.lblNv.Text = "0";
            // 
            // appPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(924, 528);
            this.Controls.Add(this.lblApps);
            this.Controls.Add(this.flpnlMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion Java The Hutt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bntExit;
        private System.Windows.Forms.Label lblApps;
        private System.Windows.Forms.FlowLayoutPanel flpnlMain;
        private System.Windows.Forms.Label lblNv;
    }
}

