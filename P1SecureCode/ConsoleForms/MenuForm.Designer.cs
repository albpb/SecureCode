
namespace ConsoleForms
{
    partial class MenuForm
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
            this.bt_AbrirFormConsola = new System.Windows.Forms.Button();
            this.bt_FormSubirFicheros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_AbrirFormConsola
            // 
            this.bt_AbrirFormConsola.Location = new System.Drawing.Point(54, 27);
            this.bt_AbrirFormConsola.Name = "bt_AbrirFormConsola";
            this.bt_AbrirFormConsola.Size = new System.Drawing.Size(136, 98);
            this.bt_AbrirFormConsola.TabIndex = 0;
            this.bt_AbrirFormConsola.Text = "Abrir Form Abrir Consola";
            this.bt_AbrirFormConsola.UseVisualStyleBackColor = true;
            this.bt_AbrirFormConsola.Click += new System.EventHandler(this.bt_AbrirFormConsola_Click);
            // 
            // bt_FormSubirFicheros
            // 
            this.bt_FormSubirFicheros.Location = new System.Drawing.Point(214, 27);
            this.bt_FormSubirFicheros.Name = "bt_FormSubirFicheros";
            this.bt_FormSubirFicheros.Size = new System.Drawing.Size(136, 98);
            this.bt_FormSubirFicheros.TabIndex = 1;
            this.bt_FormSubirFicheros.Text = "Abrir Form Subir Ficheros";
            this.bt_FormSubirFicheros.UseVisualStyleBackColor = true;
            this.bt_FormSubirFicheros.Click += new System.EventHandler(this.bt_FormSubirFicheros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_FormSubirFicheros);
            this.Controls.Add(this.bt_AbrirFormConsola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button bt_AbrirFormConsola;
        private System.Windows.Forms.Button bt_FormSubirFicheros;
    }
}