
namespace Daep
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuCmpyManage = new System.Windows.Forms.ToolStripSplitButton();
            this.mnyCmpyReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCmpyQry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProdManage = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuProdReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProdQry = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProdHistMngr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuResManage = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuResReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResQry = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResHistMngr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRevManage = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuRevReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevQry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPurManage = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuPurReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurQry = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCmpyManage,
            this.toolStripSeparator1,
            this.mnuProdManage,
            this.toolStripSeparator2,
            this.mnuResManage,
            this.toolStripSeparator3,
            this.mnuRevManage,
            this.toolStripSeparator4,
            this.mnuPurManage,
            this.toolStripSeparator5,
            this.btnSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuCmpyManage
            // 
            this.mnuCmpyManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuCmpyManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnyCmpyReg,
            this.mnuCmpyQry});
            this.mnuCmpyManage.Image = ((System.Drawing.Image)(resources.GetObject("mnuCmpyManage.Image")));
            this.mnuCmpyManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCmpyManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCmpyManage.Name = "mnuCmpyManage";
            this.mnuCmpyManage.Size = new System.Drawing.Size(83, 22);
            this.mnuCmpyManage.Text = "거래처관리";
            this.mnuCmpyManage.ButtonClick += new System.EventHandler(this.mnuCmpyManage_ButtonClick);
            // 
            // mnyCmpyReg
            // 
            this.mnyCmpyReg.Name = "mnyCmpyReg";
            this.mnyCmpyReg.Size = new System.Drawing.Size(180, 22);
            this.mnyCmpyReg.Text = "거래처등록";
            this.mnyCmpyReg.Click += new System.EventHandler(this.mnyCmpyReg_Click);
            // 
            // mnuCmpyQry
            // 
            this.mnuCmpyQry.Name = "mnuCmpyQry";
            this.mnuCmpyQry.Size = new System.Drawing.Size(180, 22);
            this.mnuCmpyQry.Text = "거래처조회";
            this.mnuCmpyQry.Click += new System.EventHandler(this.mnuCmpyQry_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuProdManage
            // 
            this.mnuProdManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuProdManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProdReg,
            this.mnuProdQry,
            this.mnuProdHistMngr});
            this.mnuProdManage.Image = ((System.Drawing.Image)(resources.GetObject("mnuProdManage.Image")));
            this.mnuProdManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuProdManage.Name = "mnuProdManage";
            this.mnuProdManage.Size = new System.Drawing.Size(71, 22);
            this.mnuProdManage.Text = "제품관리";
            this.mnuProdManage.ButtonClick += new System.EventHandler(this.mnuProdManage_ButtonClick);
            // 
            // mnuProdReg
            // 
            this.mnuProdReg.Name = "mnuProdReg";
            this.mnuProdReg.Size = new System.Drawing.Size(146, 22);
            this.mnuProdReg.Text = "제품등록";
            this.mnuProdReg.Click += new System.EventHandler(this.mnuProdReg_Click);
            // 
            // mnuProdQry
            // 
            this.mnuProdQry.Name = "mnuProdQry";
            this.mnuProdQry.Size = new System.Drawing.Size(146, 22);
            this.mnuProdQry.Text = "제품조회";
            this.mnuProdQry.Click += new System.EventHandler(this.mnuProdQry_Click);
            // 
            // mnuProdHistMngr
            // 
            this.mnuProdHistMngr.Name = "mnuProdHistMngr";
            this.mnuProdHistMngr.Size = new System.Drawing.Size(146, 22);
            this.mnuProdHistMngr.Text = "제품이력관리";
            this.mnuProdHistMngr.Click += new System.EventHandler(this.mnuProdHistMngr_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuResManage
            // 
            this.mnuResManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuResManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResReg,
            this.mnuResQry,
            this.mnuResHistMngr});
            this.mnuResManage.Image = ((System.Drawing.Image)(resources.GetObject("mnuResManage.Image")));
            this.mnuResManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuResManage.Name = "mnuResManage";
            this.mnuResManage.Size = new System.Drawing.Size(83, 22);
            this.mnuResManage.Text = "원재료관리";
            this.mnuResManage.ButtonClick += new System.EventHandler(this.mnuResManage_ButtonClick);
            // 
            // mnuResReg
            // 
            this.mnuResReg.Name = "mnuResReg";
            this.mnuResReg.Size = new System.Drawing.Size(158, 22);
            this.mnuResReg.Text = "원재료등록";
            this.mnuResReg.Click += new System.EventHandler(this.mnuResReg_Click);
            // 
            // mnuResQry
            // 
            this.mnuResQry.Name = "mnuResQry";
            this.mnuResQry.Size = new System.Drawing.Size(158, 22);
            this.mnuResQry.Text = "원재료조회";
            this.mnuResQry.Click += new System.EventHandler(this.mnuResQry_Click);
            // 
            // mnuResHistMngr
            // 
            this.mnuResHistMngr.Name = "mnuResHistMngr";
            this.mnuResHistMngr.Size = new System.Drawing.Size(158, 22);
            this.mnuResHistMngr.Text = "원재료이력관리";
            this.mnuResHistMngr.Click += new System.EventHandler(this.mnuResHistMngr_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuRevManage
            // 
            this.mnuRevManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuRevManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRevReg,
            this.mnuRevQry});
            this.mnuRevManage.Image = ((System.Drawing.Image)(resources.GetObject("mnuRevManage.Image")));
            this.mnuRevManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuRevManage.Name = "mnuRevManage";
            this.mnuRevManage.Size = new System.Drawing.Size(71, 22);
            this.mnuRevManage.Text = "매출관리";
            this.mnuRevManage.ButtonClick += new System.EventHandler(this.mnuRevManage_ButtonClick);
            // 
            // mnuRevReg
            // 
            this.mnuRevReg.Name = "mnuRevReg";
            this.mnuRevReg.Size = new System.Drawing.Size(122, 22);
            this.mnuRevReg.Text = "매출등록";
            this.mnuRevReg.Click += new System.EventHandler(this.mnuRevReg_Click);
            // 
            // mnuRevQry
            // 
            this.mnuRevQry.Name = "mnuRevQry";
            this.mnuRevQry.Size = new System.Drawing.Size(122, 22);
            this.mnuRevQry.Text = "매출조회";
            this.mnuRevQry.Click += new System.EventHandler(this.mnuRevQry_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuPurManage
            // 
            this.mnuPurManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuPurManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPurReg,
            this.mnuPurQry});
            this.mnuPurManage.Image = ((System.Drawing.Image)(resources.GetObject("mnuPurManage.Image")));
            this.mnuPurManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPurManage.Name = "mnuPurManage";
            this.mnuPurManage.Size = new System.Drawing.Size(71, 22);
            this.mnuPurManage.Text = "매입관리";
            this.mnuPurManage.ButtonClick += new System.EventHandler(this.mnuPurManage_ButtonClick);
            // 
            // mnuPurReg
            // 
            this.mnuPurReg.Name = "mnuPurReg";
            this.mnuPurReg.Size = new System.Drawing.Size(180, 22);
            this.mnuPurReg.Text = "매입등록";
            this.mnuPurReg.Click += new System.EventHandler(this.mnuPurReg_Click);
            // 
            // mnuPurQry
            // 
            this.mnuPurQry.Name = "mnuPurQry";
            this.mnuPurQry.Size = new System.Drawing.Size(180, 22);
            this.mnuPurQry.Text = "매입조회";
            this.mnuPurQry.Click += new System.EventHandler(this.mnuPurQry_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(35, 22);
            this.btnSetting.Text = "설정";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Daep";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton mnuRevManage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton mnuPurManage;
        private System.Windows.Forms.ToolStripMenuItem mnuRevReg;
        private System.Windows.Forms.ToolStripMenuItem mnuRevQry;
        private System.Windows.Forms.ToolStripMenuItem mnuPurReg;
        private System.Windows.Forms.ToolStripMenuItem mnuPurQry;
        private System.Windows.Forms.ToolStripSplitButton mnuCmpyManage;
        private System.Windows.Forms.ToolStripMenuItem mnyCmpyReg;
        private System.Windows.Forms.ToolStripMenuItem mnuCmpyQry;
        private System.Windows.Forms.ToolStripSplitButton mnuProdManage;
        private System.Windows.Forms.ToolStripMenuItem mnuProdReg;
        private System.Windows.Forms.ToolStripMenuItem mnuProdQry;
        private System.Windows.Forms.ToolStripMenuItem mnuProdHistMngr;
        private System.Windows.Forms.ToolStripSplitButton mnuResManage;
        private System.Windows.Forms.ToolStripMenuItem mnuResReg;
        private System.Windows.Forms.ToolStripMenuItem mnuResQry;
        private System.Windows.Forms.ToolStripMenuItem mnuResHistMngr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSetting;
    }
}

