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
            this.label6 = new System.Windows.Forms.Label();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShohinName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponcedMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponcedMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.grpStatus = new IssueBox.Views.Infrastructure.StatusRadioButtons();
            this.dtDeadLine = new IssueBox.Views.Infrastructure.DateMaskedTextBox();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "カテゴリ";
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "製品";
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
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(171, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "ステータス";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Visible = false;
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProjectID,
            this.ProjectName,
            this.ProductID,
            this.ShohinName,
            this.ResponcedMemberID,
            this.ResponcedMemberName,
            this.DeadLine,
            this.Status});
            this.grdList.Location = new System.Drawing.Point(7, 160);
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowTemplate.Height = 21;
            this.grdList.Size = new System.Drawing.Size(774, 369);
            this.grdList.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 10;
            // 
            // ProjectID
            // 
            this.ProjectID.Frozen = true;
            this.ProjectID.HeaderText = "案件ID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            this.ProjectID.Width = 80;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.Frozen = true;
            this.ProjectName.HeaderText = "案件";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Width = 150;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.Frozen = true;
            this.ProductID.HeaderText = "製品ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            this.ProductID.Width = 10;
            // 
            // ShohinName
            // 
            this.ShohinName.DataPropertyName = "ProductName";
            this.ShohinName.Frozen = true;
            this.ShohinName.HeaderText = "製品";
            this.ShohinName.Name = "ShohinName";
            this.ShohinName.ReadOnly = true;
            this.ShohinName.Width = 150;
            // 
            // ResponcedMemberID
            // 
            this.ResponcedMemberID.DataPropertyName = "ResponcedMemberID";
            this.ResponcedMemberID.Frozen = true;
            this.ResponcedMemberID.HeaderText = "担当者ID";
            this.ResponcedMemberID.Name = "ResponcedMemberID";
            this.ResponcedMemberID.ReadOnly = true;
            this.ResponcedMemberID.Visible = false;
            this.ResponcedMemberID.Width = 10;
            // 
            // ResponcedMemberName
            // 
            this.ResponcedMemberName.DataPropertyName = "ResponcedMemberName";
            this.ResponcedMemberName.Frozen = true;
            this.ResponcedMemberName.HeaderText = "担当者";
            this.ResponcedMemberName.Name = "ResponcedMemberName";
            this.ResponcedMemberName.ReadOnly = true;
            this.ResponcedMemberName.Width = 150;
            // 
            // DeadLine
            // 
            this.DeadLine.DataPropertyName = "DeadLine";
            this.DeadLine.Frozen = true;
            this.DeadLine.HeaderText = "期日";
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.Frozen = true;
            this.Status.HeaderText = "ステータス";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(625, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(706, 126);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 28);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "新規登録";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grpStatus
            // 
            this.grpStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpStatus.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpStatus.Location = new System.Drawing.Point(248, 75);
            this.grpStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.SelectedStatus = 1;
            this.grpStatus.Size = new System.Drawing.Size(260, 28);
            this.grpStatus.TabIndex = 17;
            this.grpStatus.Visible = false;
            // 
            // dtDeadLine
            // 
            this.dtDeadLine.GetDate = null;
            this.dtDeadLine.Location = new System.Drawing.Point(44, 76);
            this.dtDeadLine.Mask = "0000/00/00";
            this.dtDeadLine.Name = "dtDeadLine";
            this.dtDeadLine.Size = new System.Drawing.Size(100, 27);
            this.dtDeadLine.TabIndex = 18;
            this.dtDeadLine.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // SearchIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtDeadLine);
            this.Controls.Add(this.grpStatus);
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
            this.Load += new System.EventHandler(this.SearchIssue_Load);
            this.Controls.SetChildIndex(this.lblAlert, 0);
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
            this.Controls.SetChildIndex(this.grpStatus, 0);
            this.Controls.SetChildIndex(this.dtDeadLine, 0);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNew;
        private Infrastructure.StatusRadioButtons grpStatus;
        private Infrastructure.DateMaskedTextBox dtDeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShohinName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponcedMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponcedMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
