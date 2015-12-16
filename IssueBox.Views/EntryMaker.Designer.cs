namespace IssueBox.Views
{
    partial class EntryMaker
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
            this.label6 = new System.Windows.Forms.Label();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.EquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rateing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommunicationMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OutputControlFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EnableFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpEnable = new IssueBox.Views.Infrastructure.EnableRadioButtons();
            this.txtName = new IssueBox.Views.Infrastructure.TextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(547, 242);
            this.btnReturn.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "データ有効";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdList
            // 
            this.grdList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipID,
            this.EquipName,
            this.Rateing,
            this.MakerID,
            this.CommunicationMethod,
            this.OutputControlFlag,
            this.EnableFlag});
            this.grdList.Location = new System.Drawing.Point(12, 80);
            this.grdList.Name = "grdList";
            this.grdList.RowTemplate.Height = 21;
            this.grdList.Size = new System.Drawing.Size(610, 150);
            this.grdList.TabIndex = 4;
            // 
            // EquipID
            // 
            this.EquipID.DataPropertyName = "ID";
            this.EquipID.HeaderText = "機器ID";
            this.EquipID.Name = "EquipID";
            this.EquipID.ReadOnly = true;
            this.EquipID.Visible = false;
            // 
            // EquipName
            // 
            this.EquipName.DataPropertyName = "Name";
            this.EquipName.HeaderText = "型番";
            this.EquipName.Name = "EquipName";
            this.EquipName.Width = 150;
            // 
            // Rateing
            // 
            this.Rateing.DataPropertyName = "Rating";
            this.Rateing.HeaderText = "定格";
            this.Rateing.Name = "Rateing";
            this.Rateing.Width = 80;
            // 
            // MakerID
            // 
            this.MakerID.DataPropertyName = "MakerID";
            this.MakerID.HeaderText = "メーカーID";
            this.MakerID.Name = "MakerID";
            this.MakerID.ReadOnly = true;
            this.MakerID.Visible = false;
            // 
            // CommunicationMethod
            // 
            this.CommunicationMethod.DataPropertyName = "CommunicationMethodID";
            this.CommunicationMethod.HeaderText = "通信方式";
            this.CommunicationMethod.Name = "CommunicationMethod";
            this.CommunicationMethod.Width = 120;
            // 
            // OutputControlFlag
            // 
            this.OutputControlFlag.DataPropertyName = "OutputControlFlag";
            this.OutputControlFlag.HeaderText = "出力制御";
            this.OutputControlFlag.Name = "OutputControlFlag";
            // 
            // EnableFlag
            // 
            this.EnableFlag.DataPropertyName = "EnableFlag";
            this.EnableFlag.HeaderText = "データ有効";
            this.EnableFlag.Name = "EnableFlag";
            this.EnableFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EnableFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(466, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // grpEnable
            // 
            this.grpEnable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpEnable.Enable = true;
            this.grpEnable.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpEnable.Location = new System.Drawing.Point(93, 44);
            this.grpEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnable.Name = "grpEnable";
            this.grpEnable.Size = new System.Drawing.Size(117, 28);
            this.grpEnable.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 27);
            this.txtName.TabIndex = 1;
            // 
            // EntryMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 282);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grpEnable);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "EntryMaker";
            this.Text = "メーカー設定";
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.grdList, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.grpEnable, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.Button btnSave;
        private Infrastructure.EnableRadioButtons grpEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rateing;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakerID;
        private System.Windows.Forms.DataGridViewComboBoxColumn CommunicationMethod;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OutputControlFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EnableFlag;
        private Infrastructure.TextBoxEx txtName;
    }
}