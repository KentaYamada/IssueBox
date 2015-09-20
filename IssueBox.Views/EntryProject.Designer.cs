namespace IssueBox.Views
{
    partial class EntryProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectID = new IssueBox.Views.Infrastructure.TextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new IssueBox.Views.Infrastructure.TextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpEnable = new IssueBox.Views.Infrastructure.EnableRadioButtons();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstEquipments = new System.Windows.Forms.ListBox();
            this.cmbMaker = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.grdDetail = new System.Windows.Forms.DataGridView();
            this.MakerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ConfID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnableFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(690, 295);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "案件ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Location = new System.Drawing.Point(93, 10);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(188, 27);
            this.txtProjectID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "案件名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 27);
            this.txtName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "データ有効";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(609, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpEnable
            // 
            this.grpEnable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpEnable.Enable = true;
            this.grpEnable.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpEnable.Location = new System.Drawing.Point(93, 78);
            this.grpEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnable.Name = "grpEnable";
            this.grpEnable.Size = new System.Drawing.Size(117, 28);
            this.grpEnable.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstEquipments);
            this.groupBox1.Controls.Add(this.cmbMaker);
            this.groupBox1.Location = new System.Drawing.Point(543, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 280);
            this.groupBox1.TabIndex = 1002;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "機器選択";
            // 
            // lstEquipments
            // 
            this.lstEquipments.FormattingEnabled = true;
            this.lstEquipments.ItemHeight = 20;
            this.lstEquipments.Items.AddRange(new object[] {
            "XXXXXXXXX1XXXXXXXXX2"});
            this.lstEquipments.Location = new System.Drawing.Point(11, 57);
            this.lstEquipments.Name = "lstEquipments";
            this.lstEquipments.Size = new System.Drawing.Size(200, 204);
            this.lstEquipments.TabIndex = 9;
            this.lstEquipments.DoubleClick += new System.EventHandler(this.lstEquipments_DoubleClick);
            // 
            // cmbMaker
            // 
            this.cmbMaker.DisplayMember = "Value";
            this.cmbMaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaker.FormattingEnabled = true;
            this.cmbMaker.Location = new System.Drawing.Point(11, 23);
            this.cmbMaker.Name = "cmbMaker";
            this.cmbMaker.Size = new System.Drawing.Size(200, 28);
            this.cmbMaker.TabIndex = 8;
            this.cmbMaker.ValueMember = "ID";
            this.cmbMaker.SelectedValueChanged += new System.EventHandler(this.cmbMaker_SelectedValueChanged);
            // 
            // grdDetail
            // 
            this.grdDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MakerName,
            this.UnitName,
            this.Rating,
            this.UnitCount,
            this.Column1,
            this.ConfID,
            this.ProjectID,
            this.EnableFlag,
            this.DeleteBtn});
            this.grdDetail.Location = new System.Drawing.Point(12, 114);
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.RowTemplate.Height = 21;
            this.grdDetail.Size = new System.Drawing.Size(525, 175);
            this.grdDetail.TabIndex = 10;
            this.grdDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetail_CellContentClick);
            // 
            // MakerName
            // 
            this.MakerName.DataPropertyName = "MakerName";
            this.MakerName.HeaderText = "メーカー";
            this.MakerName.Name = "MakerName";
            this.MakerName.ReadOnly = true;
            this.MakerName.Width = 120;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "EquipName";
            this.UnitName.HeaderText = "型番";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 120;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "定格";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 60;
            // 
            // UnitCount
            // 
            this.UnitCount.DataPropertyName = "UnitCount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.UnitCount.DefaultCellStyle = dataGridViewCellStyle1;
            this.UnitCount.HeaderText = "台数";
            this.UnitCount.MaxInputLength = 2;
            this.UnitCount.Name = "UnitCount";
            this.UnitCount.Width = 60;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IrrTempFlag";
            this.Column1.HeaderText = "日射計/気温計";
            this.Column1.Name = "Column1";
            // 
            // ConfID
            // 
            this.ConfID.DataPropertyName = "ID";
            this.ConfID.HeaderText = "Column2";
            this.ConfID.Name = "ConfID";
            this.ConfID.Visible = false;
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "ProjectID";
            this.ProjectID.HeaderText = "Column2";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Visible = false;
            // 
            // EnableFlag
            // 
            this.EnableFlag.DataPropertyName = "EnableFlag";
            this.EnableFlag.HeaderText = "Column2";
            this.EnableFlag.Name = "EnableFlag";
            this.EnableFlag.Visible = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.HeaderText = "";
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ReadOnly = true;
            this.DeleteBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteBtn.Text = "削除";
            this.DeleteBtn.UseColumnTextForButtonValue = true;
            // 
            // EntryProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 342);
            this.Controls.Add(this.grdDetail);
            this.Controls.Add(this.grpEnable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "EntryProject";
            this.Text = "案件登録";
            this.Load += new System.EventHandler(this.EntryProject_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtProjectID, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.grpEnable, 0);
            this.Controls.SetChildIndex(this.grdDetail, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Infrastructure.TextBoxEx txtProjectID;
        private System.Windows.Forms.Label label2;
        private Infrastructure.TextBoxEx txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private Infrastructure.EnableRadioButtons grpEnable;
        private System.Windows.Forms.GroupBox groupBox1;
        private Infrastructure.DropDownListEx cmbMaker;
        private System.Windows.Forms.DataGridView grdDetail;
        private System.Windows.Forms.ListBox lstEquipments;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnableFlag;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBtn;
    }
}