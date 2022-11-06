
namespace Daep
{
    partial class frmRptViewer
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
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptViewer
            // 
            this.rptViewer.AutoSize = true;
            this.rptViewer.LocalReport.ReportEmbeddedResource = "";
            this.rptViewer.Location = new System.Drawing.Point(0, 1);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.ShowBackButton = false;
            this.rptViewer.ShowContextMenu = false;
            this.rptViewer.ShowCredentialPrompts = false;
            this.rptViewer.ShowExportButton = false;
            this.rptViewer.ShowFindControls = false;
            this.rptViewer.ShowParameterPrompts = false;
            this.rptViewer.ShowProgress = false;
            this.rptViewer.ShowRefreshButton = false;
            this.rptViewer.ShowStopButton = false;
            this.rptViewer.Size = new System.Drawing.Size(734, 716);
            this.rptViewer.TabIndex = 12;
            this.rptViewer.WaitControlDisplayAfter = 1;
            this.rptViewer.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.rptViewer_RenderingComplete);
            // 
            // frmRptViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(734, 717);
            this.Controls.Add(this.rptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRptViewer";
            this.ShowIcon = false;
            this.Text = "거래명세서";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRptViewer_FormClosing);
            this.Load += new System.EventHandler(this.frmRptViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
    }
}