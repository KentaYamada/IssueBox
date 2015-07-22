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
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpEnable = new IssueBox.Views.Infrastructure.EnableRadioButtons();
            this.label6 = new System.Windows.Forms.Label();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.EquipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnableFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(362, 228);
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 27);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "XXXXXXXXX1XXXXXXXXX2";
            // 
            // grpEnable
            // 
            this.grpEnable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpEnable.Enable = true;
            this.grpEnable.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpEnable.Location = new System.Drawing.Point(93, 41);
            this.grpEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnable.Name = "grpEnable";
            this.grpEnable.Size = new System.Drawing.Size(117, 23);
            this.grpEnable.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "データ有効";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdList
            // 
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipmentID,
            this.EquipName,
            this.Rating,
            this.MakerID,
            this.EnableFlag});
            this.grdList.Location = new System.Drawing.Point(12, 72);
            this.grdList.Name = "grdList";
            this.grdList.RowTemplate.Height = 21;
            this.grdList.Size = new System.Drawing.Size(425, 150);
            this.grdList.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(281, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EquipmentID
            // 
            this.EquipmentID.DataPropertyName = "ID";
            this.EquipmentID.HeaderText = "EquipmentID";
            this.EquipmentID.Name = "EquipmentID";
            this.EquipmentID.Visible = false;
            // 
            // EquipName
            // 
            this.EquipName.DataPropertyName = "Name";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EquipName.DefaultCellStyle = dataGridViewCellStyle1;
            this.EquipName.HeaderText = "型番";
            this.EquipName.Name = "EquipName";
            this.EquipName.Width = 200;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "定格";
            this.Rating.Name = "Rating";
            this.Rating.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rating.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Rating.Width = 60;
            // 
            // MakerID
            // 
            this.MakerID.DataPropertyName = "MakerID";
            this.MakerID.HeaderText = "MakerID";
            this.MakerID.Name = "MakerID";
            this.MakerID.Visible = false;
            // 
            // EnableFlag
            // 
            this.EnableFlag.DataPropertyName = "EnableFlag";
            this.EnableFlag.HeaderText = "データ有効";
            this.EnableFlag.Name = "EnableFlag";
            // 
            // EntryMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 265);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.grpEnable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "EntryMaker";
            this.Text = "メーカー登録";
            this.Load += new System.EventHandler(this.EntryMaker_Load);
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.grpEnable, 0);
            this.Controls.SetChildIndex(this.grdList, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private Infrastructure.EnableRadioButtons grpEnable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakerID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EnableFlag;
    }
}