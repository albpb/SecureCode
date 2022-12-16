
namespace FormsTratamientoDatos
{
    partial class formTaulaSimple_Species
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
            this.lb_CodeSpecie = new System.Windows.Forms.Label();
            this.lb_DescSpecie = new System.Windows.Forms.Label();
            this.swTextbox_CodeSpecie = new CustomControls.SWTextbox();
            this.swTextbox_DescSpecie = new CustomControls.SWTextbox();
            this.SuspendLayout();
            // 
            // lb_CodeSpecie
            // 
            this.lb_CodeSpecie.AutoSize = true;
            this.lb_CodeSpecie.Location = new System.Drawing.Point(49, 508);
            this.lb_CodeSpecie.Name = "lb_CodeSpecie";
            this.lb_CodeSpecie.Size = new System.Drawing.Size(102, 20);
            this.lb_CodeSpecie.TabIndex = 9;
            this.lb_CodeSpecie.Text = "Codi Especie";
            // 
            // lb_DescSpecie
            // 
            this.lb_DescSpecie.AutoSize = true;
            this.lb_DescSpecie.Location = new System.Drawing.Point(256, 508);
            this.lb_DescSpecie.Name = "lb_DescSpecie";
            this.lb_DescSpecie.Size = new System.Drawing.Size(136, 20);
            this.lb_DescSpecie.TabIndex = 10;
            this.lb_DescSpecie.Text = "Descripció Specie";
            // 
            // swTextbox_CodeSpecie
            // 
            this.swTextbox_CodeSpecie.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox_CodeSpecie.DBName = "CodeSpecie";
            this.swTextbox_CodeSpecie.ForeignKey = false;
            this.swTextbox_CodeSpecie.IsEmpty = false;
            this.swTextbox_CodeSpecie.Location = new System.Drawing.Point(53, 549);
            this.swTextbox_CodeSpecie.Name = "swTextbox_CodeSpecie";
            this.swTextbox_CodeSpecie.Size = new System.Drawing.Size(175, 26);
            this.swTextbox_CodeSpecie.TabIndex = 11;
            // 
            // swTextbox_DescSpecie
            // 
            this.swTextbox_DescSpecie.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox_DescSpecie.DBName = "DescSpecie";
            this.swTextbox_DescSpecie.ForeignKey = false;
            this.swTextbox_DescSpecie.IsEmpty = false;
            this.swTextbox_DescSpecie.Location = new System.Drawing.Point(260, 549);
            this.swTextbox_DescSpecie.Name = "swTextbox_DescSpecie";
            this.swTextbox_DescSpecie.Size = new System.Drawing.Size(175, 26);
            this.swTextbox_DescSpecie.TabIndex = 12;
            // 
            // formTaulaSimple_Species
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 603);
            this.Controls.Add(this.swTextbox_DescSpecie);
            this.Controls.Add(this.swTextbox_CodeSpecie);
            this.Controls.Add(this.lb_DescSpecie);
            this.Controls.Add(this.lb_CodeSpecie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formTaulaSimple_Species";
            this.NomTaula = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formHeredat_MantenimentTaulaSimple_Species";
            this.Controls.SetChildIndex(this.lb_CodeSpecie, 0);
            this.Controls.SetChildIndex(this.lb_DescSpecie, 0);
            this.Controls.SetChildIndex(this.swTextbox_CodeSpecie, 0);
            this.Controls.SetChildIndex(this.swTextbox_DescSpecie, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CodeSpecie;
        private System.Windows.Forms.Label lb_DescSpecie;
        private CustomControls.SWTextbox swTextbox_CodeSpecie;
        private CustomControls.SWTextbox swTextbox_DescSpecie;
    }
}