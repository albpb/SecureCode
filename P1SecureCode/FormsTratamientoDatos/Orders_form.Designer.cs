
namespace FormsTratamientoDatos
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
            this.swFactory = new CustomControls.SWCodi();
            this.swTextbox2 = new CustomControls.SWTextbox();
            this.swTextbox3 = new CustomControls.SWTextbox();
            this.swTextbox4 = new CustomControls.SWTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swPriority
            // 
            this.swPriority.ClasseCS = null;
            this.swPriority.ControlID = null;
            this.swPriority.FormCS = null;
            this.swPriority.Location = new System.Drawing.Point(692, 92);
            this.swPriority.Margin = new System.Windows.Forms.Padding(5);
            this.swPriority.Name = "swPriority";
            this.swPriority.Nomcodi = "CodePriority";
            this.swPriority.NomDesc = "DescPriority";
            this.swPriority.NomId = "idPriority";
            this.swPriority.NomTaula = "Priority";
            this.swPriority.Size = new System.Drawing.Size(636, 33);
            this.swPriority.TabIndex = 9;
            // 
            // swTextbox1
            // 
            this.swTextbox1.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox1.DBName = "IdPriority";
            this.swTextbox1.Enabled = false;
            this.swTextbox1.ForeignKey = true;
            this.swTextbox1.IsEmpty = false;
            this.swTextbox1.Location = new System.Drawing.Point(1336, 96);
            this.swTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(132, 22);
            this.swTextbox1.SWCodi = "swPriority";
            this.swTextbox1.TabIndex = 10;
            // 
            // swFactory
            // 
            this.swFactory.ClasseCS = null;
            this.swFactory.ControlID = null;
            this.swFactory.FormCS = null;
            this.swFactory.Location = new System.Drawing.Point(692, 134);
            this.swFactory.Margin = new System.Windows.Forms.Padding(5);
            this.swFactory.Name = "swFactory";
            this.swFactory.Nomcodi = "codeFactory";
            this.swFactory.NomDesc = "DescFactory";
            this.swFactory.NomId = "idFactory";
            this.swFactory.NomTaula = "Factories";
            this.swFactory.Size = new System.Drawing.Size(636, 33);
            this.swFactory.TabIndex = 11;
            // 
            // swTextbox2
            // 
            this.swTextbox2.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox2.DBName = "IdFactory";
            this.swTextbox2.Enabled = false;
            this.swTextbox2.ForeignKey = true;
            this.swTextbox2.IsEmpty = false;
            this.swTextbox2.Location = new System.Drawing.Point(1336, 134);
            this.swTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(132, 22);
            this.swTextbox2.SWCodi = "swFactory";
            this.swTextbox2.TabIndex = 12;
            // 
            // swTextbox3
            // 
            this.swTextbox3.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox3.DBName = "codeOrder";
            this.swTextbox3.ForeignKey = false;
            this.swTextbox3.IsEmpty = false;
            this.swTextbox3.Location = new System.Drawing.Point(47, 423);
            this.swTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.Size = new System.Drawing.Size(281, 22);
            this.swTextbox3.SWCodi = null;
            this.swTextbox3.TabIndex = 13;
            // 
            // swTextbox4
            // 
            this.swTextbox4.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox4.DBName = "dateOrder";
            this.swTextbox4.ForeignKey = false;
            this.swTextbox4.IsEmpty = false;
            this.swTextbox4.Location = new System.Drawing.Point(48, 485);
            this.swTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox4.Name = "swTextbox4";
            this.swTextbox4.Size = new System.Drawing.Size(615, 22);
            this.swTextbox4.SWCodi = null;
            this.swTextbox4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 398);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código de orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 457);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha";
            // 
            // Orders_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swTextbox4);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swFactory);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.swPriority);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Orders_form";
            this.Text = "Ordenes";
            this.Controls.SetChildIndex(this.swPriority, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swFactory, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.Controls.SetChildIndex(this.swTextbox4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWCodi swPriority;
        private CustomControls.SWTextbox swTextbox1;
        private CustomControls.SWCodi swFactory;
        private CustomControls.SWTextbox swTextbox2;
        private CustomControls.SWTextbox swTextbox3;
        private CustomControls.SWTextbox swTextbox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}