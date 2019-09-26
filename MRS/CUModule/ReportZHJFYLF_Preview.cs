using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.CUModule
{
    public partial class ReportZHJFYLF_Preview : Form
    {
        public ReportZHJFYLF_Preview()
        {
            InitializeComponent();
        }

        public PrintPreviewControl PrintPreviewControl
        {
            get { return printPreviewControl1; }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog(this) == DialogResult.OK)
            {
                printPreviewControl1.Document.PrinterSettings = printDialog1.PrinterSettings;
                printPreviewControl1.Document.Print();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}