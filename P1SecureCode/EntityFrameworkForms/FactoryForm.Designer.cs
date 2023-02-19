
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
            this.lb_Informatiu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactories)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFactories
            // 
            this.DGVFactories.AllowUserToAddRows = false;
            this.DGVFactories.AllowUserToDeleteRows = false;
            this.DGVFactories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFactories.Location = new System.Drawing.Point(24, 64);
            this.DGVFactories.Name = "DGVFactories";
            this.DGVFactories.ReadOnly = true;
            this.DGVFactories.Size = new System.Drawing.Size(535, 263);
            this.DGVFactories.TabIndex = 0;
            // 
            // LBLCodi
            // 
            this.LBLCodi.AutoSize = true;
            this.LBLCodi.Location = new System.Drawing.Point(21, 385);
            this.LBLCodi.Name = "LBLCodi";
            this.LBLCodi.Size = new System.Drawing.Size(40, 13);
            this.LBLCodi.TabIndex = 1;
            this.LBLCodi.Text = "Código";
            // 
            // TBCodi
            // 
            this.TBCodi.Location = new System.Drawing.Point(90, 382);
            this.TBCodi.Name = "TBCodi";
            this.TBCodi.Size = new System.Drawing.Size(166, 20);
            this.TBCodi.TabIndex = 3;
            this.TBCodi.Tag = "codeFactory";
            // 
            // TBDesc
            // 
            this.TBDesc.Location = new System.Drawing.Point(90, 408);
            this.TBDesc.Name = "TBDesc";
            this.TBDesc.Size = new System.Drawing.Size(214, 20);
            this.TBDesc.TabIndex = 5;
            this.TBDesc.Tag = "DescFactory";
            // 
            // LBLDesc
            // 
            this.LBLDesc.AutoSize = true;
            this.LBLDesc.Location = new System.Drawing.Point(21, 411);
            this.LBLDesc.Name = "LBLDesc";
            this.LBLDesc.Size = new System.Drawing.Size(63, 13);
            this.LBLDesc.TabIndex = 4;
            this.LBLDesc.Text = "Descripción";
            // 
            // BTNNew
            // 
            this.BTNNew.Location = new System.Drawing.Point(402, 12);
            this.BTNNew.Name = "BTNNew";
            this.BTNNew.Size = new System.Drawing.Size(75, 37);
            this.BTNNew.TabIndex = 6;
            this.BTNNew.Text = "Nuevo";
            this.BTNNew.UseVisualStyleBackColor = true;
            this.BTNNew.Click += new System.EventHandler(this.BTNNew_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(483, 12);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(76, 37);
            this.BTNUpdate.TabIndex = 7;
            this.BTNUpdate.Text = "Actualizar";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // lb_Informatiu
            // 
            this.lb_Informatiu.AutoSize = true;
            this.lb_Informatiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Informatiu.Location = new System.Drawing.Point(20, 340);
            this.lb_Informatiu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Informatiu.Name = "lb_Informatiu";
            this.lb_Informatiu.Size = new System.Drawing.Size(86, 24);
            this.lb_Informatiu.TabIndex = 9;
            this.lb_Informatiu.Text = "Campos";
            // 
            // FactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.lb_Informatiu);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNNew);
            this.Controls.Add(this.TBDesc);
            this.Controls.Add(this.LBLDesc);
            this.Controls.Add(this.TBCodi);
            this.Controls.Add(this.LBLCodi);
            this.Controls.Add(this.DGVFactories);
            this.Name = "FactoryForm";
            this.Text = "Fabricas";
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
        private System.Windows.Forms.Label lb_Informatiu;
    }
}