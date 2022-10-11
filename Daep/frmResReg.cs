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
    public partial class frmResReg : Form
    {
        public ResCode resCode
        {
            get;set;
        }      
        public frmResReg()
        {
            InitializeComponent();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtResCode.Text == "")
            {
                MessageBox.Show("품번을 입력해주세요.");
                return;
            }
            if (txtResName.Text == "")
            {
                MessageBox.Show("품명을 입력해주세요.");
                return;
            }
            ResCode resCode = new ResCode();
            resCode.histDate = dtpHistDate.Value.ToString("yyyyMMdd");
            resCode.resCode = txtResCode.Text;
            resCode.resName = txtResName.Text;
            resCode.creator = txtCreator.Text;
            resCode.color = txtColor.Text;
            resCode.standard = txtStandard.Text;
            resCode.unitFee = txtUnitFee.Text;
            resCode.unit = txtUnit.Text;
            if (this.resCode == null)
            {
                if (resCode.insResCode() < 1)
                {
                    MessageBox.Show("입력 실패");
                }
                ResCode.getResCodeLatestAll();
                init();
            }
            else
            {
                if (this.resCode.updResCode(resCode) < 1)
                {
                    MessageBox.Show("수정 실패");
                }
                ResCode.getResCodeLatestAll();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void init()
        {
            if (resCode == null)
            {
                dtpHistDate.Value = Convert.ToDateTime(DateTime.Now.ToString());
                txtResCode.Text = "";
                txtResName.Text = "";
                txtCreator.Text = "";
                txtColor.Text = "";
                txtStandard.Text = "";
                txtUnitFee.Text = "";
                txtUnit.Text = "";
            }
            else
            {
                dtpHistDate.Value = DateTime.ParseExact(resCode.histDate, "yyyyMMdd", null);
                txtResCode.Text = resCode.resCode;
                txtResName.Text = resCode.resName;
                txtCreator.Text = resCode.creator;
                txtColor.Text = resCode.color;
                txtStandard.Text = resCode.standard;
                txtUnitFee.Text = resCode.unitFee;
                txtUnit.Text = resCode.unit;
            }
        }
    }
}
