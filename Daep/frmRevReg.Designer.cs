
namespace Daep
{
    partial class frmRevReg
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
            this.cboProdName = new System.Windows.Forms.ComboBox();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.cboCmpyName = new System.Windows.Forms.ComboBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtUnitFee = new System.Windows.Forms.TextBox();
            this.txtStandard = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblUnitFee = new System.Windows.Forms.Label();
            this.lblStandard = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblProdCode = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblRevDate = new System.Windows.Forms.Label();
            this.txtCmpyCode = new System.Windows.Forms.TextBox();
            this.lblCmpyName = new System.Windows.Forms.Label();
            this.lblCmpyCode = new System.Windows.Forms.Label();
            this.dtpRevDate = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bsrcProd = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsrcProd)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProdName
            // 
            this.cboProdName.FormattingEnabled = true;
            this.cboProdName.Location = new System.Drawing.Point(293, 97);
            this.cboProdName.Name = "cboProdName";
            this.cboProdName.Size = new System.Drawing.Size(132, 20);
            this.cboProdName.TabIndex = 0;
            this.cboProdName.SelectedIndexChanged += new System.EventHandler(this.cboProdName_SelectedIndexChanged);
            // 
            // txtProdCode
            // 
            this.txtProdCode.BackColor = System.Drawing.Color.White;
            this.txtProdCode.Location = new System.Drawing.Point(90, 97);
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.ReadOnly = true;
            this.txtProdCode.Size = new System.Drawing.Size(132, 21);
            this.txtProdCode.TabIndex = 1;
            // 
            // cboCmpyName
            // 
            this.cboCmpyName.FormattingEnabled = true;
            this.cboCmpyName.Location = new System.Drawing.Point(294, 61);
            this.cboCmpyName.Name = "cboCmpyName";
            this.cboCmpyName.Size = new System.Drawing.Size(131, 20);
            this.cboCmpyName.TabIndex = 2;
            this.cboCmpyName.SelectedIndexChanged += new System.EventHandler(this.cboCmpyName_SelectedIndexChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.Location = new System.Drawing.Point(348, 173);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(77, 21);
            this.txtUnit.TabIndex = 25;
            // 
            // txtUnitFee
            // 
            this.txtUnitFee.BackColor = System.Drawing.Color.White;
            this.txtUnitFee.Location = new System.Drawing.Point(223, 173);
            this.txtUnitFee.Name = "txtUnitFee";
            this.txtUnitFee.ReadOnly = true;
            this.txtUnitFee.Size = new System.Drawing.Size(73, 21);
            this.txtUnitFee.TabIndex = 24;
            // 
            // txtStandard
            // 
            this.txtStandard.BackColor = System.Drawing.Color.White;
            this.txtStandard.Location = new System.Drawing.Point(90, 173);
            this.txtStandard.Name = "txtStandard";
            this.txtStandard.ReadOnly = true;
            this.txtStandard.Size = new System.Drawing.Size(73, 21);
            this.txtStandard.TabIndex = 23;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(293, 134);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(132, 21);
            this.txtColor.TabIndex = 22;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.White;
            this.txtType.Location = new System.Drawing.Point(90, 134);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(149, 21);
            this.txtType.TabIndex = 21;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(313, 176);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 12);
            this.lblUnit.TabIndex = 20;
            this.lblUnit.Text = "단위";
            // 
            // lblUnitFee
            // 
            this.lblUnitFee.AutoSize = true;
            this.lblUnitFee.Location = new System.Drawing.Point(188, 176);
            this.lblUnitFee.Name = "lblUnitFee";
            this.lblUnitFee.Size = new System.Drawing.Size(29, 12);
            this.lblUnitFee.TabIndex = 19;
            this.lblUnitFee.Text = "단가";
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Location = new System.Drawing.Point(55, 176);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(29, 12);
            this.lblStandard.TabIndex = 18;
            this.lblStandard.Text = "규격";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(252, 137);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(35, 12);
            this.lblColor.TabIndex = 17;
            this.lblColor.Text = "Color";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(55, 137);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(29, 12);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "차종";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(258, 100);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(29, 12);
            this.lblProdName.TabIndex = 15;
            this.lblProdName.Text = "품명";
            // 
            // lblProdCode
            // 
            this.lblProdCode.AutoSize = true;
            this.lblProdCode.Location = new System.Drawing.Point(55, 100);
            this.lblProdCode.Name = "lblProdCode";
            this.lblProdCode.Size = new System.Drawing.Size(29, 12);
            this.lblProdCode.TabIndex = 14;
            this.lblProdCode.Text = "품번";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(90, 209);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(73, 21);
            this.txtCount.TabIndex = 26;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(223, 209);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(73, 21);
            this.txtAmt.TabIndex = 27;
            this.txtAmt.TextChanged += new System.EventHandler(this.txtAmt_TextChanged);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(90, 247);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(206, 21);
            this.txtTag.TabIndex = 28;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(55, 212);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(29, 12);
            this.lblCount.TabIndex = 29;
            this.lblCount.Text = "수량";
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Location = new System.Drawing.Point(188, 212);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(29, 12);
            this.lblAmt.TabIndex = 30;
            this.lblAmt.Text = "금액";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(55, 250);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(29, 12);
            this.lblTag.TabIndex = 31;
            this.lblTag.Text = "비고";
            // 
            // lblRevDate
            // 
            this.lblRevDate.AutoSize = true;
            this.lblRevDate.Location = new System.Drawing.Point(31, 31);
            this.lblRevDate.Name = "lblRevDate";
            this.lblRevDate.Size = new System.Drawing.Size(53, 12);
            this.lblRevDate.TabIndex = 32;
            this.lblRevDate.Text = "매출일자";
            // 
            // txtCmpyCode
            // 
            this.txtCmpyCode.BackColor = System.Drawing.Color.White;
            this.txtCmpyCode.Location = new System.Drawing.Point(90, 61);
            this.txtCmpyCode.Name = "txtCmpyCode";
            this.txtCmpyCode.ReadOnly = true;
            this.txtCmpyCode.Size = new System.Drawing.Size(132, 21);
            this.txtCmpyCode.TabIndex = 33;
            // 
            // lblCmpyName
            // 
            this.lblCmpyName.AutoSize = true;
            this.lblCmpyName.Location = new System.Drawing.Point(246, 64);
            this.lblCmpyName.Name = "lblCmpyName";
            this.lblCmpyName.Size = new System.Drawing.Size(41, 12);
            this.lblCmpyName.TabIndex = 34;
            this.lblCmpyName.Text = "회사명";
            // 
            // lblCmpyCode
            // 
            this.lblCmpyCode.AutoSize = true;
            this.lblCmpyCode.Location = new System.Drawing.Point(19, 64);
            this.lblCmpyCode.Name = "lblCmpyCode";
            this.lblCmpyCode.Size = new System.Drawing.Size(65, 12);
            this.lblCmpyCode.TabIndex = 35;
            this.lblCmpyCode.Text = "사업자번호";
            // 
            // dtpRevDate
            // 
            this.dtpRevDate.CustomFormat = "yyyy-MM-dd";
            this.dtpRevDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRevDate.Location = new System.Drawing.Point(90, 25);
            this.dtpRevDate.Name = "dtpRevDate";
            this.dtpRevDate.Size = new System.Drawing.Size(102, 21);
            this.dtpRevDate.TabIndex = 0;
            this.dtpRevDate.ValueChanged += new System.EventHandler(this.dtpRevDate_ValueChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(421, 279);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(315, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmRevReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 316);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpRevDate);
            this.Controls.Add(this.lblCmpyCode);
            this.Controls.Add(this.lblCmpyName);
            this.Controls.Add(this.txtCmpyCode);
            this.Controls.Add(this.lblRevDate);
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
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblUnitFee);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblProdCode);
            this.Controls.Add(this.cboCmpyName);
            this.Controls.Add(this.txtProdCode);
            this.Controls.Add(this.cboProdName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRevReg";
            this.ShowIcon = false;
            this.Text = "매출등록";
            this.Load += new System.EventHandler(this.frmRevReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsrcProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProdName;
        private System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.ComboBox cboCmpyName;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtUnitFee;
        private System.Windows.Forms.TextBox txtStandard;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblUnitFee;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblProdCode;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblRevDate;
        private System.Windows.Forms.TextBox txtCmpyCode;
        private System.Windows.Forms.Label lblCmpyName;
        private System.Windows.Forms.Label lblCmpyCode;
        private System.Windows.Forms.DateTimePicker dtpRevDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsrcProd;
    }
}