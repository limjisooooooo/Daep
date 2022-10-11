
namespace Daep
{
    partial class frmProdManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdManage));
            this.gridProd = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuGetProd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAddProd = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridProd)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProd
            // 
            this.gridProd.AllowUserToAddRows = false;
            this.gridProd.AllowUserToDeleteRows = false;
            this.gridProd.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProd.Location = new System.Drawing.Point(0, 28);
            this.gridProd.Name = "gridProd";
            this.gridProd.ReadOnly = true;
            this.gridProd.RowTemplate.Height = 23;
            this.gridProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProd.Size = new System.Drawing.Size(844, 369);
            this.gridProd.TabIndex = 0;
            this.gridProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProd_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGetProd,
            this.toolStripButton1,
            this.mnuAddProd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuGetProd
            // 
            this.mnuGetProd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuGetProd.Image = ((System.Drawing.Image)(resources.GetObject("mnuGetProd.Image")));
            this.mnuGetProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuGetProd.Name = "mnuGetProd";
            this.mnuGetProd.Size = new System.Drawing.Size(35, 22);
            this.mnuGetProd.Text = "조회";
            this.mnuGetProd.Click += new System.EventHandler(this.mnuGetProd_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuAddProd
            // 
            this.mnuAddProd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuAddProd.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddProd.Image")));
            this.mnuAddProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuAddProd.Name = "mnuAddProd";
            this.mnuAddProd.Size = new System.Drawing.Size(35, 22);
            this.mnuAddProd.Text = "추가";
            this.mnuAddProd.Click += new System.EventHandler(this.mnuAddProd_Click);
            // 
            // frmProdManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 398);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdManage";
            this.ShowIcon = false;
            this.Text = "제품관리";
            this.Load += new System.EventHandler(this.frmProdManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProd)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuGetProd;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripButton mnuAddProd;
    }
}