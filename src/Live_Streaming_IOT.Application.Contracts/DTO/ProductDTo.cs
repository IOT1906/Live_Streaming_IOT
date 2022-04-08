using System;
using System.Collections.Generic;
using System.Text;

namespace Live_Streaming_IOT.DTO
{
    public class ProductDTo
    {
        /// <summary>
        /// 品牌管理表
        /// </summary>
        public class Brand_ListDTO 
        {
            public Guid Id { get; set; }
            /// <summary>
            /// 品牌名称
            /// </summary>
            public string BrandName { get; set; }
            /// <summary>
            /// 品牌Logo
            /// </summary>
            public string BrandLogo { get; set; }
            /// <summary>
            /// 品牌网站
            /// </summary>
            public string BrandWebsite { get; set; }
            /// <summary>
            /// 品牌描述
            /// </summary>
            public string Branddescription { get; set; }
            /// <summary>
            /// 品牌排序
            /// </summary>
            public int BrandSort { get; set; }
            /// <summary>
            /// 是否显示
            /// </summary>
            public string BrandShow { get; set; }

        }

        /// <summary>
        /// 分类表
        /// </summary>
        public class Category_listingsDTO 
        {
            public Guid Id { get; set; }
            /// <summary>
            /// 分类名称
            /// </summary>
            public string CName { get; set; }
            /// <summary>
            /// 上级分类
            /// </summary>
            public string Categret { get; set; }
            /// <summary>
            /// 排序
            /// </summary>
            public int Sort { get; set; }

        }
        /// <summary>
        /// 详情表
        /// </summary>
        public class DetalisDTO 
        {
            public Guid Id { get; set; }
            /// <summary>
            /// 商品图片
            /// </summary>
            public string DetailsImg { get; set; }
            /// <summary>
            /// 商品价格
            /// </summary>
            public decimal DetailPrice { get; set; }
            /// <summary>
            /// 商品标题
            /// </summary>
            public string DetailTitle { get; set; }


        }

        /// <summary>
        /// 橱窗图
        /// </summary>
        public class ShowcaseDTO
        {
            public Guid Id { get; set; }
            /// <summary>
            /// 主图
            /// </summary>
            public string ShowcaseMap { get; set; }
            /// <summary>
            /// 预览
            /// </summary>
            public string Preview { get; set; }
            /// <summary>
            /// 图片链接
            /// </summary>
            public string Imagelinks { get; set; }
            /// <summary>
            /// 排序
            /// </summary>
            public string ShowCaseSort { get; set; }
        }

        /// <summary>
        /// 规格信息
        /// </summary>
        public class SKUDTO
        {
            public Guid Id { get; set; }

            /// <summary>
            /// 颜色
            /// </summary>
            public string SKUColor { get; set; }
            /// <summary>
            /// 批量填充
            /// </summary>
            public string SKUBatch { get; set; }
            /// <summary>
            /// 销售价
            /// </summary>
            public string SKUSellPrice { get; set; }
            /// <summary>
            /// 数量
            /// </summary>
            public string SKUNum { get; set; }
            /// <summary>
            /// 产品列表
            /// </summary>
            public string Productlist { get; set; }
        }
        /// <summary>
        /// 款式信息
        /// </summary>
        public class SPUDTO
        {
            public Guid Id { get; set; }
            /// <summary>
            /// 商品名称
            /// </summary>
            public string ProductName { get; set; }
            /// <summary>
            /// 商品品牌
            /// </summary>
            public string ProductBrand { get; set; }
            /// <summary>
            /// 供应商
            /// </summary>
            public string Supplier { get; set; }
            /// <summary>
            /// 所属分类
            /// </summary>
            public string ProductBelong { get; set; }
            /// <summary>
            /// 商品数量
            /// </summary>
            public int ProductNum { get; set; }
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
            public string ProductHight { get; set; }
            /// <summary>
            /// 是否推荐
            /// </summary>
            public string ProdictRecommend { get; set; }
            /// <summary>
            /// 是否赠品
            /// </summary>
            public string ProductGift { get; set; }
            /// <summary>
            /// 是否直播福利商品
            /// </summary>
            public string ProductWelfare { get; set; }
            /// <summary>
            /// 商品模型
            /// </summary>
            public string ProductModel { get; set; }
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
}
