namespace MRS.MRModule
{
    partial class InputInvoice
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbYYF_number = new System.Windows.Forms.Label();
            this.mtbFPDate = new System.Windows.Forms.MaskedTextBox();
            this.btnGetDate = new System.Windows.Forms.Button();
            this.mcFPDate = new System.Windows.Forms.MonthCalendar();
            this.lbFPDate = new System.Windows.Forms.Label();
            this.cbJZFS = new System.Windows.Forms.ComboBox();
            this.lbJZFS = new System.Windows.Forms.Label();
            this.tbTCJJ = new System.Windows.Forms.TextBox();
            this.lbTCJJ = new System.Windows.Forms.Label();
            this.tbGRCDBao = new System.Windows.Forms.TextBox();
            this.lbGRCDBao = new System.Windows.Forms.Label();
            this.tbGRZFBao = new System.Windows.Forms.TextBox();
            this.lbGRZFBao = new System.Windows.Forms.Label();
            this.tbGRZFu = new System.Windows.Forms.TextBox();
            this.lbGRZFu = new System.Windows.Forms.Label();
            this.tbGRZFei = new System.Windows.Forms.TextBox();
            this.lbGRZFei = new System.Windows.Forms.Label();
            this.lbYYF = new System.Windows.Forms.Label();
            this.tbLNZHBao = new System.Windows.Forms.TextBox();
            this.lbLNZHBao = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInitCalc = new System.Windows.Forms.Button();
            this.lbKeyCharNumber = new System.Windows.Forms.Label();
            this.tbGRZFuHide = new System.Windows.Forms.TextBox();
            this.lbGRZFuHide = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbIsZero = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbYYF_number
            // 
            this.lbYYF_number.AutoSize = true;
            this.lbYYF_number.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lbYYF_number.Location = new System.Drawing.Point(449, 127);
            this.lbYYF_number.Name = "lbYYF_number";
            this.lbYYF_number.Size = new System.Drawing.Size(21, 22);
            this.lbYYF_number.TabIndex = 41;
            this.lbYYF_number.Text = "0";
            // 
            // mtbFPDate
            // 
            this.mtbFPDate.BeepOnError = true;
            this.mtbFPDate.Location = new System.Drawing.Point(82, 24);
            this.mtbFPDate.Mask = "0000-00-00";
            this.mtbFPDate.Name = "mtbFPDate";
            this.mtbFPDate.Size = new System.Drawing.Size(100, 21);
            this.mtbFPDate.TabIndex = 1;
            this.mtbFPDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnGetDate
            // 
            this.btnGetDate.Location = new System.Drawing.Point(186, 24);
            this.btnGetDate.Name = "btnGetDate";
            this.btnGetDate.Size = new System.Drawing.Size(20, 23);
            this.btnGetDate.TabIndex = 40;
            this.btnGetDate.TabStop = false;
            this.btnGetDate.Text = "=";
            this.btnGetDate.UseVisualStyleBackColor = true;
            this.btnGetDate.Click += new System.EventHandler(this.btnGetDate_Click);
            // 
            // mcFPDate
            // 
            this.mcFPDate.Location = new System.Drawing.Point(82, 48);
            this.mcFPDate.Name = "mcFPDate";
            this.mcFPDate.TabIndex = 39;
            this.mcFPDate.Visible = false;
            this.mcFPDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcFPDate_DateSelected);
            // 
            // lbFPDate
            // 
            this.lbFPDate.AutoSize = true;
            this.lbFPDate.Location = new System.Drawing.Point(9, 28);
            this.lbFPDate.Name = "lbFPDate";
            this.lbFPDate.Size = new System.Drawing.Size(65, 12);
            this.lbFPDate.TabIndex = 38;
            this.lbFPDate.Text = "发票日期：";
            // 
            // cbJZFS
            // 
            this.cbJZFS.BackColor = System.Drawing.SystemColors.Info;
            this.cbJZFS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJZFS.FormattingEnabled = true;
            this.cbJZFS.Location = new System.Drawing.Point(283, 24);
            this.cbJZFS.Name = "cbJZFS";
            this.cbJZFS.Size = new System.Drawing.Size(121, 20);
            this.cbJZFS.TabIndex = 2;
            // 
            // lbJZFS
            // 
            this.lbJZFS.AutoSize = true;
            this.lbJZFS.Location = new System.Drawing.Point(212, 27);
            this.lbJZFS.Name = "lbJZFS";
            this.lbJZFS.Size = new System.Drawing.Size(65, 12);
            this.lbJZFS.TabIndex = 37;
            this.lbJZFS.Text = "就诊方式：";
            // 
            // tbTCJJ
            // 
            this.tbTCJJ.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbTCJJ.Location = new System.Drawing.Point(481, 92);
            this.tbTCJJ.Name = "tbTCJJ";
            this.tbTCJJ.Size = new System.Drawing.Size(100, 21);
            this.tbTCJJ.TabIndex = 8;
            // 
            // lbTCJJ
            // 
            this.lbTCJJ.AutoSize = true;
            this.lbTCJJ.Location = new System.Drawing.Point(410, 95);
            this.lbTCJJ.Name = "lbTCJJ";
            this.lbTCJJ.Size = new System.Drawing.Size(65, 12);
            this.lbTCJJ.TabIndex = 36;
            this.lbTCJJ.Text = "统筹基金：";
            // 
            // tbGRCDBao
            // 
            this.tbGRCDBao.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbGRCDBao.Location = new System.Drawing.Point(82, 92);
            this.tbGRCDBao.Name = "tbGRCDBao";
            this.tbGRCDBao.Size = new System.Drawing.Size(100, 21);
            this.tbGRCDBao.TabIndex = 6;
            // 
            // lbGRCDBao
            // 
            this.lbGRCDBao.AutoSize = true;
            this.lbGRCDBao.Location = new System.Drawing.Point(9, 95);
            this.lbGRCDBao.Name = "lbGRCDBao";
            this.lbGRCDBao.Size = new System.Drawing.Size(65, 12);
            this.lbGRCDBao.TabIndex = 35;
            this.lbGRCDBao.Text = "个人承担：";
            // 
            // tbGRZFBao
            // 
            this.tbGRZFBao.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbGRZFBao.Location = new System.Drawing.Point(481, 56);
            this.tbGRZFBao.Name = "tbGRZFBao";
            this.tbGRZFBao.Size = new System.Drawing.Size(100, 21);
            this.tbGRZFBao.TabIndex = 5;
            // 
            // lbGRZFBao
            // 
            this.lbGRZFBao.AutoSize = true;
            this.lbGRZFBao.Location = new System.Drawing.Point(410, 59);
            this.lbGRZFBao.Name = "lbGRZFBao";
            this.lbGRZFBao.Size = new System.Drawing.Size(65, 12);
            this.lbGRZFBao.TabIndex = 31;
            this.lbGRZFBao.Text = "个人自负：";
            // 
            // tbGRZFu
            // 
            this.tbGRZFu.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbGRZFu.Location = new System.Drawing.Point(283, 56);
            this.tbGRZFu.Name = "tbGRZFu";
            this.tbGRZFu.Size = new System.Drawing.Size(100, 21);
            this.tbGRZFu.TabIndex = 4;
            // 
            // lbGRZFu
            // 
            this.lbGRZFu.AutoSize = true;
            this.lbGRZFu.Location = new System.Drawing.Point(212, 60);
            this.lbGRZFu.Name = "lbGRZFu";
            this.lbGRZFu.Size = new System.Drawing.Size(65, 12);
            this.lbGRZFu.TabIndex = 29;
            this.lbGRZFu.Text = "个人自付：";
            // 
            // tbGRZFei
            // 
            this.tbGRZFei.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbGRZFei.Location = new System.Drawing.Point(82, 57);
            this.tbGRZFei.Name = "tbGRZFei";
            this.tbGRZFei.Size = new System.Drawing.Size(100, 21);
            this.tbGRZFei.TabIndex = 3;
            // 
            // lbGRZFei
            // 
            this.lbGRZFei.AutoSize = true;
            this.lbGRZFei.Location = new System.Drawing.Point(9, 60);
            this.lbGRZFei.Name = "lbGRZFei";
            this.lbGRZFei.Size = new System.Drawing.Size(65, 12);
            this.lbGRZFei.TabIndex = 26;
            this.lbGRZFei.Text = "个人自费：";
            // 
            // lbYYF
            // 
            this.lbYYF.AutoSize = true;
            this.lbYYF.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbYYF.Location = new System.Drawing.Point(282, 129);
            this.lbYYF.Name = "lbYYF";
            this.lbYYF.Size = new System.Drawing.Size(161, 19);
            this.lbYYF.TabIndex = 23;
            this.lbYYF.Text = "请核对医药费：￥";
            // 
            // tbLNZHBao
            // 
            this.tbLNZHBao.Location = new System.Drawing.Point(283, 92);
            this.tbLNZHBao.Name = "tbLNZHBao";
            this.tbLNZHBao.Size = new System.Drawing.Size(100, 21);
            this.tbLNZHBao.TabIndex = 7;
            // 
            // lbLNZHBao
            // 
            this.lbLNZHBao.AutoSize = true;
            this.lbLNZHBao.Location = new System.Drawing.Point(212, 95);
            this.lbLNZHBao.Name = "lbLNZHBao";
            this.lbLNZHBao.Size = new System.Drawing.Size(65, 12);
            this.lbLNZHBao.TabIndex = 42;
            this.lbLNZHBao.Text = "历年账户：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(186, 321);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(329, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInitCalc);
            this.groupBox1.Controls.Add(this.lbKeyCharNumber);
            this.groupBox1.Controls.Add(this.tbGRZFuHide);
            this.groupBox1.Controls.Add(this.lbGRZFuHide);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 143);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "扣除项";
            // 
            // btnInitCalc
            // 
            this.btnInitCalc.Location = new System.Drawing.Point(270, 100);
            this.btnInitCalc.Name = "btnInitCalc";
            this.btnInitCalc.Size = new System.Drawing.Size(75, 23);
            this.btnInitCalc.TabIndex = 4;
            this.btnInitCalc.TabStop = false;
            this.btnInitCalc.Text = "重新计算";
            this.btnInitCalc.UseVisualStyleBackColor = true;
            // 
            // lbKeyCharNumber
            // 
            this.lbKeyCharNumber.AutoSize = true;
            this.lbKeyCharNumber.Location = new System.Drawing.Point(515, 103);
            this.lbKeyCharNumber.Name = "lbKeyCharNumber";
            this.lbKeyCharNumber.Size = new System.Drawing.Size(47, 12);
            this.lbKeyCharNumber.TabIndex = 3;
            this.lbKeyCharNumber.Text = "KeyChar";
            // 
            // tbGRZFuHide
            // 
            this.tbGRZFuHide.Location = new System.Drawing.Point(125, 100);
            this.tbGRZFuHide.Name = "tbGRZFuHide";
            this.tbGRZFuHide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbGRZFuHide.Size = new System.Drawing.Size(139, 21);
            this.tbGRZFuHide.TabIndex = 2;
            this.tbGRZFuHide.Text = "0.0";
            // 
            // lbGRZFuHide
            // 
            this.lbGRZFuHide.AutoSize = true;
            this.lbGRZFuHide.Location = new System.Drawing.Point(30, 103);
            this.lbGRZFuHide.Name = "lbGRZFuHide";
            this.lbGRZFuHide.Size = new System.Drawing.Size(89, 12);
            this.lbGRZFuHide.TabIndex = 6;
            this.lbGRZFuHide.Text = "隐性个人自付：";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(556, 56);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "隐性个人自付说明";
            // 
            // cbIsZero
            // 
            this.cbIsZero.AutoSize = true;
            this.cbIsZero.Checked = true;
            this.cbIsZero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsZero.Location = new System.Drawing.Point(86, 132);
            this.cbIsZero.Name = "cbIsZero";
            this.cbIsZero.Size = new System.Drawing.Size(96, 16);
            this.cbIsZero.TabIndex = 9;
            this.cbIsZero.Text = "本年余额为零";
            this.cbIsZero.UseVisualStyleBackColor = true;
            this.cbIsZero.CheckedChanged += new System.EventHandler(this.cbIsZero_CheckedChanged);
            // 
            // InputInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(592, 358);
            this.Controls.Add(this.mcFPDate);
            this.Controls.Add(this.cbIsZero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbYYF_number);
            this.Controls.Add(this.lbLNZHBao);
            this.Controls.Add(this.mtbFPDate);
            this.Controls.Add(this.tbLNZHBao);
            this.Controls.Add(this.btnGetDate);
            this.Controls.Add(this.lbFPDate);
            this.Controls.Add(this.cbJZFS);
            this.Controls.Add(this.lbJZFS);
            this.Controls.Add(this.tbTCJJ);
            this.Controls.Add(this.lbTCJJ);
            this.Controls.Add(this.tbGRCDBao);
            this.Controls.Add(this.lbGRCDBao);
            this.Controls.Add(this.tbGRZFBao);
            this.Controls.Add(this.lbGRZFBao);
            this.Controls.Add(this.tbGRZFu);
            this.Controls.Add(this.lbGRZFu);
            this.Controls.Add(this.tbGRZFei);
            this.Controls.Add(this.lbGRZFei);
            this.Controls.Add(this.lbYYF);
            this.Name = "InputInvoice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "医保结算信息采集窗口";
            this.Load += new System.EventHandler(this.InputInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbYYF_number;
        private System.Windows.Forms.MaskedTextBox mtbFPDate;
        private System.Windows.Forms.Button btnGetDate;
        private System.Windows.Forms.MonthCalendar mcFPDate;
        private System.Windows.Forms.Label lbFPDate;
        private System.Windows.Forms.ComboBox cbJZFS;
        private System.Windows.Forms.Label lbJZFS;
        private System.Windows.Forms.TextBox tbTCJJ;
        private System.Windows.Forms.Label lbTCJJ;
        private System.Windows.Forms.TextBox tbGRCDBao;
        private System.Windows.Forms.Label lbGRCDBao;
        private System.Windows.Forms.TextBox tbGRZFBao;
        private System.Windows.Forms.Label lbGRZFBao;
        private System.Windows.Forms.TextBox tbGRZFu;
        private System.Windows.Forms.Label lbGRZFu;
        private System.Windows.Forms.TextBox tbGRZFei;
        private System.Windows.Forms.Label lbGRZFei;
        private System.Windows.Forms.Label lbYYF;
        private System.Windows.Forms.TextBox tbLNZHBao;
        private System.Windows.Forms.Label lbLNZHBao;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbGRZFuHide;
        private System.Windows.Forms.Label lbGRZFuHide;
        private System.Windows.Forms.Label lbKeyCharNumber;
        private System.Windows.Forms.Button btnInitCalc;
        private System.Windows.Forms.CheckBox cbIsZero;


    }
}