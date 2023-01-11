
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
            this.lb_Informatiu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecies)).BeginInit();
            this.SuspendLayout();
            // 
            // btActualitzar
            // 
            this.btActualitzar.Location = new System.Drawing.Point(559, 19);
            this.btActualitzar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualitzar.Name = "btActualitzar";
            this.btActualitzar.Size = new System.Drawing.Size(105, 49);
            this.btActualitzar.TabIndex = 7;
            this.btActualitzar.Text = "Actualizar";
            this.btActualitzar.UseVisualStyleBackColor = true;
            this.btActualitzar.Click += new System.EventHandler(this.btActualitzar_Click);
            // 
            // btNou
            // 
            this.btNou.Location = new System.Drawing.Point(456, 19);
            this.btNou.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(77, 49);
            this.btNou.TabIndex = 6;
            this.btNou.Text = "Nuevo";
            this.btNou.UseVisualStyleBackColor = true;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // dgvSpecies
            // 
            this.dgvSpecies.AllowUserToAddRows = false;
            this.dgvSpecies.AllowUserToDeleteRows = false;
            this.dgvSpecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecies.Location = new System.Drawing.Point(47, 92);
            this.dgvSpecies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSpecies.Name = "dgvSpecies";
            this.dgvSpecies.ReadOnly = true;
            this.dgvSpecies.RowHeadersWidth = 62;
            this.dgvSpecies.RowTemplate.Height = 28;
            this.dgvSpecies.Size = new System.Drawing.Size(617, 249);
            this.dgvSpecies.TabIndex = 5;
            this.dgvSpecies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpecies_CellContentClick);
            // 
            // lb_Informatiu
            // 
            this.lb_Informatiu.AutoSize = true;
            this.lb_Informatiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Informatiu.Location = new System.Drawing.Point(42, 362);
            this.lb_Informatiu.Name = "lb_Informatiu";
            this.lb_Informatiu.Size = new System.Drawing.Size(109, 29);
            this.lb_Informatiu.TabIndex = 8;
            this.lb_Informatiu.Text = "Campos";
            // 
            // formBaseTratamientoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 530);
            this.Controls.Add(this.lb_Informatiu);
            this.Controls.Add(this.btActualitzar);
            this.Controls.Add(this.btNou);
            this.Controls.Add(this.dgvSpecies);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formBaseTratamientoDatos";
            this.Text = "formBaseTratamientoDatos";
            this.Load += new System.EventHandler(this.formBaseTratamientoDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btActualitzar;
        private System.Windows.Forms.Button btNou;
        public System.Windows.Forms.DataGridView dgvSpecies;
        private System.Windows.Forms.Label lb_Informatiu;
    }
}