using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daep
{
    public partial class frmRptViewer : Form
    {
        public frmRptViewer(List<RevInfo> revInfos)
        {
            InitializeComponent();
            RevInfo.getRptData(revInfos);
            ReportDataSource rds = new ReportDataSource("revInfos", dbWork.ds.Tables["rptRev"]);
            this.rptViewer.LocalReport.DataSources.Clear();
            this.rptViewer.LocalReport.DataSources.Add(rds);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "Daep.rptRev.rdlc";
        }
        public frmRptViewer(List<PurInfo> purInfos)
        {
            InitializeComponent();
            PurInfo.getRptData(purInfos);
            ReportDataSource rds = new ReportDataSource("purInfos", dbWork.ds.Tables["rptPur"]);
            this.rptViewer.LocalReport.DataSources.Clear();
            this.rptViewer.LocalReport.DataSources.Add(rds);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "Daep.rptPur.rdlc";                        
        }

        private void frmRptViewer_Load(object sender, EventArgs e)
        {
            rptViewer.RefreshReport();
        }
        private void rptViewer_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            
        }

        private void frmRptViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            rptViewer.LocalReport.ReleaseSandboxAppDomain();
        }
    }

}
