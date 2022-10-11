
namespace Daep
{
    partial class frmProdHist
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdHist));
            this.gridProdHist = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuGetProdHist = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnudelProdHist = new System.Windows.Forms.ToolStripButton();
            this.cboProdName = new System.Windows.Forms.ComboBox();
            this.bsrcProd = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdHist)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcProd)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProdHist
            // 
            this.gridProdHist.AllowUserToAddRows = false;
            this.gridProdHist.AllowUserToDeleteRows = false;
            this.gridProdHist.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProdHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdHist.Location = new System.Drawing.Point(0, 54);
            this.gridProdHist.Name = "gridProdHist";
            this.gridProdHist.ReadOnly = true;
            this.gridProdHist.RowTemplate.Height = 23;
            this.gridProdHist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdHist.Size = new System.Drawing.Size(844, 363);
            this.gridProdHist.TabIndex = 1;
            this.gridProdHist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdHist_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGetProdHist,
            this.toolStripSeparator1,
            this.mnudelProdHist});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuGetProdHist
            // 
            this.mnuGetProdHist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuGetProdHist.Image = ((System.Drawing.Image)(resources.GetObject("mnuGetProdHist.Image")));
            this.mnuGetProdHist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuGetProdHist.Name = "mnuGetProdHist";
            this.mnuGetProdHist.Size = new System.Drawing.Size(35, 22);
            this.mnuGetProdHist.Text = "조회";
            this.mnuGetProdHist.Click += new System.EventHandler(this.mnuGetProdHist_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnudelProdHist
            // 
            this.mnudelProdHist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnudelProdHist.Image = ((System.Drawing.Image)(resources.GetObject("mnudelProdHist.Image")));
            this.mnudelProdHist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnudelProdHist.Name = "mnudelProdHist";
            this.mnudelProdHist.Size = new System.Drawing.Size(35, 22);
            this.mnudelProdHist.Text = "삭제";
            this.mnudelProdHist.Click += new System.EventHandler(this.mnudelProdHist_Click);
            // 
            // cboProdName
            // 
            this.cboProdName.FormattingEnabled = true;
            this.cboProdName.Location = new System.Drawing.Point(12, 28);
            this.cboProdName.Name = "cboProdName";
            this.cboProdName.Size = new System.Drawing.Size(118, 20);
            this.cboProdName.TabIndex = 3;
            this.cboProdName.SelectedIndexChanged += new System.EventHandler(this.cboProdName_SelectedIndexChanged);
            // 
            // frmProdHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 418);
            this.Controls.Add(this.cboProdName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridProdHist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdHist";
            this.ShowIcon = false;
            this.Text = "제품이력관리";
            this.Load += new System.EventHandler(this.frmProdHist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdHist)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProdHist;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuGetProdHist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnudelProdHist;
        private System.Windows.Forms.ComboBox cboProdName;
        private System.Windows.Forms.BindingSource bsrcProd;
    }
}