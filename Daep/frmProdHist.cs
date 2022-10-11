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
    public partial class frmProdHist : Form
    {
        public string selectProdCode 
        {
            get; set;
        }
        public frmProdHist()
        {
            InitializeComponent();
            selectProdCode = "";
        }
        private void mnuGetProdHist_Click(object sender, EventArgs e)
        {
            if (cboProdName.SelectedValue != null)
            {
                getProdHist();
            }
        }

        private void frmProdHist_Load(object sender, EventArgs e)
        {
            ProdCode.getProdCodeLatestAll();
            bsrcProd.DataSource = dbWork.ds.Tables["PRODCODES"];
            bsrcProd.CurrentItemChanged += BsrcProd_CurrentItemChanged;
            setCbo();
            selectCbo();
            getProdHist();
            gridProdHist.DataSource = dbWork.ds.Tables["PRODCODEHIST"];
        }

        private void BsrcProd_CurrentItemChanged(object sender, EventArgs e)
        {
            setCbo();
            selectCbo();
            getProdHist();
        }

        private void gridProdHist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];

            ProdCode prodCode = new ProdCode();            
            prodCode.histDate = Convert.ToDateTime(row.Cells["적용일"].Value.ToString()).ToString("yyyyMMdd");
            prodCode.prodCode = row.Cells["품번"].Value.ToString();
            prodCode.prodName = row.Cells["품명"].Value.ToString();
            prodCode.type = row.Cells["차종"].Value.ToString();
            prodCode.color = row.Cells["COLOR"].Value.ToString();
            prodCode.standard = row.Cells["규격"].Value.ToString();
            prodCode.unitFee = row.Cells["단가"].Value.ToString();
            prodCode.unit = row.Cells["단위"].Value.ToString();

            if (frmMgr.frmProdReg == null || frmMgr.frmProdReg.IsDisposed)
            {
                frmMgr.frmProdReg = new frmProdReg();
                frmMgr.frmProdReg.MdiParent = this.MdiParent;
            }
            frmMgr.frmProdReg.Text = "제품수정";
            frmMgr.frmProdReg.prodCode = prodCode;
            frmMgr.frmProdReg.init();
            frmMgr.frmProdReg.Show();
            frmMgr.frmProdReg.Activate();
        }
        public void setCbo()
        {
            if (bsrcProd.Count > 0)
            {
                cboProdName.DisplayMember = "";
                cboProdName.ValueMember = "";
                List<ProdCode> items = new List<ProdCode>();                
                items.Add(new ProdCode("", "", "전체"));
                foreach (DataRowView row in bsrcProd)
                {
                    items.Add(new ProdCode(row["적용일"].ToString(), row["품번"].ToString(), row["품명"].ToString()));
                }
                cboProdName.DataSource = items;
                cboProdName.DisplayMember = "PRODNAME";
                cboProdName.ValueMember = "PRODCODE";
            }
        }
        public void selectCbo()
        {
            cboProdName.SelectedValue = selectProdCode;
            if(cboProdName.SelectedValue == null)
            {
                cboProdName.SelectedIndex = 0;
            }
        }
        public void getProdHist()
        {
            if (cboProdName.SelectedValue.ToString() == "")
            {
                ProdCode.getProdCodeHistAll();
            }
            else
            {
                ProdCode.getProdCodeHistWithProdCode(cboProdName.SelectedValue.ToString());
            }
        }
        private void mnudelProdHist_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridProdHist.SelectedRows)
            {
                ProdCode prodCode = new ProdCode();
                prodCode.histDate = Convert.ToDateTime(row.Cells["적용일"].Value.ToString()).ToString("yyyyMMdd");
                prodCode.prodCode = row.Cells["품번"].Value.ToString();
                prodCode.prodName = row.Cells["품명"].Value.ToString();
                prodCode.type = row.Cells["차종"].Value.ToString();
                prodCode.color = row.Cells["COLOR"].Value.ToString();
                prodCode.standard = row.Cells["규격"].Value.ToString();
                prodCode.unitFee = row.Cells["단가"].Value.ToString();
                prodCode.unit = row.Cells["단위"].Value.ToString();
                prodCode.delProdCode();
            }
            ProdCode.getProdCodeLatestAll();
        }
        private void cboProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedValue.GetType() == typeof(string))
            {
                selectProdCode = ((ComboBox)sender).SelectedValue.ToString();
            }            
        }
    }
}
