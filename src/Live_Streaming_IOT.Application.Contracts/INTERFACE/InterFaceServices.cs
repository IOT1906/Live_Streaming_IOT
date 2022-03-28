using Live_Streaming_IOT.Product_List;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Live_Streaming_IOT.INTERFACE
{
    public interface  InterFaceServices: IApplicationService
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        Task<TbCommodityType> GetListShow();
        /// <summary>
        /// 条件
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        Task<TbCommodityType> CreateAdd(string CommodTypeAlias,string CommodTypeName, int CommodTypeOrder, int CommodTypeDisplay, int CommodTypeId);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Delete(int id);


    }
}
