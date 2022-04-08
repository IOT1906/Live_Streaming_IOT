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
    public class ShowcaseLiveServices : ApplicationService, ShowcaseInterface
    {
        private readonly IRepository<Showcase, Guid> repository;

        public ShowcaseLiveServices(IRepository<Showcase, Guid> repository)
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
        [Route("api/ShowcaseAdd")]
        public async Task<int> ShowcaseAdd(Showcase ljq)
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
        [Route("api/ShowcaseDelete")]
        public async Task ShowcaseDelete(Guid id)
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
        [Route("api/ShowcaseGetFind")]
        public Task<Showcase> ShowcaseGetFind(Guid ids)
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
        [Route("api/ShowcaseListShow")]
        public Task<List<Showcase>> ShowcaseListShow()
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
        [Route("api/ShowcaseUpd")]
        public async Task<Guid> ShowcaseUpd(ProductDTo.ShowcaseDTO db)
        {
            var sit = ObjectMapper.Map<ShowcaseDTO, Showcase>(db);
            var liu = await repository.UpdateAsync(sit);
            return liu.Id;
        }
    }
}
