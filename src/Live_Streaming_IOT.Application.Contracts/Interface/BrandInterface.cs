using Live_Streaming_IOT.Brand;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using static Live_Streaming_IOT.DTO.ProductDTo;

namespace Live_Streaming_IOT.INTERFACE
{
    public interface  BrandInterface: IApplicationService
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        Task<List<Brand_List>> BrandListShow();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        Task<int> BrandAdd(Brand_List ljq);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task BrandDelete(Guid id);
        /// <summary>
        /// 详情反填
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<Brand_List> BrandGetFind(Guid ids);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        Task<Guid> BrandUpd(Brand_ListDTO db);
    }
}
