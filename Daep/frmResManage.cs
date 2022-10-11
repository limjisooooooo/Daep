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
    public partial class frmResManage : Form
    {
        public frmResManage()
        {
            InitializeComponent();
        }

        private void mnuAddRes_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmResReg == null || frmMgr.frmResReg.IsDisposed)
            {
                frmMgr.frmResReg = new frmResReg();
                frmMgr.frmResReg.MdiParent = this.MdiParent;                
            }
            frmMgr.frmResReg.Text = "원재료등록";
            frmMgr.frmResReg.resCode = null;
            frmMgr.frmResReg.init();
            frmMgr.frmResReg.Show();
            frmMgr.frmResReg.Activate();
        }

        private void mnuGetRes_Click(object sender, EventArgs e)
        {
            ResCode.getResCodeLatestAll();
        }

        private void frmResManage_Load(object sender, EventArgs e)
        {
            ResCode.getResCodeLatestAll();
            gridRes.DataSource = dbWork.ds.Tables["RESCODES"];
        }

        private void gridRes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(frmMgr.frmResHist == null || frmMgr.frmResHist.IsDisposed)
            {
                frmMgr.frmResHist = new frmResHist();
                frmMgr.frmResHist.MdiParent = this.MdiParent;
                frmMgr.frmResHist.selectResCode = gridRes.Rows[e.RowIndex].Cells["품번"].Value.ToString();
                frmMgr.frmResHist.Show();
                frmMgr.frmResHist.Activate();
            }
            else
            {
                frmMgr.frmResHist.selectResCode = gridRes.Rows[e.RowIndex].Cells["품번"].Value.ToString();
                frmMgr.frmResHist.selectCbo();
                frmMgr.frmResHist.getResHist();
                frmMgr.frmResHist.Show();
                frmMgr.frmResHist.Activate();
            }
        }
    }
}
