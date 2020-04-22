using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Supermarket.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TropsmartAPI.Domain.Models;
using TropsmartAPI.Domain.Services;

namespace TropsmartAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private ILogger _logger;
        private ICarrierService _service;
        public ProductsController(ILogger<ProductsController> logger, ICarrierService service)
        {
            _logger = logger;
            _service = service;

        }
        [HttpGet("/api/carrier")]
        public ActionResult<List<Carrier>> GetCarriers()
        {
            return _service.GetCarriers();
        }
        [HttpGet("/api/carrier")]
        public ActionResult<Carrier> AddCarrier(Carrier carrier)
        {
            _service.AddCarrier(carrier);
            return carrier;
        }
        [HttpPut("/api/carrier/{id}")]
        public ActionResult<Carrier> UpdateProduct(int id, Carrier carrier)
        {
            _service.UpdateCarrier(id, carrier);
            return carrier;
        }
        [HttpPut("/api/carrier/{id}")]
        public ActionResult<int> DeleteCarrier(int id)
        {
            _service.DeleteCarrier(id);
            //_logger.LogInformation("products", _products);
            return id;
        }
    }
}
