using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZFine.Domain._03_Entity.FinaceManage
{
    [Table("Sys_Area")]
    /// <summary>
    /// 固定资产
    /// </summary>
    public class FixedAssets : IEntity<FixedAssets>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        [Key]
        public string F_Id { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string F_FullName { get; set; }
        /// <summary>
        /// 资产数量
        /// </summary>
        public string F_Num { get; set; }
        /// <summary>
        /// 资产金额
        /// </summary>
        public string F_Amount { get; set; }
        /// <summary>
        /// 登记人
        /// </summary>
        public string F_Registrant { get; set; }
        /// <summary>
        /// 使用部门
        /// </summary>
        public string F_UseDept { get; set; }
        /// <summary>
        /// 资产图片
        /// </summary>
        public string AssetImageUrl { get; set; }
        /// <summary>
        /// 作废标志
        /// </summary>
        public bool? F_CancelMark { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
        public DateTime? F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }
        public bool? F_DeleteMark { get; set; }
    }
}
