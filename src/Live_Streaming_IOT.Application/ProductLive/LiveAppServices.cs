using Live_Streaming_IOT.Product_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Live_Streaming_IOT.ProductLive
{
    public class LiveAppServices : ApplicationService
    {
        private readonly IRepository<TbCommodityType, Guid> db;

        public LiveAppServices(IRepository<TbCommodityType, Guid> db)
        {
            this.db = db;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="CommodTypeAlias"></param>
        /// <param name="CommodTypeName"></param>
        /// <param name="CommodTypeOrder"></param>
        /// <param name="CommodTypeDisplay"></param>
        /// <param name="CommodTypeId"></param>
        /// <returns></returns>
        public async Task<TbCommodityType> ProductAdd(string CommodTypeAlias, string CommodTypeName, int CommodTypeOrder, int CommodTypeDisplay, int CommodTypeId)
        {
            var items = await db.InsertAsync(new TbCommodityType { CommodTypeAlias = CommodTypeAlias, CommodTypeName = CommodTypeName, CommodTypeOrder = CommodTypeOrder, CommodTypeDisplay = CommodTypeDisplay, CommodTypeId = CommodTypeId });
            return new TbCommodityType
            {
                CommodTypeAlias = items.CommodTypeAlias,
                CommodTypeName = items.CommodTypeName,
                CommodTypeOrder = items.CommodTypeOrder,
                CommodTypeDisplay = items.CommodTypeDisplay,
                CommodTypeId = items.CommodTypeId

            };
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(Guid id)
        {
            await db.DeleteAsync(id);
        }


    }
}
