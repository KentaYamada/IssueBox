namespace IssueBox.Views.Infrastructure
{
    partial class EnableRadioButtons
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
            this.rdoDisable = new System.Windows.Forms.RadioButton();
            this.rdoEnable = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdoDisable
            // 
            this.rdoDisable.AutoSize = true;
            this.rdoDisable.Location = new System.Drawing.Point(58, 2);
            this.rdoDisable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoDisable.Name = "rdoDisable";
            this.rdoDisable.Size = new System.Drawing.Size(53, 24);
            this.rdoDisable.TabIndex = 3;
            this.rdoDisable.TabStop = true;
            this.rdoDisable.Text = "無効";
            this.rdoDisable.UseVisualStyleBackColor = true;
            // 
            // rdoEnable
            // 
            this.rdoEnable.AutoSize = true;
            this.rdoEnable.Location = new System.Drawing.Point(2, 2);
            this.rdoEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoEnable.Name = "rdoEnable";
            this.rdoEnable.Size = new System.Drawing.Size(53, 24);
            this.rdoEnable.TabIndex = 2;
            this.rdoEnable.TabStop = true;
            this.rdoEnable.Text = "有効";
            this.rdoEnable.UseVisualStyleBackColor = true;
            // 
            // EnableRadioButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rdoDisable);
            this.Controls.Add(this.rdoEnable);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EnableRadioButtons";
            this.Size = new System.Drawing.Size(117, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoDisable;
        private System.Windows.Forms.RadioButton rdoEnable;
    }
}
