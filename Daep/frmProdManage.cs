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
    public partial class frmProdManage : Form
    {        
        public frmProdManage()
        {
            InitializeComponent();
        }
        private void mnuAddProd_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmProdReg == null || frmMgr.frmProdReg.IsDisposed)
            {
                frmMgr.frmProdReg = new frmProdReg();
                frmMgr.frmProdReg.MdiParent = this.MdiParent;                
            }
            frmMgr.frmProdReg.Text = "제품등록";
            frmMgr.frmProdReg.prodCode = null;
            frmMgr.frmProdReg.init();
            frmMgr.frmProdReg.Show();
            frmMgr.frmProdReg.Activate();
        }

        private void mnuGetProd_Click(object sender, EventArgs e)
        {
            ProdCode.getProdCodeLatestAll();
        }

        private void frmProdManage_Load(object sender, EventArgs e)
        {
            ProdCode.getProdCodeLatestAll();
            gridProd.DataSource = dbWork.ds.Tables["PRODCODES"];
        }

        private void gridProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmMgr.frmProdHist == null || frmMgr.frmProdHist.IsDisposed)
            {
                frmMgr.frmProdHist = new frmProdHist();
                frmMgr.frmProdHist.MdiParent = this.MdiParent;
                frmMgr.frmProdHist.selectProdCode = gridProd.Rows[e.RowIndex].Cells["품번"].Value.ToString();
                frmMgr.frmProdHist.Show();
                frmMgr.frmProdHist.Activate();
            }
            else
            {
                frmMgr.frmProdHist.selectProdCode = gridProd.Rows[e.RowIndex].Cells["품번"].Value.ToString();
                frmMgr.frmProdHist.selectCbo();
                frmMgr.frmProdHist.getProdHist();
                frmMgr.frmProdHist.Show();
                frmMgr.frmProdHist.Activate();
            }

        }
    }
}
