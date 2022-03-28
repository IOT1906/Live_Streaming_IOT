using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Streaming_IOT.Product_List
{
    /// <summary>
    /// 商品表
    /// </summary>
    public class TbCommodityInfo : Volo.Abp.Domain.Entities.Auditing.AuditedEntity<Guid>
    {
        /// <summary>
        /// 自增商品ID
        /// </summary>
        public int CommodityId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string  CommodityName{ get; set; }
        /// <summary>
        /// 商品副标题
        /// </summary>
        public string  CommoditySubtitle { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
        public string  CommodityDisplay { get; set; }
        /// <summary>
        /// 销售开始时间
        /// </summary>
        public DateTime CommoditySaleBegin { get; set; }
        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal CommoditySalePrice { get; set; }
        /// <summary>
        /// 促销价格
        /// </summary>
        public decimal CommodiSPromotion { get; set; }
        /// <summary>
        /// 商品详情
        /// </summary>
        public string  CommodityDetails { get; set; }
        /// <summary>
        /// 重量（KG）
        /// </summary>
        public int CommodityWeight { get; set; }
        /// <summary>
        /// 商品条形码
        /// </summary>
        public string  CommodityBarCode { get; set; }
        /// <summary>
        /// 商品详情描述（富文本编辑器填写）			
        /// </summary>
        public string  CommodityDescription { get; set; }
        /// <summary>
        /// 上架状态
        /// </summary>
        public int CommodityState { get; set; }
        /// <summary>
        /// 浏览量
        /// </summary>
        public int CommodityBorwseNum { get; set; }
        /// <summary>
        /// 销售量
        /// </summary>
        public int CommoditySaleNum { get; set; }
        /// <summary>
        /// 评价数
        /// </summary>
        public int CommodityEvaluaNum { get; set; }
        /// <summary>
        /// 商品属性
        /// </summary>
        public string  CommodityAttrName { get; set; }
        /// <summary>
        /// 信息完整度
        /// </summary>
        public int CommodityInfoIntegrity { get; set; }
        /// <summary>
        /// 商品规格ID
        /// </summary>
        public int CommodSpeciId { get; set; }
        /// <summary>
        /// 商品类型ID
        /// </summary>
        public int CommodTypeId { get; set; }
        
    }
}
