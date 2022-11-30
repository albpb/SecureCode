
namespace FormBase
{
    partial class formBaseTratamientoDatos
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
            this.btActualitzar = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
            this.dgvSpecies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecies)).BeginInit();
            this.SuspendLayout();
            // 
            // btActualitzar
            // 
            this.btActualitzar.Location = new System.Drawing.Point(629, 24);
            this.btActualitzar.Name = "btActualitzar";
            this.btActualitzar.Size = new System.Drawing.Size(118, 61);
            this.btActualitzar.TabIndex = 7;
            this.btActualitzar.Text = "Actualitzar";
            this.btActualitzar.UseVisualStyleBackColor = true;
            this.btActualitzar.Click += new System.EventHandler(this.btActualitzar_Click);
            // 
            // btNou
            // 
            this.btNou.Location = new System.Drawing.Point(513, 24);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(87, 61);
            this.btNou.TabIndex = 6;
            this.btNou.Text = "Nou";
            this.btNou.UseVisualStyleBackColor = true;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // dgvSpecies
            // 
            this.dgvSpecies.AllowUserToAddRows = false;
            this.dgvSpecies.AllowUserToDeleteRows = false;
            this.dgvSpecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecies.Location = new System.Drawing.Point(53, 115);
            this.dgvSpecies.Name = "dgvSpecies";
            this.dgvSpecies.ReadOnly = true;
            this.dgvSpecies.RowHeadersWidth = 62;
            this.dgvSpecies.RowTemplate.Height = 28;
            this.dgvSpecies.Size = new System.Drawing.Size(694, 311);
            this.dgvSpecies.TabIndex = 5;
            // 
            // formBaseTratamientoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btActualitzar);
            this.Controls.Add(this.btNou);
            this.Controls.Add(this.dgvSpecies);
            this.Name = "formBaseTratamientoDatos";
            this.Text = "formBaseTratamientoDatos";
            this.Load += new System.EventHandler(this.formBaseTratamientoDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btActualitzar;
        private System.Windows.Forms.Button btNou;
        public System.Windows.Forms.DataGridView dgvSpecies;
    }
}