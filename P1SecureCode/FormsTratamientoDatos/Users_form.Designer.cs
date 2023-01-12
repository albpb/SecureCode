using System.Collections;
using System;
namespace FormsTratamientoDatos
{
    partial class Users_form
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
            this.swTextbox1 = new CustomControls.SWTextbox();
            this.swTextbox2 = new CustomControls.SWTextbox();
            this.swTextbox3 = new CustomControls.SWTextbox();
            this.swRank = new CustomControls.SWCodi();
            this.swTextbox4 = new CustomControls.SWTextbox();
            this.swCategory = new CustomControls.SWCodi();
            this.swTextbox5 = new CustomControls.SWTextbox();
            this.swPlanet = new CustomControls.SWCodi();
            this.swTextbox6 = new CustomControls.SWTextbox();
            this.swSpecie = new CustomControls.SWCodi();
            this.swTextbox7 = new CustomControls.SWTextbox();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.swTextbox_IdUser = new CustomControls.SWTextbox();
            this.bt_ActualizarTarjetaIdentificación = new System.Windows.Forms.Button();
            this.pl_TaparSwTB_IdUser = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox1.DBName = "CodeUser";
            this.swTextbox1.ForeignKey = false;
            this.swTextbox1.IsEmpty = false;
            this.swTextbox1.Location = new System.Drawing.Point(53, 522);
            this.swTextbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(148, 26);
            this.swTextbox1.SWCodi = null;
            this.swTextbox1.TabIndex = 9;
            // 
            // swTextbox2
            // 
            this.swTextbox2.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox2.DBName = "UserName";
            this.swTextbox2.ForeignKey = false;
            this.swTextbox2.IsEmpty = false;
            this.swTextbox2.Location = new System.Drawing.Point(53, 562);
            this.swTextbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(419, 26);
            this.swTextbox2.SWCodi = null;
            this.swTextbox2.TabIndex = 10;
            // 
            // swTextbox3
            // 
            this.swTextbox3.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox3.DBName = "Photo";
            this.swTextbox3.ForeignKey = false;
            this.swTextbox3.IsEmpty = false;
            this.swTextbox3.Location = new System.Drawing.Point(53, 602);
            this.swTextbox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.Size = new System.Drawing.Size(419, 26);
            this.swTextbox3.SWCodi = null;
            this.swTextbox3.TabIndex = 11;
            // 
            // swRank
            // 
            this.swRank.ClasseCS = null;
            this.swRank.ControlID = null;
            this.swRank.FormCS = null;
            this.swRank.Location = new System.Drawing.Point(771, 115);
            this.swRank.Margin = new System.Windows.Forms.Padding(6);
            this.swRank.Name = "swRank";
            this.swRank.Nomcodi = "CodeRank";
            this.swRank.NomDesc = "DescRank";
            this.swRank.NomId = "idUserRank";
            this.swRank.NomTaula = "UserRanks";
            this.swRank.Size = new System.Drawing.Size(716, 41);
            this.swRank.TabIndex = 12;
            // 
            // swTextbox4
            // 
            this.swTextbox4.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox4.DBName = "idUserRank";
            this.swTextbox4.ForeignKey = true;
            this.swTextbox4.IsEmpty = false;
            this.swTextbox4.Location = new System.Drawing.Point(1473, 120);
            this.swTextbox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox4.Name = "swTextbox4";
            this.swTextbox4.Size = new System.Drawing.Size(148, 26);
            this.swTextbox4.SWCodi = "swRank";
            this.swTextbox4.TabIndex = 13;
            // 
            // swCategory
            // 
            this.swCategory.ClasseCS = null;
            this.swCategory.ControlID = null;
            this.swCategory.FormCS = null;
            this.swCategory.Location = new System.Drawing.Point(771, 172);
            this.swCategory.Margin = new System.Windows.Forms.Padding(6);
            this.swCategory.Name = "swCategory";
            this.swCategory.Nomcodi = "CodeCategory";
            this.swCategory.NomDesc = "DescCategory";
            this.swCategory.NomId = "idUserCategory";
            this.swCategory.NomTaula = "UserCategories";
            this.swCategory.Size = new System.Drawing.Size(716, 41);
            this.swCategory.TabIndex = 14;
            // 
            // swTextbox5
            // 
            this.swTextbox5.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox5.DBName = "idUserCategory";
            this.swTextbox5.ForeignKey = true;
            this.swTextbox5.IsEmpty = false;
            this.swTextbox5.Location = new System.Drawing.Point(1473, 172);
            this.swTextbox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox5.Name = "swTextbox5";
            this.swTextbox5.Size = new System.Drawing.Size(148, 26);
            this.swTextbox5.SWCodi = "swCategory";
            this.swTextbox5.TabIndex = 15;
            // 
            // swPlanet
            // 
            this.swPlanet.ClasseCS = null;
            this.swPlanet.ControlID = null;
            this.swPlanet.FormCS = null;
            this.swPlanet.Location = new System.Drawing.Point(771, 225);
            this.swPlanet.Margin = new System.Windows.Forms.Padding(6);
            this.swPlanet.Name = "swPlanet";
            this.swPlanet.Nomcodi = "CodePlanet";
            this.swPlanet.NomDesc = "DescPlanet";
            this.swPlanet.NomId = "idPlanet";
            this.swPlanet.NomTaula = "Planets";
            this.swPlanet.Size = new System.Drawing.Size(716, 41);
            this.swPlanet.TabIndex = 16;
            // 
            // swTextbox6
            // 
            this.swTextbox6.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox6.DBName = "idPlanet";
            this.swTextbox6.ForeignKey = true;
            this.swTextbox6.IsEmpty = false;
            this.swTextbox6.Location = new System.Drawing.Point(1473, 225);
            this.swTextbox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox6.Name = "swTextbox6";
            this.swTextbox6.Size = new System.Drawing.Size(148, 26);
            this.swTextbox6.SWCodi = "swPlanet";
            this.swTextbox6.TabIndex = 17;
            // 
            // swSpecie
            // 
            this.swSpecie.ClasseCS = null;
            this.swSpecie.ControlID = null;
            this.swSpecie.FormCS = null;
            this.swSpecie.Location = new System.Drawing.Point(771, 278);
            this.swSpecie.Margin = new System.Windows.Forms.Padding(6);
            this.swSpecie.Name = "swSpecie";
            this.swSpecie.Nomcodi = "CodeSpecie";
            this.swSpecie.NomDesc = "DescSpecie";
            this.swSpecie.NomId = "idSpecie";
            this.swSpecie.NomTaula = "Species";
            this.swSpecie.Size = new System.Drawing.Size(716, 41);
            this.swSpecie.TabIndex = 18;
            // 
            // swTextbox7
            // 
            this.swTextbox7.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox7.DBName = "idSpecie";
            this.swTextbox7.ForeignKey = true;
            this.swTextbox7.IsEmpty = false;
            this.swTextbox7.Location = new System.Drawing.Point(1473, 278);
            this.swTextbox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox7.Name = "swTextbox7";
            this.swTextbox7.Size = new System.Drawing.Size(148, 26);
            this.swTextbox7.SWCodi = "swSpecie";
            this.swTextbox7.TabIndex = 19;
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.DisplayStatusBar = false;
            this.crystalReportViewer.Location = new System.Drawing.Point(793, 352);
            this.crystalReportViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ShowCopyButton = false;
            this.crystalReportViewer.ShowGotoPageButton = false;
            this.crystalReportViewer.ShowGroupTreeButton = false;
            this.crystalReportViewer.ShowLogo = false;
            this.crystalReportViewer.ShowPageNavigateButtons = false;
            this.crystalReportViewer.ShowParameterPanelButton = false;
            this.crystalReportViewer.ShowRefreshButton = false;
            this.crystalReportViewer.ShowTextSearchButton = false;
            this.crystalReportViewer.Size = new System.Drawing.Size(786, 491);
            this.crystalReportViewer.TabIndex = 20;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer.ToolPanelWidth = 267;
            // 
            // swTextbox_IdUser
            // 
            this.swTextbox_IdUser.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox_IdUser.DBName = "idUser";
            this.swTextbox_IdUser.ForeignKey = false;
            this.swTextbox_IdUser.IsEmpty = false;
            this.swTextbox_IdUser.Location = new System.Drawing.Point(629, 736);
            this.swTextbox_IdUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swTextbox_IdUser.Name = "swTextbox_IdUser";
            this.swTextbox_IdUser.Size = new System.Drawing.Size(118, 26);
            this.swTextbox_IdUser.SWCodi = null;
            this.swTextbox_IdUser.TabIndex = 21;
            // 
            // bt_ActualizarTarjetaIdentificación
            // 
            this.bt_ActualizarTarjetaIdentificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ActualizarTarjetaIdentificación.Location = new System.Drawing.Point(523, 452);
            this.bt_ActualizarTarjetaIdentificación.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_ActualizarTarjetaIdentificación.Name = "bt_ActualizarTarjetaIdentificación";
            this.bt_ActualizarTarjetaIdentificación.Size = new System.Drawing.Size(224, 136);
            this.bt_ActualizarTarjetaIdentificación.TabIndex = 22;
            this.bt_ActualizarTarjetaIdentificación.Text = "Cargar Tarjeta Identificación";
            this.bt_ActualizarTarjetaIdentificación.UseVisualStyleBackColor = true;
            this.bt_ActualizarTarjetaIdentificación.Click += new System.EventHandler(this.bt_ActualizarTarjetaIdentificación_Click);
            // 
            // pl_TaparSwTB_IdUser
            // 
            this.pl_TaparSwTB_IdUser.Location = new System.Drawing.Point(570, 704);
            this.pl_TaparSwTB_IdUser.Name = "pl_TaparSwTB_IdUser";
            this.pl_TaparSwTB_IdUser.Size = new System.Drawing.Size(200, 100);
            this.pl_TaparSwTB_IdUser.TabIndex = 23;
            // 
            // Users_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 879);
            this.Controls.Add(this.pl_TaparSwTB_IdUser);
            this.Controls.Add(this.bt_ActualizarTarjetaIdentificación);
            this.Controls.Add(this.swTextbox_IdUser);
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.swTextbox7);
            this.Controls.Add(this.swSpecie);
            this.Controls.Add(this.swTextbox6);
            this.Controls.Add(this.swPlanet);
            this.Controls.Add(this.swTextbox5);
            this.Controls.Add(this.swCategory);
            this.Controls.Add(this.swTextbox4);
            this.Controls.Add(this.swRank);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimumSize = new System.Drawing.Size(1900, 935);
            this.Name = "Users_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users_form";
            this.Load += new System.EventHandler(this.Users_form_Load);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.Controls.SetChildIndex(this.swRank, 0);
            this.Controls.SetChildIndex(this.swTextbox4, 0);
            this.Controls.SetChildIndex(this.swCategory, 0);
            this.Controls.SetChildIndex(this.swTextbox5, 0);
            this.Controls.SetChildIndex(this.swPlanet, 0);
            this.Controls.SetChildIndex(this.swTextbox6, 0);
            this.Controls.SetChildIndex(this.swSpecie, 0);
            this.Controls.SetChildIndex(this.swTextbox7, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer, 0);
            this.Controls.SetChildIndex(this.swTextbox_IdUser, 0);
            this.Controls.SetChildIndex(this.bt_ActualizarTarjetaIdentificación, 0);
            this.Controls.SetChildIndex(this.pl_TaparSwTB_IdUser, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox swTextbox1;
        private CustomControls.SWTextbox swTextbox2;
        private CustomControls.SWTextbox swTextbox3;
        private CustomControls.SWCodi swRank;
        private CustomControls.SWTextbox swTextbox4;
        private CustomControls.SWCodi swCategory;
        private CustomControls.SWTextbox swTextbox5;
        private CustomControls.SWCodi swPlanet;
        private CustomControls.SWTextbox swTextbox6;
        private CustomControls.SWCodi swSpecie;
        private CustomControls.SWTextbox swTextbox7;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private CustomControls.SWTextbox swTextbox_IdUser;
        private System.Windows.Forms.Button bt_ActualizarTarjetaIdentificación;
        private System.Windows.Forms.Panel pl_TaparSwTB_IdUser;
    }
}