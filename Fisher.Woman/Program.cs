using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fisher.Woman {
    static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Form_Main());
            //Application.Run(new Form_Startup());
            //Application.Run(new Form_MySQL());
            //Application.Run(new Form_SQLBuilder());
            Application.Run(new Form_MSSQL());
        }
    }
}