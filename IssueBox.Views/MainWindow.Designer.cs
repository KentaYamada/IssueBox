namespace IssueBox.Views
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.メインメニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchMaker = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchMember = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIO = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome,
            this.メインメニューToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.menuIO,
            this.終了ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(56, 22);
            this.menuHome.Text = "ホーム";
            this.menuHome.Visible = false;
            // 
            // メインメニューToolStripMenuItem
            // 
            this.メインメニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSearchProject,
            this.menuSearchIssue});
            this.メインメニューToolStripMenuItem.Name = "メインメニューToolStripMenuItem";
            this.メインメニューToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.メインメニューToolStripMenuItem.Text = "メインメニュー";
            // 
            // menuSearchProject
            // 
            this.menuSearchProject.Name = "menuSearchProject";
            this.menuSearchProject.Size = new System.Drawing.Size(136, 22);
            this.menuSearchProject.Text = "案件登録";
            this.menuSearchProject.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuSearchIssue
            // 
            this.menuSearchIssue.Name = "menuSearchIssue";
            this.menuSearchIssue.Size = new System.Drawing.Size(136, 22);
            this.menuSearchIssue.Text = "タスク登録";
            this.menuSearchIssue.Click += new System.EventHandler(this.menu_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSearchProduct,
            this.menuSearchMaker,
            this.menuSearchMember,
            this.menuSearchCategory,
            this.menuSearchUnit});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // menuSearchProduct
            // 
            this.menuSearchProduct.Name = "menuSearchProduct";
            this.menuSearchProduct.Size = new System.Drawing.Size(152, 22);
            this.menuSearchProduct.Text = "製品";
            this.menuSearchProduct.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuSearchMaker
            // 
            this.menuSearchMaker.Name = "menuSearchMaker";
            this.menuSearchMaker.Size = new System.Drawing.Size(152, 22);
            this.menuSearchMaker.Text = "メーカー";
            this.menuSearchMaker.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuSearchMember
            // 
            this.menuSearchMember.Name = "menuSearchMember";
            this.menuSearchMember.Size = new System.Drawing.Size(152, 22);
            this.menuSearchMember.Text = "メンバー";
            this.menuSearchMember.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuSearchCategory
            // 
            this.menuSearchCategory.Name = "menuSearchCategory";
            this.menuSearchCategory.Size = new System.Drawing.Size(152, 22);
            this.menuSearchCategory.Text = "カテゴリ";
            this.menuSearchCategory.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuSearchUnit
            // 
            this.menuSearchUnit.Name = "menuSearchUnit";
            this.menuSearchUnit.Size = new System.Drawing.Size(152, 22);
            this.menuSearchUnit.Text = "単位";
            this.menuSearchUnit.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuIO
            // 
            this.menuIO.Name = "menuIO";
            this.menuIO.Size = new System.Drawing.Size(92, 22);
            this.menuIO.Text = "データ入出力";
            this.menuIO.Visible = false;
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.logout_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 29);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(760, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "名前どうしよう";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メインメニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem menuSearchIssue;
        private System.Windows.Forms.ToolStripMenuItem menuSearchMember;
        private System.Windows.Forms.ToolStripMenuItem menuSearchCategory;
        private System.Windows.Forms.ToolStripMenuItem menuSearchProduct;
        private System.Windows.Forms.ToolStripMenuItem menuIO;
        private System.Windows.Forms.ToolStripMenuItem menuSearchMaker;
        private System.Windows.Forms.ToolStripMenuItem menuSearchProject;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuSearchUnit;
    }
}