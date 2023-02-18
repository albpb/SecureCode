
namespace EntityFrameworkForms
{
    partial class FactoryForm
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
            this.DGVFactories = new System.Windows.Forms.DataGridView();
            this.LBLCodi = new System.Windows.Forms.Label();
            this.TBCodi = new System.Windows.Forms.TextBox();
            this.TBDesc = new System.Windows.Forms.TextBox();
            this.LBLDesc = new System.Windows.Forms.Label();
            this.BTNNew = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactories)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFactories
            // 
            this.DGVFactories.AllowUserToAddRows = false;
            this.DGVFactories.AllowUserToDeleteRows = false;
            this.DGVFactories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFactories.Location = new System.Drawing.Point(12, 64);
            this.DGVFactories.Name = "DGVFactories";
            this.DGVFactories.ReadOnly = true;
            this.DGVFactories.Size = new System.Drawing.Size(776, 345);
            this.DGVFactories.TabIndex = 0;
            // 
            // LBLCodi
            // 
            this.LBLCodi.AutoSize = true;
            this.LBLCodi.Location = new System.Drawing.Point(41, 15);
            this.LBLCodi.Name = "LBLCodi";
            this.LBLCodi.Size = new System.Drawing.Size(28, 13);
            this.LBLCodi.TabIndex = 1;
            this.LBLCodi.Text = "Codi";
            // 
            // TBCodi
            // 
            this.TBCodi.Location = new System.Drawing.Point(75, 12);
            this.TBCodi.Name = "TBCodi";
            this.TBCodi.Size = new System.Drawing.Size(342, 20);
            this.TBCodi.TabIndex = 3;
            this.TBCodi.Tag = "codeFactory";
            // 
            // TBDesc
            // 
            this.TBDesc.Location = new System.Drawing.Point(75, 38);
            this.TBDesc.Name = "TBDesc";
            this.TBDesc.Size = new System.Drawing.Size(713, 20);
            this.TBDesc.TabIndex = 5;
            this.TBDesc.Tag = "DescFactory";
            // 
            // LBLDesc
            // 
            this.LBLDesc.AutoSize = true;
            this.LBLDesc.Location = new System.Drawing.Point(12, 41);
            this.LBLDesc.Name = "LBLDesc";
            this.LBLDesc.Size = new System.Drawing.Size(57, 13);
            this.LBLDesc.TabIndex = 4;
            this.LBLDesc.Text = "Descripció";
            // 
            // BTNNew
            // 
            this.BTNNew.Location = new System.Drawing.Point(322, 415);
            this.BTNNew.Name = "BTNNew";
            this.BTNNew.Size = new System.Drawing.Size(75, 23);
            this.BTNNew.TabIndex = 6;
            this.BTNNew.Text = "New";
            this.BTNNew.UseVisualStyleBackColor = true;
            this.BTNNew.Click += new System.EventHandler(this.BTNNew_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(403, 415);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(75, 23);
            this.BTNUpdate.TabIndex = 7;
            this.BTNUpdate.Text = "Update";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // Factories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNNew);
            this.Controls.Add(this.TBDesc);
            this.Controls.Add(this.LBLDesc);
            this.Controls.Add(this.TBCodi);
            this.Controls.Add(this.LBLCodi);
            this.Controls.Add(this.DGVFactories);
            this.Name = "Factories";
            this.Text = "Factories";
            this.Load += new System.EventHandler(this.Factories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView DGVFactories;
        private System.Windows.Forms.Label LBLCodi;
        private System.Windows.Forms.TextBox TBCodi;
        private System.Windows.Forms.TextBox TBDesc;
        private System.Windows.Forms.Label LBLDesc;
        private System.Windows.Forms.Button BTNNew;
        private System.Windows.Forms.Button BTNUpdate;

    }
}