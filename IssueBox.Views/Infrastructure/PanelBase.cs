using System.ComponentModel;
using System.Windows.Forms;

namespace IssueBox.Views.Infrastructure
{
    [Browsable(false)]
    public partial class PanelBase : UserControl
    {
        private ErrorProvider _error = null;

        [Description("エラー表示するアイコン")]
        protected ErrorProvider ErrorIcon 
        {
            get
            {
                if (this._error == null)
                {
                    this._error = new ErrorProvider() { BlinkStyle = ErrorBlinkStyle.NeverBlink };
                    this._error.ContainerControl = this;
                }

                return this._error;
            } 
        }

        public PanelBase()
        {
            InitializeComponent();
        }
    }
}
