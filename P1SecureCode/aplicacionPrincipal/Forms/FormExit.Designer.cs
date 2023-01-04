
namespace aplicacionPrincipal.Forms
{
    partial class FormExit
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblNv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Lato", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(204, 95);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(392, 51);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblNivel
            // 
            this.lblNivel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(300, 167);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNivel.Size = new System.Drawing.Size(178, 23);
            this.lblNivel.TabIndex = 6;
            this.lblNivel.Text = "Nivel de poder Jedi:";
            // 
            // lblNv
            // 
            this.lblNv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNv.AutoSize = true;
            this.lblNv.BackColor = System.Drawing.Color.Transparent;
            this.lblNv.Font = new System.Drawing.Font("Lato", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNv.Location = new System.Drawing.Point(363, 204);
            this.lblNv.Name = "lblNv";
            this.lblNv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNv.Size = new System.Drawing.Size(53, 57);
            this.lblNv.TabIndex = 7;
            this.lblNv.Text = "0";
            // 
            // FormExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblNv);
            this.Controls.Add(this.lblNombreUsuario);
            this.Name = "FormExit";
            this.Text = "FormExit";
            this.Load += new System.EventHandler(this.FormExit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblNv;
    }
}