
namespace FormsTratamientoDatos
{
    partial class Sectors_form
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
            this.swTextbox1 = new CustomControls.SWTextbox();
            this.swTextbox2 = new CustomControls.SWTextbox();
            this.swRegion = new CustomControls.SWCodi();
            this.swTextbox3 = new CustomControls.SWTextbox();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox1.DBName = "CodeSector";
            this.swTextbox1.ForeignKey = false;
            this.swTextbox1.IsEmpty = false;
            this.swTextbox1.Location = new System.Drawing.Point(35, 342);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(100, 20);
            this.swTextbox1.SWCodi = null;
            this.swTextbox1.TabIndex = 9;
            // 
            // swTextbox2
            // 
            this.swTextbox2.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox2.DBName = "DescSector";
            this.swTextbox2.ForeignKey = false;
            this.swTextbox2.IsEmpty = false;
            this.swTextbox2.Location = new System.Drawing.Point(35, 387);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(100, 20);
            this.swTextbox2.SWCodi = null;
            this.swTextbox2.TabIndex = 10;
            // 
            // swRegion
            // 
            this.swRegion.ClasseCS = null;
            this.swRegion.ControlID = null;
            this.swRegion.FormCS = null;
            this.swRegion.Location = new System.Drawing.Point(249, 342);
            this.swRegion.Name = "swRegion";
            this.swRegion.Nomcodi = "CodeRegion";
            this.swRegion.NomDesc = "DescRegion";
            this.swRegion.NomId = "idRegion";
            this.swRegion.NomTaula = "Regions";
            this.swRegion.Size = new System.Drawing.Size(477, 27);
            this.swRegion.TabIndex = 11;
            // 
            // swTextbox3
            // 
            this.swTextbox3.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox3.DBName = "idRegion";
            this.swTextbox3.Enabled = false;
            this.swTextbox3.ForeignKey = true;
            this.swTextbox3.IsEmpty = false;
            this.swTextbox3.Location = new System.Drawing.Point(732, 343);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.Size = new System.Drawing.Size(100, 20);
            this.swTextbox3.SWCodi = "swRegion";
            this.swTextbox3.TabIndex = 12;
            // 
            // Sectors_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swRegion);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Name = "Sectors_form";
            this.Text = "Sectors_form";
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swRegion, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox swTextbox1;
        private CustomControls.SWTextbox swTextbox2;
        private CustomControls.SWCodi swRegion;
        private CustomControls.SWTextbox swTextbox3;
    }
}