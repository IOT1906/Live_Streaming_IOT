using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Streaming_IOT.Brand
{
    /// <summary>
    /// 品牌管理表
    /// </summary>
    public class Brand_List:Volo.Abp.Domain.Entities.Auditing.AuditedEntity<Guid>
    {
        
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string  BrandName { get; set; }
        /// <summary>
        /// 品牌Logo
        /// </summary>
        public string  BrandLogo { get; set; }
        /// <summary>
        /// 品牌网站
        /// </summary>
        public string  BrandWebsite { get; set; }
        /// <summary>
        /// 品牌描述
        /// </summary>
        public string  Branddescription { get; set; }
        /// <summary>
        /// 品牌排序
        /// </summary>
        public int BrandSort { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
        public string  BrandShow { get; set; }

    }
}
