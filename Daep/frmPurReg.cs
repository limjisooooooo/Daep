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
    public partial class frmPurReg : Form
    {
        public frmPurReg()
        {
            InitializeComponent();
        }
        public PurInfo purInfo { get; set; }
        private void frmPurReg_Load(object sender, EventArgs e)
        {
            CmpyCode.getCmpyCodeAll();
            cboCmpyName.DataSource = dbWork.ds.Tables["CMPYCODES"];
            cboCmpyName.DisplayMember = "상호";
            cboCmpyName.ValueMember = "사업자번호";
            ResCode.getResCodeLatestAll();
            bsrcRes.CurrentItemChanged += BsrcRes_CurrentItemChanged;
            bsrcRes.DataSource = dbWork.ds.Tables["RESCODES"];    //적용일 Select 위한 더미            
            init();
        }

        private void BsrcRes_CurrentItemChanged(object sender, EventArgs e)
        {
            if (purInfo == null)
            {
                setResCbo(-1);
            }
            else
            {
                setResCbo(purInfo.resCode);
            }
        }
        private void cboCmpyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCmpyName.SelectedIndex < 0)
            {
                txtCmpyCode.Text = "";
                return;
            }
            if (cboCmpyName.SelectedValue.GetType() != typeof(string))
            {
                return;
            }
            txtCmpyCode.Text = cboCmpyName.SelectedValue.ToString();
        }

        private void cboResName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboResName.SelectedIndex < 0)
            {
                txtResCode.Text = "";
                txtCreator.Text = "";
                txtColor.Text = "";
                txtStandard.Text = "";
                txtUnitFee.Text = "";
                txtUnit.Text = "";
                txtCount.Text = "";
                txtAmt.Text = "";
                txtTag.Text = "";
                return;
            }
            if (cboResName.SelectedValue.GetType() != typeof(string))
            {
                return;
            }
            txtResCode.Text = cboResName.SelectedValue.ToString();
            txtCreator.Text = ((DataRowView)cboResName.SelectedItem)["제조처"].ToString();
            txtColor.Text = ((DataRowView)cboResName.SelectedItem)["COLOR"].ToString();
            txtStandard.Text = ((DataRowView)cboResName.SelectedItem)["규격"].ToString();
            txtUnitFee.Text = ((DataRowView)cboResName.SelectedItem)["단가"].ToString();
            txtUnit.Text = ((DataRowView)cboResName.SelectedItem)["단위"].ToString();
            if (purInfo == null)
            {
                txtCount.Text = "";
                txtAmt.Text = "";
                txtTag.Text = "";
            }
            else
            {
                txtCount.Text = purInfo.count.ToString();
                txtAmt.Text = purInfo.amt.ToString();
                txtTag.Text = purInfo.tag;
            }
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (txtUnitFee.Text == "")
            {
                txtCount.Text = "";
                return;
            }
            if (txtCount.Text == "")
            {
                txtAmt.Text = "";
                return;
            }
            try
            {
                if (txtCount.Text != long.Parse(txtCount.Text).ToString())
                {
                    txtCount.Text = long.Parse(txtCount.Text).ToString();
                    txtCount.SelectionStart = txtCount.Text.Length;
                }
            }
            catch (FormatException)
            {
                txtCount.Text = txtCount.Text.Substring(0, txtCount.Text.Length - 1);
                txtCount.SelectionStart = txtCount.Text.Length;
                return;
            }
            txtAmt.Text = (long.Parse(txtCount.Text) * long.Parse(txtUnitFee.Text)).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCmpyCode.Text == "")
            {
                MessageBox.Show("사업자를 입력해주세요.");
                return;
            }
            if (txtResCode.Text == "")
            {
                MessageBox.Show("품목을 입력해주세요.");
                return;
            }
            if (txtCount.Text == "")
            {
                MessageBox.Show("수량을 입력해주세요.");
                return;
            }
            if (txtAmt.Text == "")
            {
                MessageBox.Show("금액을 입력해주세요.");
                return;
            }
            PurInfo purInfo = new PurInfo();
            purInfo.purDate = dtpPurDate.Value.ToString("yyyyMMdd");
            purInfo.cmpyCode = txtCmpyCode.Text;
            purInfo.resCode = txtResCode.Text;
            purInfo.count = int.Parse(txtCount.Text);
            purInfo.amt = int.Parse(txtAmt.Text);
            purInfo.tag = txtTag.Text;
            if (this.purInfo == null)
            {
                purInfo.insPurInfo();
                if (PurInfo.Dummy.Columns.Count < 1)
                {
                    PurInfo.Dummy.Columns.Add();
                }
                if (PurInfo.Dummy.Rows.Count > 0)
                {
                    PurInfo.Dummy.Clear();
                }
                else
                {
                    PurInfo.Dummy.Rows.Add("1");
                }

                init();
            }
            else
            {
                this.purInfo.updPurInfo(purInfo);
                if (PurInfo.Dummy.Columns.Count < 1)
                {
                    PurInfo.Dummy.Columns.Add();
                }
                if (PurInfo.Dummy.Rows.Count > 0)
                {
                    PurInfo.Dummy.Clear();
                }
                else
                {
                    PurInfo.Dummy.Rows.Add("1");
                }
                this.Close();
            }

        }
        public void init()
        {
            if (purInfo == null)
            {
                dtpPurDate.Value = DateTime.Now;
                cboCmpyName.SelectedIndex = -1;
            }
            else
            {
                dtpPurDate.Value = DateTime.ParseExact(purInfo.purDate, "yyyyMMdd", null);
                cboCmpyName.SelectedIndex = -1;
                cboCmpyName.SelectedValue = purInfo.cmpyCode;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpPurDate_ValueChanged(object sender, EventArgs e)
        {
            if (purInfo == null)
            {
                setResCbo(-1);
            }
            else
            {
                setResCbo(purInfo.resCode);
            }
        }
        public void setResCbo(object cboIdx)
        {
            if (bsrcRes.Count > 0)
            {
                string sql = " SELECT DATE_FORMAT(STR_TO_DATE(HISTDATE, '%Y%m%d'), '%Y-%m-%d') 적용일, RESCODE 품번, RESNAME 품명, CREATOR 제조처, COLOR, STANDARD 규격, UNITFEE 단가, UNIT 단위 " +
                             " FROM RESCODES " +
                             " WHERE (RESCODE, HISTDATE) IN (SELECT RESCODE, MAX(HISTDATE) " +
                             "                                FROM RESCODES " +
                             "                                WHERE HISTDATE <= @histDate " +
                             "                                GROUP BY RESCODE) ";
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("@histDate", dtpPurDate.Value.ToString("yyyyMMdd"));
                cboResName.DataSource = new DataTable();
                dbWork.selectQry(sql, pairs, (DataTable)cboResName.DataSource);
                cboResName.DisplayMember = "품명";
                cboResName.ValueMember = "품번";
                if (cboResName.Items.Count < 1)
                {
                    cboResName_SelectedIndexChanged(null, null);
                }
                if (cboIdx.GetType() == typeof(int))
                {
                    cboResName.SelectedIndex = (int)cboIdx;
                }
                else
                {
                    cboResName.SelectedValue = (string)cboIdx;
                }
            }
        }

        private void txtAmt_TextChanged(object sender, EventArgs e)
        {
            if (txtAmt.Text == "")
            {
                return;
            }
            try
            {
                if (txtAmt.Text != long.Parse(txtAmt.Text).ToString())
                {
                    txtAmt.Text = long.Parse(txtAmt.Text).ToString();
                    txtAmt.SelectionStart = txtAmt.Text.Length;
                }
            }
            catch (FormatException)
            {
                txtAmt.Text = txtAmt.Text.Substring(0, txtAmt.Text.Length - 1);
                txtAmt.SelectionStart = txtAmt.Text.Length;
                return;
            }
        }
    }
}
