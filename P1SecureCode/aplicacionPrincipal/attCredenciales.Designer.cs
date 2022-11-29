
namespace aplicacionPrincipal
{
    partial class attCredenciales
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
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblNewPassConfirm = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.bntFinish = new System.Windows.Forms.Button();
            this.lblValorUser = new System.Windows.Forms.Label();
            this.lblUserTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(87, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(202, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Actualize su contraseña";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(64, 86);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(96, 13);
            this.lblNewPass.TabIndex = 1;
            this.lblNewPass.Text = "Nueva Contraseña";
            // 
            // lblNewPassConfirm
            // 
            this.lblNewPassConfirm.AutoSize = true;
            this.lblNewPassConfirm.Location = new System.Drawing.Point(64, 112);
            this.lblNewPassConfirm.Name = "lblNewPassConfirm";
            this.lblNewPassConfirm.Size = new System.Drawing.Size(95, 13);
            this.lblNewPassConfirm.TabIndex = 2;
            this.lblNewPassConfirm.Text = "Repita Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(166, 83);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(157, 20);
            this.txtPass.TabIndex = 3;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(166, 109);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.Size = new System.Drawing.Size(157, 20);
            this.txtPassConfirm.TabIndex = 4;
            // 
            // bntFinish
            // 
            this.bntFinish.Location = new System.Drawing.Point(248, 137);
            this.bntFinish.Name = "bntFinish";
            this.bntFinish.Size = new System.Drawing.Size(75, 23);
            this.bntFinish.TabIndex = 5;
            this.bntFinish.Text = "Finalizar";
            this.bntFinish.UseVisualStyleBackColor = true;
            this.bntFinish.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblValorUser
            // 
            this.lblValorUser.AutoSize = true;
            this.lblValorUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUser.Location = new System.Drawing.Point(122, 172);
            this.lblValorUser.Name = "lblValorUser";
            this.lblValorUser.Size = new System.Drawing.Size(50, 13);
            this.lblValorUser.TabIndex = 6;
            this.lblValorUser.Text = "Usuario";
            // 
            // lblUserTitulo
            // 
            this.lblUserTitulo.AutoSize = true;
            this.lblUserTitulo.Location = new System.Drawing.Point(12, 172);
            this.lblUserTitulo.Name = "lblUserTitulo";
            this.lblUserTitulo.Size = new System.Drawing.Size(104, 13);
            this.lblUserTitulo.TabIndex = 7;
            this.lblUserTitulo.Text = "Acceso con usuario:";
            // 
            // attCredenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(383, 194);
            this.Controls.Add(this.lblUserTitulo);
            this.Controls.Add(this.lblValorUser);
            this.Controls.Add(this.bntFinish);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblNewPassConfirm);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblTitulo);
            this.Name = "attCredenciales";
            this.Text = "Actualizacion de Contraseña";
            this.Load += new System.EventHandler(this.attCredenciales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblNewPassConfirm;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.Button bntFinish;
        public System.Windows.Forms.Label lblValorUser;
        private System.Windows.Forms.Label lblUserTitulo;
        private System.Windows.Forms.TextBox txtPass;
    }
}

