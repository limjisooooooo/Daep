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
    public partial class frmMain : Form
    {
         
        public frmMain()
        {
            InitializeComponent();
            IniFile ini = new IniFile();
            try
            {
                ini.Load("daep.ini");
            }
            catch (System.IO.FileNotFoundException)
            {
                ini["daep"]["server"] = "127.0.0.1";
                ini["daep"]["port"] = 3306;
                ini["daep"]["database"] = "daep";
                ini["daep"]["user"] = "root";
                ini["daep"]["passwd"] = "root";
                ini.Save("daep.ini");
            }
            finally
            {
                string server = ini["daep"]["server"].ToString();
                int port = ini["daep"]["port"].ToInt();
                string database = ini["daep"]["database"].ToString();                
                string user = ini["daep"]["user"].ToString();
                string passwd = ini["daep"]["passwd"].ToString();
                dbWork.connStr = $"server={server};port={port};database={database};user={user};password={passwd};Allow User Variables=True;";
            }            
    }        
        private void mnuRevReg_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmRevReg == null || frmMgr.frmRevReg.IsDisposed)
            {
                frmMgr.frmRevReg = new frmRevReg();
                frmMgr.frmRevReg.MdiParent = this;
            }
            frmMgr.frmRevReg.Text = "매출등록";
            frmMgr.frmRevReg.revInfo = null;
            frmMgr.frmRevReg.init();
            frmMgr.frmRevReg.Show();
            frmMgr.frmRevReg.Activate();
        }

        private void mnuRevQry_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmRevInfos == null || frmMgr.frmRevInfos.IsDisposed)
            {
                frmMgr.frmRevInfos = new frmRevInfos();
                frmMgr.frmRevInfos.MdiParent = this;
            }
            frmMgr.frmRevInfos.Show();
            frmMgr.frmRevInfos.Activate();            
        }

        private void mnuRevManage_ButtonClick(object sender, EventArgs e)
        {
            mnuRevQry_Click(null, null);
        }

        private void mnuCmpyManage_ButtonClick(object sender, EventArgs e)
        {
            if (frmMgr.frmCmpyManage == null || frmMgr.frmCmpyManage.IsDisposed)
            {
                frmMgr.frmCmpyManage = new frmCmpyManage();
                frmMgr.frmCmpyManage.MdiParent = this;
            }
            frmMgr.frmCmpyManage.Show();
            frmMgr.frmCmpyManage.Activate();
        }

        private void mnyCmpyReg_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmCmpyReg == null || frmMgr.frmCmpyReg.IsDisposed)
            {
                frmMgr.frmCmpyReg = new frmCmpyReg();
                frmMgr.frmCmpyReg.MdiParent = this;
            }
            frmMgr.frmCmpyReg.Text = "거래처등록";
            frmMgr.frmCmpyReg.cmpyCode = null;
            frmMgr.frmCmpyReg.init();
            frmMgr.frmCmpyReg.Show();
            frmMgr.frmCmpyReg.Activate();
        }

        private void mnuCmpyQry_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmCmpyManage == null || frmMgr.frmCmpyManage.IsDisposed)
            {
                frmMgr.frmCmpyManage = new frmCmpyManage();
                frmMgr.frmCmpyManage.MdiParent = this;
            }
            frmMgr.frmCmpyManage.Show();
            frmMgr.frmCmpyManage.Activate();
        }

        private void mnuProdManage_ButtonClick(object sender, EventArgs e)
        {
            if (frmMgr.frmProdManage == null || frmMgr.frmProdManage.IsDisposed)
            {
                frmMgr.frmProdManage = new frmProdManage();
                frmMgr.frmProdManage.MdiParent = this;
            }
            frmMgr.frmProdManage.Show();
            frmMgr.frmProdManage.Activate();
        }

        private void mnuProdReg_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmProdReg == null || frmMgr.frmProdReg.IsDisposed)
            {
                frmMgr.frmProdReg = new frmProdReg();
                frmMgr.frmProdReg.MdiParent = this;
            }
            frmMgr.frmProdReg.Text = "제품등록";
            frmMgr.frmProdReg.prodCode = null;
            frmMgr.frmProdReg.init();
            frmMgr.frmProdReg.Show();
            frmMgr.frmProdReg.Activate();
        }

        private void mnuProdQry_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmProdManage == null || frmMgr.frmProdManage.IsDisposed)
            {
                frmMgr.frmProdManage = new frmProdManage();
                frmMgr.frmProdManage.MdiParent = this;
            }
            frmMgr.frmProdManage.Show();
            frmMgr.frmProdManage.Activate();
        }

        private void mnuProdHistMngr_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmProdHist == null || frmMgr.frmProdHist.IsDisposed)
            {
                frmMgr.frmProdHist = new frmProdHist();
                frmMgr.frmProdHist.MdiParent = this;
            }
            else
            {
                frmMgr.frmProdHist.selectProdCode = "";
                frmMgr.frmProdHist.selectCbo();
            }
            frmMgr.frmProdHist.Show();
            frmMgr.frmProdHist.Activate();
        }

        private void mnuResManage_ButtonClick(object sender, EventArgs e)
        {
            if (frmMgr.frmResManage == null || frmMgr.frmResManage.IsDisposed)
            {
                frmMgr.frmResManage = new frmResManage();
                frmMgr.frmResManage.MdiParent = this;
            }
            frmMgr.frmResManage.Show();
            frmMgr.frmResManage.Activate();
        }

        private void mnuPurReg_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmPurReg == null || frmMgr.frmPurReg.IsDisposed)
            {
                frmMgr.frmPurReg = new frmPurReg();
                frmMgr.frmPurReg.MdiParent = this;
            }
            frmMgr.frmPurReg.Text = "매입등록";
            frmMgr.frmPurReg.purInfo = null;
            frmMgr.frmPurReg.init();
            frmMgr.frmPurReg.Show();
            frmMgr.frmPurReg.Activate();
        }

        private void mnuPurQry_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmPurInfos == null || frmMgr.frmPurInfos.IsDisposed)
            {
                frmMgr.frmPurInfos = new frmPurInfos();
                frmMgr.frmPurInfos.MdiParent = this;
            }
            frmMgr.frmPurInfos.Show();
            frmMgr.frmPurInfos.Activate();
        }

        private void mnuPurManage_ButtonClick(object sender, EventArgs e)
        {
            mnuPurQry_Click(null, null);
        }

        private void mnuResReg_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmResReg == null || frmMgr.frmResReg.IsDisposed)
            {
                frmMgr.frmResReg = new frmResReg();
                frmMgr.frmResReg.MdiParent = this;
            }
            frmMgr.frmResReg.Text = "원재료등록";
            frmMgr.frmResReg.resCode = null;
            frmMgr.frmResReg.init();
            frmMgr.frmResReg.Show();
            frmMgr.frmResReg.Activate();
        }

        private void mnuResQry_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmResManage == null || frmMgr.frmResManage.IsDisposed)
            {
                frmMgr.frmResManage = new frmResManage();
                frmMgr.frmResManage.MdiParent = this;
            }
            frmMgr.frmResManage.Show();
            frmMgr.frmResManage.Activate();
        }

        private void mnuResHistMngr_Click(object sender, EventArgs e)
        {
            if (frmMgr.frmResHist == null || frmMgr.frmResHist.IsDisposed)
            {
                frmMgr.frmResHist = new frmResHist();
                frmMgr.frmResHist.MdiParent = this;
            }
            else
            {
                frmMgr.frmResHist.selectResCode = "";
                frmMgr.frmResHist.selectCbo();
            }
            frmMgr.frmResHist.Show();
            frmMgr.frmResHist.Activate();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSetting frmSetting = new frmSetting();
            frmSetting.ShowDialog();
        }
    }
}
