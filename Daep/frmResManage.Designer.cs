
namespace Daep
{
    partial class frmResManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResManage));
            this.gridRes = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuGetRes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAddRes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.gridRes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridRes
            // 
            this.gridRes.AllowUserToAddRows = false;
            this.gridRes.AllowUserToDeleteRows = false;
            this.gridRes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRes.Location = new System.Drawing.Point(0, 28);
            this.gridRes.Name = "gridRes";
            this.gridRes.ReadOnly = true;
            this.gridRes.RowTemplate.Height = 23;
            this.gridRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRes.Size = new System.Drawing.Size(844, 369);
            this.gridRes.TabIndex = 0;
            this.gridRes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRes_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGetRes,
            this.toolStripButton1,
            this.mnuAddRes,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuGetRes
            // 
            this.mnuGetRes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuGetRes.Image = ((System.Drawing.Image)(resources.GetObject("mnuGetRes.Image")));
            this.mnuGetRes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuGetRes.Name = "mnuGetRes";
            this.mnuGetRes.Size = new System.Drawing.Size(35, 22);
            this.mnuGetRes.Text = "조회";
            this.mnuGetRes.Click += new System.EventHandler(this.mnuGetRes_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuAddRes
            // 
            this.mnuAddRes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuAddRes.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddRes.Image")));
            this.mnuAddRes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuAddRes.Name = "mnuAddRes";
            this.mnuAddRes.Size = new System.Drawing.Size(35, 22);
            this.mnuAddRes.Text = "추가";
            this.mnuAddRes.Click += new System.EventHandler(this.mnuAddRes_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 25);
            // 
            // frmResManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 398);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridRes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResManage";
            this.ShowIcon = false;
            this.Text = "원재료관리";
            this.Load += new System.EventHandler(this.frmResManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuGetRes;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripButton mnuAddRes;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
    }
}