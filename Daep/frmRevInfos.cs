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
    public partial class frmRevInfos : Form
    {        
        public frmRevInfos()
        {
            InitializeComponent();
        }

        private void frmRevInfos_Load(object sender, EventArgs e)
        {
            dtpSDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-") + "01");
            dtpEDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-") + "01").AddMonths(1).AddDays(-1);                        
            
            CmpyCode.getCmpyCodeAll();
            bsrcCmpy.CurrentChanged += BsrcCmpy_CurrentChanged;
            bsrcCmpy.DataSource = dbWork.ds.Tables["CMPYCODES"];
            if(bsrcCmpy.Count < 1)
            {
                List<CmpyCode> items = new List<CmpyCode>();
                items.Add(new CmpyCode("", "회사 전체"));
                cboCmpyName.DisplayMember = "CMPYNAME";
                cboCmpyName.ValueMember = "CMPYCODE";
                cboCmpyName.DataSource = items;
            }

            ProdCode.getProdCodeLatestAll();
            bsrcProd.CurrentItemChanged += BsrcProd_CurrentItemChanged;
            bsrcProd.DataSource = dbWork.ds.Tables["PRODCODES"];
            if (bsrcProd.Count < 1)
            {
                List<ProdCode> items = new List<ProdCode>();
                items.Add(new ProdCode("", "", "제품 전체"));
                cboProdName.DisplayMember = "PRODNAME";
                cboProdName.ValueMember = "PRODCODE";
                cboProdName.DataSource = items;
            }

            RevInfo.getRevInfos(dtpSDate.Value.ToString("yyyyMMdd"), dtpEDate.Value.ToString("yyyyMMdd"), cboCmpyName.SelectedValue.ToString(), cboProdName.SelectedValue.ToString());
            
            bsrcRev.CurrentItemChanged += BsrcRev_CurrentItemChanged;

            bsrcDummy.DataSource = RevInfo.Dummy;
            bsrcDummy.CurrentItemChanged += BsrcDummy_CurrentItemChanged;
        }

        private void BsrcDummy_CurrentItemChanged(object sender, EventArgs e)
        {
            RevInfo.getRevInfos(dtpSDate.Value.ToString("yyyyMMdd"), dtpEDate.Value.ToString("yyyyMMdd"), cboCmpyName.SelectedValue.ToString(), cboProdName.SelectedValue.ToString());
        }

        private void BsrcRev_CurrentItemChanged(object sender, EventArgs e)
        {
            setGridRev();
        }

        private void BsrcProd_CurrentItemChanged(object sender, EventArgs e)
        {
            setCboProd();
        }

        private void BsrcCmpy_CurrentChanged(object sender, EventArgs e)
        {
            setCboCmpy();
        }

        private void btnGetInfos_Click(object sender, EventArgs e)
        {
            RevInfo.getRevInfos(dtpSDate.Value.ToString("yyyyMMdd"), dtpEDate.Value.ToString("yyyyMMdd"), cboCmpyName.SelectedValue.ToString(), cboProdName.SelectedValue.ToString());
        }

        private void dtpSDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpSDate.Value > dtpEDate.Value)
            {
                dtpEDate.Value = dtpSDate.Value;
            }
        }

        private void dtpEDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpSDate.Value > dtpEDate.Value)
            {
                dtpSDate.Value = dtpEDate.Value;
            }
        }
        public void setCboCmpy()
        {
            if (bsrcCmpy.Count > 0)
            {
                List<CmpyCode> items = new List<CmpyCode>();
                items.Add(new CmpyCode("", "회사 전체"));
                foreach (DataRowView row in bsrcCmpy)
                {
                    items.Add(new CmpyCode(row["사업자번호"].ToString(), row["상호"].ToString()));
                }
                cboCmpyName.DisplayMember = "CMPYNAME";
                cboCmpyName.ValueMember = "CMPYCODE";
                cboCmpyName.DataSource = items;
            }
        }
        public void setCboProd()
        {
            if (bsrcProd.Count > 0)
            {
                List<ProdCode> items = new List<ProdCode>();
                items.Add(new ProdCode("", "", "제품 전체"));
                foreach (DataRowView row in bsrcProd)
                {
                    items.Add(new ProdCode(row["적용일"].ToString(), row["품번"].ToString(), row["품명"].ToString()));
                }
                cboProdName.DisplayMember = "PRODNAME";
                cboProdName.ValueMember = "PRODCODE";
                cboProdName.DataSource = items;
            }
        }
        public void setGridRev()
        {
            gridRev.DataSource = dbWork.ds.Tables["REVINFOS"].Clone();
            if(bsrcRev.Count > 0)
            {                
                gridRev.Columns[dbWork.ds.Tables["REVINFOS"].Columns["SEQ"].Ordinal].Visible = false;
                gridRev.Columns[dbWork.ds.Tables["REVINFOS"].Columns["수량"].Ordinal].DefaultCellStyle.Format = "N0";
                gridRev.Columns[dbWork.ds.Tables["REVINFOS"].Columns["금액"].Ordinal].DefaultCellStyle.Format = "N0";

                DataRow prevRow = dbWork.ds.Tables["REVINFOS"].Rows[0];
                DataRow nRow;
                foreach (DataRow row in dbWork.ds.Tables["REVINFOS"].Rows)
                {
                    nRow = ((DataTable)gridRev.DataSource).NewRow();
                    if (prevRow["매출일자"].ToString() != row["매출일자"].ToString() || prevRow["사업자번호"].ToString() != row["사업자번호"].ToString())
                    {
                        nRow["매출일자"] = prevRow["매출일자"].ToString();
                        nRow["사업자번호"] = prevRow["사업자번호"].ToString();
                        nRow["상호"] = prevRow["상호"].ToString();
                        nRow["품번"] = "합계";
                        nRow["금액"] = dbWork.ds.Tables["REVINFOS"].Select().Where(r => r["매출일자"].ToString() == prevRow["매출일자"].ToString() && r["사업자번호"].ToString() == prevRow["사업자번호"].ToString()).Select(r => r["금액"]).Sum(x => int.Parse(x.ToString()));
                        ((DataTable)gridRev.DataSource).Rows.Add(nRow);
                    }
                    ((DataTable)gridRev.DataSource).ImportRow(row);
                    prevRow = row;
                }
                nRow = ((DataTable)gridRev.DataSource).NewRow();
                nRow["매출일자"] = prevRow["매출일자"].ToString();
                nRow["사업자번호"] = prevRow["사업자번호"].ToString();
                nRow["상호"] = prevRow["상호"].ToString();
                nRow["품번"] = "합계";                
                nRow["금액"] = dbWork.ds.Tables["REVINFOS"].Select().Where(r => r["매출일자"].ToString() == prevRow["매출일자"].ToString() && r["사업자번호"].ToString() == prevRow["사업자번호"].ToString()).Select(r => r["금액"]).Sum(x => int.Parse(x.ToString()));
                ((DataTable)gridRev.DataSource).Rows.Add(nRow);

                nRow = ((DataTable)gridRev.DataSource).NewRow();
                nRow["품번"] = "총계";

                nRow["금액"] = dbWork.ds.Tables["REVINFOS"].Select().Select(r => r["금액"]).Sum(x => int.Parse(x.ToString()));
                ((DataTable)gridRev.DataSource).Rows.Add(nRow);

                ((DataTable)gridRev.DataSource).AcceptChanges();
                foreach (DataGridViewRow row in gridRev.Rows)
                {
                    if (row.Cells["품번"].Value.ToString() == "합계")
                    {
                        row.DefaultCellStyle.ForeColor = Color.Blue;
                    }
                    if (row.Cells["품번"].Value.ToString() == "총계")
                    {
                        row.DefaultCellStyle.ForeColor = Color.Blue;
                        row.DefaultCellStyle.Font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
                    }
                }
            }
        }
        private void gridRev_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];
            if(row.Cells["SEQ"].Value.ToString() == "")
            {
                return;
            }
            RevInfo revInfo = new RevInfo();
            revInfo.revDate = Convert.ToDateTime(row.Cells["매출일자"].Value.ToString()).ToString("yyyyMMdd");
            revInfo.cmpyCode = row.Cells["사업자번호"].Value.ToString();
            revInfo.prodCode = row.Cells["품번"].Value.ToString();
            revInfo.seq = (int)row.Cells["SEQ"].Value;
            revInfo.count = (int)row.Cells["수량"].Value;
            revInfo.amt = (int)row.Cells["금액"].Value;
            revInfo.tag = row.Cells["비고"].Value.ToString();
            if (frmMgr.frmRevReg == null || frmMgr.frmRevReg.IsDisposed)
            {
                frmMgr.frmRevReg = new frmRevReg();
                frmMgr.frmRevReg.MdiParent = this.MdiParent;
            }
            frmMgr.frmRevReg.Text = "매출수정";
            frmMgr.frmRevReg.revInfo = revInfo;
            frmMgr.frmRevReg.init();
            frmMgr.frmRevReg.Show();
            frmMgr.frmRevReg.Activate();
        }        

        private void btnDelInfos_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in gridRev.SelectedRows)
            {
                if (row.Cells["SEQ"].Value.ToString() == "")
                {
                    continue;
                }
                RevInfo revInfo = new RevInfo();
                revInfo.revDate = Convert.ToDateTime(row.Cells["매출일자"].Value.ToString()).ToString("yyyyMMdd");
                revInfo.cmpyCode = row.Cells["사업자번호"].Value.ToString();
                revInfo.prodCode = row.Cells["품번"].Value.ToString();
                revInfo.seq = (int)row.Cells["SEQ"].Value;
                revInfo.count = (int)row.Cells["수량"].Value;
                revInfo.amt = (int)row.Cells["금액"].Value;
                revInfo.tag = row.Cells["비고"].Value.ToString();
                revInfo.delRevInfo();
            }            
            RevInfo.getRevInfos(dtpSDate.Value.ToString("yyyyMMdd"), dtpEDate.Value.ToString("yyyyMMdd"), cboCmpyName.SelectedValue.ToString(), cboProdName.SelectedValue.ToString());
        }

        private void frmRevInfos_Shown(object sender, EventArgs e)
        {
            //Load에 넣으면 합계나 총계의 색상이 안바뀐다.
            bsrcRev.DataSource = dbWork.ds.Tables["REVINFOS"];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<RevInfo> revInfos = new List<RevInfo>();
            foreach(DataGridViewRow row in gridRev.SelectedRows)
            {
                if (row.Cells["SEQ"].Value.ToString() == "")
                {
                    continue;
                }
                RevInfo revInfo = new RevInfo();
                revInfo.revDate = Convert.ToDateTime(row.Cells["매출일자"].Value.ToString()).ToString("yyyyMMdd");
                revInfo.cmpyCode = row.Cells["사업자번호"].Value.ToString();
                revInfo.prodCode = row.Cells["품번"].Value.ToString();
                revInfo.seq = (int)row.Cells["SEQ"].Value;
                revInfos.Add(revInfo);
            }
            if (revInfos.Count == 0)
            {
                return;
            }
            frmRptViewer frmRptViewer = new frmRptViewer(revInfos);
            frmRptViewer.ShowDialog();
        }
    }    
}
