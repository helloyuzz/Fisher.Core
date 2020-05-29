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
using Fisherman.Core;
using Fisherman.LadyFirst;

namespace Fisherman.LadyFirst {
    public partial class Form_Main:Form {
        int totalPage = -1;
        public Form_Main() {
            InitializeComponent();
        }
        
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

            FisherResult<TSysConfiguration> result = Fisher.Query<TSysConfiguration>(tbx_SqlCondition.Text,null,pageSize,pageIndex);

            dgv.DataSource = result.Result;
            tbx_PageIndex.Text = result.PageIndex.ToString();
            tbx_RecordCount.Text = result.TotalRecord.ToString();
            tbx_TotalPage.Text = result.TotalPage.ToString();
            totalPage = result.TotalPage;
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
            //using(IDbConnection dbConnection = new SqlConnection(Globals.SqlConnectionString)) {
            //    result = dbConnection.Insert<TSysConfiguration>(sysConfiguration);
            //}
            //if(result.ExecResult == Result.OK) {

            //}
        }

        private void btn_Save_Click(object sender,EventArgs e) {
            int id = FisherUtil.ParseInt(tbx_ConfigurationID.Text);

            TSysConfiguration configuration = new TSysConfiguration();

            if(id > 0) { // 修改
                configuration.ConfigurationID = id;
            }
            configuration.ConfigurationKey = tbx_ConfigurationKey.Text;
            configuration.Value = tbx_Value.Text;
            configuration.Remark = tbx_Remark.Text;
            configuration.IsDisabled = cbx_IsDisabled.Checked;

            FisherResult result = null;

            if(id > 0) {
                result = Fisher.Update<TSysConfiguration>(configuration);
            } else {
                result = Fisher.Insert<TSysConfiguration>(configuration);
            }
            if(result.Success == Result.True) {
                Console.WriteLine(result.Pk_Id);
            }


        }

        private void btn_SignleRow_Click(object sender,EventArgs e) {
            int id = FisherUtil.ParseInt(tbx_Get_ConfigurationID.Text);
            if(id > 0) {
                TSysConfiguration configuration = Fisher.SignleRow<TSysConfiguration>(id);
                Fisher.SignleRow<TSysConfiguration>("",true);
            }
        }
    }
}
