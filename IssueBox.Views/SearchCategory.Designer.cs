namespace IssueBox.Views
{
    partial class SearchCategory
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
            this.txtName = new IssueBox.Views.Infrastructure.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnableFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbEnable = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(471, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(552, 102);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 28);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "新規登録";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "(部分一致)";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(233, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 27);
            this.txtName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "カテゴリ名";
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CategoryName,
            this.EnableFlag});
            this.grdList.Location = new System.Drawing.Point(157, 136);
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowTemplate.Height = 21;
            this.grdList.Size = new System.Drawing.Size(470, 369);
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
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "Name";
            this.CategoryName.Frozen = true;
            this.CategoryName.HeaderText = "カテゴリ名";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 300;
            // 
            // EnableFlag
            // 
            this.EnableFlag.DataPropertyName = "EnableFlag";
            this.EnableFlag.Frozen = true;
            this.EnableFlag.HeaderText = "データ有効";
            this.EnableFlag.Name = "EnableFlag";
            this.EnableFlag.ReadOnly = true;
            // 
            // cmbEnable
            // 
            this.cmbEnable.DisplayMember = "Value";
            this.cmbEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnable.FormattingEnabled = true;
            this.cmbEnable.Location = new System.Drawing.Point(233, 63);
            this.cmbEnable.Name = "cmbEnable";
            this.cmbEnable.Size = new System.Drawing.Size(121, 28);
            this.cmbEnable.TabIndex = 23;
            this.cmbEnable.ValueMember = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "データ有効";
            // 
            // SearchCategory
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
            this.Name = "SearchCategory";
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

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label2;
        private Infrastructure.TextBoxEx txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EnableFlag;
        private Infrastructure.DropDownListEx cmbEnable;
        private System.Windows.Forms.Label label6;
    }
}
