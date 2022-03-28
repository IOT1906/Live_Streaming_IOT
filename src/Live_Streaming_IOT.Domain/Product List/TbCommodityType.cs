using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Streaming_IOT.Product_List
{
    /// <summary>
    /// 商品分类表
    /// </summary>
    public class TbCommodityType : Volo.Abp.Domain.Entities.Auditing.AuditedEntity<Guid>
    {
        /// <summary>
        /// 商品分类ID自增
        /// </summary>
        public int CommodTypeId { get; set; }       
        /// <summary>
        /// 别名
        /// </summary>
        public string  CommodTypeAlias { get; set; }
        /// <summary>
        /// 商品分类名称
        /// </summary>
        public string  CommodTypeName { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int CommodTypeOrder { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
        public int CommodTypeDisplay { get; set; }
    }
}
