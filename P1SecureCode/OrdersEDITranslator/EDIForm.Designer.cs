
namespace OrdersEDITranslator
{
    partial class EDIForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.directoryTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // directoryTB
            // 
            this.directoryTB.Enabled = false;
            this.directoryTB.Location = new System.Drawing.Point(22, 57);
            this.directoryTB.Name = "directoryTB";
            this.directoryTB.Size = new System.Drawing.Size(299, 22);
            this.directoryTB.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "Uploud 2 DB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 184);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.directoryTB);
            this.Controls.Add(this.button1);
            this.Name = "Form";
            this.Text = "Uploud EDI to DB";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox directoryTB;
        private System.Windows.Forms.Button button2;
    }
}