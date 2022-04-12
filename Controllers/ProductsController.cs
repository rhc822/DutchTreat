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
    public class ProductsController : Controller
    {
        private readonly IDutchRepository _repository;
        private readonly ILogger<ProductsController> _logger;
        public ProductsController(IDutchRepository repository, ILogger<ProductsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<Product> Get()
        //{
        //    try
        //    {
        //        return _repository.GetAllProducts().ToList().FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Failed to get products: {ex}");
        //        return null;
        //    }
        //}

        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                //throw new Exception();
                return Json(_repository.GetAllProducts().ToList().FirstOrDefault());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get products: {ex}");
                return Json("Bad request");
            }
        }

    }
}
