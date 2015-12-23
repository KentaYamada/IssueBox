namespace IssueBox.Views
{
    partial class SearchIssue
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProjects = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.cmbCategories = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProducts = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SysProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuingMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponcedMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponcedMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DispStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dtDeadlineFrom = new IssueBox.Views.Infrastructure.DateMaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDeadlineTo = new IssueBox.Views.Infrastructure.DateMaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "案件";
            // 
            // cmbProjects
            // 
            this.cmbProjects.DisplayMember = "Value";
            this.cmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(44, 32);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(121, 28);
            this.cmbProjects.TabIndex = 2;
            this.cmbProjects.ValueMember = "ID";
            // 
            // cmbCategories
            // 
            this.cmbCategories.DisplayMember = "Value";
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(248, 32);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(121, 28);
            this.cmbCategories.TabIndex = 4;
            this.cmbCategories.ValueMember = "ID";
            this.cmbCategories.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "カテゴリ";
            this.label2.Visible = false;
            // 
            // cmbProducts
            // 
            this.cmbProducts.DisplayMember = "Value";
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(416, 32);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(121, 28);
            this.cmbProducts.TabIndex = 6;
            this.cmbProducts.ValueMember = "ID";
            this.cmbProducts.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "製品";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "期限";
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SysProjectID,
            this.ProjectID,
            this.ProjectName,
            this.CategoryID,
            this.CategoryName,
            this.IssuingMemberID,
            this.ProductID,
            this.ProductionName,
            this.Deadline,
            this.ResponcedMemberID,
            this.ResponcedMemberName,
            this.Status,
            this.DispStatus,
            this.FinishedDate,
            this.Comment,
            this.CheckedMemberID,
            this.OriginationDate});
            this.grdList.Location = new System.Drawing.Point(7, 160);
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowTemplate.Height = 21;
            this.grdList.Size = new System.Drawing.Size(774, 348);
            this.grdList.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SysProjectID
            // 
            this.SysProjectID.DataPropertyName = "ProjectID";
            this.SysProjectID.HeaderText = "SysProjectID";
            this.SysProjectID.Name = "SysProjectID";
            this.SysProjectID.ReadOnly = true;
            this.SysProjectID.Visible = false;
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "DispProjectID";
            this.ProjectID.HeaderText = "案件ID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.HeaderText = "案件名";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "カテゴリ";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // IssuingMemberID
            // 
            this.IssuingMemberID.DataPropertyName = "IssuingMemberID";
            this.IssuingMemberID.HeaderText = "IssuingMemberID";
            this.IssuingMemberID.Name = "IssuingMemberID";
            this.IssuingMemberID.ReadOnly = true;
            this.IssuingMemberID.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductionName
            // 
            this.ProductionName.DataPropertyName = "ProductName";
            this.ProductionName.HeaderText = "対象製品";
            this.ProductionName.Name = "ProductionName";
            this.ProductionName.ReadOnly = true;
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "Deadline";
            this.Deadline.HeaderText = "期限";
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            // 
            // ResponcedMemberID
            // 
            this.ResponcedMemberID.DataPropertyName = "ResponcedMemberID";
            this.ResponcedMemberID.HeaderText = "ResponcedMemberID";
            this.ResponcedMemberID.Name = "ResponcedMemberID";
            this.ResponcedMemberID.ReadOnly = true;
            this.ResponcedMemberID.Visible = false;
            // 
            // ResponcedMemberName
            // 
            this.ResponcedMemberName.DataPropertyName = "ResponcedMemberName";
            this.ResponcedMemberName.HeaderText = "対応者";
            this.ResponcedMemberName.Name = "ResponcedMemberName";
            this.ResponcedMemberName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // DispStatus
            // 
            this.DispStatus.DataPropertyName = "DispStatus";
            this.DispStatus.HeaderText = "ステータス";
            this.DispStatus.Name = "DispStatus";
            this.DispStatus.ReadOnly = true;
            // 
            // FinishedDate
            // 
            this.FinishedDate.DataPropertyName = "FinishedDate";
            this.FinishedDate.HeaderText = "完了日";
            this.FinishedDate.Name = "FinishedDate";
            this.FinishedDate.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Visible = false;
            // 
            // CheckedMemberID
            // 
            this.CheckedMemberID.DataPropertyName = "CheckedMemberID";
            this.CheckedMemberID.HeaderText = "CheckedMemberID";
            this.CheckedMemberID.Name = "CheckedMemberID";
            this.CheckedMemberID.ReadOnly = true;
            this.CheckedMemberID.Visible = false;
            // 
            // OriginationDate
            // 
            this.OriginationDate.DataPropertyName = "OriginationDate";
            this.OriginationDate.HeaderText = "OriginationDate";
            this.OriginationDate.Name = "OriginationDate";
            this.OriginationDate.ReadOnly = true;
            this.OriginationDate.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(625, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(706, 126);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 28);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "新規登録";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // dtDeadlineFrom
            // 
            this.dtDeadlineFrom.GetDate = null;
            this.dtDeadlineFrom.Location = new System.Drawing.Point(44, 76);
            this.dtDeadlineFrom.Mask = "0000/00/00";
            this.dtDeadlineFrom.Name = "dtDeadlineFrom";
            this.dtDeadlineFrom.Size = new System.Drawing.Size(100, 27);
            this.dtDeadlineFrom.TabIndex = 18;
            this.dtDeadlineFrom.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "～";
            // 
            // dtDeadlineTo
            // 
            this.dtDeadlineTo.GetDate = null;
            this.dtDeadlineTo.Location = new System.Drawing.Point(175, 76);
            this.dtDeadlineTo.Mask = "0000/00/00";
            this.dtDeadlineTo.Name = "dtDeadlineTo";
            this.dtDeadlineTo.Size = new System.Drawing.Size(100, 27);
            this.dtDeadlineTo.TabIndex = 20;
            this.dtDeadlineTo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "ステータス";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Visible = false;
            // 
            // SearchIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtDeadlineTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtDeadlineFrom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.label1);
            this.Name = "SearchIssue";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbProjects, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbCategories, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbProducts, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.grdList, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.dtDeadlineFrom, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dtDeadlineTo, 0);
            this.Controls.SetChildIndex(this.lblAlert, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Infrastructure.DropDownListEx cmbProjects;
        private Infrastructure.DropDownListEx cmbCategories;
        private System.Windows.Forms.Label label2;
        private Infrastructure.DropDownListEx cmbProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNew;
        private Infrastructure.DateMaskedTextBox dtDeadlineFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SysProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuingMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponcedMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponcedMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DispStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginationDate;
        private System.Windows.Forms.Label label5;
        private Infrastructure.DateMaskedTextBox dtDeadlineTo;
        private System.Windows.Forms.Label label6;
    }
}
