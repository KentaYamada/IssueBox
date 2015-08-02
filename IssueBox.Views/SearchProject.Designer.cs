namespace IssueBox.Views
{
    partial class SearchProject
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEnable = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProjectID = new IssueBox.Views.Infrastructure.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnableFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new IssueBox.Views.Infrastructure.TextBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(541, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(622, 105);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 28);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "新規登録";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(289, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "(前方一致)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEnable
            // 
            this.cmbEnable.DisplayMember = "Value";
            this.cmbEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnable.FormattingEnabled = true;
            this.cmbEnable.Location = new System.Drawing.Point(163, 65);
            this.cmbEnable.Name = "cmbEnable";
            this.cmbEnable.Size = new System.Drawing.Size(120, 28);
            this.cmbEnable.TabIndex = 7;
            this.cmbEnable.ValueMember = "ID";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(83, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "データ有効";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Location = new System.Drawing.Point(163, 32);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(120, 27);
            this.txtProjectID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(83, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "案件ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.EnableFlag});
            this.grdList.Location = new System.Drawing.Point(87, 139);
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowTemplate.Height = 21;
            this.grdList.Size = new System.Drawing.Size(610, 369);
            this.grdList.TabIndex = 10;
            this.grdList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdList_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "ProjectID";
            this.ProjectID.Frozen = true;
            this.ProjectID.HeaderText = "案件ID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            this.ProjectID.Width = 140;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "Name";
            this.ProjectName.Frozen = true;
            this.ProjectName.HeaderText = "案件名";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Width = 320;
            // 
            // EnableFlag
            // 
            this.EnableFlag.DataPropertyName = "EnableFlag";
            this.EnableFlag.Frozen = true;
            this.EnableFlag.HeaderText = "データ有効";
            this.EnableFlag.Name = "EnableFlag";
            this.EnableFlag.ReadOnly = true;
            this.EnableFlag.Width = 85;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(599, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "(部分一致)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(422, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 27);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(368, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "案件名";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEnable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdList);
            this.Name = "SearchProject";
            this.Load += new System.EventHandler(this.SearchProject_Load);
            this.Controls.SetChildIndex(this.lblAlert, 0);
            this.Controls.SetChildIndex(this.grdList, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtProjectID, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cmbEnable, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label2;
        private Infrastructure.DropDownListEx cmbEnable;
        private System.Windows.Forms.Label label6;
        private Infrastructure.TextBoxEx txtProjectID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.Label label3;
        private Infrastructure.TextBoxEx txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EnableFlag;
    }
}
