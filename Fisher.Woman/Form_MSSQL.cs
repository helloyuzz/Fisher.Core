﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;
using com.yuzz.dblibrary;
using System.Drawing;
using System.Text.RegularExpressions;
using Fisherman.Core;

namespace Fisher.Woman {
    public partial class Form_MSSQL:Form {
        List<SmTable> smTableList = new List<SmTable>();
        List<SmProcedure> smProcedures = new List<SmProcedure>();

        delegate void OnSaveFileCallback(string filePath,int currentIndex = 0,int fileCount = 0);

        public Form_MSSQL() {
            InitializeComponent();
        }


        // 加载数据库表列表
        private void load_SchemaAndSPList(SqlConnection dbConn) {
            SqlCommand dbCmd = new SqlCommand("select [Id],[Name] from [SysObjects] where type='u' order by [name] asc",dbConn);          
            // 表
            SqlDataReader dbReader = dbCmd.ExecuteReader();
            while(dbReader.Read()) {
                string tableId = FisherUtil.IngoreNull(dbReader["Id"]);
                string tableName = FisherUtil.IngoreNull(dbReader["Name"]);
                SmTable smTable = new SmTable(tableId,tableName);
                smTableList.Add(smTable);                
            }
            dbReader.Close();
            dbReader = null;

            list_Schema.DisplayMember = "TableName";
            list_Schema.ValueMember = "TableId";
            foreach(SmTable smTable in smTableList) {
                list_Schema.Items.Add(smTable);
            }

            // 存储过程
            dbCmd.CommandText = "select [Id],[Name] from [SysObjects] where type='p' order by [name] asc";  //  and name like 'sp_%'
            dbReader = dbCmd.ExecuteReader();
            while(dbReader.Read()) {
                string p_Id = FisherUtil.IngoreNull(dbReader["Id"]);
                string p_Name = FisherUtil.IngoreNull(dbReader["Name"]);
                SmProcedure smProcedure = new SmProcedure(p_Name);      

                smProcedures.Add(smProcedure);
            }
            dbReader.Close();
            dbReader = null;
            dbConn.Close();

            list_StoreProcedure.ValueMember = "ProcedureId";
            list_StoreProcedure.DisplayMember = "ProcedureName";
            foreach(SmProcedure smProcedure in smProcedures) {
                list_StoreProcedure.Items.Add(smProcedure);
            }
        }

        private SmProcedure getSmProcedure(string p_Name,SqlConnection dbConn = null) {
            SmProcedure smProcedure = new SmProcedure(p_Name);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = dbConn;
            sqlCommand.CommandText = string.Format("select t.text from syscomments t left join sysobjects j ON t.id = j.id where j.name ='{0}' and type='p'",p_Name);
            smProcedure.SQLText = sqlCommand.ExecuteScalar() as string;
            smProcedure.SQLText = smProcedure.SQLText.Replace("\r\n","");
            smProcedure.SQLText = smProcedure.SQLText.Remove(0,smProcedure.SQLText.IndexOf("SET XACT_ABORT ON") + "SET XACT_ABORT ON".Length);

            //string sqlReslut = @"--==================================================--Create Author: HuangLong--Create Date: 20171204--==================================================CREATE PROCEDURE P_DASHBOARD_GET_COLLECT_INFO_REPORT		@ActionUserID int,		@ProductID int,		@StartTime datetime,		@EndTime datetime,		@OrgID INTASBEGINSET XACT_ABORT ONSELECT TU.UserFullName AS ActionName,TC.CreatedTime AS ActionTime,TP.ProductName,TBF.FlowBarcode,1 AS Quantity ,TU2.UserFullName AS CollectUser,TS.SectionName AS SectionNameFROM TFlowCollect TCINNER JOIN TFlowPoductInFlow TPF ON TC.FlowID=TPF.FlowID INNER JOIN TFlowIssue ION I.FlowID = TPF.FlowIDINNER JOIN TMasterProduct TP ON TP.ProductID =TPF.ProductID INNER JOIN TMasterUser TUON TU.UserID =TC.IssueUserID LEFT JOIN TFlowBarcodeInFlow TBF ON TBF.FlowID =TC.FlowID INNER JOIN TMasterUser TU2ON TC.CollectUserID=TU2.UserIDINNER JOIN TMasterSection TSON TC.SectionID=TS.SectionIDWHERE TP.ProductID =ISNULL(@ProductID,TP.ProductID)AND TC.IssueUserID =ISNULL(@ActionUserID,TC.IssueUserID)AND DATEDIFF(DAY,  ISNULL(@StartTime, TC.CreatedTime) , TC.CreatedTime) >= 0AND DATEDIFF(DAY,  ISNULL(@EndTime, TC.CreatedTime) , TC.CreatedTime) <= 0AND TPF.IsDeleted =0AND I.IssueOrgID = ISNULL(@OrgID, I.IssueOrgID)END;";
            Regex regex = new Regex(@"select\s.*\sfrom",RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection mc = regex.Matches(smProcedure.SQLText);
            foreach(Match match1 in mc) {
                Console.WriteLine(match1.Value);

                MatchCollection mc1 = regex.Matches(match1.Value.Remove(0,6));
            }


            string line = "lane=1;speed=30.3mph;acceleration=2.5mph/s";
            Regex reg = new Regex(@"speeds*=\s*([\d\.]+)\s*(mph|km/h|m/s)*");
            Match match = reg.Match(line);

            //MatchCollection mc = reg.Matches(line);


            return smProcedure;
        }

        private SmTable getSmTable(string tableName,SqlConnection dbConn = null) {
            SmTable smTable = new SmTable(tableName);
            
            // 获取描述信息
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.Connection = dbConn;
            //selectCommand.CommandText = "select t.name,e.value from sys.extended_properties e ,syscolumns t where e.name = 'MS_Description' and t.id = (select object_id('" + tableName + "')) and e.major_id = t.id and e.minor_id = t.colorder";
            selectCommand.CommandText = string.Format(@"
                                SELECT t.name,e.value FROM sys.extended_properties e left join syscolumns t on e.minor_id = t.colorder WHERE t.id = object_id( '{0}' )	
                                UNION
                                SELECT '_SchemaName' as name, [value] FROM sys.extended_properties t  WHERE t.major_id= object_id('{1}') and t.minor_id =0
                                ",tableName,tableName);

            DataTable dt_Comment = new DataTable();
            SqlDataAdapter comment = new SqlDataAdapter();
            comment.SelectCommand = selectCommand;
            comment.Fill(dt_Comment);
            DataRow[] schemaComment = dt_Comment.Select("name='_SchemaName'");
            if(schemaComment.Length > 0) {
                smTable.Remarks = FisherUtil.IngoreNull(schemaComment[0]["value"]);
            }
            // 获取所有的字属性信息
            SqlDataAdapter dbAdapter = new SqlDataAdapter() {
                //SelectCommand = new SqlCommand("sp_columns " + tableName,dbConn)
                SelectCommand = new SqlCommand("SELECT t1.colorder, t1.colid, t1.isnullable as 'Is_Nullable', t1.name as 'Column_Name', t1.scale, t2.name AS 'Type_Name', t1.length, COLUMNPROPERTY(t1.id,t1.name,'PRECISION') AS realy_length FROM syscolumns t1 LEFT JOIN systypes t2 ON t1.xtype = t2.xusertype INNER JOIN sysobjects t3 ON t1.id = t3.id AND t3.xtype = 'U' AND t3.name <> 'dtproperties' WHERE t3.name = '" + tableName + "' ORDER BY    t1.id",dbConn)
            };
            DataTable dt_Columns = new DataTable();
            int getCount = dbAdapter.Fill(dt_Columns);

            // 获取主键信息
            SqlDataAdapter dbpk = new SqlDataAdapter() {
                SelectCommand = new SqlCommand("sp_pkeys @table_name='" + tableName + "'",dbConn)
            };
            DataTable dt_pk = new DataTable();
            dbpk.Fill(dt_pk);
            string pkname = "";
            int key_SEQ = -1;
            if(dt_pk != null && dt_pk.Rows.Count > 0) {
                pkname = FisherUtil.IngoreNull(dt_pk.Rows[0]["Column_name"]);
                key_SEQ = FisherUtil.ParseInt(dt_pk.Rows[0]["KEY_SEQ"]);
            }

            smTable.TableName = tableName;
            foreach(DataRow getRow in dt_Columns.Rows) {
                if(smTable.Fields == null) {
                    smTable.Fields = new List<SmField>();
                }

                string typeName = FisherUtil.IngoreNull(getRow["Type_Name"]);

                SmField smColumn = new SmField();
                smColumn.Name = FisherUtil.IngoreNull(getRow["Column_Name"]);
                smColumn.DbType = FisherUtil.ParseToSqlDbType(typeName);

                DataRow[] commentRows = dt_Comment.Select("name='" + smColumn.Name + "'");
                if(commentRows.Length > 0) {
                    DataRow commentRow = commentRows[0];
                    smColumn.Remarks = commentRow[1].ToString();
                }
                smColumn.MaxLength = FisherUtil.ParseInt(getRow["realy_length"]);   // Real_Length

                if(typeName.IndexOf("identity") != -1 || smColumn.Name.Equals(pkname,StringComparison.CurrentCultureIgnoreCase)) {
                    smColumn.PrimaryKey = true;
                smColumn.KEY_SEQ = key_SEQ;
                }

                smColumn.Is_Nullable = FisherUtil.ParseBool(getRow["Is_Nullable"]);                 

                if(smColumn.PrimaryKey == true) {   // 主键放在最开始的位置
                    smTable.PrimaryKey = smColumn;
                    smTable.Fields.Insert(0,smColumn);
                } else {
                    smTable.Fields.Add(smColumn);
                }
            }

            return smTable;
        }


        string createGetByIdMethod(SmTable smTable) {
            StringBuilder getMethod = new StringBuilder();

            getMethod.Append("\r\n");
            getMethod.Append("public static ").Append(tbx_Prefix.Text).Append(smTable.TableName).Append(" Get").Append(tbx_Prefix.Text).Append(smTable.TableName).Append("(string sqlCondition,bool getVoContent) {\r\n");
            getMethod.Append("   List<").Append(tbx_Prefix.Text).Append(smTable.TableName).Append("> getList = Get").Append(tbx_Prefix.Text).Append(smTable.TableName).Append("(sqlCondition,getVoContent,\"\");").Append("\r\n");
            getMethod.Append("   if(getList.Count > 0) {\r\n");
            getMethod.Append("      return getList[0];\r\n");
            getMethod.Append("   }else{\r\n");
            getMethod.Append("      return null;\r\n");
            getMethod.Append("   }\r\n");

            getMethod.Append("}\r\n");
            return getMethod.ToString();
        }

        string createGetListMethod(SmTable smTable) {
            StringBuilder getMethod = new StringBuilder();

            getMethod.Append("\r\n");
            getMethod.Append("// sqlCondition=查询条件\r\n");
            getMethod.Append("// getVoContent=true仅查询VoContent，=false查询展示字段（不包括VoContent）\r\n");
            getMethod.Append("// sortCodtion=排序条件\r\n");
            getMethod.Append("public static List<").Append(tbx_Prefix.Text).Append(smTable.TableName).Append("> Get").Append(tbx_Prefix.Text).Append(smTable.TableName).Append("(string sqlCondition,bool getVoContent,string sortCondition){\r\n");

            getMethod.Append("  List<").Append(tbx_Prefix.Text).Append(smTable.TableName).Append("> getList = new List<").Append(tbx_Prefix.Text).Append(smTable.TableName).Append(">();\r\n");
            getMethod.Append("  SqlCommand dbCmd = new SqlCommand();\r\n");
            getMethod.Append("  try{\r\n");
            getMethod.Append("      using(SqlConnection dbConn = new SqlConnection(DBUtil.MSSQLConnectionString)){\r\n");
            getMethod.Append("          dbConn.Open();\r\n");
            getMethod.Append("          dbCmd.Connection = dbConn;\r\n");
            getMethod.Append("  \r\n");
            getMethod.Append("          if(string.IsNullOrEmpty(sortCondition)) {\r\n");
            getMethod.Append("              sortCondition = \" Order by [ModifyTime] desc\";\r\n");
            getMethod.Append("          }\r\n");
            getMethod.Append("          if(getVoContent == true) {\r\n");
            getMethod.Append("              dbCmd.CommandText = \"select [VoContent] from [").Append(smTable.TableName).Append("]").Append("\" + sqlCondition + sortCondition;\r\n");
            getMethod.Append("          }else{\r\n");
            getMethod.Append("              dbCmd.CommandText = \"select ").Append(getSelectFields(smTable.Fields)).Append(" from ").Append(smTable.TableName).Append("\" + sqlCondition + sortCondition;\r\n");
            getMethod.Append("          }\r\n");
            getMethod.Append("  \r\n");
            getMethod.Append("          SqlDataReader dbReader = dbCmd.ExecuteReader();\r\n");
            getMethod.Append("          while(dbReader.Read()) {\r\n");
            getMethod.Append("              ").Append(tbx_Prefix.Text).Append(smTable.TableName).Append("   getValue = new ").Append(tbx_Prefix.Text).Append(smTable.TableName).Append("();\r\n");
            getMethod.Append("              if(getVoContent == true) {\r\n");
            getMethod.Append("                  string getXMLString = BIMPUtil.IngoreNull(dbReader[\"VoContent\"]);\r\n");
            getMethod.Append("                  getValue = (").Append(tbx_Prefix.Text).Append(smTable.TableName).Append(")BIMPUtil.ParseObjectFromXMLString(getXMLString,typeof(").Append(tbx_Prefix.Text).Append(smTable.TableName).Append("));\r\n");
            getMethod.Append("              }else{\r\n");
            getMethod.Append("                  getValue = new ").Append(tbx_Prefix.Text).Append(smTable.TableName).Append("();\r\n");
            getMethod.Append(getChaXunFields(smTable.Fields));
            getMethod.Append("              }\r\n");
            getMethod.Append("              getList.Add(getValue);\r\n");
            getMethod.Append("          }\r\n");
            getMethod.Append("          dbReader.Close();\r\n");
            getMethod.Append("          dbReader = null;\r\n");
            getMethod.Append("      \r\n");
            getMethod.Append("          dbConn.Close();\r\n");
            getMethod.Append("      }");
            getMethod.Append("  }catch{\r\n");
            getMethod.Append("  }finally{\r\n");
            getMethod.Append("      dbCmd = null;\r\n");
            getMethod.Append("  }\r\n");
            getMethod.Append("  \r\n");
            getMethod.Append("  return getList;\r\n");
            getMethod.Append("}\r\n");

            return getMethod.ToString();
        }

        string getChaXunFields(List<SmField> smColumns) {
            StringBuilder temp = new StringBuilder();
            foreach(SmField smColumn in smColumns) {
                if(smColumn.Name.Equals("VoContent")) {
                    continue;
                }
                temp.Append("                  getValue.").Append(smColumn.Name).Append(" = ").Append(getToolkitMethod(smColumn));
            }
            return temp.ToString();
        }

        string getToolkitMethod(SmField smColumn) {
            string temp = "";
            if(smColumn.DbType.Equals(typeof(string))) {
                temp = "BIMPUtil.IngoreNull(dbReader[\"" + smColumn.Name + "\"]);\r\n";
            } else if(smColumn.DbType.Equals(typeof(int))) {
                temp = "BIMPUtil.ParseInt(dbReader[\"" + smColumn.Name + "\"]);\r\n";
            } else if(smColumn.DbType.Equals(typeof(Int16))) {
                temp = "BIMPUtil.ParseInt(dbReader[\"" + smColumn.Name + "\"]);\r\n";
            } else if(smColumn.DbType.Equals(typeof(DateTime))) {
                temp = "BIMPUtil.ParseDateTime(dbReader[\"" + smColumn.Name + "\"]);\r\n";
            } else if(smColumn.DbType.Equals(typeof(Single))) {
                temp = "BIMPUtil.ParseFloat(dbReader[\"" + smColumn.Name + "\"],2);\r\n";
            } else if(smColumn.DbType.Equals(typeof(bool))) {
                temp = "BIMPUtil.ParseBool(dbReader[\"" + smColumn.Name + "\"]);\r\n";
            }
            return temp;
        }

        string getSelectFields(List<SmField> smColumns) {
            string temp = "";

            foreach(SmField smColumn in smColumns) {
                if(smColumn.Name.Equals("VoContent")) {
                    continue;
                }
                if(string.IsNullOrEmpty(temp)) {
                    temp = "[" + smColumn.Name + "]";
                } else {
                    temp += ",[" + smColumn.Name + "]";
                }
            }

            return temp;
        }

        string getTypeString(Type getType) {
            string getString = "";

            if(getType.Equals(typeof(String))) {
                getString = "SqlDbType.NVarChar";
            } else if(getType.Equals(typeof(DateTime))) {
                getString = "SqlDbType.DateTime";
            } else if(getType.Equals(typeof(Single))) {
                getString = "SqlDbType.Real";
            } else if(getType.Equals(typeof(Int16))) {
                getString = "SqlDbType.Int";
            } else if(getType.Equals(typeof(int))) {
                getString = "SqlDbType.Int";
            } else if(getType.Equals(typeof(bool))) {
                getString = "SqlDbType.Bit";
            } else if(getType.Equals(typeof(Decimal))) {
                getString = "SqlDbType.Decimal";
            }

            return getString;
        }
        // 生成问号“?”占位字符
        private string getAskCode(int getCount) {
            string askCode = "";

            for(int n = 0;n < getCount;n++) {
                if(n > 0) {
                    askCode += ",";
                }
                askCode += "@Arg" + n;
            }

            return askCode;
        }
        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            //showPage.SelectedTab = tp_VisualSQLBuilder;
        }

        // 解析OleDbType为System.Type
        
        
        private void btn_Invoker_Click(object sender,EventArgs e) {
            init_DefaultVisualSQLEditor();
        }

        private void init_DefaultVisualSQLEditor() {
            init_SelectDataGridView();            
            
        }

        private void Form_Main_Load(object sender,EventArgs e) {
            tbx_MSSQL_ServerIP.Text = ConfigurationManager.AppSettings["MSSQL_ServerIP"];
            tbx_MSSQL_Port.Text = ConfigurationManager.AppSettings["MSSQL_Port"];
            tbx_MSSQL_User.Text = ConfigurationManager.AppSettings["MSSQL_User"];
            tbx_MSSQL_Pwd.Text = ConfigurationManager.AppSettings["MSSQL_Pwd"];
            tbx_MSSQL_Schema.Text = ConfigurationManager.AppSettings["MSSQL_Schema"];
            tbx_Project_SavePath.Text = ConfigurationManager.AppSettings["Project_SavePath"];

            cbx_AutoSaveToFile.Checked = true;            

            //init_DefaultVisualSQLEditor();
        }
        private void SaveConfig(bool saveServerConfig = true,bool saveProjectConfig = false) {
            Configuration cm = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if(saveServerConfig == true) {
                cm.AppSettings.Settings["MSSQL_ServerIP"].Value = tbx_MSSQL_ServerIP.Text;
                cm.AppSettings.Settings["MSSQL_Port"].Value = tbx_MSSQL_Port.Text;
                cm.AppSettings.Settings["MSSQL_User"].Value = tbx_MSSQL_User.Text;
                cm.AppSettings.Settings["MSSQL_Pwd"].Value = tbx_MSSQL_Pwd.Text;
                cm.AppSettings.Settings["MSSQL_Schema"].Value = tbx_MSSQL_Schema.Text;
            }
            if(saveProjectConfig == true) {
                cm.AppSettings.Settings["Project_SavePath"].Value = tbx_Project_SavePath.Text;
            }
            cm.Save(ConfigurationSaveMode.Modified);
        }
        private void btn_选择文件_Click(object sender,EventArgs e) {
            if(dlg_OpenFile.ShowDialog() == DialogResult.OK) {
                //tbx_Text.Text = dlg_OpenFile.FileName;
            }
        }

     

        private string getControlValuefix(SqlDbType type) {
            if(type == SqlDbType.DateTime) {
                return ".Value = ";
            }
            return ".Text = ";
        }

     
        string sqlString {
            get {
                return string.Format("Server = {0},{4};Database = {1};User Id = {2};Password = {3};",tbx_MSSQL_ServerIP.Text,tbx_MSSQL_Schema.Text,tbx_MSSQL_User.Text,tbx_MSSQL_Pwd.Text,tbx_MSSQL_Port.Text); 
            }
        }

        private void btn_连接_Click(object sender,EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            list_Schema.DataSource = null;
            smTableList.Clear();
            Application.DoEvents();

            using(SqlConnection dbConn = new SqlConnection(sqlString)) {
                try {
                    dbConn.Open();
                    load_SchemaAndSPList(dbConn);
                    SaveConfig();
                } catch(Exception ex) {
                    MessageBox.Show(this,ex.ToString(),"系统提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    tbx_MSSQL_ServerIP.Focus();
                }
            }
            Application.DoEvents();
            this.Cursor = Cursors.Default;
        }


        private void btn_Build_Clicked(object sender,EventArgs e) {
            uc_BuildAction();
        }

        private void uc_BuildAction() {
            tbx_VO_Code.Clear();
            string getBuildString = string.Empty;

            if(showDBPage.SelectedTab.Name.Equals(tp_Schema.Name)) {    // tp_Schema
                bool signleVo = list_Schema.SelectedItems.Count <= 1 ? true : false;
                foreach(SmTable smTable in list_Schema.SelectedItems) {
                    string schemaName = smTable.TableName;

                    getBuildString = buildValueObject(schemaName);

                    if(signleVo == true) {  // 单文件操作才添加到界面显示
                        tbx_VO_Code.AppendText(getBuildString);
                        tbx_VO_Code.AppendText("\n\n");
                    }

                    if(cbx_AutoSaveToFile.Checked == true) {
                        if(Directory.Exists(tbx_Project_SavePath.Text) == false) {
                            MessageBox.Show(this,"VS工程文件夹(.\\DbLibrary\\)不存在。","系统提示");
                            tbx_Project_SavePath.Focus();
                            return;
                        }
                        string filePath = tbx_Project_SavePath.Text + "\\" + tbx_Prefix.Text + schemaName + ".cs";
                        bool saveResult = uc_SaveFile(filePath,getBuildString);

                        this.Invoke(new OnSaveFileCallback(showSaveFileMessage),new object[] { filePath,list_Schema.SelectedItems.IndexOf(smTable),list_Schema.SelectedItems.Count });

                        Application.DoEvents();
                    }
                    if(signleVo == true) {  // 单文件操作才添加到界面显示
                        tp_VO.Text = string.Format("Model Generato - {0}.cs",schemaName);
                    }
                    showPage.SelectedTab = tp_VO;

                }
            } else {    // Procedure
                string p_Name = (list_StoreProcedure.SelectedItem as SmProcedure).ProcedureName;
                getBuildString = buildProcedureObject(p_Name);

                tbx_VO_Code.Clear();
                tbx_VO_Code.AppendText(getBuildString);
            }
        }

        void showSaveFileMessage(string filePath,int currentIndex = 0,int fileCount = 0) {
            if(fileCount > 0) {
                currentIndex++;
            }
            //tbx_VO_Code.SelectionStart = tbx_VO_Code.TextLength;
            //tbx_VO_Code.SelectedRtf = @"{\rtf1\ansi " + filePath + @"\v #" + filePath + @"\v0}";
            //tbx_VO_Code.Select(tbx_VO_Code.TextLength,filePath.Length + filePath.Length + 1);
            //tbx_VO_Code.SetSelectionLink(true);

            tbx_VO_Code.AppendText(currentIndex+ "." + filePath);
            tbx_VO_Code.AppendText(" - 已生成\r\n");
            tbx_VO_Code.ScrollToCaret();

            if(currentIndex > 0) {
                tp_VO.Text = string.Format("Model Generato - {0}/{1} files.",currentIndex,fileCount);
            }
        }

        private bool uc_SaveFile(string filePath,string getBuildString) {
            bool saveResult = false;
            try {
                StreamWriter vofile = File.CreateText(filePath);
                vofile.Write(getBuildString);
                vofile.Flush();
                vofile.Close();
                vofile = null;

                saveResult = true;
            } catch {
                saveResult = false;
            }
            return saveResult;
        }

        private void btn_File_Click(object sender,EventArgs e) {
            //string vofilepath = tbx_SavePath_VO.Text + "\\" + tbx_VOFile.Text.Trim();
            //bool saveResult = uc_SaveFile(vofilepath,tbx_VO_Code.Text);
            //if(saveResult == true) {
            //    if(MessageBox.Show(this,"文件已保存，是否打开文件夹？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
            //        Process.Start(tbx_SavePath_VO.Text);
            //    }
            //}

            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                if(Directory.Exists(folderBrowserDialog1.SelectedPath) == true) {
                    tbx_Project_SavePath.Text = folderBrowserDialog1.SelectedPath;                    
                }
            }
        }

        List<string> ingoreList = new List<string>() {
        "UUID","ShopId","ModifyTime","ShowIndex"};

        private string buildProcedureObject(string p_Name) {
            SmProcedure smProcedure = smProcedures.Find(t => t.ProcedureName.Equals(p_Name));
            if(string.IsNullOrEmpty(smProcedure.SQLText)) {
                int pos = smProcedures.IndexOf(smProcedure);
                using(SqlConnection dbConn = new SqlConnection(sqlString)) {
                    dbConn.Open();
                    smProcedure = getSmProcedure(p_Name,dbConn);
                    smProcedures[pos] = smProcedure;
                }
            }
            return smProcedure.SQLText;
        }

        private string buildValueObject(string sechemaName) {
            SmTable smTable = smTableList.Find(t => t.TableName.Equals(sechemaName));//  getSmTable(sechemaName);
            if(smTable.Fields == null) {
                int pos = smTableList.IndexOf(smTable);
                using(SqlConnection dbConn = new SqlConnection(sqlString)) {
                    try {
                        dbConn.Open();
                        smTable = getSmTable(smTable.TableName,dbConn);
                        smTableList[pos] = smTable;
                    } catch(Exception ex) {
                        MessageBox.Show(this,ex.ToString(),"系统提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        tbx_MSSQL_ServerIP.Focus();
                    }
                }
            }

            StringBuilder temp = new StringBuilder();

            string vofile = tbx_Prefix.Text + smTable.TableName;
            tbx_VO_Filename.Text = vofile + ".cs";
            //temp.Append("using CSSD.Web.API.Dapper.vo;\r\n");
            temp.Append("using System;\r\n");
            temp.Append("using Fisherman.Core;\r\n");
            temp.Append("using System.Data;\r\n\r\n");
            //temp.Append("using System.Linq;\r\n");
            //temp.Append("using System.Threading.Tasks;\r\n");

            temp.Append("namespace App.DbLibrary {\r\n");
            temp.Append("   [Serializable]\r\n");
            temp.Append(string.Format("   [FisherField(Name=\"{0}\",Remarks=\"{1}\")]\r\n",smTable.TableName,smTable.Remarks));            
            temp.Append("   public class ").Append(tbx_Prefix.Text).Append(smTable.TableName).Append(" {\r\n");//.Append(":DBItem{\r\n");
            //temp.Append("   public class ").Append(smTable.Name).Append(":DBItem{\r\n");
            if(false) {
                temp.Append("      private string _TableName = string.Empty;\r\n");
                temp.Append("      public virtual string TableName {\r\n");
                temp.Append("          get{\r\n");
                temp.Append("              if(string.IsNullOrEmpty(_TableName)){\r\n");
                temp.Append("                  _TableName = \"" + smTable.TableName + "\";\r\n");
                temp.Append("              }\r\n");
                temp.Append("              return _TableName;\r\n");
                temp.Append("          }\r\n");
                temp.Append("      }\r\n");

                foreach(SmField smColumn in smTable.Fields) {
                    if(smColumn.PrimaryKey) {
                        temp.Append("      private string _PkFieldName = string.Empty;\r\n");
                        temp.Append("      public virtual string PkFieldName {\r\n");
                        temp.Append("          get{\r\n");
                        temp.Append("              if(string.IsNullOrEmpty(_PkFieldName)){\r\n");
                        temp.Append("                  _PkFieldName = \"" + smColumn.Name + "\";\r\n");
                        temp.Append("              }\r\n");
                        temp.Append("              return _PkFieldName;\r\n");
                        temp.Append("          }\r\n");
                        temp.Append("      }\r\n");
                        break;
                    }
                }

                temp.Append("      private List<SQLField> _Fields = null;\r\n");
                temp.Append("      public List<SQLField> Fields{\r\n");
                temp.Append("          get{\r\n");
                temp.Append("              if(_Fields == null){\r\n");
                temp.Append("                  _Fields = new List<SQLField>();\r\n");

                string pkFieldType = string.Empty;
                foreach(SmField smColumn in smTable.Fields) {
                    pkFieldType = FisherUtil.ParseToDbTypeString(smColumn.DbType);
                    if(smColumn.PrimaryKey) {
                        temp.Append("                  _Fields.Add(new SQLField(\"" + smColumn.Name + "\"," + pkFieldType + ",true));\r\n");
                    } else if(string.IsNullOrEmpty(smColumn.Remarks) == false) {
                        temp.Append("                  _Fields.Add(new SQLField(\"" + smColumn.Name + "\"," + pkFieldType + ",false,\"" + smColumn.Remarks.Trim().Replace("\r","").Replace("\n","") + "\"));\r\n");
                    } else {
                        temp.Append("                  _Fields.Add(new SQLField(\"" + smColumn.Name + "\"," + pkFieldType + "));\r\n");
                    }
                }
                temp.Append("              }\r\n");
                temp.Append("              return _Fields;\r\n");
                temp.Append("          }\r\n");
                temp.Append("      }\r\n");
            }


            foreach(SmField smColumn in smTable.Fields) {
                temp.Append("      ");
                temp.Append(ParseDapperFieldAttribute(smColumn)).Append("\r\n");
                temp.Append("      public virtual ").Append(FisherUtil.ParseRunTimeDbTypeString(smColumn.DbType)).Append(" ").Append(smColumn.Name).Append(" {\r\n");
                temp.Append("          get;\r\n");
                temp.Append("          set;\r\n");
                temp.Append("      }\r\n");
            }
            temp.Append("   }\r\n");
            temp.Append("}");

            //if(saveToFile) {
            //    string filePath = Application.StartupPath + "\\makefile\\BIMP_" + smTable.Name + ".cs";
            //    StreamWriter streamWriter = File.CreateText(filePath);
            //    streamWriter.Write(temp.ToString());
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //    streamWriter = null;
            //} else {
            //    tbx_VO_Code.Text = temp.ToString();
            //}

            return temp.ToString();
        }

        private string ParseDapperFieldAttribute(SmField smColumn) {
            string getFisherFlag = string.Format("Name=\"{0}\",SqlDbType=SqlDbType.{1}",smColumn.Name,Enum.GetName(typeof(SqlDbType),smColumn.DbType));

            if(smColumn.PrimaryKey) {
                getFisherFlag += ",IsPrimaryKey = true";
            }
            if(smColumn.KEY_SEQ > 0) {
                getFisherFlag += ",KEY_SEQ=" + smColumn.KEY_SEQ;
            }
            if(smColumn.Is_Nullable == false) {
                getFisherFlag += ",CanotDBNull=true";
            }
            //if(smColumn.MaxLength > 0) {
            getFisherFlag += ",MaxLength=" + smColumn.MaxLength;
            //}
            if(string.IsNullOrEmpty(smColumn.Remarks) == false) {
                getFisherFlag += ",Remarks=\"" + smColumn.Remarks + "\"";
            }


            return string.Format("[FisherField({0})]",getFisherFlag);
        }

        private string createDAO(string sechemaName) {
            SmTable smTable = getSmTable(sechemaName);

            StringBuilder code = new StringBuilder();

            code.Append(" #region -------------------------------------------------------------------").Append(smTable.TableName).Append("-------------------------------------------------------------------\r\n");

            code.Append("public static bool Save").Append(tbx_Prefix.Text).Append(smTable.TableName).Append("(").Append(tbx_Prefix.Text).Append(smTable.TableName).Append(" getValue){\r\n");
            code.Append("   bool saveResult = false;\r\n");
            code.Append("   \r\n");
            code.Append("   SqlCommand dbCmd = new SqlCommand();\r\n");
            code.Append("   try{\r\n");
            code.Append("       using(SqlConnection dbConn = new SqlConnection(DBUtil.MSSQLConnectionString)){\r\n");
            code.Append("           dbConn.Open();\r\n");
            code.Append("           dbCmd.Connection = dbConn;\r\n");

            code.Append("           if(string.IsNullOrEmpty(getValue.UUID) == true){\r\n"); // 增加操作
            code.Append("               getValue.UUID = BIMPUtil.CreateUUID();\r\n");
            code.Append("               dbCmd.CommandText = \"");

            code.Append("insert into [").Append(smTable.TableName).Append("]");          // 构建SQL
            code.Append("(");
            for(int n = 0;n < smTable.Fields.Count;n++) {
                SmField smColumn = smTable.Fields[n];
                if(n > 0) {
                    code.Append(",");
                }
                code.Append("[").Append(smColumn.Name).Append("]");
            }

            code.Append(") values(").Append(getAskCode(smTable.Fields.Count)).Append(")\";\r\n");
            code.Append("              dbCmd.Parameters.Clear();\r\n");
            code.Append("      \r\n");
            int argIndex = 0;
            foreach(SmField smColumn in smTable.Fields) {
                string getContentString = "getValue." + smColumn.Name;
                if(smColumn.DbType.Equals(typeof(string))) {
                    getContentString = "BIMPUtil.IngoreNull(" + getContentString + ")";
                }

                if(smColumn.Name.Equals("VoContent")) {
                    getContentString = "BIMPUtil.GetXMLString(getValue)";
                } else if(smColumn.Name.Equals("ModifyTime")) {
                    getContentString = "DateTime.Now";
                }
                code.Append("              dbCmd.Parameters.Add(\"@Arg").Append(argIndex++).Append("\",").Append(FisherUtil.ParseToDbTypeString(smColumn.DbType)).Append(").Value = ").Append(getContentString).Append(";\r\n");
            }

            code.Append("         }else{\r\n");   // 修改操作
            code.Append("              dbCmd.CommandText = \"update [").Append(smTable.TableName).Append("] set ");

            argIndex = 0;
            for(int n = 0;n < smTable.Fields.Count;n++) {
                SmField smColumn = smTable.Fields[n];
                if(smColumn.PrimaryKey == true || smColumn.Name.Equals("UUID")) {   // 忽略主键
                    continue;
                }

                code.Append(String.Format("[{0}]=@Arg" + argIndex++ + "",smColumn.Name));
                if(n < smTable.Fields.Count - 1) {
                    code.Append(",");
                }
            }
            code.Append(" where [UUID]=@Arg" + argIndex + ";\";\r\n");
            code.Append("              dbCmd.Parameters.Clear();\r\n");

            argIndex = 0;
            foreach(SmField smColumn in smTable.Fields) {
                if(smColumn.PrimaryKey == true || smColumn.Name.Equals("UUID")) {   // 忽略主键
                    continue;
                }
                string getContentString = "getValue." + smColumn.Name;
                if(smColumn.Name.Equals("VoContent")) {
                    getContentString = "BIMPUtil.GetXMLString(getValue)";
                } else if(smColumn.Name.Equals("ModifyTime")) {
                    getContentString = "DateTime.Now";
                }
                code.Append("              dbCmd.Parameters.Add(\"@Arg").Append(argIndex++).Append("\",").Append(FisherUtil.ParseToDbTypeString(smColumn.DbType)).Append(").Value = ").Append(getContentString).Append(";\r\n");
            }
            code.Append("              dbCmd.Parameters.Add(\"@Arg" + argIndex + "\",OleDbType.VarChar).Value = getValue.UUID;\r\n");

            code.Append("          }\r\n");

            code.Append("          if(dbCmd.ExecuteNonQuery() > 0){\r\n");
            code.Append("              saveResult = true;\r\n");
            code.Append("          }\r\n");
            code.Append("          dbConn.Close();\r\n");
            code.Append("       }\r\n");
            code.Append("   }catch{\r\n");
            code.Append("       saveResult = false;\r\n");
            code.Append("   }finally{\r\n");
            code.Append("       dbCmd = null;\r\n");
            code.Append("   }\r\n");
            code.Append("   return saveResult;\r\n");
            code.Append("}");

            code.Append(createGetListMethod(smTable));
            code.Append(createGetByIdMethod(smTable));
            code.Append("#endregion --------------------------------------------------------------------------------------------------------------------------------------\r\n");

            return code.ToString();
        }

        private string uc_BuildVO(string sechemaName) {

            StringBuilder tmp = new StringBuilder();

            SmTable smTable = getSmTable(sechemaName);
            if(smTable != null) {
                tmp.Append("using System;\r\n");
                tmp.Append("using System.Collections.Generic;\r\n");
                tmp.Append("using System.Linq;\r\n");
                tmp.Append("using System.Text;\r\n");

                tmp.Append("namespace com.cgWorkstudio.BIMP.vo {\r\n");
                tmp.Append("    public class ").Append(smTable.TableName).Append("{\r\n");

                foreach(SmField smColumn in smTable.Fields) {
                    tmp.Append("    SmColumn _").Append(smColumn.Name).Append(" = null;\r\n");
                    tmp.Append("    public virtual SmColumn ").Append(smColumn.Name).Append("{\r\n");
                    tmp.Append("        get{\r\n");
                    tmp.Append("            if(_").Append(smColumn.Name).Append(" == null){\r\n");
                    tmp.Append("                _").Append(smColumn.Name).Append(" = new SmColumn();\r\n");
                    tmp.Append("                _").Append(smColumn.Name).Append(".AllowDBNull = ").Append(smColumn.Is_Nullable.ToString().ToLower()).Append(";\r\n");
                    //tmp.Append("                _").Append(smColumn.Name).Append(".Caption = \"").Append(smColumn.Caption).Append("\";\r\n");
                    //tmp.Append("                _").Append(smColumn.Name).Append(".DateTimeMode = ").Append(smColumn.DateTimeMode).Append(";\r\n");
                    //tmp.Append("                _").Append(smColumn.Name).Append(".DefaultValue = ").Append(Toolkit.IngoreNull(smColumn.DefaultValue)).Append(";\r\n");
                    tmp.Append("                _").Append(smColumn.Name).Append(".MaxLength = ").Append(smColumn.MaxLength).Append(";\r\n");
                    tmp.Append("                _").Append(smColumn.Name).Append(".Name = \"").Append(smColumn.Name).Append("\";\r\n");
                    tmp.Append("                _").Append(smColumn.Name).Append(".PrimaryKey = ").Append(smColumn.PrimaryKey.ToString().ToLower()).Append(";\r\n");
                    tmp.Append("                _").Append(smColumn.Name).Append(".Type = typeof(").Append(smColumn.DbType).Append(");\r\n");
                    tmp.Append("            }\r\n");
                    tmp.Append("            return _").Append(smColumn.Name).Append(";\r\n");
                    tmp.Append("        }\r\n");
                    tmp.Append("    }\r\n");
                }

                tmp.Append("    }\r\n");
                tmp.Append("}\r\n");
            }

            return tmp.ToString();
            // showPage.SelectedTab = VO_Page;


            // StreamWriter txt = File.CreateText(Application.StartupPath + "\\makefile\\BIMP_" + smTable.Name + ".cs");
            // txt.Write(tmp.ToString());
            // txt.Flush();
            // txt.Close();
            // txt = null;
        }


        private void btn_BatchExec_Click(object sender,EventArgs e) {
            if(list_Schema.SelectedItems.Count <= 0) {
                MessageBox.Show(this,"未选择要生成vo类的表。","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if(MessageBox.Show(this,"批量生成vo类，生成的vo类将直接写入本地文件。\r\n\r\n文件保存路径：" + tbx_Project_SavePath.Text + "\r\n类前缀：" + tbx_Prefix.Text + "\r\n共计：" + list_Schema.SelectedItems.Count + "张表\r\n\r\n是否继续？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
                uc_BuildAction();
            }
        }

        private void btn_SoapTypes_Click(object sender,EventArgs e) {
            //StringBuilder stringBuilder = new StringBuilder();

            //stringBuilder.Append("using System;\r\n");
            //stringBuilder.Append("using BIMP.Win.WinUI.bimp_CloudPro;\r\n");
            //stringBuilder.Append("namespace BIMP.Win.WinUI {\r\n");
            //stringBuilder.Append("    public class SoapString {\r\n");

            //foreach(DataRowView getRow in list_Schema.SelectedItems) {
            //    string schemaName = getRow["Name"].ToString();

            //    stringBuilder.Append("\t").Append("public static string ").Append(schemaName.Replace("bimp_","")).Append(" {get {return typeof(").Append(schemaName).Append(").Name;}}").Append("\r\n");

            //}

            //foreach(DataRowView getRow in list_StoreProcedure.Items) {
            //    string getSp = getRow["Name"].ToString();
            //    stringBuilder.Append("\t").Append("public static string " + getSp + " {\r\n");
            //    stringBuilder.Append("\t").Append("    get {\r\n");
            //    stringBuilder.Append("\t").Append("        return \"" + getSp + "\";\r\n");
            //    stringBuilder.Append("\t").Append("    }\r\n");
            //    stringBuilder.Append("\t").Append("}   \r\n");
            //}

            //stringBuilder.Append("}}");
            //tbx_DAO_Code.Clear();
            //tbx_DAO_Code.Text = stringBuilder.ToString();
            //showPage.SelectedTab = tp_DAO;

            //uc_SaveFile(textBox1.Text,tbx_DAO_Code.Text);
        }

        private void btn_XmlInclude_Click(object sender,EventArgs e) {
            //StringBuilder stringBuilder = new StringBuilder();
            //foreach(DataRowView getRow in list_Schema.SelectedItems) {
            //    string schemaName = getRow["Name"].ToString();
            //    stringBuilder.Append("[XmlInclude(typeof(").Append(schemaName).Append("))]\r\n");
            //}

            //tbx_DAO_Code.Clear();
            //tbx_DAO_Code.Text = stringBuilder.ToString();
            //showPage.SelectedTab = tp_DAO;
        }

        private void btn_授权码管理_Click(object sender,EventArgs e) {

        }

        private void btn_反向SQL_Click(object sender,EventArgs e) {
            if(list_Schema.SelectedItems.Count > 1) {
                return;
            }

            foreach(DataRowView getRow in list_Schema.SelectedItems) {
                string schemaName = getRow["Name"].ToString();
                SmTable smTable = getSmTable(schemaName);

                StringBuilder getString = new StringBuilder();
                getString.Append("CREATE TABLE [dbo].[").Append(smTable.TableName).Append("] (\r\n");
                foreach(SmField getColumn in smTable.Fields) {
                    getString.Append("[").Append(getColumn.Name).Append("] ").Append(getColumn.DbType.ToString());
                    if(getColumn.PrimaryKey == true) {
                        getString.Append(" NOT NULL IDENTITY(1,1) ,\r\n");
                    } else {
                        getString.Append(" NULL,\r\n");
                    }
                }
                getString.Append(")");

                tbx_VO_Code.Text = getString.ToString();
                showPage.SelectedTab = tp_VO;
                break;
            }
        }

        private void menuItem_MySQL_Click(object sender,EventArgs e) {
            //Form_MySQL frmMySQL = new Form_MySQL();
            //frmMySQL.ShowDialog();
        }

        private void btn_table_Click(object sender,EventArgs e) {
            //if(list_Schema.SelectedItems.Count > 1) {
            //    MessageBox.Show("只支持单表。");
            //    return;
            //}

            //StringBuilder txt = new StringBuilder();

            ////txt.Append("<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">\r\n");
            ////txt.Append("\t<tr>\r\n");
            ////txt.Append("\t\t<td><asp:Button ID=\"btn_submit\" Text=\"保存\"  runat=\"server\"/><asp:Button ID=\"btn_cancel\" Text=\"取消\"  runat=\"server\"/></td>\r\n");
            ////txt.Append("\t</tr>\r\n");
            ////txt.Append("</table>\r\n");

            //txt.Append("<fieldset>\r\n");
            //txt.Append("\t<legend>xxx详细信息：</legend>\r\n");

            //txt.Append("\t<table id=\"editTable\" width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">\r\n");
            //foreach(DataRowView getRow in list_Schema.SelectedItems) {
            //    string schemaName = getRow["Name"].ToString();
            //    SmTable smTable = getSmTable(schemaName);
            //    foreach(SmField smColumn in smTable.Fields) {
            //        string title = smColumn.Remarks;
            //        if(string.IsNullOrEmpty(title)) {
            //            title = smColumn.Name;
            //        }
            //        txt.Append("\t\t<tr>\r\n");
            //        txt.Append("\t\t\t<td width=\"100px\" style=\"text-align:center;\">").Append(title).Append("：</td>\r\n");
            //        txt.Append("\t\t\t<td>").Append("<asp:TextBox ID=\"tbx_").Append(smColumn.Name).Append("\" runat=\"server\" CssClass=\"tbx\"></asp:TextBox></td>\r\n");
            //        //txt.Append("\t\t\t<td>").Append(smColumn.Name).Append("</td>\r\n");
            //        txt.Append("\t\t</tr>\r\n");
            //    }
            //    //txt.Append("\t\t<tr>\r\n");
            //    //txt.Append("\t\t\t<td></td>\r\n");
            //    //txt.Append("\t\t\t<td>").Append(smTable.Columns.Count).Append("</td>\r\n");
            //    //txt.Append("\t\t</tr>\r\n");
            //}
            //txt.Append("\t</table>\r\n");
            //txt.Append("</fieldset> ");
            //tbx_DAO_Code.Clear();
            //tbx_DAO_Code.AppendText(txt.ToString());
        }

        /// <summary>
        /// Asp.net Code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_aspnet_Click(object sender,EventArgs e) {
            //if(list_Schema.SelectedItems.Count > 1) {
            //    MessageBox.Show("只支持单表。");
            //    return;
            //}

            //// Asp.net Code
            //StringBuilder txt_load = new StringBuilder();
            //StringBuilder txt_save = new StringBuilder();
            //txt_load.Append("int id = -1;\r\n");

            //foreach(DataRowView getRow in list_Schema.SelectedItems) {
            //    string schemaName = getRow["Name"].ToString();
            //    SmTable smTable = getSmTable(schemaName);

            //    // txt_load
            //    txt_load.Append("protected void Page_Load(object sender,EventArgs e) {\r\n");
            //    txt_load.Append("\t  id = WebUtil.ParseRequestInt(Request,\"id\");\r\n");
            //    txt_load.Append("\t  if(!Page.IsPostBack) {\r\n");
            //    txt_load.Append("\t\t    if(id > 0) {\r\n");
            //    txt_load.Append("\t\t\t      ").Append(schemaName).Append(" item = DBUtil.GetItem<").Append(schemaName).Append(">(id);\r\n");

            //    // txt_save
            //    txt_save.Append("id = WebUtil.ParseRequestInt(Request,\"id\");\r\n");
            //    txt_save.Append(schemaName).Append(" saveItem = null;\r\n");
            //    txt_save.Append("if(id > 0) {\r\n");
            //    txt_save.Append("\t     saveItem = DBUtil.GetItem<").Append(schemaName).Append(">(id);\r\n");
            //    txt_save.Append("} else {\r\n");
            //    txt_save.Append("\t     saveItem = new ").Append(schemaName).Append("();\r\n");
            //    txt_save.Append("\t     saveItem.shopid = shopid;\r\n");
            //    txt_save.Append("}\r\n");

                

            //    foreach(SmField smColumn in smTable.Fields) {
            //        string loadString = "item." + smColumn.Name;
            //        string saveString = "tbx_" + smColumn.Name + ".Text.Trim()";
            //        switch(smColumn.DbType) {
            //            case SqlDbType.Int:
            //                loadString += ".ToString()";
            //                saveString = "WebUtil.ParseInt(" + saveString + ")";
            //                break;
            //            case SqlDbType.Float:
            //            case SqlDbType.Real:
            //                loadString += ".ToString()";
            //                saveString = "WebUtil.ParseFloat(" + saveString + ")";
            //                break;
            //            case SqlDbType.Date:
            //                loadString += ".ToString(\"yyyy-MM-dd\")";
            //                saveString = "WebUtil.ParseDate(" + saveString + ")";
            //                break;
            //            case SqlDbType.DateTime:
            //                loadString += ".ToString(\"yyyy-MM-dd HH:mm:ss\")";
            //                saveString = "WebUtil.ParseDateTime(" + saveString + ")";
            //                break;
            //        }
            //        txt_load.Append("\t\t\t      tbx_").Append(smColumn.Name).Append(".Text = ").Append(loadString).Append(";\r\n");

            //        txt_save.Append(" saveItem.").Append(smColumn.Name).Append(" = ").Append(saveString).Append(";\r\n");
            //    }

            //    // txt_load
            //    txt_load.Append("\t\t    }\r\n");
            //    txt_load.Append("\t  }\r\n");
            //    txt_load.Append("}\r\n");

            //    // txt_save
            //    txt_save.Append("\r\nSaveResult result = DBUtil.Save(saveItem);\r\n");
            //    txt_save.Append("if(result.Id > 0) {\r\n");
            //    txt_save.Append("\t     Response.Write(\"<script>alert('操作成功。');window.location='XXX.aspx';</script>\");\r\n");
            //    txt_save.Append("}\r\n");
            //}
            //tbx_Load.Clear();
            //tbx_Load.AppendText(txt_load.ToString());

            //tbx_Save.Clear();
            //tbx_Save.AppendText(txt_save.ToString());
            //showPage.SelectedTab = tp_load;
        }

        private void list_Schema_DoubleClick(object sender,EventArgs e) {
            uc_BuildAction();            

            //SmTable smTable = smTableList.Find(t => t.TableName.Equals(list_Schema.Text));
            //if(smTable.ActiveUsing == true) {
            //    return;
            //}

            //smTable.ActiveUsing = true; // 标记为正在使用

            //dgv_SourceTable.Rows.Add();
            //int usingIndex = dgv_SourceTable.Rows.Count;
            //dgv_SourceTable.Rows[dgv_SourceTable.Rows.Count - 1].Cells["id_Cell"].Value = usingIndex;
            //dgv_SourceTable.Rows[dgv_SourceTable.Rows.Count - 1].Cells["name_Cell"].Value = smTable.TableName;
            //dgv_SourceTable.Rows[dgv_SourceTable.Rows.Count - 1].Cells["nickName_Cell"].Value = smTable.Nickname;
            //dgv_SourceTable.Rows[dgv_SourceTable.Rows.Count - 1].Cells["del_Cell"].Value = "删除";

            //smTable.UsingIndex = usingIndex;    // 更新显示次序
            //if(showPage.SelectedTab.Name.Equals(tp_VisualSQLBuilder.Name) == false) {
            //    showPage.SelectedTab = tp_VisualSQLBuilder;
            //}
        }
        #region SourceTable操作代码

        private void dgv_SourceTable_CellEndEdit(object sender,DataGridViewCellEventArgs e) {
            //string name_Cell = dgv_SourceTable["name_Cell",e.RowIndex].Value.ToString();
            //string inputNickname = MyToolkit.IngoreNull(dgv_SourceTable[e.ColumnIndex,e.RowIndex].Value);

            //if(string.IsNullOrEmpty(inputNickname)) {
            //    return;
            //}
            //SmTable smTable = smTableList.Find(t => t.Nickname.Equals(inputNickname));
            
            //if(smTable != null && smTable.TableName.Equals(name_Cell) == false) {  // 已存在同名的昵称
            //    dgv_SourceTable[e.ColumnIndex,e.RowIndex].Value = "";
            //    MessageBox.Show("昵称已经存在。");
            //    return;
            //}

            //smTableList.Find(t => t.TableName.Equals(name_Cell)).Nickname = inputNickname;  // 更新昵称
            //SyncSelectToDataGridView();
        }

        private void dgv_SourceTable_CellContentClick(object sender,DataGridViewCellEventArgs e) {
            //if(e.RowIndex < 0) {
            //    return;
            //}

            //if(dgv_SourceTable.Columns[e.ColumnIndex].Name.Equals("del_Cell")) {
            //    string dgvCellName = MyToolkit.IngoreNull(dgv_SourceTable["name_Cell",e.RowIndex].Value);
            //    smTableList.Find(t => t.TableName.Equals(dgvCellName)).ActiveUsing = false;

            //    dgv_SourceTable.Rows.RemoveAt(e.RowIndex);
            //    reorderUsingIndex(e.RowIndex);
            //}
        }
        #endregion

        private void reorderUsingIndex(int rowIndex) {
            //for(int n = rowIndex;n < dgv_SourceTable.Rows.Count;n++) {
            //    int newIndex = MyToolkit.ParseInt(dgv_SourceTable["id_Cell",n].Value);
            //    string nameCell = MyToolkit.IngoreNull(dgv_SourceTable["name_Cell",n].Value);
            //    int usingIndex = newIndex - 1;

            //    dgv_SourceTable["id_Cell",n].Value = usingIndex;
            //    smTableList.Find(t => t.TableName.Equals(nameCell)).UsingIndex = usingIndex;
            //}
            //dgv_SourceTable.Refresh();
        }

        #region Select操作代码
        private void dgv_Select_CellContentClick(object sender,DataGridViewCellEventArgs e) {
            //if(e.RowIndex < 0) {
            //    return;
            //}

            //// 点击右键构建菜单
            //string cellName = dgv_Select.Columns[e.ColumnIndex].Name;
            //string cellValue = MyToolkit.IngoreNull(dgv_Select[e.ColumnIndex,e.RowIndex].Value);
            //string tableName = dgv_Select["dgv_Select_ValueCell",e.RowIndex].ToolTipText;       // ToolTipText缓存的是TableName
            //string fieldName = dgv_Select["dgv_Select_ValueCell",e.RowIndex].ErrorText;         // ErrorText缓存的是FieldName
            //ctxMenu_Select.Items.Clear();
            //switch(cellName) {
            //    case "dgv_Select_FieldNameCell":    // 选择字段菜单
            //        if("<点击这里添加字段>".Equals(cellValue)) {
            //            List<SmTable> smTables = smTableList.FindAll(t => t.ActiveUsing == true);
            //            foreach(SmTable smTable in smTables) {
            //                ToolStripMenuItem menu = new ToolStripMenuItem();
            //                menu.Text = string.IsNullOrEmpty(smTable.Nickname) ? smTable.TableName : smTable.Nickname;
            //                foreach(SmField smField in smTable.Fields) {
            //                    ToolStripMenuItem subMenu = new ToolStripMenuItem();
            //                    subMenu.ToolTipText = smTable.TableName;    // TooltipText缓存表名称
            //                    subMenu.Name = smField.Name;                // Text缓存字段名称
            //                    subMenu.Text = smField.Name;                // + "\t(" + smField.DbType.ToString() + ")";
            //                    subMenu.ImageKey = "png_pk";
            //                    subMenu.Click += ctxMenu_Select_AddMenu_Click;
            //                    menu.DropDownItems.Add(subMenu);
            //                }
            //                ctxMenu_Select.Items.Add(menu);
            //            }
            //        } else {    // 删除菜单
            //            ToolStripMenuItem menu = new ToolStripMenuItem();                        
            //            menu.Text = "删除(&D)";
            //            menu.Click += ctxMenu_Select_DelMenu_Click;
            //            ctxMenu_Select.Items.Add(menu);
            //        }
            //        break;
            //    case "dgv_Select_FuncCell": // 数据库函数菜单
            //        string[] getFunc = Enum.GetNames(typeof(SelectFunction));
            //        foreach(string item in getFunc) {
            //            ToolStripMenuItem menu = new ToolStripMenuItem();
                        
            //            if("Default".Equals(item)) {
            //                menu.Text = "<->";
            //            } else {
            //                menu.Text = item;
            //            }

            //            menu.Click += ctxMenu_Select_FuncMenu_Click;
            //            ctxMenu_Select.Items.Add(menu);
            //        }
            //        break;
            //}
            //if(ctxMenu_Select.Items.Count > 0) {
            //    ctxMenu_Select.Show(dgv_Select,dgv_Select.PointToClient(MousePosition));
            //}
        }

        private void ctxMenu_Select_FuncMenu_Click(object sender,EventArgs e) {
            //ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            //int rowIndex = dgv_Select.CurrentCell.RowIndex;

            //string tableName = dgv_Select["dgv_Select_ValueCell",rowIndex].ToolTipText;       // ToolTipText缓存的是TableName
            //string fieldName = dgv_Select["dgv_Select_ValueCell",rowIndex].ErrorText;         // ErrorText缓存的是FieldName

            //SelectFunction selectFunction;
            //if("<->".Equals(menu.Text)) {
            //    Enum.TryParse("Default",out selectFunction);
            //} else {
            //    Enum.TryParse(menu.Text,out selectFunction);
            //}

            //smTableList.Find(t => t.TableName.Equals(tableName)).Fields.Find(t => t.Name.Equals(fieldName)).Func = selectFunction;

            //SyncSelectToDataGridView();
        }

        private void ctxMenu_Select_DelMenu_Click(object sender,EventArgs e) {
            //int rowIndex = dgv_Select.CurrentCell.RowIndex;
            //string tableName = dgv_Select["dgv_Select_ValueCell",rowIndex].ToolTipText;       // ToolTipText缓存的是TableName
            //string fieldName = dgv_Select["dgv_Select_ValueCell",rowIndex].ErrorText;         // ErrorText缓存的是FieldName

            //smTableList.Find(t => t.TableName.Equals(tableName)).Fields.Find(t => t.Name.Equals(fieldName)).ActiveUsing = false;
            //SyncSelectToDataGridView();
        }

        private void ctxMenu_Select_AddMenu_Click(object sender,EventArgs e) {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            string smTableName = menu.ToolTipText;
            string smFieldName = menu.Name;

            // 标记该字段为正在使用中，ActiveUsing=true
            if(smTableList.Find(t => t.TableName.Equals(smTableName)).Fields.Find(t => t.Name.Equals(smFieldName)).ActiveUsing == true) {
                return;
            }
            smTableList.Find(t => t.TableName.Equals(smTableName)).Fields.Find(t => t.Name.Equals(smFieldName)).ActiveUsing = true;

            SyncSelectToDataGridView();
        }

        private void SyncSelectToDataGridView() {
            //IEnumerable<SmTable> list = from w in smTableList
            //                            where w.ActiveUsing == true
            //                            orderby w.UsingIndex ascending
            //                            select w;

            //List<SmTable> _list = list.ToList();
            //while(dgv_Select.Rows.Count > 1) {
            //    dgv_Select.Rows.RemoveAt(0);
            //}
            //foreach(SmTable smTable in _list) {
            //    foreach(SmField smField in smTable.Fields) {
            //        if(smField.ActiveUsing == false) {
            //            continue;
            //        }

            //        dgv_Select.Rows.Insert(dgv_Select.Rows.Count - 1,1);
            //        DataGridViewRow newRow = dgv_Select.Rows[dgv_Select.Rows.Count - 2];
            //        string funcString = "<->"; 
            //        string fieldName = (string.IsNullOrEmpty(smTable.Nickname) ? smTable.TableName : smTable.Nickname) + "." + smField.Name;
            //        string fieldAs = smField.FieldAs;

            //        if(smField.Func.Equals(SelectFunction.Default) == false) {
            //            funcString = Enum.GetName(typeof(SelectFunction),smField.Func);
            //        }

            //        newRow.Cells["dgv_Select_FuncCell"].Value = funcString;
            //        newRow.Cells["dgv_Select_FieldNameCell"].Value = fieldName;
            //        newRow.Cells["dgv_Select_AsCell"].Value = fieldAs;
            //        newRow.Cells["dgv_Select_ValueCell"].ErrorText = smField.Name;
            //        newRow.Cells["dgv_Select_ValueCell"].ToolTipText = smTable.TableName;
            //    }
            //}
        }

        private void init_SelectDataGridView() {
            //ctxMenu_Select.ImageList = ctxMenu_Select_ImageList;
            //dgv_Select.Columns["dgv_Select_FuncCell"].Width = dgv_Select.Width / 6;
            //dgv_Select.Columns["dgv_Select_AsCell"].Width = dgv_Select.Width / 4;

            //dgv_Select.Rows.Add();
            //dgv_Select.Rows[dgv_Select.Rows.Count - 1].Cells["dgv_Select_FuncCell"].Value = "<->";
            //dgv_Select.Rows[dgv_Select.Rows.Count - 1].Cells["dgv_Select_FieldNameCell"].Value = "<点击这里添加字段>";
            //dgv_Select.Rows[dgv_Select.Rows.Count - 1].Cells["dgv_Select_AsCell"].Value = "<->";
        }
        #endregion

        private void btn_OpenFolder_Click(object sender,EventArgs e) {
            if(string.IsNullOrEmpty(tbx_Project_SavePath.Text.Trim())) {
                tbx_Project_SavePath.Focus();
                return;
            }
            Process.Start(tbx_Project_SavePath.Text);
        }

        private void list_Schema_SelectedIndexChanged(object sender,EventArgs e) {
            if(list_Schema.SelectedItems.Count > 1) {
                btn_BatchExec.Enabled = true;
            } else {
                btn_BatchExec.Enabled = false;
            }
        }

        private void cbx_AutoSaveToFile_CheckedChanged(object sender,EventArgs e) {
            tbx_Project_SavePath.Enabled = cbx_AutoSaveToFile.Checked;
            tbx_VO_Filename.Enabled = cbx_AutoSaveToFile.Checked;
            btn_SelectFolder.Enabled = cbx_AutoSaveToFile.Checked;
        }

        private void tbx_Project_SavePath_TextChanged(object sender,EventArgs e) {
            Application.DoEvents();
            SaveConfig(false,true);
        }
    }
}