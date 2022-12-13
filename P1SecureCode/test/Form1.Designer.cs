
namespace test
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
            this.swCodi1 = new CustomControls.SWCodi();
            this.swTextbox1 = new CustomControls.SWTextbox();
            this.SuspendLayout();
            // 
            // swCodi1
            // 
            this.swCodi1.ClasseCS = null;
            this.swCodi1.ControlID = null;
            this.swCodi1.FormCS = null;
            this.swCodi1.Location = new System.Drawing.Point(12, 49);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.Nomcodi = "CodeUser";
            this.swCodi1.NomDesc = "UserName";
            this.swCodi1.NomId = "idUser";
            this.swCodi1.NomTaula = "Users";
            this.swCodi1.Size = new System.Drawing.Size(510, 46);
            this.swCodi1.TabIndex = 0;
            // 
            // swTextbox1
            // 
            this.swTextbox1.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox1.DBName = "swCodi1";
            this.swTextbox1.ForeignKey = true;
            this.swTextbox1.IsEmpty = false;
            this.swTextbox1.Location = new System.Drawing.Point(513, 49);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(100, 20);
            this.swTextbox1.TabIndex = 1;
            this.swTextbox1.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.swCodi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWCodi swCodi1;
        private CustomControls.SWTextbox swTextbox1;
    }
}

