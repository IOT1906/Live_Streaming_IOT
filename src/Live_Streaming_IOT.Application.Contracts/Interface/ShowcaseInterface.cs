using Live_Streaming_IOT.Classify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using static Live_Streaming_IOT.DTO.ProductDTo;

namespace Live_Streaming_IOT.Interface
{
    public interface ShowcaseInterface: IApplicationService
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        Task<List<Showcase>> ShowcaseListShow();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        Task<int> ShowcaseAdd(Showcase ljq);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task ShowcaseDelete(Guid id);
        /// <summary>
        /// 详情反填
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<Showcase> ShowcaseGetFind(Guid ids);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        Task<Guid> ShowcaseUpd(ShowcaseDTO db);
    }
}
