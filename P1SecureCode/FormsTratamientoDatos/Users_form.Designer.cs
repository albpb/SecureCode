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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.swTextbox2.Location = new System.Drawing.Point(47, 480);
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
            this.swTextbox3.Location = new System.Drawing.Point(47, 533);
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
            this.swTextbox4.Enabled = false;
            this.swTextbox4.ForeignKey = true;
            this.swTextbox4.IsEmpty = false;
            this.swTextbox4.Location = new System.Drawing.Point(1309, 97);
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
            this.swCategory.Location = new System.Drawing.Point(685, 145);
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
            this.swTextbox5.Enabled = false;
            this.swTextbox5.ForeignKey = true;
            this.swTextbox5.IsEmpty = false;
            this.swTextbox5.Location = new System.Drawing.Point(1309, 151);
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
            this.swPlanet.Location = new System.Drawing.Point(685, 206);
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
            this.swTextbox6.Enabled = false;
            this.swTextbox6.ForeignKey = true;
            this.swTextbox6.IsEmpty = false;
            this.swTextbox6.Location = new System.Drawing.Point(1309, 209);
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
            this.swSpecie.Location = new System.Drawing.Point(685, 266);
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
            this.swTextbox7.Enabled = false;
            this.swTextbox7.ForeignKey = true;
            this.swTextbox7.IsEmpty = false;
            this.swTextbox7.Location = new System.Drawing.Point(1309, 272);
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
            this.crystalReportViewer.Location = new System.Drawing.Point(695, 326);
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
            this.crystalReportViewer.Size = new System.Drawing.Size(746, 400);
            this.crystalReportViewer.TabIndex = 20;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer.ToolPanelWidth = 267;
            // 
            // swTextbox_IdUser
            // 
            this.swTextbox_IdUser.Data = CustomControls.SWTextbox.DataType.Numero;
            this.swTextbox_IdUser.DBName = "idUser";
            this.swTextbox_IdUser.Enabled = false;
            this.swTextbox_IdUser.ForeignKey = false;
            this.swTextbox_IdUser.IsEmpty = false;
            this.swTextbox_IdUser.Location = new System.Drawing.Point(705, 682);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Código del usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Imagen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Rango";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(692, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Planetas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(692, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Especie";
            // 
            // Users_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1507, 756);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ActualizarTarjetaIdentificación);
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
            this.Controls.Add(this.swTextbox_IdUser);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Users_form";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Users_form_Load);
            this.Controls.SetChildIndex(this.swTextbox_IdUser, 0);
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
            this.Controls.SetChildIndex(this.bt_ActualizarTarjetaIdentificación, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}