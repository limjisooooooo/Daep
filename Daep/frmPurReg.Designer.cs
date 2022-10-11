
namespace Daep
{
    partial class frmPurReg
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpPurDate = new System.Windows.Forms.DateTimePicker();
            this.lblCmpyCode = new System.Windows.Forms.Label();
            this.lblCmpyName = new System.Windows.Forms.Label();
            this.txtCmpyCode = new System.Windows.Forms.TextBox();
            this.lblPurDate = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtUnitFee = new System.Windows.Forms.TextBox();
            this.txtStandard = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblUnitFee = new System.Windows.Forms.Label();
            this.lblStandard = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblResName = new System.Windows.Forms.Label();
            this.lblResCode = new System.Windows.Forms.Label();
            this.cboCmpyName = new System.Windows.Forms.ComboBox();
            this.txtResCode = new System.Windows.Forms.TextBox();
            this.cboResName = new System.Windows.Forms.ComboBox();
            this.bsrcRes = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(420, 282);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 66;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpPurDate
            // 
            this.dtpPurDate.CustomFormat = "yyyy-MM-dd";
            this.dtpPurDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurDate.Location = new System.Drawing.Point(89, 28);
            this.dtpPurDate.Name = "dtpPurDate";
            this.dtpPurDate.Size = new System.Drawing.Size(102, 21);
            this.dtpPurDate.TabIndex = 40;
            this.dtpPurDate.ValueChanged += new System.EventHandler(this.dtpPurDate_ValueChanged);
            // 
            // lblCmpyCode
            // 
            this.lblCmpyCode.AutoSize = true;
            this.lblCmpyCode.Location = new System.Drawing.Point(18, 67);
            this.lblCmpyCode.Name = "lblCmpyCode";
            this.lblCmpyCode.Size = new System.Drawing.Size(65, 12);
            this.lblCmpyCode.TabIndex = 64;
            this.lblCmpyCode.Text = "사업자번호";
            // 
            // lblCmpyName
            // 
            this.lblCmpyName.AutoSize = true;
            this.lblCmpyName.Location = new System.Drawing.Point(245, 67);
            this.lblCmpyName.Name = "lblCmpyName";
            this.lblCmpyName.Size = new System.Drawing.Size(41, 12);
            this.lblCmpyName.TabIndex = 63;
            this.lblCmpyName.Text = "회사명";
            // 
            // txtCmpyCode
            // 
            this.txtCmpyCode.BackColor = System.Drawing.Color.White;
            this.txtCmpyCode.Location = new System.Drawing.Point(89, 64);
            this.txtCmpyCode.Name = "txtCmpyCode";
            this.txtCmpyCode.ReadOnly = true;
            this.txtCmpyCode.Size = new System.Drawing.Size(132, 21);
            this.txtCmpyCode.TabIndex = 62;
            // 
            // lblPurDate
            // 
            this.lblPurDate.AutoSize = true;
            this.lblPurDate.Location = new System.Drawing.Point(30, 34);
            this.lblPurDate.Name = "lblPurDate";
            this.lblPurDate.Size = new System.Drawing.Size(53, 12);
            this.lblPurDate.TabIndex = 61;
            this.lblPurDate.Text = "매입일자";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(54, 253);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(29, 12);
            this.lblTag.TabIndex = 60;
            this.lblTag.Text = "비고";
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Location = new System.Drawing.Point(187, 215);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(29, 12);
            this.lblAmt.TabIndex = 59;
            this.lblAmt.Text = "금액";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(54, 215);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(29, 12);
            this.lblCount.TabIndex = 58;
            this.lblCount.Text = "수량";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(89, 250);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(206, 21);
            this.txtTag.TabIndex = 57;
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(222, 212);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(73, 21);
            this.txtAmt.TabIndex = 56;
            this.txtAmt.TextChanged += new System.EventHandler(this.txtAmt_TextChanged);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(89, 212);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(73, 21);
            this.txtCount.TabIndex = 55;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.Location = new System.Drawing.Point(347, 176);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(77, 21);
            this.txtUnit.TabIndex = 54;
            // 
            // txtUnitFee
            // 
            this.txtUnitFee.BackColor = System.Drawing.Color.White;
            this.txtUnitFee.Location = new System.Drawing.Point(222, 176);
            this.txtUnitFee.Name = "txtUnitFee";
            this.txtUnitFee.ReadOnly = true;
            this.txtUnitFee.Size = new System.Drawing.Size(73, 21);
            this.txtUnitFee.TabIndex = 53;
            // 
            // txtStandard
            // 
            this.txtStandard.BackColor = System.Drawing.Color.White;
            this.txtStandard.Location = new System.Drawing.Point(89, 176);
            this.txtStandard.Name = "txtStandard";
            this.txtStandard.ReadOnly = true;
            this.txtStandard.Size = new System.Drawing.Size(73, 21);
            this.txtStandard.TabIndex = 52;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(292, 137);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(132, 21);
            this.txtColor.TabIndex = 51;
            // 
            // txtCreator
            // 
            this.txtCreator.BackColor = System.Drawing.Color.White;
            this.txtCreator.Location = new System.Drawing.Point(89, 137);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.ReadOnly = true;
            this.txtCreator.Size = new System.Drawing.Size(149, 21);
            this.txtCreator.TabIndex = 50;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(312, 179);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 12);
            this.lblUnit.TabIndex = 49;
            this.lblUnit.Text = "단위";
            // 
            // lblUnitFee
            // 
            this.lblUnitFee.AutoSize = true;
            this.lblUnitFee.Location = new System.Drawing.Point(187, 179);
            this.lblUnitFee.Name = "lblUnitFee";
            this.lblUnitFee.Size = new System.Drawing.Size(29, 12);
            this.lblUnitFee.TabIndex = 48;
            this.lblUnitFee.Text = "단가";
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Location = new System.Drawing.Point(54, 179);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(29, 12);
            this.lblStandard.TabIndex = 47;
            this.lblStandard.Text = "규격";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(251, 140);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(35, 12);
            this.lblColor.TabIndex = 46;
            this.lblColor.Text = "Color";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(42, 140);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(41, 12);
            this.lblCreator.TabIndex = 45;
            this.lblCreator.Text = "제조처";
            // 
            // lblResName
            // 
            this.lblResName.AutoSize = true;
            this.lblResName.Location = new System.Drawing.Point(257, 103);
            this.lblResName.Name = "lblResName";
            this.lblResName.Size = new System.Drawing.Size(29, 12);
            this.lblResName.TabIndex = 44;
            this.lblResName.Text = "품명";
            // 
            // lblResCode
            // 
            this.lblResCode.AutoSize = true;
            this.lblResCode.Location = new System.Drawing.Point(54, 103);
            this.lblResCode.Name = "lblResCode";
            this.lblResCode.Size = new System.Drawing.Size(29, 12);
            this.lblResCode.TabIndex = 43;
            this.lblResCode.Text = "품번";
            // 
            // cboCmpyName
            // 
            this.cboCmpyName.FormattingEnabled = true;
            this.cboCmpyName.Location = new System.Drawing.Point(293, 64);
            this.cboCmpyName.Name = "cboCmpyName";
            this.cboCmpyName.Size = new System.Drawing.Size(131, 20);
            this.cboCmpyName.TabIndex = 42;
            this.cboCmpyName.SelectedIndexChanged += new System.EventHandler(this.cboCmpyName_SelectedIndexChanged);
            // 
            // txtResCode
            // 
            this.txtResCode.BackColor = System.Drawing.Color.White;
            this.txtResCode.Location = new System.Drawing.Point(89, 100);
            this.txtResCode.Name = "txtResCode";
            this.txtResCode.ReadOnly = true;
            this.txtResCode.Size = new System.Drawing.Size(132, 21);
            this.txtResCode.TabIndex = 41;
            // 
            // cboResName
            // 
            this.cboResName.FormattingEnabled = true;
            this.cboResName.Location = new System.Drawing.Point(292, 100);
            this.cboResName.Name = "cboResName";
            this.cboResName.Size = new System.Drawing.Size(132, 20);
            this.cboResName.TabIndex = 39;
            this.cboResName.SelectedIndexChanged += new System.EventHandler(this.cboResName_SelectedIndexChanged);
            // 
            // frmPurReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 335);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpPurDate);
            this.Controls.Add(this.lblCmpyCode);
            this.Controls.Add(this.lblCmpyName);
            this.Controls.Add(this.txtCmpyCode);
            this.Controls.Add(this.lblPurDate);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblAmt);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtUnitFee);
            this.Controls.Add(this.txtStandard);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtCreator);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblUnitFee);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblResName);
            this.Controls.Add(this.lblResCode);
            this.Controls.Add(this.cboCmpyName);
            this.Controls.Add(this.txtResCode);
            this.Controls.Add(this.cboResName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPurReg";
            this.ShowIcon = false;
            this.Text = "매입등록";
            this.Load += new System.EventHandler(this.frmPurReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpPurDate;
        private System.Windows.Forms.Label lblCmpyCode;
        private System.Windows.Forms.Label lblCmpyName;
        private System.Windows.Forms.TextBox txtCmpyCode;
        private System.Windows.Forms.Label lblPurDate;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtUnitFee;
        private System.Windows.Forms.TextBox txtStandard;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblUnitFee;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.BindingSource bsrcRes;
        private System.Windows.Forms.Label lblResName;
        private System.Windows.Forms.Label lblResCode;
        private System.Windows.Forms.ComboBox cboCmpyName;
        private System.Windows.Forms.TextBox txtResCode;
        private System.Windows.Forms.ComboBox cboResName;
    }
}