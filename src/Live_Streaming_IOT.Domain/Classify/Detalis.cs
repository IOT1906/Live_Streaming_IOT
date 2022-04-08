using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Streaming_IOT.Classify
{
    /// <summary>
    /// 详情表
    /// </summary>
    public class Detalis: Volo.Abp.Domain.Entities.Auditing.AuditedEntity<Guid>
    {
       
        /// <summary>
        /// 商品图片
        /// </summary>
        public string  DetailsImg { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public decimal DetailPrice { get; set; }
        /// <summary>
        /// 商品标题
        /// </summary>
        public string  DetailTitle { get; set; }


    }
}
