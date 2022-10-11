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
    public partial class frmPurInfos : Form
    {
        public frmPurInfos()
        {
            InitializeComponent();
        }

        private void frmPurInfos_Load(object sender, EventArgs e)
        {
            dtpSDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-") + "01");
            dtpEDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-") + "01").AddMonths(1).AddDays(-1);

            CmpyCode.getCmpyCodeAll();
            bsrcCmpy.CurrentChanged += BsrcCmpy_CurrentChanged;
            bsrcCmpy.DataSource = dbWork.ds.Tables["CMPYCODES"];
            if (bsrcCmpy.Count < 1)
            {
                List<CmpyCode> items = new List<CmpyCode>();
                items.Add(new CmpyCode("", "회사 전체"));
                cboCmpyName.DisplayMember = "CMPYNAME";
                cboCmpyName.ValueMember = "CMPYCODE";
                cboCmpyName.DataSource = items;
            }
            ResCode.getResCodeLatestAll();
            bsrcRes.CurrentItemChanged += BsrcRes_CurrentItemChanged;
            bsrcRes.DataSource = dbWork.ds.Tables["RESCODES"];
            if (bsrcRes.Count < 1)
            {
                List<ResCode> items = new List<ResCode>();
                items.Add(new ResCode("", "", "원재료 전체"));
                cboResName.DisplayMember = "RESNAME";
                cboResName.ValueMember = "RESCODE";
                cboResName.DataSource = items;
            }
            PurInfo.getPurInfos(dtpSDate.Value.ToString("yyyyMMdd"), dtpEDate.Value.ToString("yyyyMMdd"), cboCmpyName.SelectedValue.ToString(), cboResName.SelectedValue.ToString());
            bsrcPur.CurrentItemChanged += BsrcPur_CurrentItemChanged;

            bsrcDummy.DataSource = PurInfo.Dummy;
            bsrcDummy.CurrentItemChanged += BsrcDummy_CurrentItemChanged;
        }

        private void BsrcDummy_CurrentItemChanged(object sender, EventArgs e)
        {
            PurInfo.getPurInfos(dtpSDate.Value.ToString("yyyyMMdd"), dtpEDate.Value.ToString("yyyyMMdd"), cboCmpyName.SelectedValue.ToString(), cboResName.SelectedValue.ToString());
        }

        private void BsrcPur_CurrentItemChanged(object sender, EventArgs e)
        {
            setGridPur();
        }

        private void BsrcRes_CurrentItemChanged(object sender, EventArgs e)
        {
            setCboRes();
        }

        private void BsrcCmpy_CurrentChanged(object sender, EventArgs e)
        {
            setCboCmpy();
        }

        private void frmPurInfos_Shown(object sender, EventArgs e)
        {
            //Load에 넣으면 합계나 총계의 색상이 안바뀐다.
            bsrcPur.DataSource = dbWork.ds.Tables["PURINFOS"];
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
        public void setCboRes()
        {
            if (bsrcRes.Count > 0)
            {
                List<ResCode> items = new List<ResCode>();
                items.Add(new ResCode("", "", "원재료 전체"));
                foreach (DataRowView row in bsrcRes)
                {
                    items.Add(new ResCode(row["적용일"].ToString(), row["품번"].ToString(), row["품명"].ToString()));
                }
                cboResName.DisplayMember = "RESNAME";
                cboResName.ValueMember = "RESCODE";
                cboResName.DataSource = items;
            }
        }
        public void setGridPur()
        {
            gridPur.DataSource = dbWork.ds.Tables["PURINFOS"].Clone();
            if (bsrcPur.Count > 0)
            {
                gridPur.Columns[dbWork.ds.Tables["PURINFOS"].Columns["SEQ"].Ordinal].Visible = false;
                gridPur.Columns[dbWork.ds.Tables["PURINFOS"].Columns["수량"].Ordinal].DefaultCellStyle.Format = "N0";
                gridPur.Columns[dbWork.ds.Tables["PURINFOS"].Columns["금액"].Ordinal].DefaultCellStyle.Format = "N0";

                DataRow prevRow = dbWork.ds.Tables["PURINFOS"].Rows[0];
                DataRow nRow;
                foreach (DataRow row in dbWork.ds.Tables["PURINFOS"].Rows)
                {
                    nRow = ((DataTable)gridPur.DataSource).NewRow();
                    if (prevRow["매입일자"].ToString() != row["매입일자"].ToString() || prevRow["사업자번호"].ToString() != row["사업자번호"].ToString())
                    {
                        nRow["매입일자"] = prevRow["매입일자"].ToString();
                        nRow["사업자번호"] = prevRow["사업자번호"].ToString();
                        nRow["상호"] = prevRow["상호"].ToString();
                        nRow["품번"] = "합계";
                        nRow["금액"] = dbWork.ds.Tables["PURINFOS"].Select().Where(r => r["매입일자"].ToString() == prevRow["매입일자"].ToString() && r["사업자번호"].ToString() == prevRow["사업자번호"].ToString()).Select(r => r["금액"]).Sum(x => int.Parse(x.ToString()));
                        ((DataTable)gridPur.DataSource).Rows.Add(nRow);
                    }
                    ((DataTable)gridPur.DataSource).ImportRow(row);
                    prevRow = row;
                }
                nRow = ((DataTable)gridPur.DataSource).NewRow();
                nRow["매입일자"] = prevRow["매입일자"].ToString();
                nRow["사업자번호"] = prevRow["사업자번호"].ToString();
                nRow["상호"] = prevRow["상호"].ToString();
                nRow["품번"] = "합계";
                nRow["금액"] = dbWork.ds.Tables["PURINFOS"].Select().Where(r => r["매입일자"].ToString() == prevRow["매입일자"].ToString() && r["사업자번호"].ToString() == prevRow["사업자번호"].ToString()).Select(r => r["금액"]).Sum(x => int.Parse(x.ToString()));
                ((DataTable)gridPur.DataSource).Rows.Add(nRow);

                nRow = ((DataTable)gridPur.DataSource).NewRow();
                nRow["품번"] = "총계";

                nRow["금액"] = dbWork.ds.Tables["PURINFOS"].Select().Select(r => r["금액"]).Sum(x => int.Parse(x.ToString()));
                ((DataTable)gridPur.DataSource).Rows.Add(nRow);

                ((DataTable)gridPur.DataSource).AcceptChanges();
                foreach (DataGridViewRow row in gridPur.Rows)
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
        private void btnDelInfos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridPur.SelectedRows)
            {
                if (row.Cells["SEQ"].Value.ToString() == "")
                {
                    continue;
                }
                PurInfo purInfo = new PurInfo();
                purInfo.purDate = Convert.ToDateTime(row.Cells["매입일자"].Value.ToString()).ToString("yyyyMMdd");
                purInfo.cmpyCode = row.Cells["사업자번호"].Value.ToString();
                purInfo.resCode = row.Cells["품번"].Value.ToString();
                purInfo.seq = (int)row.Cells["SEQ"].Value;
                purInfo.count = (int)row.Cells["수량"].Value;
                purInfo.amt = (int)row.Cells["금액"].Value;
                purInfo.tag = row.Cells["비고"].Value.ToString();
                purInfo.delPurInfo();
            }
            PurInfo.getPurInfos(dtpSDate.Value.ToString("yyyyMMdd"), dtpEDate.Value.ToString("yyyyMMdd"), cboCmpyName.SelectedValue.ToString(), cboResName.SelectedValue.ToString());
        }

        private void gridPur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];
            if (row.Cells["SEQ"].Value.ToString() == "")
            {
                return;
            }
            PurInfo purInfo = new PurInfo();
            purInfo.purDate = Convert.ToDateTime(row.Cells["매입일자"].Value.ToString()).ToString("yyyyMMdd");
            purInfo.cmpyCode = row.Cells["사업자번호"].Value.ToString();
            purInfo.resCode = row.Cells["품번"].Value.ToString();
            purInfo.seq = (int)row.Cells["SEQ"].Value;
            purInfo.count = (int)row.Cells["수량"].Value;
            purInfo.amt = (int)row.Cells["금액"].Value;
            purInfo.tag = row.Cells["비고"].Value.ToString();
            if (frmMgr.frmPurReg == null || frmMgr.frmPurReg.IsDisposed)
            {
                frmMgr.frmPurReg = new frmPurReg();
                frmMgr.frmPurReg.MdiParent = this.MdiParent;
            }
            frmMgr.frmPurReg.Text = "매입수정";
            frmMgr.frmPurReg.purInfo = purInfo;
            frmMgr.frmPurReg.init();
            frmMgr.frmPurReg.Show();
            frmMgr.frmPurReg.Activate();
        }

        private void btnGetInfos_Click(object sender, EventArgs e)
        {
            PurInfo.getPurInfos(dtpSDate.Value.ToString("yyyyMMdd"), dtpEDate.Value.ToString("yyyyMMdd"), cboCmpyName.SelectedValue.ToString(), cboResName.SelectedValue.ToString());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<PurInfo> purInfos = new List<PurInfo>();
            foreach (DataGridViewRow row in gridPur.SelectedRows)
            {
                if (row.Cells["SEQ"].Value.ToString() == "")
                {
                    continue;
                }
                PurInfo purInfo = new PurInfo();
                purInfo.purDate = Convert.ToDateTime(row.Cells["매입일자"].Value.ToString()).ToString("yyyyMMdd");
                purInfo.cmpyCode = row.Cells["사업자번호"].Value.ToString();
                purInfo.resCode = row.Cells["품번"].Value.ToString();
                purInfo.seq = (int)row.Cells["SEQ"].Value;
                purInfos.Add(purInfo);
            }
            if (purInfos.Count == 0)
            {
                return;
            }
            frmRptViewer frmRptViewer = new frmRptViewer(purInfos);
            frmRptViewer.ShowDialog();
        }
    }
}
