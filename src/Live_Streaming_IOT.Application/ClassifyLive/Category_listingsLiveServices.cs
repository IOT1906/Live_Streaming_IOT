using Live_Streaming_IOT.Brand;
using Live_Streaming_IOT.Classify;
using Live_Streaming_IOT.DTO;
using Live_Streaming_IOT.Interface;
using Live_Streaming_IOT.INTERFACE;
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
    public class Category_listingsLiveServices : ApplicationService, Category_listingsinterface
    {
        private readonly IRepository<Category_listings, Guid> repository;

        public Category_listingsLiveServices(IRepository<Category_listings, Guid> repository)
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
        [Route("api/CategoryAdd")]
        public async Task<int> CategoryAdd(Category_listings ljq)
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
        [Route("api/CategoryDelete")]
        public async Task CategoryDelete(Guid id)
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
        [Route("api/CategoryGetFind")]
        public Task<Category_listings> CategoryGetFind(Guid ids)
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
        [Route("api/CategoryListShow")]
        public Task<List<Category_listings>> CategoryListShow()
        {
            var list = repository.GetListAsync();
            return list;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
       [HttpPost]
       [Route("api/CategoryUpd")]
        public async Task<Guid> CategoryUpd(ProductDTo.Category_listingsDTO db)
        {
            var sit = ObjectMapper.Map<Category_listingsDTO, Category_listings>(db);
            var liu = await repository.UpdateAsync(sit);
            return liu.Id;
        }
    }
}
