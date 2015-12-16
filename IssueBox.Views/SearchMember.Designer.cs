namespace IssueBox.Views
{
    partial class SearchMember
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
            this.grdList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnableFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtName = new IssueBox.Views.Infrastructure.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbEnable = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MemberName,
            this.LoginID,
            this.LoginPassword,
            this.EnableFlag});
            this.grdList.Location = new System.Drawing.Point(52, 142);
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowTemplate.Height = 21;
            this.grdList.Size = new System.Drawing.Size(678, 369);
            this.grdList.TabIndex = 1;
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
            // MemberName
            // 
            this.MemberName.DataPropertyName = "Name";
            this.MemberName.Frozen = true;
            this.MemberName.HeaderText = "名前";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            this.MemberName.Width = 300;
            // 
            // LoginID
            // 
            this.LoginID.DataPropertyName = "LoginID";
            this.LoginID.Frozen = true;
            this.LoginID.HeaderText = "ログインID";
            this.LoginID.Name = "LoginID";
            this.LoginID.ReadOnly = true;
            this.LoginID.Width = 200;
            // 
            // LoginPassword
            // 
            this.LoginPassword.DataPropertyName = "LoginPassword";
            this.LoginPassword.Frozen = true;
            this.LoginPassword.HeaderText = "パスワード";
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.ReadOnly = true;
            this.LoginPassword.Visible = false;
            // 
            // EnableFlag
            // 
            this.EnableFlag.DataPropertyName = "EnableFlag";
            this.EnableFlag.Frozen = true;
            this.EnableFlag.HeaderText = "データ有効";
            this.EnableFlag.Name = "EnableFlag";
            this.EnableFlag.ReadOnly = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 27);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "(部分一致)";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(655, 108);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 28);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "新規登録";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(574, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbEnable
            // 
            this.cmbEnable.DisplayMember = "Value";
            this.cmbEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnable.FormattingEnabled = true;
            this.cmbEnable.Location = new System.Drawing.Point(128, 66);
            this.cmbEnable.Name = "cmbEnable";
            this.cmbEnable.Size = new System.Drawing.Size(121, 28);
            this.cmbEnable.TabIndex = 20;
            this.cmbEnable.ValueMember = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "データ有効";
            // 
            // SearchMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbEnable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdList);
            this.Name = "SearchMember";
            this.Controls.SetChildIndex(this.lblAlert, 0);
            this.Controls.SetChildIndex(this.grdList, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cmbEnable, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdList;
        private Infrastructure.TextBoxEx txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginPassword;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EnableFlag;
        private Infrastructure.DropDownListEx cmbEnable;
        private System.Windows.Forms.Label label6;
    }
}
