using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrudelasDesafioEq2.OrderSystem.Services.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    { 

        private Dictionary<Guid, string> Clientes { get; set; }

        public ClienteController()
        {
            Clientes = new Dictionary<Guid, string>();

            Clientes.Add(Guid.NewGuid(), "Carol");

        }
  
        [HttpGet]
        public Dictionary<Guid, string> Get()
        {
            return Clientes;
        }

  

    }

}