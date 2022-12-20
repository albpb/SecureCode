
namespace CustomControls
{
    partial class SWCodi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBCode = new System.Windows.Forms.TextBox();
            this.TBDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBCode
            // 
            this.TBCode.Location = new System.Drawing.Point(3, 3);
            this.TBCode.Name = "TBCode";
            this.TBCode.Size = new System.Drawing.Size(100, 20);
            this.TBCode.TabIndex = 0;
            this.TBCode.Validated += new System.EventHandler(this.TBCode_Validated);
            // 
            // TBDesc
            // 
            this.TBDesc.Enabled = false;
            this.TBDesc.Location = new System.Drawing.Point(109, 3);
            this.TBDesc.Name = "TBDesc";
            this.TBDesc.Size = new System.Drawing.Size(346, 20);
            this.TBDesc.TabIndex = 1;
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TBDesc);
            this.Controls.Add(this.TBCode);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(477, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBCode;
        private System.Windows.Forms.TextBox TBDesc;
    }
}
