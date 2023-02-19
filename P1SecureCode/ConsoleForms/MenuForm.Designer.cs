
namespace ConsoleForms
{
    partial class MenuForm
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
            this.bt_FormSubirFicheros = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Informatiu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_FormSubirFicheros
            // 
            this.bt_FormSubirFicheros.BackColor = System.Drawing.Color.Ivory;
            this.bt_FormSubirFicheros.Location = new System.Drawing.Point(315, 245);
            this.bt_FormSubirFicheros.Margin = new System.Windows.Forms.Padding(2);
            this.bt_FormSubirFicheros.Name = "bt_FormSubirFicheros";
            this.bt_FormSubirFicheros.Size = new System.Drawing.Size(194, 26);
            this.bt_FormSubirFicheros.TabIndex = 1;
            this.bt_FormSubirFicheros.Text = "Abrir Terminal";
            this.bt_FormSubirFicheros.UseVisualStyleBackColor = false;
            this.bt_FormSubirFicheros.Click += new System.EventHandler(this.bt_FormSubirFicheros_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsoleForms.Properties.Resources.uploud_icon;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_Informatiu
            // 
            this.lb_Informatiu.AutoSize = true;
            this.lb_Informatiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Informatiu.Location = new System.Drawing.Point(25, 28);
            this.lb_Informatiu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Informatiu.Name = "lb_Informatiu";
            this.lb_Informatiu.Size = new System.Drawing.Size(143, 24);
            this.lb_Informatiu.TabIndex = 13;
            this.lb_Informatiu.Text = "Subir archivos";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lb_Informatiu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_FormSubirFicheros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "Modificar FTP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_FormSubirFicheros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Informatiu;
    }
}