namespace MRS.MRModule
{
    partial class PersonInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbYBH = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.pnlPersonInfo = new System.Windows.Forms.Panel();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbOrganization = new System.Windows.Forms.Label();
            this.lbIdentityCard = new System.Windows.Forms.Label();
            this.lbJobNumber = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBXPersonName = new System.Windows.Forms.Label();
            this.lbPsnType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbMedicareId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbBankAccountText = new System.Windows.Forms.Label();
            this.lbBankAccount = new System.Windows.Forms.Label();
            this.pnlPersonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "医保号：";
            // 
            // tbYBH
            // 
            this.tbYBH.Location = new System.Drawing.Point(80, 15);
            this.tbYBH.Name = "tbYBH";
            this.tbYBH.Size = new System.Drawing.Size(197, 21);
            this.tbYBH.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(283, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // pnlPersonInfo
            // 
            this.pnlPersonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPersonInfo.Controls.Add(this.lbBankAccount);
            this.pnlPersonInfo.Controls.Add(this.lbBankAccountText);
            this.pnlPersonInfo.Controls.Add(this.lbSex);
            this.pnlPersonInfo.Controls.Add(this.lbOrganization);
            this.pnlPersonInfo.Controls.Add(this.lbIdentityCard);
            this.pnlPersonInfo.Controls.Add(this.lbJobNumber);
            this.pnlPersonInfo.Controls.Add(this.label10);
            this.pnlPersonInfo.Controls.Add(this.label9);
            this.pnlPersonInfo.Controls.Add(this.label8);
            this.pnlPersonInfo.Controls.Add(this.label2);
            this.pnlPersonInfo.Controls.Add(this.lbBXPersonName);
            this.pnlPersonInfo.Controls.Add(this.lbPsnType);
            this.pnlPersonInfo.Controls.Add(this.label6);
            this.pnlPersonInfo.Controls.Add(this.lbBirthday);
            this.pnlPersonInfo.Controls.Add(this.lbMedicareId);
            this.pnlPersonInfo.Controls.Add(this.label5);
            this.pnlPersonInfo.Controls.Add(this.label3);
            this.pnlPersonInfo.Location = new System.Drawing.Point(23, 42);
            this.pnlPersonInfo.Name = "pnlPersonInfo";
            this.pnlPersonInfo.Size = new System.Drawing.Size(335, 298);
            this.pnlPersonInfo.TabIndex = 4;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("宋体", 11F);
            this.lbSex.Location = new System.Drawing.Point(98, 204);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(63, 15);
            this.lbSex.TabIndex = 21;
            this.lbSex.Text = "label14";
            // 
            // lbOrganization
            // 
            this.lbOrganization.AutoSize = true;
            this.lbOrganization.Font = new System.Drawing.Font("宋体", 11F);
            this.lbOrganization.Location = new System.Drawing.Point(98, 176);
            this.lbOrganization.Name = "lbOrganization";
            this.lbOrganization.Size = new System.Drawing.Size(63, 15);
            this.lbOrganization.TabIndex = 20;
            this.lbOrganization.Text = "label13";
            // 
            // lbIdentityCard
            // 
            this.lbIdentityCard.AutoSize = true;
            this.lbIdentityCard.Font = new System.Drawing.Font("宋体", 11F);
            this.lbIdentityCard.Location = new System.Drawing.Point(98, 120);
            this.lbIdentityCard.Name = "lbIdentityCard";
            this.lbIdentityCard.Size = new System.Drawing.Size(119, 15);
            this.lbIdentityCard.TabIndex = 19;
            this.lbIdentityCard.Text = "lbIdentityCard";
            // 
            // lbJobNumber
            // 
            this.lbJobNumber.AutoSize = true;
            this.lbJobNumber.Font = new System.Drawing.Font("宋体", 11F);
            this.lbJobNumber.Location = new System.Drawing.Point(98, 92);
            this.lbJobNumber.Name = "lbJobNumber";
            this.lbJobNumber.Size = new System.Drawing.Size(63, 15);
            this.lbJobNumber.TabIndex = 18;
            this.lbJobNumber.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 11F);
            this.label10.Location = new System.Drawing.Point(9, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "性　　别：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 11F);
            this.label9.Location = new System.Drawing.Point(9, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "部　　门：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 11F);
            this.label8.Location = new System.Drawing.Point(9, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "身份证号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "工　　号：";
            // 
            // lbBXPersonName
            // 
            this.lbBXPersonName.AutoSize = true;
            this.lbBXPersonName.Font = new System.Drawing.Font("楷体_GB2312", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBXPersonName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbBXPersonName.Location = new System.Drawing.Point(4, 11);
            this.lbBXPersonName.Name = "lbBXPersonName";
            this.lbBXPersonName.Size = new System.Drawing.Size(100, 27);
            this.lbBXPersonName.TabIndex = 7;
            this.lbBXPersonName.Text = "[姓名]";
            // 
            // lbPsnType
            // 
            this.lbPsnType.AutoSize = true;
            this.lbPsnType.Font = new System.Drawing.Font("宋体", 11F);
            this.lbPsnType.Location = new System.Drawing.Point(98, 232);
            this.lbPsnType.Name = "lbPsnType";
            this.lbPsnType.Size = new System.Drawing.Size(79, 15);
            this.lbPsnType.TabIndex = 11;
            this.lbPsnType.Text = "lbPsnType";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 11F);
            this.label6.Location = new System.Drawing.Point(9, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "医 保 号：";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("宋体", 11F);
            this.lbBirthday.Location = new System.Drawing.Point(98, 148);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(79, 15);
            this.lbBirthday.TabIndex = 13;
            this.lbBirthday.Text = "1955.10.1";
            // 
            // lbMedicareId
            // 
            this.lbMedicareId.AutoSize = true;
            this.lbMedicareId.Font = new System.Drawing.Font("宋体", 11F);
            this.lbMedicareId.Location = new System.Drawing.Point(98, 64);
            this.lbMedicareId.Name = "lbMedicareId";
            this.lbMedicareId.Size = new System.Drawing.Size(71, 15);
            this.lbMedicareId.TabIndex = 9;
            this.lbMedicareId.Text = "10320737";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11F);
            this.label5.Location = new System.Drawing.Point(9, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "人员类别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "出生年月：";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(155, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbBankAccountText
            // 
            this.lbBankAccountText.AutoSize = true;
            this.lbBankAccountText.Font = new System.Drawing.Font("宋体", 11F);
            this.lbBankAccountText.Location = new System.Drawing.Point(9, 261);
            this.lbBankAccountText.Name = "lbBankAccountText";
            this.lbBankAccountText.Size = new System.Drawing.Size(82, 15);
            this.lbBankAccountText.TabIndex = 22;
            this.lbBankAccountText.Text = "银行帐号：";
            // 
            // lbBankAccount
            // 
            this.lbBankAccount.AutoSize = true;
            this.lbBankAccount.Font = new System.Drawing.Font("宋体", 11F);
            this.lbBankAccount.Location = new System.Drawing.Point(98, 261);
            this.lbBankAccount.Name = "lbBankAccount";
            this.lbBankAccount.Size = new System.Drawing.Size(127, 15);
            this.lbBankAccount.TabIndex = 22;
            this.lbBankAccount.Text = "[lbBankAccount]";
            // 
            // PersonInfo
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(385, 407);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlPersonInfo);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.tbYBH);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人信息查询";
            this.Load += new System.EventHandler(this.PersonInfo_Load);
            this.pnlPersonInfo.ResumeLayout(false);
            this.pnlPersonInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYBH;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Panel pnlPersonInfo;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbOrganization;
        private System.Windows.Forms.Label lbIdentityCard;
        private System.Windows.Forms.Label lbJobNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBXPersonName;
        private System.Windows.Forms.Label lbPsnType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbMedicareId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbBankAccountText;
        private System.Windows.Forms.Label lbBankAccount;
    }
}