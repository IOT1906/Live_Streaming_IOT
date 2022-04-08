using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Streaming_IOT.Classify
{
    /// <summary>
    /// 规格信息
    /// </summary>
    public class SKU: Volo.Abp.Domain.Entities.Auditing.AuditedEntity<Guid>
    {
       
        /// <summary>
        /// 颜色
        /// </summary>
        public string  SKUColor { get; set; }
        /// <summary>
        /// 批量填充
        /// </summary>
        public string  SKUBatch { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        public string  SKUSellPrice { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string  SKUNum { get; set; }
        /// <summary>
        /// 产品列表
        /// </summary>
        public string  Productlist { get; set; }
    }
}
