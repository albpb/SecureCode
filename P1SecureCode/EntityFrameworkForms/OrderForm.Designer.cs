
namespace EntityFrameworkForms
{
    partial class OrderForm
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
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.CBFactory = new System.Windows.Forms.ComboBox();
            this.CBPriority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactories)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFactories
            // 
            this.DGVFactories.AllowUserToAddRows = false;
            this.DGVFactories.AllowUserToDeleteRows = false;
            this.DGVFactories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFactories.Location = new System.Drawing.Point(16, 90);
            this.DGVFactories.Margin = new System.Windows.Forms.Padding(4);
            this.DGVFactories.Name = "DGVFactories";
            this.DGVFactories.ReadOnly = true;
            this.DGVFactories.RowHeadersWidth = 51;
            this.DGVFactories.Size = new System.Drawing.Size(1035, 414);
            this.DGVFactories.TabIndex = 0;
            // 
            // LBLCodi
            // 
            this.LBLCodi.AutoSize = true;
            this.LBLCodi.Location = new System.Drawing.Point(55, 18);
            this.LBLCodi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLCodi.Name = "LBLCodi";
            this.LBLCodi.Size = new System.Drawing.Size(36, 17);
            this.LBLCodi.TabIndex = 1;
            this.LBLCodi.Text = "Codi";
            // 
            // TBCodi
            // 
            this.TBCodi.Location = new System.Drawing.Point(100, 15);
            this.TBCodi.Margin = new System.Windows.Forms.Padding(4);
            this.TBCodi.Name = "TBCodi";
            this.TBCodi.Size = new System.Drawing.Size(201, 22);
            this.TBCodi.TabIndex = 3;
            this.TBCodi.Tag = "codeOrder";
            // 
            // TBDesc
            // 
            this.TBDesc.Location = new System.Drawing.Point(100, 47);
            this.TBDesc.Margin = new System.Windows.Forms.Padding(4);
            this.TBDesc.Name = "TBDesc";
            this.TBDesc.Size = new System.Drawing.Size(258, 22);
            this.TBDesc.TabIndex = 5;
            this.TBDesc.Tag = "dateOrder";
            // 
            // LBLDesc
            // 
            this.LBLDesc.AutoSize = true;
            this.LBLDesc.Location = new System.Drawing.Point(16, 50);
            this.LBLDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDesc.Name = "LBLDesc";
            this.LBLDesc.Size = new System.Drawing.Size(74, 17);
            this.LBLDesc.TabIndex = 4;
            this.LBLDesc.Text = "Descripció";
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(465, 512);
            this.BTNUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(141, 44);
            this.BTNUpdate.TabIndex = 7;
            this.BTNUpdate.Text = "Update";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // CBFactory
            // 
            this.CBFactory.FormattingEnabled = true;
            this.CBFactory.Location = new System.Drawing.Point(462, 12);
            this.CBFactory.Name = "CBFactory";
            this.CBFactory.Size = new System.Drawing.Size(222, 24);
            this.CBFactory.TabIndex = 8;
            // 
            // CBPriority
            // 
            this.CBPriority.FormattingEnabled = true;
            this.CBPriority.Location = new System.Drawing.Point(773, 12);
            this.CBPriority.Name = "CBPriority";
            this.CBPriority.Size = new System.Drawing.Size(195, 24);
            this.CBPriority.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Factory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Priority";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBPriority);
            this.Controls.Add(this.CBFactory);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.TBDesc);
            this.Controls.Add(this.LBLDesc);
            this.Controls.Add(this.TBCodi);
            this.Controls.Add(this.LBLCodi);
            this.Controls.Add(this.DGVFactories);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.Text = "Orders";
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
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.ComboBox CBFactory;
        private System.Windows.Forms.ComboBox CBPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}