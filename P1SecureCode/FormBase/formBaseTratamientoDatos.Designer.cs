
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
            this.btActualitzar.BackColor = System.Drawing.Color.Ivory;
            this.btActualitzar.Location = new System.Drawing.Point(419, 15);
            this.btActualitzar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btActualitzar.Name = "btActualitzar";
            this.btActualitzar.Size = new System.Drawing.Size(79, 40);
            this.btActualitzar.TabIndex = 7;
            this.btActualitzar.Text = "Actualizar";
            this.btActualitzar.UseVisualStyleBackColor = false;
            this.btActualitzar.Click += new System.EventHandler(this.btActualitzar_Click);
            // 
            // btNou
            // 
            this.btNou.BackColor = System.Drawing.Color.Ivory;
            this.btNou.Location = new System.Drawing.Point(336, 15);
            this.btNou.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(64, 40);
            this.btNou.TabIndex = 6;
            this.btNou.Text = "Nuevo";
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // dgvSpecies
            // 
            this.dgvSpecies.AllowUserToAddRows = false;
            this.dgvSpecies.AllowUserToDeleteRows = false;
            this.dgvSpecies.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvSpecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecies.Location = new System.Drawing.Point(35, 75);
            this.dgvSpecies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSpecies.Name = "dgvSpecies";
            this.dgvSpecies.ReadOnly = true;
            this.dgvSpecies.RowHeadersWidth = 62;
            this.dgvSpecies.RowTemplate.Height = 28;
            this.dgvSpecies.Size = new System.Drawing.Size(463, 202);
            this.dgvSpecies.TabIndex = 5;
            this.dgvSpecies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpecies_CellContentClick);
            // 
            // lb_Informatiu
            // 
            this.lb_Informatiu.AutoSize = true;
            this.lb_Informatiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Informatiu.Location = new System.Drawing.Point(32, 294);
            this.lb_Informatiu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Informatiu.Name = "lb_Informatiu";
            this.lb_Informatiu.Size = new System.Drawing.Size(86, 24);
            this.lb_Informatiu.TabIndex = 8;
            this.lb_Informatiu.Text = "Campos";
            // 
            // formBaseTratamientoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(533, 431);
            this.Controls.Add(this.lb_Informatiu);
            this.Controls.Add(this.btActualitzar);
            this.Controls.Add(this.btNou);
            this.Controls.Add(this.dgvSpecies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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