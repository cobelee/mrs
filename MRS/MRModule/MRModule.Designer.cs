namespace MRS.MRModule
{
    partial class MRModule
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
            System.Windows.Forms.ToolStripMenuItem ExitSystemToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MRModule));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msReimbursement = new System.Windows.Forms.ToolStripMenuItem();
            this.msBaoXiao = new System.Windows.Forms.ToolStripMenuItem();
            this.Balance_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.查询QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.msIndividualQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.报销比例查询RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.技术支持TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tslbAccountant = new System.Windows.Forms.ToolStripLabel();
            ExitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitSystemToolStripMenuItem
            // 
            ExitSystemToolStripMenuItem.Name = "ExitSystemToolStripMenuItem";
            ExitSystemToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            ExitSystemToolStripMenuItem.Text = "退出系统";
            ExitSystemToolStripMenuItem.Click += new System.EventHandler(this.msExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msReimbursement,
            this.查询QToolStripMenuItem,
            this.windowsMenu,
            this.帮助HToolStripMenuItem,
            this.msExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msReimbursement
            // 
            this.msReimbursement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msBaoXiao,
            this.Balance_ToolStripMenuItem,
            this.toolStripSeparator3,
            ExitSystemToolStripMenuItem});
            this.msReimbursement.Name = "msReimbursement";
            this.msReimbursement.Size = new System.Drawing.Size(59, 20);
            this.msReimbursement.Text = "操作(&B)";
            // 
            // msBaoXiao
            // 
            this.msBaoXiao.Name = "msBaoXiao";
            this.msBaoXiao.Size = new System.Drawing.Size(118, 22);
            this.msBaoXiao.Text = "报销";
            this.msBaoXiao.Click += new System.EventHandler(this.msBaoXiao_Click);
            // 
            // Balance_ToolStripMenuItem
            // 
            this.Balance_ToolStripMenuItem.Name = "Balance_ToolStripMenuItem";
            this.Balance_ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.Balance_ToolStripMenuItem.Text = "冲账";
            this.Balance_ToolStripMenuItem.Click += new System.EventHandler(this.Balance_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(115, 6);
            // 
            // 查询QToolStripMenuItem
            // 
            this.查询QToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPersonInfo,
            this.msIndividualQuery,
            this.报销比例查询RToolStripMenuItem});
            this.查询QToolStripMenuItem.Name = "查询QToolStripMenuItem";
            this.查询QToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.查询QToolStripMenuItem.Text = "查询(&Q)";
            // 
            // menuItemPersonInfo
            // 
            this.menuItemPersonInfo.Name = "menuItemPersonInfo";
            this.menuItemPersonInfo.Size = new System.Drawing.Size(160, 22);
            this.menuItemPersonInfo.Text = "个人信息查询";
            this.menuItemPersonInfo.Click += new System.EventHandler(this.menuItemPersonInfo_Click);
            // 
            // msIndividualQuery
            // 
            this.msIndividualQuery.Name = "msIndividualQuery";
            this.msIndividualQuery.Size = new System.Drawing.Size(160, 22);
            this.msIndividualQuery.Text = "个人报销清单";
            this.msIndividualQuery.Click += new System.EventHandler(this.msIndividualQuery_Click);
            // 
            // 报销比例查询RToolStripMenuItem
            // 
            this.报销比例查询RToolStripMenuItem.Name = "报销比例查询RToolStripMenuItem";
            this.报销比例查询RToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.报销比例查询RToolStripMenuItem.Text = "报销比例查询(&R)";
            this.报销比例查询RToolStripMenuItem.Click += new System.EventHandler(this.报销比例查询RToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(59, 20);
            this.windowsMenu.Text = "窗口(&W)";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newWindowToolStripMenuItem.Text = "新建窗口(&N)";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cascadeToolStripMenuItem.Text = "层叠(&C)";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tileVerticalToolStripMenuItem.Text = "垂直平铺(&V)";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tileHorizontalToolStripMenuItem.Text = "水平平铺(&H)";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.closeAllToolStripMenuItem.Text = "全部关闭(&L)";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.arrangeIconsToolStripMenuItem.Text = "排列图标(&A)";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.技术支持TToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 技术支持TToolStripMenuItem
            // 
            this.技术支持TToolStripMenuItem.Name = "技术支持TToolStripMenuItem";
            this.技术支持TToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.技术支持TToolStripMenuItem.Text = "技术支持(&T)";
            this.技术支持TToolStripMenuItem.Click += new System.EventHandler(this.技术支持TToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // msExit
            // 
            this.msExit.Name = "msExit";
            this.msExit.Size = new System.Drawing.Size(83, 20);
            this.msExit.Text = "退出系统(&E)";
            this.msExit.Click += new System.EventHandler(this.msExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tslbAccountant});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(674, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(89, 22);
            this.toolStripLabel1.Text = "当前操作会计：";
            // 
            // tslbAccountant
            // 
            this.tslbAccountant.Name = "tslbAccountant";
            this.tslbAccountant.Size = new System.Drawing.Size(77, 22);
            this.tslbAccountant.Text = "会计真实姓名";
            // 
            // MRModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 459);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MRModule";
            this.Text = "补充医保报销";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msReimbursement;
        private System.Windows.Forms.ToolStripMenuItem msBaoXiao;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tslbAccountant;
        private System.Windows.Forms.ToolStripMenuItem 查询QToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msIndividualQuery;
        private System.Windows.Forms.ToolStripMenuItem Balance_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItemPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem 报销比例查询RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 技术支持TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
    }
}