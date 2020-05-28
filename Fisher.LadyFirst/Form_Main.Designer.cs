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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_GetRow = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
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
            this.dgv.Location = new System.Drawing.Point(2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(1048, 489);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "条记录，每页显示：";
            // 
            // tbx_PageSize
            // 
            this.tbx_PageSize.Location = new System.Drawing.Point(222, 25);
            this.tbx_PageSize.Name = "tbx_PageSize";
            this.tbx_PageSize.Size = new System.Drawing.Size(39, 21);
            this.tbx_PageSize.TabIndex = 3;
            this.tbx_PageSize.Text = "10";
            // 
            // btn_FirstPage
            // 
            this.btn_FirstPage.Location = new System.Drawing.Point(467, 23);
            this.btn_FirstPage.Name = "btn_FirstPage";
            this.btn_FirstPage.Size = new System.Drawing.Size(56, 23);
            this.btn_FirstPage.TabIndex = 4;
            this.btn_FirstPage.Text = "第一页";
            this.btn_FirstPage.UseVisualStyleBackColor = true;
            this.btn_FirstPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // btn_PrevPage
            // 
            this.btn_PrevPage.Location = new System.Drawing.Point(520, 23);
            this.btn_PrevPage.Name = "btn_PrevPage";
            this.btn_PrevPage.Size = new System.Drawing.Size(56, 23);
            this.btn_PrevPage.TabIndex = 5;
            this.btn_PrevPage.Text = "上一页";
            this.btn_PrevPage.UseVisualStyleBackColor = true;
            this.btn_PrevPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.Location = new System.Drawing.Point(572, 23);
            this.btn_NextPage.Name = "btn_NextPage";
            this.btn_NextPage.Size = new System.Drawing.Size(56, 23);
            this.btn_NextPage.TabIndex = 6;
            this.btn_NextPage.Text = "下一页";
            this.btn_NextPage.UseVisualStyleBackColor = true;
            this.btn_NextPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // btn_LastPage
            // 
            this.btn_LastPage.Location = new System.Drawing.Point(625, 23);
            this.btn_LastPage.Name = "btn_LastPage";
            this.btn_LastPage.Size = new System.Drawing.Size(56, 23);
            this.btn_LastPage.TabIndex = 7;
            this.btn_LastPage.Text = "末页";
            this.btn_LastPage.UseVisualStyleBackColor = true;
            this.btn_LastPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // tbx_PageIndex
            // 
            this.tbx_PageIndex.Location = new System.Drawing.Point(332, 25);
            this.tbx_PageIndex.Name = "tbx_PageIndex";
            this.tbx_PageIndex.Size = new System.Drawing.Size(58, 21);
            this.tbx_PageIndex.TabIndex = 8;
            // 
            // tbx_TotalPage
            // 
            this.tbx_TotalPage.Location = new System.Drawing.Point(411, 25);
            this.tbx_TotalPage.Name = "tbx_TotalPage";
            this.tbx_TotalPage.Size = new System.Drawing.Size(52, 21);
            this.tbx_TotalPage.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "共：";
            // 
            // tbx_RecordCount
            // 
            this.tbx_RecordCount.Location = new System.Drawing.Point(41, 25);
            this.tbx_RecordCount.Name = "tbx_RecordCount";
            this.tbx_RecordCount.Size = new System.Drawing.Size(59, 21);
            this.tbx_RecordCount.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "条，页次：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "sqlCondition:";
            // 
            // tbx_SqlCondition
            // 
            this.tbx_SqlCondition.Location = new System.Drawing.Point(222, 60);
            this.tbx_SqlCondition.Name = "tbx_SqlCondition";
            this.tbx_SqlCondition.Size = new System.Drawing.Size(459, 21);
            this.tbx_SqlCondition.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 699);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "orderby:";
            // 
            // tbx_Orderby
            // 
            this.tbx_Orderby.Location = new System.Drawing.Point(101, 696);
            this.tbx_Orderby.Name = "tbx_Orderby";
            this.tbx_Orderby.Size = new System.Drawing.Size(261, 21);
            this.tbx_Orderby.TabIndex = 17;
            this.tbx_Orderby.Text = "order by ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 519);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(1052, 493);
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
            this.panel1.Location = new System.Drawing.Point(2, 396);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 95);
            this.panel1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Add);
            this.tabPage2.Controls.Add(this.btn_GetRow);
            this.tabPage2.Controls.Add(this.btn_Select);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1052, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fisher.Save<T>";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(310, 182);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 31);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_GetRow
            // 
            this.btn_GetRow.Location = new System.Drawing.Point(310, 147);
            this.btn_GetRow.Name = "btn_GetRow";
            this.btn_GetRow.Size = new System.Drawing.Size(121, 29);
            this.btn_GetRow.TabIndex = 21;
            this.btn_GetRow.Text = "GetRow";
            this.btn_GetRow.UseVisualStyleBackColor = true;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(310, 110);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(121, 31);
            this.btn_Select.TabIndex = 20;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbx_Orderby);
            this.Controls.Add(this.label6);
            this.DoubleBuffered = true;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fisher SampleApplication";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_GetRow;
        private System.Windows.Forms.Button btn_Select;
    }
}