namespace MRS.UC
{
    partial class BxdList
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdateFpmx = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.gvBXD_Not_ChargeUP = new System.Windows.Forms.DataGridView();
            this.btnAddFpmx = new System.Windows.Forms.Button();
            this.gvBXMX = new System.Windows.Forms.DataGridView();
            this.WarrantPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBXD_Not_ChargeUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBXMX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateFpmx
            // 
            this.btnUpdateFpmx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateFpmx.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnUpdateFpmx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnUpdateFpmx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFpmx.Location = new System.Drawing.Point(483, 32);
            this.btnUpdateFpmx.Name = "btnUpdateFpmx";
            this.btnUpdateFpmx.Size = new System.Drawing.Size(90, 23);
            this.btnUpdateFpmx.TabIndex = 7;
            this.btnUpdateFpmx.Text = "修改(&E)";
            this.btnUpdateFpmx.UseVisualStyleBackColor = true;
            this.btnUpdateFpmx.Click += new System.EventHandler(this.btnUpdateFpmx_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBalance.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnBalance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Location = new System.Drawing.Point(483, 96);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(90, 23);
            this.btnBalance.TabIndex = 6;
            this.btnBalance.Text = "删除单据(&B)";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(483, 61);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除发票(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteBxmx_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.splitContainer1.Panel1.Controls.Add(this.btnPrint);
            this.splitContainer1.Panel1.Controls.Add(this.btnReload);
            this.splitContainer1.Panel1.Controls.Add(this.btnPrintPreview);
            this.splitContainer1.Panel1.Controls.Add(this.btnBalance);
            this.splitContainer1.Panel1.Controls.Add(this.gvBXD_Not_ChargeUP);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.splitContainer1.Panel2.Controls.Add(this.btnAddFpmx);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdateFpmx);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.gvBXMX);
            this.splitContainer1.Size = new System.Drawing.Size(576, 444);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(483, 37);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "设置后打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(483, 140);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(90, 23);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "重载数据(&R)";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPreview.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnPrintPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPreview.Location = new System.Drawing.Point(483, 3);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(90, 23);
            this.btnPrintPreview.TabIndex = 7;
            this.btnPrintPreview.Text = "打印预览(&V)";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // gvBXD_Not_ChargeUP
            // 
            this.gvBXD_Not_ChargeUP.AllowUserToAddRows = false;
            this.gvBXD_Not_ChargeUP.AllowUserToDeleteRows = false;
            this.gvBXD_Not_ChargeUP.AllowUserToOrderColumns = true;
            this.gvBXD_Not_ChargeUP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvBXD_Not_ChargeUP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvBXD_Not_ChargeUP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvBXD_Not_ChargeUP.BackgroundColor = System.Drawing.Color.Snow;
            this.gvBXD_Not_ChargeUP.Location = new System.Drawing.Point(3, 3);
            this.gvBXD_Not_ChargeUP.MultiSelect = false;
            this.gvBXD_Not_ChargeUP.Name = "gvBXD_Not_ChargeUP";
            this.gvBXD_Not_ChargeUP.ReadOnly = true;
            this.gvBXD_Not_ChargeUP.RowTemplate.Height = 23;
            this.gvBXD_Not_ChargeUP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBXD_Not_ChargeUP.Size = new System.Drawing.Size(474, 295);
            this.gvBXD_Not_ChargeUP.TabIndex = 0;
            this.gvBXD_Not_ChargeUP.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvBXD_Not_ChargeUP_CellMouseDoubleClick);
            this.gvBXD_Not_ChargeUP.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBXD_Not_ChargeUP_RowEnter);
            // 
            // btnAddFpmx
            // 
            this.btnAddFpmx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFpmx.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnAddFpmx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnAddFpmx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFpmx.Location = new System.Drawing.Point(483, 3);
            this.btnAddFpmx.Name = "btnAddFpmx";
            this.btnAddFpmx.Size = new System.Drawing.Size(90, 23);
            this.btnAddFpmx.TabIndex = 8;
            this.btnAddFpmx.Text = "添加(&A)";
            this.btnAddFpmx.UseVisualStyleBackColor = true;
            this.btnAddFpmx.Click += new System.EventHandler(this.btnAddFpmx_Click);
            // 
            // gvBXMX
            // 
            this.gvBXMX.AllowUserToAddRows = false;
            this.gvBXMX.AllowUserToDeleteRows = false;
            this.gvBXMX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvBXMX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvBXMX.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvBXMX.BackgroundColor = System.Drawing.Color.Snow;
            this.gvBXMX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBXMX.Location = new System.Drawing.Point(3, 3);
            this.gvBXMX.MultiSelect = false;
            this.gvBXMX.Name = "gvBXMX";
            this.gvBXMX.ReadOnly = true;
            this.gvBXMX.RowTemplate.Height = 23;
            this.gvBXMX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBXMX.Size = new System.Drawing.Size(474, 133);
            this.gvBXMX.TabIndex = 0;
            this.gvBXMX.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvBXMX_CellMouseDoubleClick);
            // 
            // WarrantPrintDocument
            // 
            this.WarrantPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.WarrantPrintDocument_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.Document = this.WarrantPrintDocument;
            this.printDialog1.PrintToFile = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // BxdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "BxdList";
            this.Size = new System.Drawing.Size(576, 444);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBXD_Not_ChargeUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBXMX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gvBXD_Not_ChargeUP;
        private System.Windows.Forms.DataGridView gvBXMX;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnUpdateFpmx;
        private System.Windows.Forms.Button btnAddFpmx;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Drawing.Printing.PrintDocument WarrantPrintDocument;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
