using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Streaming_IOT.Classify
{
    /// <summary>
    /// 分类表
    /// </summary>
    public class Category_listings: Volo.Abp.Domain.Entities.Auditing.AuditedEntity<Guid>
    {
    
        /// <summary>
        /// 分类名称
        /// </summary>
        public string  CName { get; set; }
        /// <summary>
        /// 上级分类
        /// </summary>
        public string  Categret { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

    }
}
