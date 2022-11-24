
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.swLauchForm1 = new SWLaunchForm.SWLauchForm();
            this.SuspendLayout();
            // 
            // swLauchForm1
            // 
            this.swLauchForm1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.swLauchForm1.ColorFons = "#FF00FF";
            this.swLauchForm1.ForeColor = System.Drawing.Color.Red;
            this.swLauchForm1.Location = new System.Drawing.Point(23, 25);
            this.swLauchForm1.Name = "swLauchForm1";
            this.swLauchForm1.Size = new System.Drawing.Size(447, 240);
            this.swLauchForm1.TabIndex = 0;
            this.swLauchForm1.Load += new System.EventHandler(this.swLauchForm1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swLauchForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SWLaunchForm.SWLauchForm swLauchForm1;
    }
}

