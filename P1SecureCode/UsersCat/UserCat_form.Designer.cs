
namespace UsersCat
{
    partial class UserCat_form
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
            this.swTextbox3 = new CustomControls.SWTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox1.DBName = "CodeCategory";
            this.swTextbox1.ForeignKey = false;
            this.swTextbox1.IsEmpty = false;
            this.swTextbox1.Location = new System.Drawing.Point(36, 358);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(133, 20);
            this.swTextbox1.TabIndex = 9;
            // 
            // swTextbox2
            // 
            this.swTextbox2.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox2.DBName = "DescCategory";
            this.swTextbox2.ForeignKey = false;
            this.swTextbox2.IsEmpty = false;
            this.swTextbox2.Location = new System.Drawing.Point(204, 358);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(140, 20);
            this.swTextbox2.TabIndex = 10;
            // 
            // swTextbox3
            // 
            this.swTextbox3.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox3.DBName = "AccessLevel";
            this.swTextbox3.ForeignKey = false;
            this.swTextbox3.IsEmpty = false;
            this.swTextbox3.Location = new System.Drawing.Point(372, 358);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.Size = new System.Drawing.Size(126, 20);
            this.swTextbox3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripció";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nivell Accés";
            // 
            // UserCat_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Name = "UserCat_form";
            this.Text = "UserCat_form";
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox swTextbox1;
        private CustomControls.SWTextbox swTextbox2;
        private CustomControls.SWTextbox swTextbox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}