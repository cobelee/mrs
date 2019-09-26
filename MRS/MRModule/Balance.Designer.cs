namespace MRS.MRModule
{
    partial class Balance
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.gvBalance = new System.Windows.Forms.DataGridView();
            this.btnBalance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(36, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gvBalance
            // 
            this.gvBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvBalance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvBalance.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBalance.Location = new System.Drawing.Point(12, 41);
            this.gvBalance.MultiSelect = false;
            this.gvBalance.Name = "gvBalance";
            this.gvBalance.ReadOnly = true;
            this.gvBalance.RowHeadersVisible = false;
            this.gvBalance.RowTemplate.Height = 23;
            this.gvBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBalance.Size = new System.Drawing.Size(691, 448);
            this.gvBalance.TabIndex = 4;
            this.gvBalance.DoubleClick += new System.EventHandler(this.gvBalance_DoubleClick);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(144, 12);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(75, 23);
            this.btnBalance.TabIndex = 5;
            this.btnBalance.Text = "冲账(&B)";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 501);
            this.Controls.Add(this.gvBalance);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnBalance);
            this.Name = "Balance";
            this.Text = "冲账管理窗口";
            ((System.ComponentModel.ISupportInitialize)(this.gvBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBalance;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnBalance;
    }
}