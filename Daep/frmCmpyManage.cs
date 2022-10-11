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
    public partial class frmCmpyManage : Form
    {                
        public frmCmpyManage()
        {
            InitializeComponent();
        }

        private void mnuAddCmpy_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmCmpyReg == null || frmMgr.frmCmpyReg.IsDisposed)
            {
                frmMgr.frmCmpyReg = new frmCmpyReg();
                frmMgr.frmCmpyReg.MdiParent = this.MdiParent;                
            }
            frmMgr.frmCmpyReg.Text = "거래처등록";
            frmMgr.frmCmpyReg.cmpyCode = null;
            frmMgr.frmCmpyReg.init();
            frmMgr.frmCmpyReg.Show();
            frmMgr.frmCmpyReg.Activate();
        }

        private void mnuGetCmpy_Click(object sender, EventArgs e)
        {
            CmpyCode.getCmpyCodeAll();
        }

        private void frmCmpyManage_Load(object sender, EventArgs e)
        {
            CmpyCode.getCmpyCodeAll();
            gridCmpy.DataSource = dbWork.ds.Tables["CMPYCODES"];
        }

        private void gridCmpy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];
            CmpyCode cmpyCode = new CmpyCode();
            cmpyCode.cmpyCode = row.Cells["사업자번호"].Value.ToString();
            cmpyCode.cmpyName = row.Cells["상호"].Value.ToString();
            cmpyCode.ceo = row.Cells["대표"].Value.ToString();
            cmpyCode.addr = row.Cells["사업장주소"].Value.ToString();
            cmpyCode.cmpyType = row.Cells["업태"].Value.ToString();
            cmpyCode.item = row.Cells["종목"].Value.ToString();
            cmpyCode.type = row.Cells["구분"].Value.ToString();

            if (frmMgr.frmCmpyReg == null || frmMgr.frmCmpyReg.IsDisposed)
            {
                frmMgr.frmCmpyReg = new frmCmpyReg();
                frmMgr.frmCmpyReg.MdiParent = this.MdiParent;
            }
            frmMgr.frmCmpyReg.Text = "거래처수정";
            frmMgr.frmCmpyReg.cmpyCode = cmpyCode;
            frmMgr.frmCmpyReg.init();            
            frmMgr.frmCmpyReg.Show();
            frmMgr.frmCmpyReg.Activate();
        }

        private void mnuDeleteCmpy_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridCmpy.SelectedRows)                
            {
                CmpyCode cmpyCode = new CmpyCode();
                cmpyCode.cmpyCode = row.Cells["사업자번호"].Value.ToString();
                cmpyCode.delCmpyCode();                
            }
            CmpyCode.getCmpyCodeAll();
        }
    }
}
