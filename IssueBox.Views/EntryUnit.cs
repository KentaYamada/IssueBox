using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// 単位設定画面
    /// </summary>
    public partial class EntryUnit : EntryFormBase
    {
        private Unit _unit;

        #region Constructors

        public EntryUnit()
            :this(new Unit())
        { }

        public EntryUnit(Unit unit)
        {
            InitializeComponent();

            this._unit = unit;

            //基底クラスで実装したコールバック関数でイベントフック
            this.Load += base.Form_Load;
            this.btnSave.Click += base.RegisterButton_Click;
        }

        #endregion

        /// <summary>
        /// 初期設定
        /// </summary>
        protected override void Initialize()
        {
            base.ClearBindings(this.Controls);
            this.txtName.DataBindings.Add("Text", this._unit, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._unit, "EnableFlag");
            this.txtName.Focus();
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        protected override bool Validation()
        {
            this.errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                this.errorProvider1.SetError(this.txtName, this.txtName.AlertMessage);
                this.txtName.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 登録処理
        /// </summary>
        protected override bool Register()
        {
            bool result = false;

            try
            {
                result = this._unit.Save();
            }
            catch
            {
                throw;
            }

            return result;
        }
    }
}
