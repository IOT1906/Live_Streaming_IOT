using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Streaming_IOT.Classify
{
    /// <summary>
    /// 橱窗图
    /// </summary>
    public class Showcase: Volo.Abp.Domain.Entities.Auditing.AuditedEntity<Guid>
    {
      
        /// <summary>
        /// 主图
        /// </summary>
        public string  ShowcaseMap { get; set; }
        /// <summary>
        /// 预览
        /// </summary>
        public string  Preview { get; set; }
        /// <summary>
        /// 图片链接
        /// </summary>
        public string  Imagelinks { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public string  ShowCaseSort { get; set; }
    }
}
