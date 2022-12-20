
namespace Orders
{
    partial class Orders_form
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
            this.swPriority = new CustomControls.SWCodi();
            this.swTextbox1 = new CustomControls.SWTextbox();
            this.SuspendLayout();
            // 
            // swPriority
            // 
            this.swPriority.ClasseCS = null;
            this.swPriority.ControlID = null;
            this.swPriority.FormCS = null;
            this.swPriority.Location = new System.Drawing.Point(519, 75);
            this.swPriority.Name = "swPriority";
            this.swPriority.Nomcodi = "CodePriority";
            this.swPriority.NomDesc = "DescPriority";
            this.swPriority.NomId = "idPriority";
            this.swPriority.NomTaula = "Priority";
            this.swPriority.Size = new System.Drawing.Size(477, 27);
            this.swPriority.TabIndex = 9;
            // 
            // swTextbox1
            // 
            this.swTextbox1.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox1.DBName = "IdPriority";
            this.swTextbox1.Enabled = false;
            this.swTextbox1.ForeignKey = true;
            this.swTextbox1.IsEmpty = false;
            this.swTextbox1.Location = new System.Drawing.Point(1002, 78);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(100, 20);
            this.swTextbox1.SWCodi = "swPriority";
            this.swTextbox1.TabIndex = 10;
            // 
            // Orders_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 450);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.swPriority);
            this.Name = "Orders_form";
            this.Text = "Orders_form";
            this.Controls.SetChildIndex(this.swPriority, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWCodi swPriority;
        private CustomControls.SWTextbox swTextbox1;
    }
}