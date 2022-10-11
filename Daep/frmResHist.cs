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
    public partial class frmResHist : Form
    {
        public string selectResCode
        {
            get; set;
        }
        public frmResHist()
        {
            InitializeComponent();
            selectResCode = "";
        }
        public void setCbo()
        {
            if (bsrcRes.Count > 0)
            {
                cboResName.DisplayMember = "";
                cboResName.ValueMember = "";
                List<ResCode> items = new List<ResCode>();
                items.Add(new ResCode("", "", "전체"));
                foreach (DataRowView row in bsrcRes)
                {
                    items.Add(new ResCode(row["적용일"].ToString(), row["품번"].ToString(), row["품명"].ToString()));
                }
                cboResName.DataSource = items;
                cboResName.DisplayMember = "RESNAME";
                cboResName.ValueMember = "RESCODE";
            }
        }
        public void selectCbo()
        {
            cboResName.SelectedValue = selectResCode;
            if (cboResName.SelectedValue == null)
            {
                cboResName.SelectedIndex = 0;
            }
        }
        public void getResHist()
        {
            if (cboResName.SelectedValue.ToString() == "")
            {
                ResCode.getResCodeHistAll();                
            }
            else
            {
                ResCode.getResCodeHistWithResCode(cboResName.SelectedValue.ToString());                
            }
        }

        private void gridResHist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];

            ResCode resCode = new ResCode();
            resCode.histDate = Convert.ToDateTime(row.Cells["적용일"].Value.ToString()).ToString("yyyyMMdd");
            resCode.resCode = row.Cells["품번"].Value.ToString();
            resCode.resName = row.Cells["품명"].Value.ToString();
            resCode.creator = row.Cells["제조처"].Value.ToString();
            resCode.color = row.Cells["COLOR"].Value.ToString();
            resCode.standard = row.Cells["규격"].Value.ToString();
            resCode.unitFee = row.Cells["단가"].Value.ToString();
            resCode.unit = row.Cells["단위"].Value.ToString();

            if (frmMgr.frmResReg == null || frmMgr.frmResReg.IsDisposed)
            {
                frmMgr.frmResReg = new frmResReg();
                frmMgr.frmResReg.MdiParent = this.MdiParent;
            }
            frmMgr.frmResReg.Text = "원재료수정";
            frmMgr.frmResReg.resCode = resCode;
            frmMgr.frmResReg.init();
            frmMgr.frmResReg.Show();
            frmMgr.frmResReg.Activate();
        }

        private void frmResHist_Load(object sender, EventArgs e)
        {            
            ResCode.getResCodeLatestAll();
            bsrcRes.DataSource = dbWork.ds.Tables["RESCODES"];
            bsrcRes.CurrentItemChanged += BsrcRes_CurrentItemChanged;
            setCbo();
            selectCbo();
            getResHist();
            gridResHist.DataSource = dbWork.ds.Tables["RESCODEHIST"];
        }

        private void BsrcRes_CurrentItemChanged(object sender, EventArgs e)
        {
            setCbo();
            selectCbo();
            getResHist();
        }

        private void cboResName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedValue.GetType() == typeof(string))
            {
                selectResCode = ((ComboBox)sender).SelectedValue.ToString();
            }
        }

        private void mnuGetResHist_Click(object sender, EventArgs e)
        {
            if (cboResName.SelectedValue != null)
            {
                getResHist();
            }
        }

        private void mnudelResHist_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridResHist.SelectedRows)
            {
                ResCode resCode = new ResCode();
                resCode.histDate = Convert.ToDateTime(row.Cells["적용일"].Value.ToString()).ToString("yyyyMMdd");
                resCode.resCode = row.Cells["품번"].Value.ToString();
                resCode.resName = row.Cells["품명"].Value.ToString();
                resCode.creator = row.Cells["제조처"].Value.ToString();
                resCode.color = row.Cells["COLOR"].Value.ToString();
                resCode.standard = row.Cells["규격"].Value.ToString();
                resCode.unitFee = row.Cells["단가"].Value.ToString();
                resCode.unit = row.Cells["단위"].Value.ToString();
                resCode.delResCode();
            }
            ResCode.getResCodeLatestAll();
        }
    }
}
