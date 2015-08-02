using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueBox.Models
{
    /// <summary>
    /// 機器構成モデル
    /// </summary>
    public class EquipmentConfiguration : ModelBase
    {
        /// <summary>案件ID</summary>
        public int ProjectID {get; set;}

        /// <summary>メーカー名</summary>
        public string MakerName { get; set; }

        /// <summary>型番</summary>
        public string EquipName { get; set; }

        /// <summary>定格</summary>
        public decimal Rating { get; set; }

        /// <summary>台数</summary>
        public int UnitCount { get; set; }

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        /// <summary>
        /// 機器構成情報取得
        /// </summary>
        /// <param name="projectID">案件ID</param>
        /// <returns>案件に紐づく機器構成情報</returns>
        public static List<EquipmentConfiguration> FindEquipmentConfigurationBy(int projectID)
        {
            try
            {
                return ModelBase._db.FindBy<EquipmentConfiguration, Condition>("Exec FindEquipmentConfigurationBy @ProjectID", null);
            }
            catch
            {
                throw;
            }
        }
    }
}
