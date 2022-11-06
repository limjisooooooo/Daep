
namespace Daep
{
    partial class frmRevInfos
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
            this.gridRev = new System.Windows.Forms.DataGridView();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.cboCmpyName = new System.Windows.Forms.ComboBox();
            this.cboProdName = new System.Windows.Forms.ComboBox();
            this.btnGetInfos = new System.Windows.Forms.Button();
            this.bsrcCmpy = new System.Windows.Forms.BindingSource(this.components);
            this.bsrcProd = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelInfos = new System.Windows.Forms.Button();
            this.bsrcRev = new System.Windows.Forms.BindingSource(this.components);
            this.bsrcDummy = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcCmpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcDummy)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRev
            // 
            this.gridRev.AllowUserToAddRows = false;
            this.gridRev.AllowUserToDeleteRows = false;
            this.gridRev.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRev.Location = new System.Drawing.Point(0, 51);
            this.gridRev.Name = "gridRev";
            this.gridRev.ReadOnly = true;
            this.gridRev.RowTemplate.Height = 23;
            this.gridRev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRev.Size = new System.Drawing.Size(1344, 382);
            this.gridRev.TabIndex = 2;
            this.gridRev.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRev_CellDoubleClick);
            // 
            // dtpSDate
            // 
            this.dtpSDate.CustomFormat = "yyyy-MM-dd";
            this.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSDate.Location = new System.Drawing.Point(10, 12);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(98, 21);
            this.dtpSDate.TabIndex = 3;
            this.dtpSDate.ValueChanged += new System.EventHandler(this.dtpSDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "~";
            // 
            // dtpEDate
            // 
            this.dtpEDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEDate.Location = new System.Drawing.Point(134, 12);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(98, 21);
            this.dtpEDate.TabIndex = 5;
            this.dtpEDate.ValueChanged += new System.EventHandler(this.dtpEDate_ValueChanged);
            // 
            // cboCmpyName
            // 
            this.cboCmpyName.FormattingEnabled = true;
            this.cboCmpyName.Location = new System.Drawing.Point(245, 12);
            this.cboCmpyName.Name = "cboCmpyName";
            this.cboCmpyName.Size = new System.Drawing.Size(102, 20);
            this.cboCmpyName.TabIndex = 6;
            this.cboCmpyName.Text = "회사 전체";
            // 
            // cboProdName
            // 
            this.cboProdName.FormattingEnabled = true;
            this.cboProdName.Location = new System.Drawing.Point(353, 12);
            this.cboProdName.Name = "cboProdName";
            this.cboProdName.Size = new System.Drawing.Size(107, 20);
            this.cboProdName.TabIndex = 7;
            this.cboProdName.Text = "제품 전체";
            // 
            // btnGetInfos
            // 
            this.btnGetInfos.Location = new System.Drawing.Point(466, 12);
            this.btnGetInfos.Name = "btnGetInfos";
            this.btnGetInfos.Size = new System.Drawing.Size(54, 21);
            this.btnGetInfos.TabIndex = 8;
            this.btnGetInfos.Text = "조회";
            this.btnGetInfos.UseVisualStyleBackColor = true;
            this.btnGetInfos.Click += new System.EventHandler(this.btnGetInfos_Click);
            // 
            // btnDelInfos
            // 
            this.btnDelInfos.Location = new System.Drawing.Point(526, 12);
            this.btnDelInfos.Name = "btnDelInfos";
            this.btnDelInfos.Size = new System.Drawing.Size(54, 21);
            this.btnDelInfos.TabIndex = 9;
            this.btnDelInfos.Text = "삭제";
            this.btnDelInfos.UseVisualStyleBackColor = true;
            this.btnDelInfos.Click += new System.EventHandler(this.btnDelInfos_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(586, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(54, 21);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "출력";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(646, 12);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(74, 21);
            this.btnBill.TabIndex = 10;
            this.btnBill.Text = "거래명세서";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // frmRevInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 433);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelInfos);
            this.Controls.Add(this.btnGetInfos);
            this.Controls.Add(this.cboProdName);
            this.Controls.Add(this.cboCmpyName);
            this.Controls.Add(this.dtpEDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSDate);
            this.Controls.Add(this.gridRev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRevInfos";
            this.ShowIcon = false;
            this.Text = "매출조회";
            this.Load += new System.EventHandler(this.frmRevInfos_Load);
            this.Shown += new System.EventHandler(this.frmRevInfos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcCmpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcDummy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridRev;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEDate;
        private System.Windows.Forms.ComboBox cboCmpyName;
        private System.Windows.Forms.ComboBox cboProdName;
        private System.Windows.Forms.Button btnGetInfos;
        private System.Windows.Forms.BindingSource bsrcCmpy;
        private System.Windows.Forms.BindingSource bsrcProd;
        private System.Windows.Forms.Button btnDelInfos;
        private System.Windows.Forms.BindingSource bsrcRev;
        private System.Windows.Forms.BindingSource bsrcDummy;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBill;
    }
}