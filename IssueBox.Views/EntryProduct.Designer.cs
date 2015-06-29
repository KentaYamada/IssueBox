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
            this.grpEnable = new IssueBox.Views.Infrastructure.EnableRadioButtons();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "バージョン";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(92, 45);
            this.txtVersion.Mask = "__.___.__.__";
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(100, 27);
            this.txtVersion.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "データ有効";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(166, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpEnable
            // 
            this.grpEnable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpEnable.Enable = true;
            this.grpEnable.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpEnable.Location = new System.Drawing.Point(92, 82);
            this.grpEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnable.Name = "grpEnable";
            this.grpEnable.Size = new System.Drawing.Size(117, 23);
            this.grpEnable.TabIndex = 1000;
            // 
            // EntryProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 212);
            this.Controls.Add(this.grpEnable);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EntryProduct";
            this.Text = "EntryProduct";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtVersion, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.grpEnable, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private Infrastructure.EnableRadioButtons grpEnable;
    }
}