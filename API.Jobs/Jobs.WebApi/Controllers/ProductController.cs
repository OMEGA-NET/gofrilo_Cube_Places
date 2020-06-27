using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jobs.Data.Contracts;
using Jobs.Data.Repository;
using Jobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jobs.WebApi.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IDataOriginRepository _dataOriginRepository;

        public ProductController(IDataOriginRepository dataOriginRepository)
        {
            _dataOriginRepository = dataOriginRepository;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            try
            {
                return await  _dataOriginRepository.ReadProducts();
                //return await cr.ReadProductsFromJson();
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
