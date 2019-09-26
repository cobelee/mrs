namespace MRS.SettingModule
{
    partial class SettingMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingMain));
            this.msSetting = new System.Windows.Forms.MenuStrip();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.系统配置CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统配置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHspType = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteHspType = new System.Windows.Forms.Button();
            this.btnUpdateHspType = new System.Windows.Forms.Button();
            this.gvHspType = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddHspType = new System.Windows.Forms.Button();
            this.tbHspType = new System.Windows.Forms.TextBox();
            this.lbHspType = new System.Windows.Forms.Label();
            this.tabMPeriod = new System.Windows.Forms.TabPage();
            this.gvMPeriod = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDeleteMPeriod = new System.Windows.Forms.Button();
            this.btnEditMPeriod = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddMPeriod = new System.Windows.Forms.Button();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.tbBeginDate = new System.Windows.Forms.TextBox();
            this.lbBeginDate = new System.Windows.Forms.Label();
            this.mcEndDate = new System.Windows.Forms.MonthCalendar();
            this.mcBeginDate = new System.Windows.Forms.MonthCalendar();
            this.tbMPeriod = new System.Windows.Forms.TextBox();
            this.lbMPeriod = new System.Windows.Forms.Label();
            this.tabPsnType = new System.Windows.Forms.TabPage();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.gvAccount = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTrueName = new System.Windows.Forms.TextBox();
            this.lbTrueName = new System.Windows.Forms.Label();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.lbUserType = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tbPassword2 = new System.Windows.Forms.TextBox();
            this.lbPassword2 = new System.Windows.Forms.Label();
            this.tbPassword1 = new System.Windows.Forms.TextBox();
            this.lbPassword1 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.msSetting.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHspType.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHspType)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabMPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMPeriod)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // msSetting
            // 
            this.msSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit,
            this.系统配置CToolStripMenuItem});
            this.msSetting.Location = new System.Drawing.Point(0, 0);
            this.msSetting.Name = "msSetting";
            this.msSetting.Size = new System.Drawing.Size(622, 24);
            this.msSetting.TabIndex = 0;
            this.msSetting.Text = "menuStrip1";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(83, 20);
            this.miExit.Text = "退出系统(&E)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // 系统配置CToolStripMenuItem
            // 
            this.系统配置CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统配置SToolStripMenuItem});
            this.系统配置CToolStripMenuItem.Name = "系统配置CToolStripMenuItem";
            this.系统配置CToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.系统配置CToolStripMenuItem.Text = "工具(&T)";
            // 
            // 系统配置SToolStripMenuItem
            // 
            this.系统配置SToolStripMenuItem.Name = "系统配置SToolStripMenuItem";
            this.系统配置SToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.系统配置SToolStripMenuItem.Text = "系统配置(&O)";
            this.系统配置SToolStripMenuItem.Click += new System.EventHandler(this.系统配置SToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHspType);
            this.tabControl1.Controls.Add(this.tabMPeriod);
            this.tabControl1.Controls.Add(this.tabPsnType);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 483);
            this.tabControl1.TabIndex = 1;
            // 
            // tabHspType
            // 
            this.tabHspType.Controls.Add(this.panel3);
            this.tabHspType.Controls.Add(this.gvHspType);
            this.tabHspType.Controls.Add(this.panel1);
            this.tabHspType.Location = new System.Drawing.Point(4, 21);
            this.tabHspType.Name = "tabHspType";
            this.tabHspType.Padding = new System.Windows.Forms.Padding(3);
            this.tabHspType.Size = new System.Drawing.Size(614, 458);
            this.tabHspType.TabIndex = 0;
            this.tabHspType.Text = "就诊方式";
            this.tabHspType.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteHspType);
            this.panel3.Controls.Add(this.btnUpdateHspType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 54);
            this.panel3.TabIndex = 2;
            // 
            // btnDeleteHspType
            // 
            this.btnDeleteHspType.Location = new System.Drawing.Point(108, 17);
            this.btnDeleteHspType.Name = "btnDeleteHspType";
            this.btnDeleteHspType.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteHspType.TabIndex = 1;
            this.btnDeleteHspType.Text = "删除(&D)";
            this.btnDeleteHspType.UseVisualStyleBackColor = true;
            this.btnDeleteHspType.Click += new System.EventHandler(this.btnDeleteHspType_Click);
            // 
            // btnUpdateHspType
            // 
            this.btnUpdateHspType.Location = new System.Drawing.Point(17, 18);
            this.btnUpdateHspType.Name = "btnUpdateHspType";
            this.btnUpdateHspType.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateHspType.TabIndex = 0;
            this.btnUpdateHspType.Text = "修改(&E)";
            this.btnUpdateHspType.UseVisualStyleBackColor = true;
            // 
            // gvHspType
            // 
            this.gvHspType.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvHspType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvHspType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvHspType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHspType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvHspType.GridColor = System.Drawing.SystemColors.ControlText;
            this.gvHspType.Location = new System.Drawing.Point(3, 88);
            this.gvHspType.MultiSelect = false;
            this.gvHspType.Name = "gvHspType";
            this.gvHspType.ReadOnly = true;
            this.gvHspType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvHspType.RowHeadersVisible = false;
            this.gvHspType.RowTemplate.Height = 23;
            this.gvHspType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvHspType.Size = new System.Drawing.Size(608, 367);
            this.gvHspType.TabIndex = 1;
            this.gvHspType.VirtualMode = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddHspType);
            this.panel1.Controls.Add(this.tbHspType);
            this.panel1.Controls.Add(this.lbHspType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 85);
            this.panel1.TabIndex = 0;
            // 
            // btnAddHspType
            // 
            this.btnAddHspType.Location = new System.Drawing.Point(456, 18);
            this.btnAddHspType.Name = "btnAddHspType";
            this.btnAddHspType.Size = new System.Drawing.Size(75, 23);
            this.btnAddHspType.TabIndex = 4;
            this.btnAddHspType.Text = "增加(&A)";
            this.btnAddHspType.UseVisualStyleBackColor = true;
            this.btnAddHspType.Click += new System.EventHandler(this.btnAddHspType_Click);
            // 
            // tbHspType
            // 
            this.tbHspType.Location = new System.Drawing.Point(85, 21);
            this.tbHspType.Name = "tbHspType";
            this.tbHspType.Size = new System.Drawing.Size(246, 21);
            this.tbHspType.TabIndex = 1;
            // 
            // lbHspType
            // 
            this.lbHspType.AutoSize = true;
            this.lbHspType.Location = new System.Drawing.Point(14, 24);
            this.lbHspType.Name = "lbHspType";
            this.lbHspType.Size = new System.Drawing.Size(65, 12);
            this.lbHspType.TabIndex = 0;
            this.lbHspType.Text = "就诊方式：";
            // 
            // tabMPeriod
            // 
            this.tabMPeriod.Controls.Add(this.gvMPeriod);
            this.tabMPeriod.Controls.Add(this.panel6);
            this.tabMPeriod.Controls.Add(this.panel4);
            this.tabMPeriod.Location = new System.Drawing.Point(4, 21);
            this.tabMPeriod.Name = "tabMPeriod";
            this.tabMPeriod.Padding = new System.Windows.Forms.Padding(3);
            this.tabMPeriod.Size = new System.Drawing.Size(614, 458);
            this.tabMPeriod.TabIndex = 2;
            this.tabMPeriod.Text = "医保年度";
            this.tabMPeriod.UseVisualStyleBackColor = true;
            // 
            // gvMPeriod
            // 
            this.gvMPeriod.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvMPeriod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvMPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMPeriod.GridColor = System.Drawing.SystemColors.ControlText;
            this.gvMPeriod.Location = new System.Drawing.Point(3, 269);
            this.gvMPeriod.MultiSelect = false;
            this.gvMPeriod.Name = "gvMPeriod";
            this.gvMPeriod.ReadOnly = true;
            this.gvMPeriod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvMPeriod.RowHeadersVisible = false;
            this.gvMPeriod.RowTemplate.Height = 23;
            this.gvMPeriod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMPeriod.Size = new System.Drawing.Size(608, 131);
            this.gvMPeriod.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDeleteMPeriod);
            this.panel6.Controls.Add(this.btnEditMPeriod);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 400);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(608, 55);
            this.panel6.TabIndex = 1;
            // 
            // btnDeleteMPeriod
            // 
            this.btnDeleteMPeriod.Location = new System.Drawing.Point(127, 16);
            this.btnDeleteMPeriod.Name = "btnDeleteMPeriod";
            this.btnDeleteMPeriod.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMPeriod.TabIndex = 1;
            this.btnDeleteMPeriod.Text = "删除(&D)";
            this.btnDeleteMPeriod.UseVisualStyleBackColor = true;
            this.btnDeleteMPeriod.Click += new System.EventHandler(this.btnDeleteMPeriod_Click);
            // 
            // btnEditMPeriod
            // 
            this.btnEditMPeriod.Location = new System.Drawing.Point(18, 17);
            this.btnEditMPeriod.Name = "btnEditMPeriod";
            this.btnEditMPeriod.Size = new System.Drawing.Size(75, 23);
            this.btnEditMPeriod.TabIndex = 0;
            this.btnEditMPeriod.Text = "修改(&E)";
            this.btnEditMPeriod.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnAddMPeriod);
            this.panel4.Controls.Add(this.tbEndDate);
            this.panel4.Controls.Add(this.lbEndDate);
            this.panel4.Controls.Add(this.tbBeginDate);
            this.panel4.Controls.Add(this.lbBeginDate);
            this.panel4.Controls.Add(this.mcEndDate);
            this.panel4.Controls.Add(this.mcBeginDate);
            this.panel4.Controls.Add(this.tbMPeriod);
            this.panel4.Controls.Add(this.lbMPeriod);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 266);
            this.panel4.TabIndex = 0;
            // 
            // btnAddMPeriod
            // 
            this.btnAddMPeriod.Location = new System.Drawing.Point(73, 230);
            this.btnAddMPeriod.Name = "btnAddMPeriod";
            this.btnAddMPeriod.Size = new System.Drawing.Size(115, 23);
            this.btnAddMPeriod.TabIndex = 8;
            this.btnAddMPeriod.Text = "添加医保年度(&A)";
            this.btnAddMPeriod.UseVisualStyleBackColor = true;
            this.btnAddMPeriod.Click += new System.EventHandler(this.btnAddMPeriod_Click);
            // 
            // tbEndDate
            // 
            this.tbEndDate.BackColor = System.Drawing.SystemColors.Info;
            this.tbEndDate.Location = new System.Drawing.Point(375, 46);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.ReadOnly = true;
            this.tbEndDate.Size = new System.Drawing.Size(100, 21);
            this.tbEndDate.TabIndex = 7;
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(304, 49);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(65, 12);
            this.lbEndDate.TabIndex = 6;
            this.lbEndDate.Text = "终止日期：";
            // 
            // tbBeginDate
            // 
            this.tbBeginDate.BackColor = System.Drawing.SystemColors.Info;
            this.tbBeginDate.Location = new System.Drawing.Point(88, 46);
            this.tbBeginDate.Name = "tbBeginDate";
            this.tbBeginDate.ReadOnly = true;
            this.tbBeginDate.Size = new System.Drawing.Size(100, 21);
            this.tbBeginDate.TabIndex = 5;
            // 
            // lbBeginDate
            // 
            this.lbBeginDate.AutoSize = true;
            this.lbBeginDate.Location = new System.Drawing.Point(17, 49);
            this.lbBeginDate.Name = "lbBeginDate";
            this.lbBeginDate.Size = new System.Drawing.Size(65, 12);
            this.lbBeginDate.TabIndex = 4;
            this.lbBeginDate.Text = "起始日期：";
            // 
            // mcEndDate
            // 
            this.mcEndDate.Location = new System.Drawing.Point(304, 73);
            this.mcEndDate.Name = "mcEndDate";
            this.mcEndDate.TabIndex = 3;
            this.mcEndDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcEndDate_DateSelected);
            // 
            // mcBeginDate
            // 
            this.mcBeginDate.Location = new System.Drawing.Point(17, 73);
            this.mcBeginDate.Name = "mcBeginDate";
            this.mcBeginDate.TabIndex = 2;
            this.mcBeginDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcBeginDate_DateSelected);
            // 
            // tbMPeriod
            // 
            this.tbMPeriod.Location = new System.Drawing.Point(88, 11);
            this.tbMPeriod.Name = "tbMPeriod";
            this.tbMPeriod.Size = new System.Drawing.Size(100, 21);
            this.tbMPeriod.TabIndex = 1;
            // 
            // lbMPeriod
            // 
            this.lbMPeriod.AutoSize = true;
            this.lbMPeriod.Location = new System.Drawing.Point(17, 14);
            this.lbMPeriod.Name = "lbMPeriod";
            this.lbMPeriod.Size = new System.Drawing.Size(65, 12);
            this.lbMPeriod.TabIndex = 0;
            this.lbMPeriod.Text = "医保年度：";
            // 
            // tabPsnType
            // 
            this.tabPsnType.Location = new System.Drawing.Point(4, 21);
            this.tabPsnType.Name = "tabPsnType";
            this.tabPsnType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPsnType.Size = new System.Drawing.Size(614, 458);
            this.tabPsnType.TabIndex = 1;
            this.tabPsnType.Text = "人员类别";
            this.tabPsnType.UseVisualStyleBackColor = true;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.gvAccount);
            this.tabAccount.Controls.Add(this.panel5);
            this.tabAccount.Controls.Add(this.panel2);
            this.tabAccount.Location = new System.Drawing.Point(4, 21);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(614, 458);
            this.tabAccount.TabIndex = 3;
            this.tabAccount.Text = "系统账户";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // gvAccount
            // 
            this.gvAccount.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvAccount.GridColor = System.Drawing.SystemColors.ControlText;
            this.gvAccount.Location = new System.Drawing.Point(3, 131);
            this.gvAccount.MultiSelect = false;
            this.gvAccount.Name = "gvAccount";
            this.gvAccount.ReadOnly = true;
            this.gvAccount.RowHeadersVisible = false;
            this.gvAccount.RowTemplate.Height = 23;
            this.gvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAccount.Size = new System.Drawing.Size(608, 267);
            this.gvAccount.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnUpdateAccount);
            this.panel5.Controls.Add(this.btnDeleteAccount);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(608, 57);
            this.panel5.TabIndex = 4;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(14, 17);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(185, 23);
            this.btnUpdateAccount.TabIndex = 2;
            this.btnUpdateAccount.Text = "重置密码(&E)（暂时未实现）";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(238, 17);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "删除账户(&D)";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbTrueName);
            this.panel2.Controls.Add(this.lbTrueName);
            this.panel2.Controls.Add(this.cbUserType);
            this.panel2.Controls.Add(this.lbUserType);
            this.panel2.Controls.Add(this.btnAddAccount);
            this.panel2.Controls.Add(this.tbPassword2);
            this.panel2.Controls.Add(this.lbPassword2);
            this.panel2.Controls.Add(this.tbPassword1);
            this.panel2.Controls.Add(this.lbPassword1);
            this.panel2.Controls.Add(this.tbUserName);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 128);
            this.panel2.TabIndex = 1;
            // 
            // tbTrueName
            // 
            this.tbTrueName.Location = new System.Drawing.Point(82, 85);
            this.tbTrueName.Name = "tbTrueName";
            this.tbTrueName.Size = new System.Drawing.Size(100, 21);
            this.tbTrueName.TabIndex = 10;
            // 
            // lbTrueName
            // 
            this.lbTrueName.AutoSize = true;
            this.lbTrueName.Location = new System.Drawing.Point(13, 88);
            this.lbTrueName.Name = "lbTrueName";
            this.lbTrueName.Size = new System.Drawing.Size(65, 12);
            this.lbTrueName.TabIndex = 9;
            this.lbTrueName.Text = "真实姓名：";
            // 
            // cbUserType
            // 
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Items.AddRange(new object[] {
            "会计",
            "出纳",
            "系统管理员"});
            this.cbUserType.Location = new System.Drawing.Point(82, 11);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(121, 20);
            this.cbUserType.TabIndex = 8;
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.Location = new System.Drawing.Point(13, 14);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(65, 12);
            this.lbUserType.TabIndex = 7;
            this.lbUserType.Text = "账户类型：";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(481, 85);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "添加账户";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // tbPassword2
            // 
            this.tbPassword2.Location = new System.Drawing.Point(297, 85);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.Size = new System.Drawing.Size(100, 21);
            this.tbPassword2.TabIndex = 5;
            // 
            // lbPassword2
            // 
            this.lbPassword2.AutoSize = true;
            this.lbPassword2.Location = new System.Drawing.Point(226, 88);
            this.lbPassword2.Name = "lbPassword2";
            this.lbPassword2.Size = new System.Drawing.Size(65, 12);
            this.lbPassword2.TabIndex = 4;
            this.lbPassword2.Text = "确认密码：";
            // 
            // tbPassword1
            // 
            this.tbPassword1.Location = new System.Drawing.Point(297, 48);
            this.tbPassword1.Name = "tbPassword1";
            this.tbPassword1.Size = new System.Drawing.Size(100, 21);
            this.tbPassword1.TabIndex = 3;
            // 
            // lbPassword1
            // 
            this.lbPassword1.AutoSize = true;
            this.lbPassword1.Location = new System.Drawing.Point(226, 51);
            this.lbPassword1.Name = "lbPassword1";
            this.lbPassword1.Size = new System.Drawing.Size(65, 12);
            this.lbPassword1.TabIndex = 2;
            this.lbPassword1.Text = "输入密码：";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(82, 48);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 21);
            this.tbUserName.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(13, 51);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(53, 12);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "用户名：";
            // 
            // SettingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 507);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.msSetting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msSetting;
            this.Name = "SettingMain";
            this.Text = "镇海石化工业贸易有限责任公司补充医保报销系统－－－系统设置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msSetting.ResumeLayout(false);
            this.msSetting.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabHspType.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHspType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabMPeriod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMPeriod)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msSetting;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHspType;
        private System.Windows.Forms.TabPage tabPsnType;
        private System.Windows.Forms.TabPage tabMPeriod;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbHspType;
        private System.Windows.Forms.Label lbHspType;
        private System.Windows.Forms.DataGridView gvHspType;
        private System.Windows.Forms.Button btnAddHspType;
        private System.Windows.Forms.DataGridView gvAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox tbPassword2;
        private System.Windows.Forms.Label lbPassword2;
        private System.Windows.Forms.TextBox tbPassword1;
        private System.Windows.Forms.Label lbPassword1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.ComboBox cbUserType;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteHspType;
        private System.Windows.Forms.Button btnUpdateHspType;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbBeginDate;
        private System.Windows.Forms.MonthCalendar mcEndDate;
        private System.Windows.Forms.MonthCalendar mcBeginDate;
        private System.Windows.Forms.TextBox tbMPeriod;
        private System.Windows.Forms.Label lbMPeriod;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.TextBox tbBeginDate;
        private System.Windows.Forms.Button btnAddMPeriod;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView gvMPeriod;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnDeleteMPeriod;
        private System.Windows.Forms.Button btnEditMPeriod;
        private System.Windows.Forms.Label lbTrueName;
        private System.Windows.Forms.TextBox tbTrueName;
        private System.Windows.Forms.ToolStripMenuItem 系统配置CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统配置SToolStripMenuItem;
    }
}