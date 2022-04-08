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
    public interface DetalisInterface: IApplicationService
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        Task<List<Detalis>> DetalisListShow();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        Task<int> DetalisAdd(Detalis ljq);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DetalisDelete(Guid id);
        /// <summary>
        /// 详情反填
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<Detalis> DetalisGetFind(Guid ids);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        Task<Guid> DetalisUpd(DetalisDTO db);
    }
}
