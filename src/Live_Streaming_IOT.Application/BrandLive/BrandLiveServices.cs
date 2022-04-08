﻿using Live_Streaming_IOT.Brand;
using Live_Streaming_IOT.DTO;
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

namespace Live_Streaming_IOT.BrandLive
{
    public class BrandLiveServices : ApplicationService, BrandInterface
    {

        private readonly IRepository<Brand_List, Guid> repository;

        public BrandLiveServices(IRepository<Brand_List, Guid> repository)
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
        [Route("api/BrandAdd")]
        public async Task<int> BrandAdd(Brand_List ljq)
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
        [Route("api/BrandDelete")]
        public async Task BrandDelete(Guid id)
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
        [Route("api/BrandGetFind")]
        public Task<Brand_List> BrandGetFind(Guid ids)
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
        [Route("api/BrandListShow")]
        public Task<List<Brand_List>> BrandListShow()
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
        [Route("api/BrandUpd")]
        public async Task<Guid> BrandUpd(ProductDTo.Brand_ListDTO db)
        {
            var sit = ObjectMapper.Map<Brand_ListDTO, Brand_List>(db);
            var liu = await repository.UpdateAsync(sit);
            return liu.Id;
        }
    }
}
