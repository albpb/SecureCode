
namespace EntityFrameworkForms
{
    partial class OrderForm
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
            this.DGVFactories = new System.Windows.Forms.DataGridView();
            this.LBLCodi = new System.Windows.Forms.Label();
            this.TBCodi = new System.Windows.Forms.TextBox();
            this.TBDesc = new System.Windows.Forms.TextBox();
            this.LBLDesc = new System.Windows.Forms.Label();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.CBFactory = new System.Windows.Forms.ComboBox();
            this.CBPriority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Informatiu = new System.Windows.Forms.Label();
            this.BTNReport = new System.Windows.Forms.Button();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactories)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFactories
            // 
            this.DGVFactories.AllowUserToAddRows = false;
            this.DGVFactories.AllowUserToDeleteRows = false;
            this.DGVFactories.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.DGVFactories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFactories.Location = new System.Drawing.Point(28, 73);
            this.DGVFactories.Name = "DGVFactories";
            this.DGVFactories.ReadOnly = true;
            this.DGVFactories.RowHeadersWidth = 51;
            this.DGVFactories.Size = new System.Drawing.Size(520, 280);
            this.DGVFactories.TabIndex = 0;
            // 
            // LBLCodi
            // 
            this.LBLCodi.AutoSize = true;
            this.LBLCodi.Location = new System.Drawing.Point(25, 402);
            this.LBLCodi.Name = "LBLCodi";
            this.LBLCodi.Size = new System.Drawing.Size(40, 13);
            this.LBLCodi.TabIndex = 1;
            this.LBLCodi.Text = "Código";
            // 
            // TBCodi
            // 
            this.TBCodi.Location = new System.Drawing.Point(94, 399);
            this.TBCodi.Name = "TBCodi";
            this.TBCodi.Size = new System.Drawing.Size(152, 20);
            this.TBCodi.TabIndex = 3;
            this.TBCodi.Tag = "codeOrder";
            // 
            // TBDesc
            // 
            this.TBDesc.Location = new System.Drawing.Point(94, 425);
            this.TBDesc.Name = "TBDesc";
            this.TBDesc.Size = new System.Drawing.Size(194, 20);
            this.TBDesc.TabIndex = 5;
            this.TBDesc.Tag = "dateOrder";
            // 
            // LBLDesc
            // 
            this.LBLDesc.AutoSize = true;
            this.LBLDesc.Location = new System.Drawing.Point(25, 428);
            this.LBLDesc.Name = "LBLDesc";
            this.LBLDesc.Size = new System.Drawing.Size(63, 13);
            this.LBLDesc.TabIndex = 4;
            this.LBLDesc.Text = "Descripción";
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.BackColor = System.Drawing.Color.Ivory;
            this.BTNUpdate.Location = new System.Drawing.Point(458, 22);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(90, 36);
            this.BTNUpdate.TabIndex = 7;
            this.BTNUpdate.Text = "Actualizar";
            this.BTNUpdate.UseVisualStyleBackColor = false;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // CBFactory
            // 
            this.CBFactory.FormattingEnabled = true;
            this.CBFactory.Location = new System.Drawing.Point(583, 399);
            this.CBFactory.Margin = new System.Windows.Forms.Padding(2);
            this.CBFactory.Name = "CBFactory";
            this.CBFactory.Size = new System.Drawing.Size(168, 21);
            this.CBFactory.TabIndex = 8;
            // 
            // CBPriority
            // 
            this.CBPriority.FormattingEnabled = true;
            this.CBPriority.Location = new System.Drawing.Point(353, 399);
            this.CBPriority.Margin = new System.Windows.Forms.Padding(2);
            this.CBPriority.Name = "CBPriority";
            this.CBPriority.Size = new System.Drawing.Size(168, 21);
            this.CBPriority.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fábrica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prioridad";
            // 
            // lb_Informatiu
            // 
            this.lb_Informatiu.AutoSize = true;
            this.lb_Informatiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Informatiu.Location = new System.Drawing.Point(24, 367);
            this.lb_Informatiu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Informatiu.Name = "lb_Informatiu";
            this.lb_Informatiu.Size = new System.Drawing.Size(86, 24);
            this.lb_Informatiu.TabIndex = 12;
            this.lb_Informatiu.Text = "Campos";
            // 
            // BTNReport
            // 
            this.BTNReport.BackColor = System.Drawing.Color.Ivory;
            this.BTNReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNReport.Location = new System.Drawing.Point(769, 386);
            this.BTNReport.Name = "BTNReport";
            this.BTNReport.Size = new System.Drawing.Size(113, 59);
            this.BTNReport.TabIndex = 13;
            this.BTNReport.Text = "VER INFORME";
            this.BTNReport.UseVisualStyleBackColor = false;
            this.BTNReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.DisplayStatusBar = false;
            this.crystalReportViewer.Location = new System.Drawing.Point(554, 22);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ShowCopyButton = false;
            this.crystalReportViewer.ShowGotoPageButton = false;
            this.crystalReportViewer.ShowGroupTreeButton = false;
            this.crystalReportViewer.ShowLogo = false;
            this.crystalReportViewer.ShowPageNavigateButtons = false;
            this.crystalReportViewer.ShowParameterPanelButton = false;
            this.crystalReportViewer.ShowRefreshButton = false;
            this.crystalReportViewer.ShowTextSearchButton = false;
            this.crystalReportViewer.Size = new System.Drawing.Size(511, 331);
            this.crystalReportViewer.TabIndex = 21;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer.ToolPanelWidth = 267;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1077, 470);
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.BTNReport);
            this.Controls.Add(this.lb_Informatiu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBPriority);
            this.Controls.Add(this.CBFactory);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.TBDesc);
            this.Controls.Add(this.LBLDesc);
            this.Controls.Add(this.TBCodi);
            this.Controls.Add(this.LBLCodi);
            this.Controls.Add(this.DGVFactories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OrderForm";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.Factories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVFactories;
        private System.Windows.Forms.Label LBLCodi;
        private System.Windows.Forms.TextBox TBCodi;
        private System.Windows.Forms.TextBox TBDesc;
        private System.Windows.Forms.Label LBLDesc;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.ComboBox CBFactory;
        private System.Windows.Forms.ComboBox CBPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Informatiu;
        private System.Windows.Forms.Button BTNReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    }
}