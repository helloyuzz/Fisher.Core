using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fisherman.Core;

namespace Fisherman.LadyFirst {
    class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Fisher.Set_ConnectionString(Globals.SqlConnectionString);

            Application.Run(new Form_Main());
        }
        //static void Main(string[] args) {
            
        //    LjkList<TSysConfiguration> list = null;

        //    using(IDbConnection dbConnection = new SqlConnection(Globals.SqlConnectionString)) {
        //        list = dbConnection.Select<TSysConfiguration>();
        //    }
        //    Console.ReadLine();
        //}

        //static void Main(string[] args) {

        //    LjkList<TSysConfiguration> list = null;

        //    using(IDbConnection dbConnection = new SqlConnection(Globals.SqlConnectionString)) {
        //        list = dbConnection.Select<TSysConfiguration>();
        //        list = dbConnection.Select<TSysConfiguration>(1,10,"","",null);

        //        list = dbConnection.Select<TSysConfiguration>(1,10,null,null,"ConfigurationID","ConfigurationKey");

        //        dbConnection.SingleRow<TSysConfiguration>("");

        //        //TSysConfiguration sysConfiguration = new TSysConfiguration();
        //        //sysConfiguration.ConfigurationKey = Guid.NewGuid().ToString();

        //        //dbConnection.Insert<TSysConfiguration>(sysConfiguration);

        //        //dbConnection.Update<TSysConfiguration>(sysConfiguration);

        //        //dbConnection.Delete<TSysConfiguration>(0);

        //        //sysConfiguration = dbConnection.Get<TSysConfiguration>();
        //        //sysConfiguration = dbConnection.Get<TSysConfiguration>(1);
        //        //sysConfiguration = dbConnection.Get<TSysConfiguration>("UUID");

        //        //LjkList ljkPagedList = dbConnection.List<TSysConfiguration>();
        //    }
        //    Console.ReadLine();
        //}
    }
}
