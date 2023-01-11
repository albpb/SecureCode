
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewlabel = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vista previa";
            // 
            // swTText
            // 
            this.swTText.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTText.DBName = "Texto";
            this.swTText.ForeignKey = false;
            this.swTText.IsEmpty = false;
            this.swTText.Location = new System.Drawing.Point(48, 434);
            this.swTText.Margin = new System.Windows.Forms.Padding(4);
            this.swTText.Name = "swTText";
            this.swTText.Size = new System.Drawing.Size(199, 22);
            this.swTText.SWCodi = null;
            this.swTText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 412);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Texto";
            // 
            // swTImage
            // 
            this.swTImage.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTImage.DBName = "Icono";
            this.swTImage.ForeignKey = false;
            this.swTImage.IsEmpty = false;
            this.swTImage.Location = new System.Drawing.Point(48, 490);
            this.swTImage.Margin = new System.Windows.Forms.Padding(4);
            this.swTImage.Name = "swTImage";
            this.swTImage.Size = new System.Drawing.Size(199, 22);
            this.swTImage.SWCodi = null;
            this.swTImage.TabIndex = 13;
            this.swTImage.TextChanged += new System.EventHandler(this.swTImage_TextChanged);
            // 
            // swTColor
            // 
            this.swTColor.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTColor.DBName = "Color";
            this.swTColor.ForeignKey = false;
            this.swTColor.IsEmpty = false;
            this.swTColor.Location = new System.Drawing.Point(48, 545);
            this.swTColor.Margin = new System.Windows.Forms.Padding(4);
            this.swTColor.Name = "swTColor";
            this.swTColor.Size = new System.Drawing.Size(132, 22);
            this.swTColor.SWCodi = null;
            this.swTColor.TabIndex = 14;
            this.swTColor.TextChanged += new System.EventHandler(this.swTColor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 468);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Imagen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 523);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 578);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nivel de acceso";
            // 
            // swTAccess
            // 
            this.swTAccess.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTAccess.DBName = "AccessLevel";
            this.swTAccess.ForeignKey = false;
            this.swTAccess.IsEmpty = false;
            this.swTAccess.Location = new System.Drawing.Point(47, 601);
            this.swTAccess.Margin = new System.Windows.Forms.Padding(4);
            this.swTAccess.Name = "swTAccess";
            this.swTAccess.Size = new System.Drawing.Size(132, 22);
            this.swTAccess.SWCodi = null;
            this.swTAccess.TabIndex = 18;
            // 
            // swTTable
            // 
            this.swTTable.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTTable.DBName = "Taula";
            this.swTTable.ForeignKey = false;
            this.swTTable.IsEmpty = false;
            this.swTTable.Location = new System.Drawing.Point(487, 434);
            this.swTTable.Margin = new System.Windows.Forms.Padding(4);
            this.swTTable.Name = "swTTable";
            this.swTTable.Size = new System.Drawing.Size(177, 22);
            this.swTTable.SWCodi = null;
            this.swTTable.TabIndex = 19;
            // 
            // swTClass
            // 
            this.swTClass.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTClass.DBName = "Clase";
            this.swTClass.ForeignKey = false;
            this.swTClass.IsEmpty = false;
            this.swTClass.Location = new System.Drawing.Point(487, 489);
            this.swTClass.Margin = new System.Windows.Forms.Padding(4);
            this.swTClass.Name = "swTClass";
            this.swTClass.Size = new System.Drawing.Size(177, 22);
            this.swTClass.SWCodi = null;
            this.swTClass.TabIndex = 20;
            // 
            // swTForm
            // 
            this.swTForm.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTForm.DBName = "Form";
            this.swTForm.ForeignKey = false;
            this.swTForm.IsEmpty = false;
            this.swTForm.Location = new System.Drawing.Point(487, 545);
            this.swTForm.Margin = new System.Windows.Forms.Padding(4);
            this.swTForm.Name = "swTForm";
            this.swTForm.Size = new System.Drawing.Size(177, 22);
            this.swTForm.SWCodi = null;
            this.swTForm.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 412);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tabla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 468);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Clase";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 523);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Form";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewlabel);
            this.panel1.Controls.Add(this.img);
            this.panel1.Location = new System.Drawing.Point(756, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 344);
            this.panel1.TabIndex = 25;
            // 
            // viewlabel
            // 
            this.viewlabel.AutoSize = true;
            this.viewlabel.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewlabel.ForeColor = System.Drawing.Color.Snow;
            this.viewlabel.Location = new System.Drawing.Point(314, 64);
            this.viewlabel.Name = "viewlabel";
            this.viewlabel.Size = new System.Drawing.Size(136, 51);
            this.viewlabel.TabIndex = 1;
            this.viewlabel.Text = "label9";
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(3, 0);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(296, 246);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            // 
            // FormFTP_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 658);
            this.Controls.Add(this.panel1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormFTP_form";
            this.Text = "Modificador de Opciones";
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
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label viewlabel;
        private System.Windows.Forms.PictureBox img;
    }
}