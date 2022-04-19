using DutchTreat.Data;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IDutchRepository _repository;
        private readonly ILogger<ProductsController> _logger;
        public ProductsController(IDutchRepository repository, ILogger<ProductsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<IEnumerable<Product>> Get()
        {
            try
            {
                //throw new Exception();
                return Ok(_repository.GetAllProducts());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get products: {ex}");
                return BadRequest("Failed to get products");
            }
        }

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    try
        //    {
        //        //throw new Exception();
        //        return Ok(_repository.GetAllProducts());
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Failed to get products: {ex}");
        //        return BadRequest("Failed to get products");
        //    }
        //}


        /*
         * Return JSON; problematic if you want to use another type, too rigid
         */
        //[HttpGet]
        //public JsonResult Get()
        //{
        //    try
        //    {
        //        //throw new Exception();
        //        return Json(_repository.GetAllProducts());
        //            //.ToList().FirstOrDefault()) ;
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Failed to get products: {ex}");
        //        return Json("Bad request");
        //    }
        //}

        /*
         * Returning the pure type; problematic if you want to return anything other than all the products or nothing
         */
        //[HttpGet]
        //public IEnumerable<Product> Get()
        //{
        //    try
        //    {
        //        throw new Exception();
        //        return _repository.GetAllProducts();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Failed to get products: {ex}");
        //        return null;
        //    }
        //}
    }
}
