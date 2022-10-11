using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Daep
{
    public partial class frmRevReg : Form
    {
        public RevInfo revInfo { get; set; }
        public frmRevReg()
        {
            InitializeComponent();
        }
        private void frmRevReg_Load(object sender, EventArgs e)
        {
            CmpyCode.getCmpyCodeAll();
            cboCmpyName.DataSource = dbWork.ds.Tables["CMPYCODES"];
            cboCmpyName.DisplayMember = "상호";
            cboCmpyName.ValueMember = "사업자번호";
            ProdCode.getProdCodeLatestAll();
            bsrcProd.CurrentItemChanged += BsrcProd_CurrentItemChanged;
            bsrcProd.DataSource = dbWork.ds.Tables["PRODCODES"];    //적용일 Select 위한 더미            
            init();
        }

        private void BsrcProd_CurrentItemChanged(object sender, EventArgs e)
        {
            if (revInfo == null)
            {
                setProdCbo(-1);
            }
            else
            {
                setProdCbo(revInfo.prodCode);
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

        private void cboProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProdName.SelectedIndex < 0)
            {
                txtProdCode.Text = "";
                txtType.Text = "";
                txtColor.Text = "";
                txtStandard.Text = "";
                txtUnitFee.Text = "";
                txtUnit.Text = "";
                txtCount.Text = "";
                txtAmt.Text = "";
                txtTag.Text = "";
                return;
            }
            if (cboProdName.SelectedValue.GetType() != typeof(string))
            {
                return;
            }
            txtProdCode.Text = cboProdName.SelectedValue.ToString();
            txtType.Text = ((DataRowView)cboProdName.SelectedItem)["차종"].ToString();
            txtColor.Text = ((DataRowView)cboProdName.SelectedItem)["COLOR"].ToString();
            txtStandard.Text = ((DataRowView)cboProdName.SelectedItem)["규격"].ToString();
            txtUnitFee.Text = ((DataRowView)cboProdName.SelectedItem)["단가"].ToString();
            txtUnit.Text = ((DataRowView)cboProdName.SelectedItem)["단위"].ToString();
            if (revInfo == null)
            {
                txtCount.Text = "";
                txtAmt.Text = "";
                txtTag.Text = "";
            }
            else
            {
                txtCount.Text = revInfo.count.ToString();
                txtAmt.Text = revInfo.amt.ToString();
                txtTag.Text = revInfo.tag;
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
            if(txtCmpyCode.Text == "")
            {
                MessageBox.Show("사업자를 입력해주세요.");
                return;
            }
            if(txtProdCode.Text == "")
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
            RevInfo revInfo = new RevInfo();
            revInfo.revDate = dtpRevDate.Value.ToString("yyyyMMdd");
            revInfo.cmpyCode = txtCmpyCode.Text;
            revInfo.prodCode = txtProdCode.Text;
            revInfo.count = int.Parse(txtCount.Text);
            revInfo.amt = int.Parse(txtAmt.Text);
            revInfo.tag = txtTag.Text;
            if (this.revInfo == null)
            {
                revInfo.insRevInfo();
                if (RevInfo.Dummy.Columns.Count < 1)
                {
                    RevInfo.Dummy.Columns.Add();
                }
                if (RevInfo.Dummy.Rows.Count > 0)
                {
                    RevInfo.Dummy.Clear();
                }
                else
                {
                    RevInfo.Dummy.Rows.Add("1");
                }

                init();
            }
            else
            {
                this.revInfo.updRevInfo(revInfo);
                if (RevInfo.Dummy.Columns.Count < 1)
                {
                    RevInfo.Dummy.Columns.Add();
                }
                if (RevInfo.Dummy.Rows.Count > 0)
                {
                    RevInfo.Dummy.Clear();
                }
                else
                {
                    RevInfo.Dummy.Rows.Add("1");
                }
                this.Close();
            }

        }
        public void init()
        {
            if (revInfo == null)
            {
                dtpRevDate.Value = DateTime.Now;
                cboCmpyName.SelectedIndex = -1;
            }
            else
            {
                dtpRevDate.Value = DateTime.ParseExact(revInfo.revDate, "yyyyMMdd", null);
                cboCmpyName.SelectedIndex = -1;
                cboCmpyName.SelectedValue = revInfo.cmpyCode;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpRevDate_ValueChanged(object sender, EventArgs e)
        {
            if (revInfo == null)
            {
                setProdCbo(-1);
            }
            else
            {
                setProdCbo(revInfo.prodCode);
            }
        }
        public void setProdCbo(object cboIdx)
        {
            if (bsrcProd.Count > 0)
            {
                string sql = " SELECT DATE_FORMAT(STR_TO_DATE(HISTDATE, '%Y%m%d'), '%Y-%m-%d') 적용일, PRODCODE 품번, PRODNAME 품명, TYPE 차종, COLOR, STANDARD 규격, UNITFEE 단가, UNIT 단위 " +
                             " FROM PRODCODES " +
                             " WHERE (PRODCODE, HISTDATE) IN (SELECT PRODCODE, MAX(HISTDATE) " +
                             "                                FROM PRODCODES " +
                             "                                WHERE HISTDATE <= @histDate " +
                             "                                GROUP BY PRODCODE) ";
                Dictionary<string, object> pairs = new Dictionary<string, object>();
                pairs.Add("@histDate", dtpRevDate.Value.ToString("yyyyMMdd"));
                cboProdName.DataSource = new DataTable();
                dbWork.selectQry(sql, pairs, (DataTable)cboProdName.DataSource);
                cboProdName.DisplayMember = "품명";
                cboProdName.ValueMember = "품번";
                if (cboProdName.Items.Count < 1)
                {
                    cboProdName_SelectedIndexChanged(null, null);
                }
                if (cboIdx.GetType() == typeof(int))
                {
                    cboProdName.SelectedIndex = (int)cboIdx;
                }
                else
                {
                    cboProdName.SelectedValue = (string)cboIdx;
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
