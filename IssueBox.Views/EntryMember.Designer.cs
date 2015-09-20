namespace IssueBox.Views
{
    partial class EntryMember
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new IssueBox.Views.Infrastructure.TextBoxEx();
            this.txtLoginPW = new IssueBox.Views.Infrastructure.TextBoxEx();
            this.txtLoginID = new IssueBox.Views.Infrastructure.TextBoxEx();
            this.grpEnable = new IssueBox.Views.Infrastructure.EnableRadioButtons();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "ログインID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "パスワード";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 120);
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
            // txtName
            // 
            this.txtName.AlertMessage = "必須入力です。";
            this.txtName.Location = new System.Drawing.Point(94, 21);
            this.txtName.Name = "txtName";
            this.txtName.Required = true;
            this.txtName.Size = new System.Drawing.Size(171, 27);
            this.txtName.TabIndex = 1;
            // 
            // txtLoginPW
            // 
            this.txtLoginPW.AlertMessage = "必須入力です。";
            this.txtLoginPW.Location = new System.Drawing.Point(94, 85);
            this.txtLoginPW.Name = "txtLoginPW";
            this.txtLoginPW.PasswordChar = '*';
            this.txtLoginPW.Required = true;
            this.txtLoginPW.Size = new System.Drawing.Size(121, 27);
            this.txtLoginPW.TabIndex = 5;
            // 
            // txtLoginID
            // 
            this.txtLoginID.AlertMessage = "必須入力です。";
            this.txtLoginID.Location = new System.Drawing.Point(94, 54);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Required = true;
            this.txtLoginID.Size = new System.Drawing.Size(121, 27);
            this.txtLoginID.TabIndex = 3;
            // 
            // grpEnable
            // 
            this.grpEnable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpEnable.Enable = true;
            this.grpEnable.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpEnable.Location = new System.Drawing.Point(93, 120);
            this.grpEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnable.Name = "grpEnable";
            this.grpEnable.Size = new System.Drawing.Size(117, 28);
            this.grpEnable.TabIndex = 7;
            // 
            // EntryMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 212);
            this.Controls.Add(this.grpEnable);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLoginPW);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "EntryMember";
            this.Text = "メンバー設定";
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtLoginID, 0);
            this.Controls.SetChildIndex(this.txtLoginPW, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.grpEnable, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Infrastructure.TextBoxEx txtLoginID;
        private Infrastructure.TextBoxEx txtLoginPW;
        private Infrastructure.TextBoxEx txtName;
        private System.Windows.Forms.Button btnSave;
        private Infrastructure.EnableRadioButtons grpEnable;
    }
}