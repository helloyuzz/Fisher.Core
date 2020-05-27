using CSSD.Web.API;
using CSSD.Web.API.Dapper.vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fisher.Core;

namespace Fisher.Man {
    public partial class Form_Main:Form {
        public Form_Main() {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender,EventArgs e) {
            //LjkResult<TSysConfiguration> list = null;

            //using(IDbConnection dbConnection = new SqlConnection(Globals.SqlConnectionString)) {
            //    list = dbConnection.Select<TSysConfiguration>();
            //}
            //dgv.DataSource = list.Result;
        }

        int totalPage = -1;
        private void btn_PageClicked(object sender,EventArgs e) {
            int pageSize = FisherUtil.ParseInt(tbx_PageSize.Text,10);
            int pageIndex = FisherUtil.ParseInt(tbx_PageIndex.Text,1);

            Button btn = (Button)sender;
            switch(btn.Name) {
                case "btn_FirstPage":
                    pageIndex = 1;
                    break;
                case "btn_PrevPage":
                    pageIndex--;
                    break;
                case "btn_NextPage":
                    pageIndex++;
                    break;
                case "btn_LastPage":
                    pageIndex = totalPage;
                    break;
            }
            if(pageIndex <= 0) {
                pageIndex = 1;
            } else if(pageIndex > totalPage && totalPage > 0) {
                pageIndex = totalPage;
            }

            FisherResult<TSysConfiguration> result = null;

            using(IDbConnection dbConnection = new SqlConnection(Globals.SqlConnectionString)) {
                result = dbConnection.Select<TSysConfiguration>(pageSize,pageIndex);
            }
            dgv.DataSource = result.Result;
            tbx_PageIndex.Text = result.PageIndex.ToString();
            tbx_RecordCount.Text = result.TotalRecord.ToString();

            totalPage = result.TotalRecord / result.PageSize;
            if(result.TotalRecord % result.PageSize > 0) {
                totalPage++;
            }            
            tbx_TotalPage.Text = totalPage.ToString();
        }

        private void btn_GetRow_Click(object sender,EventArgs e) {
            int pk_Int = FisherUtil.ParseInt(dgv[0,dgv.CurrentCell.RowIndex].Value);
            TSysConfiguration configuration = null;
            using(IDbConnection dbConnection = new SqlConnection(Globals.SqlConnectionString)) {
                configuration = dbConnection.SingleRow<TSysConfiguration>(pk_Int);
            }

            MessageBox.Show(configuration.ConfigurationKey);
        }

        private void btn_Add_Click(object sender,EventArgs e) {
            FisherResult result = null;
            TSysConfiguration sysConfiguration = new TSysConfiguration() {
                ConfigurationID = 1,
                ConfigurationKey = Guid.NewGuid().ToString(),
                IsDisabled=false

            };
            using(IDbConnection dbConnection = new SqlConnection(Globals.SqlConnectionString)) {
                result = dbConnection.Insert<TSysConfiguration>(sysConfiguration);
            }
            if(result.ExecResult == Result.OK) {

            }
        }
    }
}
