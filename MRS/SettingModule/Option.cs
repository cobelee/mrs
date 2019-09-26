using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.SettingModule
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "报销比例定义": LoadDefineRatio();
                    break;
                default: break;
            }
        }

        private void LoadDefineRatio()
        {
            UC.SetBXRatio setRatio = new UC.SetBXRatio();
            panel1.Controls.Clear();
            panel1.Controls.Add(setRatio as Control);
            setRatio.Dock = DockStyle.Fill;
        }
    }
}