namespace IssueBox.Views.Infrastructure
{
    partial class StatusRadioButtons
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
            this.originationRadioButton1 = new IssueBox.Views.Infrastructure.OriginationRadioButton();
            this.responcingRadioButton1 = new IssueBox.Views.Infrastructure.ResponcingRadioButton();
            this.checkingRadioButton1 = new IssueBox.Views.Infrastructure.CheckingRadioButton();
            this.doneRadioButton1 = new IssueBox.Views.Infrastructure.DoneRadioButton();
            this.SuspendLayout();
            // 
            // originationRadioButton1
            // 
            this.originationRadioButton1.AutoSize = true;
            this.originationRadioButton1.Checked = true;
            this.originationRadioButton1.Location = new System.Drawing.Point(3, 3);
            this.originationRadioButton1.Name = "originationRadioButton1";
            this.originationRadioButton1.Size = new System.Drawing.Size(53, 24);
            this.originationRadioButton1.TabIndex = 0;
            this.originationRadioButton1.TabStop = true;
            this.originationRadioButton1.Text = "起票";
            this.originationRadioButton1.UseVisualStyleBackColor = true;
            // 
            // responcingRadioButton1
            // 
            this.responcingRadioButton1.AutoSize = true;
            this.responcingRadioButton1.Location = new System.Drawing.Point(62, 3);
            this.responcingRadioButton1.Name = "responcingRadioButton1";
            this.responcingRadioButton1.Size = new System.Drawing.Size(66, 24);
            this.responcingRadioButton1.TabIndex = 1;
            this.responcingRadioButton1.Text = "対応中";
            this.responcingRadioButton1.UseVisualStyleBackColor = true;
            // 
            // checkingRadioButton1
            // 
            this.checkingRadioButton1.AutoSize = true;
            this.checkingRadioButton1.Location = new System.Drawing.Point(134, 3);
            this.checkingRadioButton1.Name = "checkingRadioButton1";
            this.checkingRadioButton1.Size = new System.Drawing.Size(66, 24);
            this.checkingRadioButton1.TabIndex = 2;
            this.checkingRadioButton1.Text = "確認中";
            this.checkingRadioButton1.UseVisualStyleBackColor = true;
            // 
            // doneRadioButton1
            // 
            this.doneRadioButton1.AutoSize = true;
            this.doneRadioButton1.Location = new System.Drawing.Point(206, 3);
            this.doneRadioButton1.Name = "doneRadioButton1";
            this.doneRadioButton1.Size = new System.Drawing.Size(53, 24);
            this.doneRadioButton1.TabIndex = 3;
            this.doneRadioButton1.Text = "完了";
            this.doneRadioButton1.UseVisualStyleBackColor = true;
            // 
            // StatusRadioButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.doneRadioButton1);
            this.Controls.Add(this.checkingRadioButton1);
            this.Controls.Add(this.responcingRadioButton1);
            this.Controls.Add(this.originationRadioButton1);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatusRadioButtons";
            this.Size = new System.Drawing.Size(260, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OriginationRadioButton originationRadioButton1;
        private ResponcingRadioButton responcingRadioButton1;
        private CheckingRadioButton checkingRadioButton1;
        private DoneRadioButton doneRadioButton1;

    }
}
