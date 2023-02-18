
namespace ConsoleForms
{
    partial class OpenConsoleForm
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
            this.pictureBox_btOpenConsole = new System.Windows.Forms.PictureBox();
            this.lbAbrirConsola = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_btOpenConsole)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_btOpenConsole
            // 
            this.pictureBox_btOpenConsole.Image = global::ConsoleForms.Properties.Resources.terminal;
            this.pictureBox_btOpenConsole.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox_btOpenConsole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_btOpenConsole.Name = "pictureBox_btOpenConsole";
            this.pictureBox_btOpenConsole.Size = new System.Drawing.Size(422, 335);
            this.pictureBox_btOpenConsole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_btOpenConsole.TabIndex = 0;
            this.pictureBox_btOpenConsole.TabStop = false;
            this.pictureBox_btOpenConsole.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_btOpenConsole_MouseClick);
            // 
            // lbAbrirConsola
            // 
            this.lbAbrirConsola.AutoSize = true;
            this.lbAbrirConsola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(55)))), ((int)(((byte)(17)))));
            this.lbAbrirConsola.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbrirConsola.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAbrirConsola.Location = new System.Drawing.Point(129, 293);
            this.lbAbrirConsola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAbrirConsola.Name = "lbAbrirConsola";
            this.lbAbrirConsola.Size = new System.Drawing.Size(168, 26);
            this.lbAbrirConsola.TabIndex = 1;
            this.lbAbrirConsola.Text = "Abrir Consola";
            // 
            // OpenConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 330);
            this.Controls.Add(this.lbAbrirConsola);
            this.Controls.Add(this.pictureBox_btOpenConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OpenConsoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Consola";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ObrirConsola_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_btOpenConsole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_btOpenConsole;
        private System.Windows.Forms.Label lbAbrirConsola;

    }
}