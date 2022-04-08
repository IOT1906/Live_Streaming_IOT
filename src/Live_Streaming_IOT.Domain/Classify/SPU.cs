using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Streaming_IOT.Classify
{
    /// <summary>
    /// 款式信息
    /// </summary>
    public class SPU: Volo.Abp.Domain.Entities.Auditing.AuditedEntity<Guid>
    {
        
        /// <summary>
        /// 商品名称
        /// </summary>
        public string  ProductName { get; set; }
        /// <summary>
        /// 商品品牌
        /// </summary>
        public string  ProductBrand { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        public string Supplier  { get; set; }
        /// <summary>
        /// 所属分类
        /// </summary>
        public string  ProductBelong { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int  ProductNum { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public int ProductNumber { get; set; }
        /// <summary>
        /// 市场价
        /// </summary>
        public decimal ProductPrice { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        public decimal ProdictMarket { get; set; }
        /// <summary>
        /// 是否上下架
        /// </summary>
        public string  ProductHight { get; set; }
        /// <summary>
        /// 是否推荐
        /// </summary>
        public string ProdictRecommend { get; set; }
        /// <summary>
        /// 是否赠品
        /// </summary>
        public string  ProductGift { get; set; }
        /// <summary>
        /// 是否直播福利商品
        /// </summary>
        public string ProductWelfare { get; set; }
        /// <summary>
        /// 商品模型
        /// </summary>
        public string ProductModel  { get; set; }
        /// <summary>
        /// 商品参数
        /// </summary>
        public string ProductParameter { get; set; }
        /// <summary>
        /// 产品标签
        /// </summary>
        public string ProductLabel { get; set; }

    }
}
