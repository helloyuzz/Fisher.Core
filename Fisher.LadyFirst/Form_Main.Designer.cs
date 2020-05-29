namespace Fisherman.LadyFirst {
    partial class Form_Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_PageSize = new System.Windows.Forms.TextBox();
            this.btn_FirstPage = new System.Windows.Forms.Button();
            this.btn_PrevPage = new System.Windows.Forms.Button();
            this.btn_NextPage = new System.Windows.Forms.Button();
            this.btn_LastPage = new System.Windows.Forms.Button();
            this.tbx_PageIndex = new System.Windows.Forms.TextBox();
            this.tbx_TotalPage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_RecordCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_SqlCondition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_Orderby = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_GetRow = new System.Windows.Forms.Button();
            this.btn_SignleRow = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_IsDisabled = new System.Windows.Forms.CheckBox();
            this.tbx_ConfigurationID = new System.Windows.Forms.TextBox();
            this.tbx_ConfigurationKey = new System.Windows.Forms.TextBox();
            this.tbx_Value = new System.Windows.Forms.TextBox();
            this.tbx_Remark = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_Get_ConfigurationID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 2);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(1399, 616);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "条记录，每页显示：";
            // 
            // tbx_PageSize
            // 
            this.tbx_PageSize.Location = new System.Drawing.Point(296, 31);
            this.tbx_PageSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_PageSize.Name = "tbx_PageSize";
            this.tbx_PageSize.Size = new System.Drawing.Size(51, 25);
            this.tbx_PageSize.TabIndex = 3;
            this.tbx_PageSize.Text = "10";
            // 
            // btn_FirstPage
            // 
            this.btn_FirstPage.Location = new System.Drawing.Point(623, 29);
            this.btn_FirstPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_FirstPage.Name = "btn_FirstPage";
            this.btn_FirstPage.Size = new System.Drawing.Size(75, 29);
            this.btn_FirstPage.TabIndex = 4;
            this.btn_FirstPage.Text = "第一页";
            this.btn_FirstPage.UseVisualStyleBackColor = true;
            this.btn_FirstPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // btn_PrevPage
            // 
            this.btn_PrevPage.Location = new System.Drawing.Point(693, 29);
            this.btn_PrevPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PrevPage.Name = "btn_PrevPage";
            this.btn_PrevPage.Size = new System.Drawing.Size(75, 29);
            this.btn_PrevPage.TabIndex = 5;
            this.btn_PrevPage.Text = "上一页";
            this.btn_PrevPage.UseVisualStyleBackColor = true;
            this.btn_PrevPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.Location = new System.Drawing.Point(763, 29);
            this.btn_NextPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_NextPage.Name = "btn_NextPage";
            this.btn_NextPage.Size = new System.Drawing.Size(75, 29);
            this.btn_NextPage.TabIndex = 6;
            this.btn_NextPage.Text = "下一页";
            this.btn_NextPage.UseVisualStyleBackColor = true;
            this.btn_NextPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // btn_LastPage
            // 
            this.btn_LastPage.Location = new System.Drawing.Point(833, 29);
            this.btn_LastPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LastPage.Name = "btn_LastPage";
            this.btn_LastPage.Size = new System.Drawing.Size(75, 29);
            this.btn_LastPage.TabIndex = 7;
            this.btn_LastPage.Text = "末页";
            this.btn_LastPage.UseVisualStyleBackColor = true;
            this.btn_LastPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // tbx_PageIndex
            // 
            this.tbx_PageIndex.Location = new System.Drawing.Point(443, 31);
            this.tbx_PageIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_PageIndex.Name = "tbx_PageIndex";
            this.tbx_PageIndex.Size = new System.Drawing.Size(76, 25);
            this.tbx_PageIndex.TabIndex = 8;
            // 
            // tbx_TotalPage
            // 
            this.tbx_TotalPage.Location = new System.Drawing.Point(548, 31);
            this.tbx_TotalPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_TotalPage.Name = "tbx_TotalPage";
            this.tbx_TotalPage.Size = new System.Drawing.Size(68, 25);
            this.tbx_TotalPage.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "共：";
            // 
            // tbx_RecordCount
            // 
            this.tbx_RecordCount.Location = new System.Drawing.Point(55, 31);
            this.tbx_RecordCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_RecordCount.Name = "tbx_RecordCount";
            this.tbx_RecordCount.Size = new System.Drawing.Size(77, 25);
            this.tbx_RecordCount.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "条，页次：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "sqlCondition:";
            // 
            // tbx_SqlCondition
            // 
            this.tbx_SqlCondition.Location = new System.Drawing.Point(296, 75);
            this.tbx_SqlCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_SqlCondition.Name = "tbx_SqlCondition";
            this.tbx_SqlCondition.Size = new System.Drawing.Size(611, 25);
            this.tbx_SqlCondition.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 874);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "orderby:";
            // 
            // tbx_Orderby
            // 
            this.tbx_Orderby.Location = new System.Drawing.Point(135, 870);
            this.tbx_Orderby.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_Orderby.Name = "tbx_Orderby";
            this.tbx_Orderby.Size = new System.Drawing.Size(347, 25);
            this.tbx_Orderby.TabIndex = 17;
            this.tbx_Orderby.Text = "order by ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1413, 649);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1405, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fisher.Query<T>";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbx_RecordCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbx_PageSize);
            this.panel1.Controls.Add(this.btn_FirstPage);
            this.panel1.Controls.Add(this.btn_PrevPage);
            this.panel1.Controls.Add(this.tbx_SqlCondition);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_NextPage);
            this.panel1.Controls.Add(this.btn_LastPage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbx_PageIndex);
            this.panel1.Controls.Add(this.tbx_TotalPage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 499);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 119);
            this.panel1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbx_Remark);
            this.tabPage2.Controls.Add(this.tbx_Value);
            this.tabPage2.Controls.Add(this.tbx_ConfigurationKey);
            this.tabPage2.Controls.Add(this.tbx_Get_ConfigurationID);
            this.tabPage2.Controls.Add(this.tbx_ConfigurationID);
            this.tabPage2.Controls.Add(this.cbx_IsDisabled);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btn_Save);
            this.tabPage2.Controls.Add(this.btn_GetRow);
            this.tabPage2.Controls.Add(this.btn_SignleRow);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1405, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fisher.Save<T>";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(231, 277);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(124, 39);
            this.btn_Save.TabIndex = 22;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_GetRow
            // 
            this.btn_GetRow.Location = new System.Drawing.Point(796, 328);
            this.btn_GetRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GetRow.Name = "btn_GetRow";
            this.btn_GetRow.Size = new System.Drawing.Size(161, 36);
            this.btn_GetRow.TabIndex = 21;
            this.btn_GetRow.Text = "GetRow";
            this.btn_GetRow.UseVisualStyleBackColor = true;
            // 
            // btn_SignleRow
            // 
            this.btn_SignleRow.Location = new System.Drawing.Point(796, 83);
            this.btn_SignleRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SignleRow.Name = "btn_SignleRow";
            this.btn_SignleRow.Size = new System.Drawing.Size(161, 39);
            this.btn_SignleRow.TabIndex = 20;
            this.btn_SignleRow.Text = "SignleRow";
            this.btn_SignleRow.UseVisualStyleBackColor = true;
            this.btn_SignleRow.Click += new System.EventHandler(this.btn_SignleRow_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "ConfigurationID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "ConfigurationKey";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Remark";
            // 
            // cbx_IsDisabled
            // 
            this.cbx_IsDisabled.AutoSize = true;
            this.cbx_IsDisabled.Location = new System.Drawing.Point(231, 211);
            this.cbx_IsDisabled.Name = "cbx_IsDisabled";
            this.cbx_IsDisabled.Size = new System.Drawing.Size(109, 19);
            this.cbx_IsDisabled.TabIndex = 27;
            this.cbx_IsDisabled.Text = "IsDisabled";
            this.cbx_IsDisabled.UseVisualStyleBackColor = true;
            // 
            // tbx_ConfigurationID
            // 
            this.tbx_ConfigurationID.Location = new System.Drawing.Point(231, 43);
            this.tbx_ConfigurationID.Name = "tbx_ConfigurationID";
            this.tbx_ConfigurationID.ReadOnly = true;
            this.tbx_ConfigurationID.Size = new System.Drawing.Size(232, 25);
            this.tbx_ConfigurationID.TabIndex = 28;
            // 
            // tbx_ConfigurationKey
            // 
            this.tbx_ConfigurationKey.Location = new System.Drawing.Point(231, 83);
            this.tbx_ConfigurationKey.Name = "tbx_ConfigurationKey";
            this.tbx_ConfigurationKey.Size = new System.Drawing.Size(232, 25);
            this.tbx_ConfigurationKey.TabIndex = 28;
            // 
            // tbx_Value
            // 
            this.tbx_Value.Location = new System.Drawing.Point(231, 126);
            this.tbx_Value.Name = "tbx_Value";
            this.tbx_Value.Size = new System.Drawing.Size(232, 25);
            this.tbx_Value.TabIndex = 28;
            // 
            // tbx_Remark
            // 
            this.tbx_Remark.Location = new System.Drawing.Point(231, 169);
            this.tbx_Remark.Name = "tbx_Remark";
            this.tbx_Remark.Size = new System.Drawing.Size(232, 25);
            this.tbx_Remark.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(654, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "ConfigurationID";
            // 
            // tbx_Get_ConfigurationID
            // 
            this.tbx_Get_ConfigurationID.Location = new System.Drawing.Point(796, 43);
            this.tbx_Get_ConfigurationID.Name = "tbx_Get_ConfigurationID";
            this.tbx_Get_ConfigurationID.Size = new System.Drawing.Size(232, 25);
            this.tbx_Get_ConfigurationID.TabIndex = 28;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 649);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbx_Orderby);
            this.Controls.Add(this.label6);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fisher SampleApplication";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_PageSize;
        private System.Windows.Forms.Button btn_FirstPage;
        private System.Windows.Forms.Button btn_PrevPage;
        private System.Windows.Forms.Button btn_NextPage;
        private System.Windows.Forms.Button btn_LastPage;
        private System.Windows.Forms.TextBox tbx_PageIndex;
        private System.Windows.Forms.TextBox tbx_TotalPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_RecordCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_SqlCondition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_Orderby;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_GetRow;
        private System.Windows.Forms.Button btn_SignleRow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbx_IsDisabled;
        private System.Windows.Forms.TextBox tbx_Remark;
        private System.Windows.Forms.TextBox tbx_Value;
        private System.Windows.Forms.TextBox tbx_ConfigurationKey;
        private System.Windows.Forms.TextBox tbx_ConfigurationID;
        private System.Windows.Forms.TextBox tbx_Get_ConfigurationID;
        private System.Windows.Forms.Label label11;
    }
}