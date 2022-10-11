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
    public partial class frmCmpyReg : Form
    {
        public CmpyCode cmpyCode
        {
            get; set;
        }
        public frmCmpyReg()
        {
            InitializeComponent();            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCmpyCode.Text == "")
            {
                MessageBox.Show("사업자번호를 입력해주세요.");
                return;
            }
            if (txtCmpyName.Text == "")
            {
                MessageBox.Show("상호를 입력해주세요.");
                return;
            }
            CmpyCode cmpyCode = new CmpyCode();
            cmpyCode.cmpyCode = txtCmpyCode.Text;
            cmpyCode.cmpyName = txtCmpyName.Text;
            cmpyCode.ceo = txtCEO.Text;
            cmpyCode.addr = txtAddr.Text;
            cmpyCode.cmpyType = txtCmpyType.Text;
            cmpyCode.item = txtItem.Text;
            cmpyCode.type = txtType.Text;
            if (this.cmpyCode == null)
            {                
                if (cmpyCode.insCmpyCode() < 1)
                {
                    MessageBox.Show("입력 실패");
                }
                CmpyCode.getCmpyCodeAll();
                init();
            }
            else
            {
                if (this.cmpyCode.updCmpyCode(cmpyCode) < 1)
                {
                    MessageBox.Show("입력 실패");
                }
                CmpyCode.getCmpyCodeAll();
                this.Close();
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void init()
        {            
            if(cmpyCode == null)
            {
                txtCmpyCode.Text = "";
                txtCmpyName.Text = "";
                txtCEO.Text = "";
                txtAddr.Text = "";
                txtCmpyType.Text = "";
                txtItem.Text = "";
                txtType.Text = "";
            }
            else
            {
                txtCmpyCode.Text = cmpyCode.cmpyCode;
                txtCmpyName.Text = cmpyCode.cmpyName;
                txtCEO.Text = cmpyCode.ceo;
                txtAddr.Text = cmpyCode.addr;
                txtCmpyType.Text = cmpyCode.cmpyType;
                txtItem.Text = cmpyCode.item;
                txtType.Text = cmpyCode.type;
            }

        }

        private void frmCmpyReg_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
