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
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox1.DBName = "CodeUser";
            this.swTextbox1.ForeignKey = false;
            this.swTextbox1.IsEmpty = false;
            this.swTextbox1.Location = new System.Drawing.Point(47, 418);
            this.swTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(132, 22);
            this.swTextbox1.SWCodi = null;
            this.swTextbox1.TabIndex = 9;
            // 
            // swTextbox2
            // 
            this.swTextbox2.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox2.DBName = "UserName";
            this.swTextbox2.ForeignKey = false;
            this.swTextbox2.IsEmpty = false;
            this.swTextbox2.Location = new System.Drawing.Point(47, 450);
            this.swTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(373, 22);
            this.swTextbox2.SWCodi = null;
            this.swTextbox2.TabIndex = 10;
            // 
            // swTextbox3
            // 
            this.swTextbox3.Data = CustomControls.SWTextbox.DataType.Texte;
            this.swTextbox3.DBName = "Photo";
            this.swTextbox3.ForeignKey = false;
            this.swTextbox3.IsEmpty = false;
            this.swTextbox3.Location = new System.Drawing.Point(47, 482);
            this.swTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.Size = new System.Drawing.Size(373, 22);
            this.swTextbox3.SWCodi = null;
            this.swTextbox3.TabIndex = 11;
            // 
            // swRank
            // 
            this.swRank.ClasseCS = null;
            this.swRank.ControlID = null;
            this.swRank.FormCS = null;
            this.swRank.Location = new System.Drawing.Point(685, 92);
            this.swRank.Margin = new System.Windows.Forms.Padding(5);
            this.swRank.Name = "swRank";
            this.swRank.Nomcodi = "CodeRank";
            this.swRank.NomDesc = "DescRank";
            this.swRank.NomId = "idUserRank";
            this.swRank.NomTaula = "UserRanks";
            this.swRank.Size = new System.Drawing.Size(636, 33);
            this.swRank.TabIndex = 12;
            // 
            // swTextbox4
            // 
            this.swTextbox4.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox4.DBName = "idUserRank";
            this.swTextbox4.ForeignKey = true;
            this.swTextbox4.IsEmpty = false;
            this.swTextbox4.Location = new System.Drawing.Point(1309, 96);
            this.swTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox4.Name = "swTextbox4";
            this.swTextbox4.Size = new System.Drawing.Size(132, 22);
            this.swTextbox4.SWCodi = "swRank";
            this.swTextbox4.TabIndex = 13;
            // 
            // swCategory
            // 
            this.swCategory.ClasseCS = null;
            this.swCategory.ControlID = null;
            this.swCategory.FormCS = null;
            this.swCategory.Location = new System.Drawing.Point(685, 138);
            this.swCategory.Margin = new System.Windows.Forms.Padding(5);
            this.swCategory.Name = "swCategory";
            this.swCategory.Nomcodi = "CodeCategory";
            this.swCategory.NomDesc = "DescCategory";
            this.swCategory.NomId = "idUserCategory";
            this.swCategory.NomTaula = "UserCategories";
            this.swCategory.Size = new System.Drawing.Size(636, 33);
            this.swCategory.TabIndex = 14;
            // 
            // swTextbox5
            // 
            this.swTextbox5.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox5.DBName = "idUserCategory";
            this.swTextbox5.ForeignKey = true;
            this.swTextbox5.IsEmpty = false;
            this.swTextbox5.Location = new System.Drawing.Point(1309, 138);
            this.swTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox5.Name = "swTextbox5";
            this.swTextbox5.Size = new System.Drawing.Size(132, 22);
            this.swTextbox5.SWCodi = "swCategory";
            this.swTextbox5.TabIndex = 15;
            // 
            // swPlanet
            // 
            this.swPlanet.ClasseCS = null;
            this.swPlanet.ControlID = null;
            this.swPlanet.FormCS = null;
            this.swPlanet.Location = new System.Drawing.Point(685, 180);
            this.swPlanet.Margin = new System.Windows.Forms.Padding(5);
            this.swPlanet.Name = "swPlanet";
            this.swPlanet.Nomcodi = "CodePlanet";
            this.swPlanet.NomDesc = "DescPlanet";
            this.swPlanet.NomId = "idPlanet";
            this.swPlanet.NomTaula = "Planets";
            this.swPlanet.Size = new System.Drawing.Size(636, 33);
            this.swPlanet.TabIndex = 16;
            // 
            // swTextbox6
            // 
            this.swTextbox6.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox6.DBName = "idPlanet";
            this.swTextbox6.ForeignKey = true;
            this.swTextbox6.IsEmpty = false;
            this.swTextbox6.Location = new System.Drawing.Point(1309, 180);
            this.swTextbox6.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox6.Name = "swTextbox6";
            this.swTextbox6.Size = new System.Drawing.Size(132, 22);
            this.swTextbox6.SWCodi = "swPlanet";
            this.swTextbox6.TabIndex = 17;
            // 
            // swSpecie
            // 
            this.swSpecie.ClasseCS = null;
            this.swSpecie.ControlID = null;
            this.swSpecie.FormCS = null;
            this.swSpecie.Location = new System.Drawing.Point(685, 222);
            this.swSpecie.Margin = new System.Windows.Forms.Padding(5);
            this.swSpecie.Name = "swSpecie";
            this.swSpecie.Nomcodi = "CodeSpecie";
            this.swSpecie.NomDesc = "DescSpecie";
            this.swSpecie.NomId = "idSpecie";
            this.swSpecie.NomTaula = "Species";
            this.swSpecie.Size = new System.Drawing.Size(636, 33);
            this.swSpecie.TabIndex = 18;
            // 
            // swTextbox7
            // 
            this.swTextbox7.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox7.DBName = "idSpecie";
            this.swTextbox7.ForeignKey = true;
            this.swTextbox7.IsEmpty = false;
            this.swTextbox7.Location = new System.Drawing.Point(1309, 222);
            this.swTextbox7.Margin = new System.Windows.Forms.Padding(4);
            this.swTextbox7.Name = "swTextbox7";
            this.swTextbox7.Size = new System.Drawing.Size(132, 22);
            this.swTextbox7.SWCodi = "swSpecie";
            this.swTextbox7.TabIndex = 19;
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.DisplayStatusBar = false;
            this.crystalReportViewer.Location = new System.Drawing.Point(705, 282);
            this.crystalReportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ShowCopyButton = false;
            this.crystalReportViewer.ShowGotoPageButton = false;
            this.crystalReportViewer.ShowGroupTreeButton = false;
            this.crystalReportViewer.ShowLogo = false;
            this.crystalReportViewer.ShowPageNavigateButtons = false;
            this.crystalReportViewer.ShowParameterPanelButton = false;
            this.crystalReportViewer.ShowRefreshButton = false;
            this.crystalReportViewer.ShowTextSearchButton = false;
            this.crystalReportViewer.Size = new System.Drawing.Size(699, 393);
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
            this.swTextbox_IdUser.Location = new System.Drawing.Point(559, 589);
            this.swTextbox_IdUser.Name = "swTextbox_IdUser";
            this.swTextbox_IdUser.Size = new System.Drawing.Size(105, 22);
            this.swTextbox_IdUser.SWCodi = null;
            this.swTextbox_IdUser.TabIndex = 21;
            // 
            // bt_ActualizarTarjetaIdentificación
            // 
            this.bt_ActualizarTarjetaIdentificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ActualizarTarjetaIdentificación.Location = new System.Drawing.Point(465, 362);
            this.bt_ActualizarTarjetaIdentificación.Name = "bt_ActualizarTarjetaIdentificación";
            this.bt_ActualizarTarjetaIdentificación.Size = new System.Drawing.Size(199, 109);
            this.bt_ActualizarTarjetaIdentificación.TabIndex = 22;
            this.bt_ActualizarTarjetaIdentificación.Text = "Cargar Tarjeta Identificación";
            this.bt_ActualizarTarjetaIdentificación.UseVisualStyleBackColor = true;
            this.bt_ActualizarTarjetaIdentificación.Click += new System.EventHandler(this.bt_ActualizarTarjetaIdentificación_Click);
            // 
            // Users_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1460, 702);
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
            this.Name = "Users_form";
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
    }
}