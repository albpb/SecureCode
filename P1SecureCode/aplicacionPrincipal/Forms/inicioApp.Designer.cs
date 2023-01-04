
namespace aplicacionPrincipal.Forms
{
    partial class inicioApp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::aplicacionPrincipal.Properties.Resources.bgPrinc;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSTitulo
            // 
            this.lblSTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSTitulo.AutoSize = true;
            this.lblSTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSTitulo.Font = new System.Drawing.Font("Lato", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTitulo.Location = new System.Drawing.Point(229, 143);
            this.lblSTitulo.Name = "lblSTitulo";
            this.lblSTitulo.Size = new System.Drawing.Size(321, 51);
            this.lblSTitulo.TabIndex = 1;
            this.lblSTitulo.Text = "Bienvenido Jedi";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato Semibold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "En este mundo, tu tienes el poder!";
            // 
            // inicioApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "inicioApp";
            this.Text = "inicioApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblSTitulo;
        public System.Windows.Forms.Label label1;
    }
}