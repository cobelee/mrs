namespace MRS.UC
{
    partial class IndividualQuery
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlPersonInfo = new System.Windows.Forms.Panel();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbOrganization = new System.Windows.Forms.Label();
            this.lbIdentityCard = new System.Windows.Forms.Label();
            this.lbJobNumber = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBXPersonName = new System.Windows.Forms.Label();
            this.lbPsnType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbMedicareId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbYBH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gvIndividual = new System.Windows.Forms.DataGridView();
            this.gvGR_BXMX = new System.Windows.Forms.DataGridView();
            this.WarrantPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvIndividual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGR_BXMX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(526, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 355);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 355);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 10);
            this.panel2.TabIndex = 1;
            // 
            // btnCollapse
            // 
            this.btnCollapse.Location = new System.Drawing.Point(10, 13);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(95, 23);
            this.btnCollapse.TabIndex = 5;
            this.btnCollapse.Text = "隐藏测边栏";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnPrintPreview);
            this.panel1.Controls.Add(this.btnCollapse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(316, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "立即打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(167, 13);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(92, 23);
            this.btnPrintPreview.TabIndex = 6;
            this.btnPrintPreview.Text = "打印预览(&P)";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlPersonInfo);
            this.splitContainer1.Panel1.Controls.Add(this.tbYBH);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuery);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dtpEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.dtpBeginDate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(783, 420);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 1;
            // 
            // pnlPersonInfo
            // 
            this.pnlPersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPersonInfo.Controls.Add(this.lbSex);
            this.pnlPersonInfo.Controls.Add(this.lbOrganization);
            this.pnlPersonInfo.Controls.Add(this.lbIdentityCard);
            this.pnlPersonInfo.Controls.Add(this.lbJobNumber);
            this.pnlPersonInfo.Controls.Add(this.label10);
            this.pnlPersonInfo.Controls.Add(this.label9);
            this.pnlPersonInfo.Controls.Add(this.label8);
            this.pnlPersonInfo.Controls.Add(this.label3);
            this.pnlPersonInfo.Controls.Add(this.lbBXPersonName);
            this.pnlPersonInfo.Controls.Add(this.lbPsnType);
            this.pnlPersonInfo.Controls.Add(this.label6);
            this.pnlPersonInfo.Controls.Add(this.lbBirthday);
            this.pnlPersonInfo.Controls.Add(this.lbMedicareId);
            this.pnlPersonInfo.Controls.Add(this.label5);
            this.pnlPersonInfo.Controls.Add(this.label4);
            this.pnlPersonInfo.Location = new System.Drawing.Point(12, 233);
            this.pnlPersonInfo.Name = "pnlPersonInfo";
            this.pnlPersonInfo.Size = new System.Drawing.Size(215, 296);
            this.pnlPersonInfo.TabIndex = 6;
            this.pnlPersonInfo.Visible = false;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(94, 208);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(47, 12);
            this.lbSex.TabIndex = 21;
            this.lbSex.Text = "label14";
            // 
            // lbOrganization
            // 
            this.lbOrganization.AutoSize = true;
            this.lbOrganization.Location = new System.Drawing.Point(94, 180);
            this.lbOrganization.Name = "lbOrganization";
            this.lbOrganization.Size = new System.Drawing.Size(47, 12);
            this.lbOrganization.TabIndex = 20;
            this.lbOrganization.Text = "label13";
            // 
            // lbIdentityCard
            // 
            this.lbIdentityCard.AutoSize = true;
            this.lbIdentityCard.Location = new System.Drawing.Point(94, 124);
            this.lbIdentityCard.Name = "lbIdentityCard";
            this.lbIdentityCard.Size = new System.Drawing.Size(89, 12);
            this.lbIdentityCard.TabIndex = 19;
            this.lbIdentityCard.Text = "lbIdentityCard";
            // 
            // lbJobNumber
            // 
            this.lbJobNumber.AutoSize = true;
            this.lbJobNumber.Location = new System.Drawing.Point(94, 96);
            this.lbJobNumber.Name = "lbJobNumber";
            this.lbJobNumber.Size = new System.Drawing.Size(47, 12);
            this.lbJobNumber.TabIndex = 18;
            this.lbJobNumber.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "性　　别：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "部　　门：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "身份证号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "工　　号：";
            // 
            // lbBXPersonName
            // 
            this.lbBXPersonName.AutoSize = true;
            this.lbBXPersonName.Font = new System.Drawing.Font("楷体_GB2312", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBXPersonName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbBXPersonName.Location = new System.Drawing.Point(18, 15);
            this.lbBXPersonName.Name = "lbBXPersonName";
            this.lbBXPersonName.Size = new System.Drawing.Size(99, 27);
            this.lbBXPersonName.TabIndex = 7;
            this.lbBXPersonName.Text = "岑海菊";
            // 
            // lbPsnType
            // 
            this.lbPsnType.AutoSize = true;
            this.lbPsnType.Location = new System.Drawing.Point(94, 236);
            this.lbPsnType.Name = "lbPsnType";
            this.lbPsnType.Size = new System.Drawing.Size(59, 12);
            this.lbPsnType.TabIndex = 11;
            this.lbPsnType.Text = "lbPsnType";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "医 保 号：";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(94, 152);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(59, 12);
            this.lbBirthday.TabIndex = 13;
            this.lbBirthday.Text = "1955.10.1";
            // 
            // lbMedicareId
            // 
            this.lbMedicareId.AutoSize = true;
            this.lbMedicareId.Location = new System.Drawing.Point(94, 68);
            this.lbMedicareId.Name = "lbMedicareId";
            this.lbMedicareId.Size = new System.Drawing.Size(53, 12);
            this.lbMedicareId.TabIndex = 9;
            this.lbMedicareId.Text = "10320737";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "人员类别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "出生年月：";
            // 
            // tbYBH
            // 
            this.tbYBH.Location = new System.Drawing.Point(12, 33);
            this.tbYBH.Name = "tbYBH";
            this.tbYBH.Size = new System.Drawing.Size(215, 21);
            this.tbYBH.TabIndex = 1;
            this.tbYBH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYBH_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "医保号：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(152, 191);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择时间段：";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(13, 150);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(214, 21);
            this.dtpEndDate.TabIndex = 3;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(12, 108);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(215, 21);
            this.dtpBeginDate.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(10, 53);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gvIndividual);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gvGR_BXMX);
            this.splitContainer2.Size = new System.Drawing.Size(516, 355);
            this.splitContainer2.SplitterDistance = 190;
            this.splitContainer2.TabIndex = 4;
            // 
            // gvIndividual
            // 
            this.gvIndividual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvIndividual.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvIndividual.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvIndividual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIndividual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvIndividual.Location = new System.Drawing.Point(0, 0);
            this.gvIndividual.MultiSelect = false;
            this.gvIndividual.Name = "gvIndividual";
            this.gvIndividual.ReadOnly = true;
            this.gvIndividual.RowHeadersVisible = false;
            this.gvIndividual.RowTemplate.Height = 23;
            this.gvIndividual.RowTemplate.ReadOnly = true;
            this.gvIndividual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvIndividual.Size = new System.Drawing.Size(516, 190);
            this.gvIndividual.TabIndex = 8;
            this.gvIndividual.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvIndividual_CellClick);
            // 
            // gvGR_BXMX
            // 
            this.gvGR_BXMX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvGR_BXMX.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvGR_BXMX.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvGR_BXMX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvGR_BXMX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGR_BXMX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGR_BXMX.Location = new System.Drawing.Point(0, 0);
            this.gvGR_BXMX.MultiSelect = false;
            this.gvGR_BXMX.Name = "gvGR_BXMX";
            this.gvGR_BXMX.ReadOnly = true;
            this.gvGR_BXMX.RowHeadersVisible = false;
            this.gvGR_BXMX.RowTemplate.Height = 23;
            this.gvGR_BXMX.RowTemplate.ReadOnly = true;
            this.gvGR_BXMX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvGR_BXMX.Size = new System.Drawing.Size(516, 161);
            this.gvGR_BXMX.TabIndex = 9;
            // 
            // WarrantPrintDocument
            // 
            this.WarrantPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.WarrantPrintDocument_PrintPage);
            // 
            // IndividualQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 420);
            this.Controls.Add(this.splitContainer1);
            this.Name = "IndividualQuery";
            this.Text = "个人清单查询窗口";
            this.Load += new System.EventHandler(this.IndividualQuery_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlPersonInfo.ResumeLayout(false);
            this.pnlPersonInfo.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvIndividual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGR_BXMX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbYBH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.DataGridView gvIndividual;
        private System.Windows.Forms.Panel pnlPersonInfo;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbOrganization;
        private System.Windows.Forms.Label lbIdentityCard;
        private System.Windows.Forms.Label lbJobNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBXPersonName;
        private System.Windows.Forms.Label lbPsnType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbMedicareId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvGR_BXMX;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Drawing.Printing.PrintDocument WarrantPrintDocument;
        private System.Windows.Forms.Button btnPrint;

    }
}