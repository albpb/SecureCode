
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
            this.TBEDIpreview = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(423, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // directoryTB
            // 
            this.directoryTB.Enabled = false;
            this.directoryTB.Location = new System.Drawing.Point(21, 30);
            this.directoryTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.directoryTB.Name = "directoryTB";
            this.directoryTB.Size = new System.Drawing.Size(398, 20);
            this.directoryTB.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.Location = new System.Drawing.Point(499, 260);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Subir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBEDIpreview
            // 
            this.TBEDIpreview.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TBEDIpreview.Enabled = false;
            this.TBEDIpreview.Location = new System.Drawing.Point(21, 71);
            this.TBEDIpreview.Multiline = true;
            this.TBEDIpreview.Name = "TBEDIpreview";
            this.TBEDIpreview.Size = new System.Drawing.Size(444, 242);
            this.TBEDIpreview.TabIndex = 3;
            // 
            // EDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(637, 325);
            this.Controls.Add(this.TBEDIpreview);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.directoryTB);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EDIForm";
            this.Text = "Subir orden EDI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox directoryTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBEDIpreview;
    }
}