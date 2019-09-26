using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MRS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new MRS.CUModule.MDIMain());
            //Application.Run(new MRS.MRModule.MRModule());
            //Application.Run(new SettingModule.SettingMain());

        }
    }
}