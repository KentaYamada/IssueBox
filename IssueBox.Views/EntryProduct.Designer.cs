namespace IssueBox.Views
{
    partial class EntryProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new IssueBox.Views.Infrastructure.TextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpStatus = new IssueBox.Views.Infrastructure.RadioButtonPanel();
            this.serviceRadioButton1 = new IssueBox.Views.Infrastructure.ServiceRadioButton();
            this.productRadioButton1 = new IssueBox.Views.Infrastructure.ProductRadioButton();
            this.grpEnable = new IssueBox.Views.Infrastructure.EnableRadioButtons();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "バージョン";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVersion
            // 
            this.txtVersion.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtVersion.Location = new System.Drawing.Point(92, 49);
            this.txtVersion.Mask = "000.000.000.000";
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(117, 27);
            this.txtVersion.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.AlertMessage = "必須入力です。";
            this.txtName.Location = new System.Drawing.Point(92, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 27);
            this.txtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "データ有効";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(166, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "製品種別";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpStatus
            // 
            this.grpStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpStatus.Controls.Add(this.serviceRadioButton1);
            this.grpStatus.Controls.Add(this.productRadioButton1);
            this.grpStatus.Location = new System.Drawing.Point(92, 84);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.SelectedStatus = 1;
            this.grpStatus.Size = new System.Drawing.Size(149, 28);
            this.grpStatus.TabIndex = 5;
            // 
            // serviceRadioButton1
            // 
            this.serviceRadioButton1.AutoSize = true;
            this.serviceRadioButton1.Location = new System.Drawing.Point(62, 1);
            this.serviceRadioButton1.Name = "serviceRadioButton1";
            this.serviceRadioButton1.Size = new System.Drawing.Size(79, 24);
            this.serviceRadioButton1.TabIndex = 1;
            this.serviceRadioButton1.Text = "サービス";
            this.serviceRadioButton1.UseVisualStyleBackColor = true;
            // 
            // productRadioButton1
            // 
            this.productRadioButton1.AutoSize = true;
            this.productRadioButton1.Checked = true;
            this.productRadioButton1.Location = new System.Drawing.Point(3, 1);
            this.productRadioButton1.Name = "productRadioButton1";
            this.productRadioButton1.Size = new System.Drawing.Size(53, 24);
            this.productRadioButton1.TabIndex = 0;
            this.productRadioButton1.TabStop = true;
            this.productRadioButton1.Text = "製品";
            this.productRadioButton1.UseVisualStyleBackColor = true;
            // 
            // grpEnable
            // 
            this.grpEnable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpEnable.Enable = true;
            this.grpEnable.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpEnable.Location = new System.Drawing.Point(92, 122);
            this.grpEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnable.Name = "grpEnable";
            this.grpEnable.Size = new System.Drawing.Size(117, 28);
            this.grpEnable.TabIndex = 7;
            // 
            // EntryProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 212);
            this.Controls.Add(this.grpEnable);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EntryProduct";
            this.Text = "製品登録";
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtVersion, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.grpStatus, 0);
            this.Controls.SetChildIndex(this.grpEnable, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtVersion;
        private Infrastructure.TextBoxEx txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private Infrastructure.RadioButtonPanel grpStatus;
        private Infrastructure.ServiceRadioButton serviceRadioButton1;
        private Infrastructure.ProductRadioButton productRadioButton1;
        private Infrastructure.EnableRadioButtons grpEnable;
    }
}