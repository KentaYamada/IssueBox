namespace IssueBox.Views
{
    partial class EntryIssue
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtOrigination = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtDeadLine = new IssueBox.Views.Infrastructure.DateMaskedTextBox();
            this.grpStatus = new IssueBox.Views.Infrastructure.StatusRadioButtons();
            this.cmbIssuingMember = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.cmbProject = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.cmbProduct = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.cmbCategory = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.cmbResponcedMember = new IssueBox.Views.Infrastructure.DropDownListEx();
            this.txtComment = new IssueBox.Views.Infrastructure.TextBoxEx();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 27);
            this.label11.TabIndex = 40;
            this.label11.Text = "案件";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 27);
            this.label10.TabIndex = 38;
            this.label10.Text = "期限";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(380, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 27);
            this.label9.TabIndex = 36;
            this.label9.Text = "ｖ1.0.0.0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(295, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "バージョン";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 27);
            this.label7.TabIndex = 34;
            this.label7.Text = "コメント";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 27);
            this.label6.TabIndex = 31;
            this.label6.Text = "ステータス";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "担当者";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "製品";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "カテゴリ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "起票者";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "起票日";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtOrigination
            // 
            this.dtOrigination.Location = new System.Drawing.Point(103, 9);
            this.dtOrigination.Name = "dtOrigination";
            this.dtOrigination.Size = new System.Drawing.Size(144, 27);
            this.dtOrigination.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 495);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(400, 495);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "戻る";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtDeadLine
            // 
            this.dtDeadLine.GetDate = null;
            this.dtDeadLine.Location = new System.Drawing.Point(103, 172);
            this.dtDeadLine.Mask = "0000/00/00";
            this.dtDeadLine.Name = "dtDeadLine";
            this.dtDeadLine.Size = new System.Drawing.Size(100, 27);
            this.dtDeadLine.TabIndex = 51;
            this.dtDeadLine.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // grpStatus
            // 
            this.grpStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpStatus.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpStatus.Location = new System.Drawing.Point(103, 235);
            this.grpStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.SelectedStatus = 1;
            this.grpStatus.Size = new System.Drawing.Size(260, 28);
            this.grpStatus.TabIndex = 50;
            // 
            // cmbIssuingMember
            // 
            this.cmbIssuingMember.DisplayMember = "Value";
            this.cmbIssuingMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssuingMember.FormattingEnabled = true;
            this.cmbIssuingMember.Location = new System.Drawing.Point(103, 41);
            this.cmbIssuingMember.Name = "cmbIssuingMember";
            this.cmbIssuingMember.Size = new System.Drawing.Size(186, 28);
            this.cmbIssuingMember.TabIndex = 49;
            this.cmbIssuingMember.ValueMember = "ID";
            // 
            // cmbProject
            // 
            this.cmbProject.DisplayMember = "Value";
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(103, 74);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(186, 28);
            this.cmbProject.TabIndex = 48;
            this.cmbProject.ValueMember = "ID";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DisplayMember = "Value";
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(103, 106);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(186, 28);
            this.cmbProduct.TabIndex = 46;
            this.cmbProduct.ValueMember = "ID";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DisplayMember = "Value";
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(103, 137);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(186, 28);
            this.cmbCategory.TabIndex = 45;
            this.cmbCategory.ValueMember = "ID";
            // 
            // cmbResponcedMember
            // 
            this.cmbResponcedMember.DisplayMember = "Value";
            this.cmbResponcedMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponcedMember.FormattingEnabled = true;
            this.cmbResponcedMember.Location = new System.Drawing.Point(103, 201);
            this.cmbResponcedMember.Name = "cmbResponcedMember";
            this.cmbResponcedMember.Size = new System.Drawing.Size(186, 28);
            this.cmbResponcedMember.TabIndex = 44;
            this.cmbResponcedMember.ValueMember = "ID";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(103, 271);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(372, 211);
            this.txtComment.TabIndex = 33;
            // 
            // EntryIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 536);
            this.Controls.Add(this.dtDeadLine);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.cmbIssuingMember);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbResponcedMember);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtOrigination);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EntryIssue";
            this.Text = "タスク登録";
            this.Load += new System.EventHandler(this.EntryIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Infrastructure.TextBoxEx txtComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtOrigination;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private Infrastructure.DropDownListEx cmbResponcedMember;
        private Infrastructure.DropDownListEx cmbCategory;
        private Infrastructure.DropDownListEx cmbProduct;
        private Infrastructure.DropDownListEx cmbProject;
        private Infrastructure.DropDownListEx cmbIssuingMember;
        private Infrastructure.StatusRadioButtons grpStatus;
        private Infrastructure.DateMaskedTextBox dtDeadLine;
    }
}