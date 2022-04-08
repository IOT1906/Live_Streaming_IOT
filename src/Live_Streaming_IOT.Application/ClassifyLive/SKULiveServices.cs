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
    public class SKULiveServices : ApplicationService, SKUInterface
    {
        private readonly IRepository<SKU, Guid> repository;

        public SKULiveServices(IRepository<SKU, Guid> repository)
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
        [Route("api/SKUAdd")]
        public async Task<int> SKUAdd(SKU ljq)
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
        [Route("api/SKUDelete")]
        public async Task SKUDelete(Guid id)
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
        [Route("api/SKUGetFind")]
        public Task<SKU> SKUGetFind(Guid ids)
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
        [Route("api/SKUListShow")]
        public Task<List<SKU>> SKUListShow()
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
        [Route("api/SKUUpd")]
        public async Task<Guid> SKUUpd(ProductDTo.SKUDTO db)
        {
            var sit = ObjectMapper.Map<SKUDTO, SKU>(db);
            var liu = await repository.UpdateAsync(sit);
            return liu.Id;
        }
    }
}
