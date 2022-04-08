using Live_Streaming_IOT.Classify;
using Live_Streaming_IOT.DTO;
using Live_Streaming_IOT.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using static Live_Streaming_IOT.DTO.ProductDTo;

namespace Live_Streaming_IOT.ClassifyLive
{
    public class SPULiveServices : ApplicationService, SPUInterface
    {
        private readonly IRepository<SPU, Guid> repository;

        public SPULiveServices(IRepository<SPU, Guid> repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="ljq"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        [Route("api/SPUAdd")]
        public async Task<int> SPUAdd(SPU ljq)
        {
            var list = await repository.InsertAsync(ljq);
            try
            {
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }

        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("api/SPUDelete")]
        public async Task SPUDelete(Guid id)
        {
            await repository.DeleteAsync(id);
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        [Route("api/SPUGetFind")]
        public Task<SPU> SPUGetFind(Guid ids)
        {
            var list = repository.FindAsync(ids);
            return list;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet]
        [Route("api/SPUListShow")]
        public Task<List<SPU>> SPUListShow()
        {
            var list = repository.GetListAsync();
            return list;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        [Route("api/SPUUpd")]
        public async Task<Guid> SPUUpd(ProductDTo.SPUDTO db)
        {
            var sit = ObjectMapper.Map<SPUDTO, SPU>(db);
            var liu = await repository.UpdateAsync(sit);
            return liu.Id;
        }
    }
}
