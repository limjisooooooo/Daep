
namespace Daep
{
    partial class frmResHist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResHist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuGetResHist = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnudelResHist = new System.Windows.Forms.ToolStripButton();
            this.gridResHist = new System.Windows.Forms.DataGridView();
            this.cboResName = new System.Windows.Forms.ComboBox();
            this.bsrcRes = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGetResHist,
            this.toolStripSeparator1,
            this.mnudelResHist});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(844, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuGetResHist
            // 
            this.mnuGetResHist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuGetResHist.Image = ((System.Drawing.Image)(resources.GetObject("mnuGetResHist.Image")));
            this.mnuGetResHist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuGetResHist.Name = "mnuGetResHist";
            this.mnuGetResHist.Size = new System.Drawing.Size(35, 22);
            this.mnuGetResHist.Text = "조회";
            this.mnuGetResHist.Click += new System.EventHandler(this.mnuGetResHist_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnudelResHist
            // 
            this.mnudelResHist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnudelResHist.Image = ((System.Drawing.Image)(resources.GetObject("mnudelResHist.Image")));
            this.mnudelResHist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnudelResHist.Name = "mnudelResHist";
            this.mnudelResHist.Size = new System.Drawing.Size(35, 22);
            this.mnudelResHist.Text = "삭제";
            this.mnudelResHist.Click += new System.EventHandler(this.mnudelResHist_Click);
            // 
            // gridResHist
            // 
            this.gridResHist.AllowUserToAddRows = false;
            this.gridResHist.AllowUserToDeleteRows = false;
            this.gridResHist.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridResHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResHist.Location = new System.Drawing.Point(0, 52);
            this.gridResHist.Name = "gridResHist";
            this.gridResHist.ReadOnly = true;
            this.gridResHist.RowTemplate.Height = 23;
            this.gridResHist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResHist.Size = new System.Drawing.Size(844, 363);
            this.gridResHist.TabIndex = 4;
            this.gridResHist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResHist_CellDoubleClick);
            // 
            // cboResName
            // 
            this.cboResName.FormattingEnabled = true;
            this.cboResName.Location = new System.Drawing.Point(12, 26);
            this.cboResName.Name = "cboResName";
            this.cboResName.Size = new System.Drawing.Size(118, 20);
            this.cboResName.TabIndex = 6;
            this.cboResName.SelectedIndexChanged += new System.EventHandler(this.cboResName_SelectedIndexChanged);
            // 
            // frmResHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 415);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridResHist);
            this.Controls.Add(this.cboResName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResHist";
            this.ShowIcon = false;
            this.Text = "원재료이력관리";
            this.Load += new System.EventHandler(this.frmResHist_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuGetResHist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnudelResHist;
        private System.Windows.Forms.DataGridView gridResHist;
        private System.Windows.Forms.ComboBox cboResName;
        private System.Windows.Forms.BindingSource bsrcRes;
    }
}