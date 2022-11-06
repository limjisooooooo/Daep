
namespace Daep
{
    partial class frmPurInfos
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
            this.btnGetInfos = new System.Windows.Forms.Button();
            this.cboResName = new System.Windows.Forms.ComboBox();
            this.cboCmpyName = new System.Windows.Forms.ComboBox();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.gridPur = new System.Windows.Forms.DataGridView();
            this.bsrcCmpy = new System.Windows.Forms.BindingSource(this.components);
            this.bsrcRes = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelInfos = new System.Windows.Forms.Button();
            this.bsrcPur = new System.Windows.Forms.BindingSource(this.components);
            this.bsrcDummy = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcCmpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcPur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcDummy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetInfos
            // 
            this.btnGetInfos.Location = new System.Drawing.Point(469, 17);
            this.btnGetInfos.Name = "btnGetInfos";
            this.btnGetInfos.Size = new System.Drawing.Size(54, 21);
            this.btnGetInfos.TabIndex = 16;
            this.btnGetInfos.Text = "조회";
            this.btnGetInfos.UseVisualStyleBackColor = true;
            this.btnGetInfos.Click += new System.EventHandler(this.btnGetInfos_Click);
            // 
            // cboResName
            // 
            this.cboResName.FormattingEnabled = true;
            this.cboResName.Location = new System.Drawing.Point(356, 17);
            this.cboResName.Name = "cboResName";
            this.cboResName.Size = new System.Drawing.Size(107, 20);
            this.cboResName.TabIndex = 15;
            this.cboResName.Text = "원재료 전체";
            // 
            // cboCmpyName
            // 
            this.cboCmpyName.FormattingEnabled = true;
            this.cboCmpyName.Location = new System.Drawing.Point(248, 17);
            this.cboCmpyName.Name = "cboCmpyName";
            this.cboCmpyName.Size = new System.Drawing.Size(102, 20);
            this.cboCmpyName.TabIndex = 14;
            this.cboCmpyName.Text = "회사 전체";
            // 
            // dtpEDate
            // 
            this.dtpEDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEDate.Location = new System.Drawing.Point(137, 17);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(98, 21);
            this.dtpEDate.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "~";
            // 
            // dtpSDate
            // 
            this.dtpSDate.CustomFormat = "yyyy-MM-dd";
            this.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSDate.Location = new System.Drawing.Point(13, 17);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(98, 21);
            this.dtpSDate.TabIndex = 11;
            // 
            // gridPur
            // 
            this.gridPur.AllowUserToAddRows = false;
            this.gridPur.AllowUserToDeleteRows = false;
            this.gridPur.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPur.Location = new System.Drawing.Point(3, 56);
            this.gridPur.Name = "gridPur";
            this.gridPur.ReadOnly = true;
            this.gridPur.RowTemplate.Height = 23;
            this.gridPur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPur.Size = new System.Drawing.Size(1344, 382);
            this.gridPur.TabIndex = 10;
            this.gridPur.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPur_CellDoubleClick);
            // 
            // btnDelInfos
            // 
            this.btnDelInfos.Location = new System.Drawing.Point(529, 17);
            this.btnDelInfos.Name = "btnDelInfos";
            this.btnDelInfos.Size = new System.Drawing.Size(54, 21);
            this.btnDelInfos.TabIndex = 17;
            this.btnDelInfos.Text = "삭제";
            this.btnDelInfos.UseVisualStyleBackColor = true;
            this.btnDelInfos.Click += new System.EventHandler(this.btnDelInfos_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(589, 17);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(54, 21);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "출력";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(649, 17);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(74, 21);
            this.btnBill.TabIndex = 19;
            this.btnBill.Text = "거래명세서";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Visible = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // frmPurInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 438);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGetInfos);
            this.Controls.Add(this.cboResName);
            this.Controls.Add(this.cboCmpyName);
            this.Controls.Add(this.dtpEDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSDate);
            this.Controls.Add(this.gridPur);
            this.Controls.Add(this.btnDelInfos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPurInfos";
            this.ShowIcon = false;
            this.Text = "매입조회";
            this.Load += new System.EventHandler(this.frmPurInfos_Load);
            this.Shown += new System.EventHandler(this.frmPurInfos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridPur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcCmpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcPur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcDummy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetInfos;
        private System.Windows.Forms.ComboBox cboResName;
        private System.Windows.Forms.ComboBox cboCmpyName;
        private System.Windows.Forms.DateTimePicker dtpEDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.DataGridView gridPur;
        private System.Windows.Forms.BindingSource bsrcCmpy;
        private System.Windows.Forms.BindingSource bsrcRes;
        private System.Windows.Forms.Button btnDelInfos;
        private System.Windows.Forms.BindingSource bsrcPur;
        private System.Windows.Forms.BindingSource bsrcDummy;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBill;
    }
}