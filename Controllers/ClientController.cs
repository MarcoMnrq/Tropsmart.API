using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TropsmartAPI.Services;
using TropsmartAPI.Domain.Services;
using TropsmartAPI.Domain.Models;

namespace Supermarket.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private ILogger _logger;
        private IClientService _service;


        public ProductsController(ILogger<ProductsController> logger, IClientService service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/client")]
        public ActionResult<List<Client>> GetClients()
        {
            return _service.GetClients();
        }

        [HttpPost("/api/client")]
        public ActionResult<Client> AddClient(Client client)
        {
            _service.AddClient(client);
            return client;
        }

        [HttpPut("/api/client/{id}")]
        public ActionResult<Client> UpdateProduct(int id, Client client)
        {
            _service.UpdateClient(id, client);
            return client;
        }

        [HttpDelete("/api/client/{id}")]
        public ActionResult<int> DeleteClient(int id)
        {
            _service.DeleteClient(id);
            //_logger.LogInformation("products", _products);
            return id;
        }
    }
}
