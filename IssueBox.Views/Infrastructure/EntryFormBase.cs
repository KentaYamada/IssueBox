using System;
using System.Linq;
using System.Windows.Forms;

namespace IssueBox.Views.Infrastructure
{
    public partial class EntryFormBase : Form
    {
        public EntryFormBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「戻る」ボタンクリックイベント
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// Model⇔Controlバインドクリア
        /// </summary>
        /// <param name="controls">Formに配置したコントロール</param>
        protected void ClearBindings(Control.ControlCollection controls)
        {
            controls.OfType<Control>()
                    .ToList()
                    .ForEach(x => x.DataBindings.Clear());
        }
    }
}
