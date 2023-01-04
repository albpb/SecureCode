
namespace FormsTratamientoDatos
{
    partial class FormFTP_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.swTText = new CustomControls.SWTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.swTImage = new CustomControls.SWTextbox();
            this.swTColor = new CustomControls.SWTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.swTAccess = new CustomControls.SWTextbox();
            this.swTTable = new CustomControls.SWTextbox();
            this.swTClass = new CustomControls.SWTextbox();
            this.swTForm = new CustomControls.SWTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.swLauchForm1 = new CustomControls.SWLauchForm();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vista previa";
            // 
            // swTText
            // 
            this.swTText.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTText.DBName = "Texto";
            this.swTText.ForeignKey = false;
            this.swTText.IsEmpty = false;
            this.swTText.Location = new System.Drawing.Point(36, 353);
            this.swTText.Name = "swTText";
            this.swTText.Size = new System.Drawing.Size(150, 20);
            this.swTText.SWCodi = null;
            this.swTText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Texto";
            // 
            // swTImage
            // 
            this.swTImage.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTImage.DBName = "Icono";
            this.swTImage.ForeignKey = false;
            this.swTImage.IsEmpty = false;
            this.swTImage.Location = new System.Drawing.Point(36, 398);
            this.swTImage.Name = "swTImage";
            this.swTImage.Size = new System.Drawing.Size(150, 20);
            this.swTImage.SWCodi = null;
            this.swTImage.TabIndex = 13;
            this.swTImage.Validated += new System.EventHandler(this.swTImage_Validated);
            // 
            // swTColor
            // 
            this.swTColor.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTColor.DBName = "Color";
            this.swTColor.ForeignKey = false;
            this.swTColor.IsEmpty = false;
            this.swTColor.Location = new System.Drawing.Point(36, 443);
            this.swTColor.Name = "swTColor";
            this.swTColor.Size = new System.Drawing.Size(100, 20);
            this.swTColor.SWCodi = null;
            this.swTColor.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Imagen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Color (HEX)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nivell d\'accés";
            // 
            // swTAccess
            // 
            this.swTAccess.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTAccess.DBName = "AccessLevel";
            this.swTAccess.ForeignKey = false;
            this.swTAccess.IsEmpty = false;
            this.swTAccess.Location = new System.Drawing.Point(35, 488);
            this.swTAccess.Name = "swTAccess";
            this.swTAccess.Size = new System.Drawing.Size(100, 20);
            this.swTAccess.SWCodi = null;
            this.swTAccess.TabIndex = 18;
            // 
            // swTTable
            // 
            this.swTTable.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTTable.DBName = "Taula";
            this.swTTable.ForeignKey = false;
            this.swTTable.IsEmpty = false;
            this.swTTable.Location = new System.Drawing.Point(365, 353);
            this.swTTable.Name = "swTTable";
            this.swTTable.Size = new System.Drawing.Size(134, 20);
            this.swTTable.SWCodi = null;
            this.swTTable.TabIndex = 19;
            // 
            // swTClass
            // 
            this.swTClass.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTClass.DBName = "Clase";
            this.swTClass.ForeignKey = false;
            this.swTClass.IsEmpty = false;
            this.swTClass.Location = new System.Drawing.Point(365, 397);
            this.swTClass.Name = "swTClass";
            this.swTClass.Size = new System.Drawing.Size(134, 20);
            this.swTClass.SWCodi = null;
            this.swTClass.TabIndex = 20;
            // 
            // swTForm
            // 
            this.swTForm.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTForm.DBName = "Form";
            this.swTForm.ForeignKey = false;
            this.swTForm.IsEmpty = false;
            this.swTForm.Location = new System.Drawing.Point(365, 443);
            this.swTForm.Name = "swTForm";
            this.swTForm.Size = new System.Drawing.Size(134, 20);
            this.swTForm.SWCodi = null;
            this.swTForm.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Taula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Clase";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Form";
            // 
            // swLauchForm1
            // 
            this.swLauchForm1.Clase = null;
            this.swLauchForm1.ColorFons = "#000000";
            this.swLauchForm1.Form = null;
            this.swLauchForm1.Imagen = null;
            this.swLauchForm1.isEnabled = false;
            this.swLauchForm1.Label = null;
            this.swLauchForm1.Location = new System.Drawing.Point(552, 64);
            this.swLauchForm1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.swLauchForm1.Name = "swLauchForm1";
            this.swLauchForm1.Size = new System.Drawing.Size(438, 273);
            this.swLauchForm1.TabIndex = 25;
            this.swLauchForm1.Taula = null;
            // 
            // FormFTP_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 535);
            this.Controls.Add(this.swLauchForm1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.swTForm);
            this.Controls.Add(this.swTClass);
            this.Controls.Add(this.swTTable);
            this.Controls.Add(this.swTAccess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.swTColor);
            this.Controls.Add(this.swTImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.swTText);
            this.Controls.Add(this.label1);
            this.Name = "FormFTP_form";
            this.Text = "FormulariFTP";
            this.Load += new System.EventHandler(this.FormFTP_form_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.swTText, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.swTImage, 0);
            this.Controls.SetChildIndex(this.swTColor, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.swTAccess, 0);
            this.Controls.SetChildIndex(this.swTTable, 0);
            this.Controls.SetChildIndex(this.swTClass, 0);
            this.Controls.SetChildIndex(this.swTForm, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.swLauchForm1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CustomControls.SWTextbox swTText;
        private System.Windows.Forms.Label label2;
        private CustomControls.SWTextbox swTImage;
        private CustomControls.SWTextbox swTColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomControls.SWTextbox swTAccess;
        private CustomControls.SWTextbox swTTable;
        private CustomControls.SWTextbox swTClass;
        private CustomControls.SWTextbox swTForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CustomControls.SWLauchForm swLauchForm1;
    }
}