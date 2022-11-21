
namespace aplicacionPrincipal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNivelUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntApp4 = new System.Windows.Forms.Button();
            this.bntApp3 = new System.Windows.Forms.Button();
            this.bntApp2 = new System.Windows.Forms.Button();
            this.bntApp1 = new System.Windows.Forms.Button();
            this.bntApp5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(37, 18);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(163, 20);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(-10, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 10);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(38, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(90, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha de hoy";
            // 
            // lblNivelUsuario
            // 
            this.lblNivelUsuario.AutoSize = true;
            this.lblNivelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelUsuario.Location = new System.Drawing.Point(37, 95);
            this.lblNivelUsuario.Name = "lblNivelUsuario";
            this.lblNivelUsuario.Size = new System.Drawing.Size(319, 20);
            this.lblNivelUsuario.TabIndex = 3;
            this.lblNivelUsuario.Text = "Aplicaciones disponibles para el nivel actual:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bntApp5);
            this.panel1.Controls.Add(this.bntApp4);
            this.panel1.Controls.Add(this.bntApp3);
            this.panel1.Controls.Add(this.bntApp2);
            this.panel1.Controls.Add(this.bntApp1);
            this.panel1.Location = new System.Drawing.Point(41, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 220);
            this.panel1.TabIndex = 4;
            // 
            // bntApp4
            // 
            this.bntApp4.Enabled = false;
            this.bntApp4.Location = new System.Drawing.Point(137, 126);
            this.bntApp4.Name = "bntApp4";
            this.bntApp4.Size = new System.Drawing.Size(81, 71);
            this.bntApp4.TabIndex = 3;
            this.bntApp4.Text = "button4";
            this.bntApp4.UseVisualStyleBackColor = true;
            // 
            // bntApp3
            // 
            this.bntApp3.Location = new System.Drawing.Point(137, 30);
            this.bntApp3.Name = "bntApp3";
            this.bntApp3.Size = new System.Drawing.Size(81, 71);
            this.bntApp3.TabIndex = 2;
            this.bntApp3.Text = "button3";
            this.bntApp3.UseVisualStyleBackColor = true;
            // 
            // bntApp2
            // 
            this.bntApp2.Location = new System.Drawing.Point(30, 126);
            this.bntApp2.Name = "bntApp2";
            this.bntApp2.Size = new System.Drawing.Size(81, 71);
            this.bntApp2.TabIndex = 1;
            this.bntApp2.Text = "button2";
            this.bntApp2.UseVisualStyleBackColor = true;
            // 
            // bntApp1
            // 
            this.bntApp1.Location = new System.Drawing.Point(30, 30);
            this.bntApp1.Name = "bntApp1";
            this.bntApp1.Size = new System.Drawing.Size(81, 71);
            this.bntApp1.TabIndex = 0;
            this.bntApp1.Text = "button1";
            this.bntApp1.UseVisualStyleBackColor = true;
            // 
            // bntApp5
            // 
            this.bntApp5.Enabled = false;
            this.bntApp5.Location = new System.Drawing.Point(246, 30);
            this.bntApp5.Name = "bntApp5";
            this.bntApp5.Size = new System.Drawing.Size(81, 71);
            this.bntApp5.TabIndex = 4;
            this.bntApp5.Text = "button5";
            this.bntApp5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::aplicacionPrincipal.Properties.Resources.fondoDeFormPrinc2;
            this.ClientSize = new System.Drawing.Size(682, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNivelUsuario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombreUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNivelUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntApp4;
        private System.Windows.Forms.Button bntApp3;
        private System.Windows.Forms.Button bntApp2;
        private System.Windows.Forms.Button bntApp1;
        private System.Windows.Forms.Button bntApp5;
    }
}

