
namespace Daep
{
    partial class frmCmpyManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCmpyManage));
            this.gridCmpy = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuGetCmpy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAddCmpy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDeleteCmpy = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCmpy)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCmpy
            // 
            this.gridCmpy.AllowUserToAddRows = false;
            this.gridCmpy.AllowUserToDeleteRows = false;
            this.gridCmpy.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCmpy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCmpy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCmpy.Location = new System.Drawing.Point(0, 28);
            this.gridCmpy.Name = "gridCmpy";
            this.gridCmpy.ReadOnly = true;
            this.gridCmpy.RowTemplate.Height = 23;
            this.gridCmpy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCmpy.Size = new System.Drawing.Size(803, 369);
            this.gridCmpy.TabIndex = 0;
            this.gridCmpy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCmpy_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGetCmpy,
            this.toolStripButton1,
            this.mnuAddCmpy,
            this.toolStripButton2,
            this.mnuDeleteCmpy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(807, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuGetCmpy
            // 
            this.mnuGetCmpy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuGetCmpy.Image = ((System.Drawing.Image)(resources.GetObject("mnuGetCmpy.Image")));
            this.mnuGetCmpy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuGetCmpy.Name = "mnuGetCmpy";
            this.mnuGetCmpy.Size = new System.Drawing.Size(35, 22);
            this.mnuGetCmpy.Text = "조회";
            this.mnuGetCmpy.Click += new System.EventHandler(this.mnuGetCmpy_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuAddCmpy
            // 
            this.mnuAddCmpy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuAddCmpy.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddCmpy.Image")));
            this.mnuAddCmpy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuAddCmpy.Name = "mnuAddCmpy";
            this.mnuAddCmpy.Size = new System.Drawing.Size(35, 22);
            this.mnuAddCmpy.Text = "추가";
            this.mnuAddCmpy.Click += new System.EventHandler(this.mnuAddCmpy_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuDeleteCmpy
            // 
            this.mnuDeleteCmpy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuDeleteCmpy.Image = ((System.Drawing.Image)(resources.GetObject("mnuDeleteCmpy.Image")));
            this.mnuDeleteCmpy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuDeleteCmpy.Name = "mnuDeleteCmpy";
            this.mnuDeleteCmpy.Size = new System.Drawing.Size(35, 22);
            this.mnuDeleteCmpy.Text = "삭제";
            this.mnuDeleteCmpy.Click += new System.EventHandler(this.mnuDeleteCmpy_Click);
            // 
            // frmCmpyManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(807, 398);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridCmpy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCmpyManage";
            this.Text = "거래처관리";
            this.Load += new System.EventHandler(this.frmCmpyManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCmpy)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCmpy;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuGetCmpy;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripButton mnuAddCmpy;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
        private System.Windows.Forms.ToolStripButton mnuDeleteCmpy;
    }
}