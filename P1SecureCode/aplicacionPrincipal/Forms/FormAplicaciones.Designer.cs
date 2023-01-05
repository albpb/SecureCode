
namespace aplicacionPrincipal.Forms
{
    partial class FormAplicaciones
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
            this.flpnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lblApps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpnlMain
            // 
            this.flpnlMain.BackColor = System.Drawing.Color.Beige;
            this.flpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlMain.Location = new System.Drawing.Point(0, 23);
            this.flpnlMain.Name = "flpnlMain";
            this.flpnlMain.Size = new System.Drawing.Size(800, 427);
            this.flpnlMain.TabIndex = 9;
            this.flpnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.flpnlMain_Paint_1);
            // 
            // lblApps
            // 
            this.lblApps.AutoSize = true;
            this.lblApps.BackColor = System.Drawing.Color.Transparent;
            this.lblApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApps.Font = new System.Drawing.Font("Lato Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApps.Location = new System.Drawing.Point(0, 0);
            this.lblApps.Name = "lblApps";
            this.lblApps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblApps.Size = new System.Drawing.Size(403, 23);
            this.lblApps.TabIndex = 8;
            this.lblApps.Text = "Aplicaciones permitidas al nivel de Poder Jedi:";
            // 
            // FormAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpnlMain);
            this.Controls.Add(this.lblApps);
            this.Name = "FormAplicaciones";
            this.Text = "FormAplicaciones";
            this.Load += new System.EventHandler(this.FormAplicaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnlMain;
        private System.Windows.Forms.Label lblApps;
    }
}