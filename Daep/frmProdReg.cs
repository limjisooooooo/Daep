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
    public partial class frmProdReg : Form
    {
        public ProdCode prodCode
        {
            get; set;
        }
        public frmProdReg()
        {
            InitializeComponent();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtProdCode.Text == "")
            {
                MessageBox.Show("품번을 입력해주세요.");
                return;
            }
            if(txtProdName.Text == "")
            {
                MessageBox.Show("품명을 입력해주세요.");
                return;
            }
            ProdCode prodCode = new ProdCode();
            prodCode.histDate = dtpHistDate.Value.ToString("yyyyMMdd");
            prodCode.prodCode = txtProdCode.Text;
            prodCode.prodName = txtProdName.Text;
            prodCode.type = txtType.Text;
            prodCode.color = txtColor.Text;
            prodCode.standard = txtStandard.Text;
            prodCode.unitFee = txtUnitFee.Text;
            prodCode.unit = txtUnit.Text;
            if (this.prodCode == null)
            {
                if (prodCode.insProdCode() < 1)
                {
                    MessageBox.Show("입력 실패");
                }
                ProdCode.getProdCodeLatestAll();
                init();                
            }
            else
            {                
                if (this.prodCode.updProdCode(prodCode) < 1)
                {
                    MessageBox.Show("수정 실패");
                }
                ProdCode.getProdCodeLatestAll();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void init()
        {
            if (prodCode == null)
            {
                dtpHistDate.Value = Convert.ToDateTime(DateTime.Now.ToString());
                txtProdCode.Text = "";
                txtProdName.Text = "";
                txtType.Text = "";
                txtColor.Text = "";
                txtStandard.Text = "";
                txtUnitFee.Text = "";
                txtUnit.Text = "";
            }
            else
            {
                dtpHistDate.Value = DateTime.ParseExact(prodCode.histDate, "yyyyMMdd", null);
                txtProdCode.Text = prodCode.prodCode;
                txtProdName.Text = prodCode.prodName;
                txtType.Text = prodCode.type;
                txtColor.Text = prodCode.color;
                txtStandard.Text = prodCode.standard;
                txtUnitFee.Text = prodCode.unitFee;
                txtUnit.Text = prodCode.unit;                               
            }

        }
    }
}
