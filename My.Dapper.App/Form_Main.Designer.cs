namespace Ljk.Dapper.App {
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
            this.btn_Select = new System.Windows.Forms.Button();
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
            this.btn_GetRow = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 21);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(1003, 582);
            this.dgv.TabIndex = 0;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(1021, 21);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(121, 31);
            this.btn_Select.TabIndex = 1;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "条记录，每页显示：";
            // 
            // tbx_PageSize
            // 
            this.tbx_PageSize.Location = new System.Drawing.Point(262, 623);
            this.tbx_PageSize.Name = "tbx_PageSize";
            this.tbx_PageSize.Size = new System.Drawing.Size(100, 21);
            this.tbx_PageSize.TabIndex = 3;
            this.tbx_PageSize.Text = "10";
            // 
            // btn_FirstPage
            // 
            this.btn_FirstPage.Location = new System.Drawing.Point(680, 622);
            this.btn_FirstPage.Name = "btn_FirstPage";
            this.btn_FirstPage.Size = new System.Drawing.Size(75, 23);
            this.btn_FirstPage.TabIndex = 4;
            this.btn_FirstPage.Text = "第一页";
            this.btn_FirstPage.UseVisualStyleBackColor = true;
            this.btn_FirstPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // btn_PrevPage
            // 
            this.btn_PrevPage.Location = new System.Drawing.Point(761, 622);
            this.btn_PrevPage.Name = "btn_PrevPage";
            this.btn_PrevPage.Size = new System.Drawing.Size(75, 23);
            this.btn_PrevPage.TabIndex = 5;
            this.btn_PrevPage.Text = "上一页";
            this.btn_PrevPage.UseVisualStyleBackColor = true;
            this.btn_PrevPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.Location = new System.Drawing.Point(842, 622);
            this.btn_NextPage.Name = "btn_NextPage";
            this.btn_NextPage.Size = new System.Drawing.Size(75, 23);
            this.btn_NextPage.TabIndex = 6;
            this.btn_NextPage.Text = "下一页";
            this.btn_NextPage.UseVisualStyleBackColor = true;
            this.btn_NextPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // btn_LastPage
            // 
            this.btn_LastPage.Location = new System.Drawing.Point(923, 622);
            this.btn_LastPage.Name = "btn_LastPage";
            this.btn_LastPage.Size = new System.Drawing.Size(75, 23);
            this.btn_LastPage.TabIndex = 7;
            this.btn_LastPage.Text = "末页";
            this.btn_LastPage.UseVisualStyleBackColor = true;
            this.btn_LastPage.Click += new System.EventHandler(this.btn_PageClicked);
            // 
            // tbx_PageIndex
            // 
            this.tbx_PageIndex.Location = new System.Drawing.Point(436, 623);
            this.tbx_PageIndex.Name = "tbx_PageIndex";
            this.tbx_PageIndex.Size = new System.Drawing.Size(100, 21);
            this.tbx_PageIndex.TabIndex = 8;
            // 
            // tbx_TotalPage
            // 
            this.tbx_TotalPage.Location = new System.Drawing.Point(560, 623);
            this.tbx_TotalPage.Name = "tbx_TotalPage";
            this.tbx_TotalPage.Size = new System.Drawing.Size(100, 21);
            this.tbx_TotalPage.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 627);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "共：";
            // 
            // tbx_RecordCount
            // 
            this.tbx_RecordCount.Location = new System.Drawing.Point(37, 623);
            this.tbx_RecordCount.Name = "tbx_RecordCount";
            this.tbx_RecordCount.Size = new System.Drawing.Size(100, 21);
            this.tbx_RecordCount.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "条，页次：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 670);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "sqlCondition:";
            // 
            // tbx_SqlCondition
            // 
            this.tbx_SqlCondition.Location = new System.Drawing.Point(101, 667);
            this.tbx_SqlCondition.Name = "tbx_SqlCondition";
            this.tbx_SqlCondition.Size = new System.Drawing.Size(559, 21);
            this.tbx_SqlCondition.TabIndex = 15;
            this.tbx_SqlCondition.Text = "where ";
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
            // btn_GetRow
            // 
            this.btn_GetRow.Location = new System.Drawing.Point(1021, 58);
            this.btn_GetRow.Name = "btn_GetRow";
            this.btn_GetRow.Size = new System.Drawing.Size(121, 29);
            this.btn_GetRow.TabIndex = 18;
            this.btn_GetRow.Text = "GetRow";
            this.btn_GetRow.UseVisualStyleBackColor = true;
            this.btn_GetRow.Click += new System.EventHandler(this.btn_GetRow_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(1021, 93);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 31);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 731);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_GetRow);
            this.Controls.Add(this.tbx_Orderby);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_SqlCondition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_RecordCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_TotalPage);
            this.Controls.Add(this.tbx_PageIndex);
            this.Controls.Add(this.btn_LastPage);
            this.Controls.Add(this.btn_NextPage);
            this.Controls.Add(this.btn_PrevPage);
            this.Controls.Add(this.btn_FirstPage);
            this.Controls.Add(this.tbx_PageSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.dgv);
            this.DoubleBuffered = true;
            this.Name = "Form_Main";
            this.Text = "Ljk.Dapper SampleApp";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Select;
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
        private System.Windows.Forms.Button btn_GetRow;
        private System.Windows.Forms.Button btn_Add;
    }
}