using System.Collections.Generic;

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

        /// <summary>日射/気温可否</summary>
        public bool IrrTempFlag { get; set; }

        #region Default constructor

        public EquipmentConfiguration()
        {
            this.ProjectID = 0;
            this.MakerName = "";
            this.EquipName = "";
            this.Rating = 0;
            this.UnitCount = 0;
            this.IrrTempFlag = true;
        }

        #endregion

        /// <summary>
        /// 機器構成情報削除
        /// </summary>
        /// <returns></returns>
        public bool DeleteEquipmentConfiguration()
        {
            return ModelBase._db.Execute("Exec DeleteEquipmentConfigurationBy @ID", this) > 0 ? true : false;
        }

        /// <summary>
        /// 機器構成情報取得
        /// </summary>
        /// <param name="projectID">案件ID</param>
        /// <returns>案件に紐づく機器構成情報</returns>
        public static List<EquipmentConfiguration> FindEquipmentConfigurationBy(int projectID)
        {
            return ModelBase._db.ReadAny<EquipmentConfiguration, EquipmentConfiguration>("Exec FindEquipmentConfigurationBy @ProjectID", new EquipmentConfiguration() { ProjectID = projectID });
        }
    }
}
