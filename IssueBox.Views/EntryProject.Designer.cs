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
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.grpEnable = new IssueBox.Views.Infrastructure.EnableRadioButtons();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lstEquipments = new System.Windows.Forms.CheckedListBox();
            this.cmbMaker = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpBasicInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(297, 440);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "案件ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Location = new System.Drawing.Point(87, 24);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(188, 27);
            this.txtProjectID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "案件名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 27);
            this.txtName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "データ有効";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpBasicInfo
            // 
            this.grpBasicInfo.Controls.Add(this.grpEnable);
            this.grpBasicInfo.Controls.Add(this.label1);
            this.grpBasicInfo.Controls.Add(this.txtProjectID);
            this.grpBasicInfo.Controls.Add(this.txtName);
            this.grpBasicInfo.Controls.Add(this.label6);
            this.grpBasicInfo.Controls.Add(this.label2);
            this.grpBasicInfo.Location = new System.Drawing.Point(12, 12);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.Size = new System.Drawing.Size(360, 134);
            this.grpBasicInfo.TabIndex = 1001;
            this.grpBasicInfo.TabStop = false;
            this.grpBasicInfo.Text = "基本情報";
            // 
            // grpEnable
            // 
            this.grpEnable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpEnable.Enable = true;
            this.grpEnable.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpEnable.Location = new System.Drawing.Point(87, 92);
            this.grpEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnable.Name = "grpEnable";
            this.grpEnable.Size = new System.Drawing.Size(117, 28);
            this.grpEnable.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lstEquipments);
            this.groupBox1.Controls.Add(this.cmbMaker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 268);
            this.groupBox1.TabIndex = 1002;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "機器構成";
            this.groupBox1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitName,
            this.UnitCount,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(10, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(325, 94);
            this.dataGridView1.TabIndex = 10;
            // 
            // UnitName
            // 
            this.UnitName.HeaderText = "型番";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // UnitCount
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.UnitCount.DefaultCellStyle = dataGridViewCellStyle1;
            this.UnitCount.HeaderText = "台数";
            this.UnitCount.MaxInputLength = 2;
            this.UnitCount.Name = "UnitCount";
            this.UnitCount.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "日射計/気温計";
            this.Column1.Name = "Column1";
            // 
            // lstEquipments
            // 
            this.lstEquipments.FormattingEnabled = true;
            this.lstEquipments.Location = new System.Drawing.Point(10, 57);
            this.lstEquipments.Name = "lstEquipments";
            this.lstEquipments.Size = new System.Drawing.Size(325, 92);
            this.lstEquipments.TabIndex = 9;
            this.lstEquipments.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // cmbMaker
            // 
            this.cmbMaker.DisplayMember = "Value";
            this.cmbMaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaker.FormattingEnabled = true;
            this.cmbMaker.Location = new System.Drawing.Point(75, 23);
            this.cmbMaker.Name = "cmbMaker";
            this.cmbMaker.Size = new System.Drawing.Size(200, 28);
            this.cmbMaker.TabIndex = 8;
            this.cmbMaker.ValueMember = "ID";
            this.cmbMaker.SelectedValueChanged += new System.EventHandler(this.cmbMaker_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "メーカー";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntryProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBasicInfo);
            this.Controls.Add(this.btnSave);
            this.Name = "EntryProject";
            this.Text = "案件設定";
            this.Load += new System.EventHandler(this.EntryProject_Load);
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.grpBasicInfo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Infrastructure.TextBoxEx txtProjectID;
        private System.Windows.Forms.Label label2;
        private Infrastructure.TextBoxEx txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpBasicInfo;
        private Infrastructure.EnableRadioButtons grpEnable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox lstEquipments;
        private Infrastructure.DropDownListEx cmbMaker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}