using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VirtualMarket.apiPagamentoBoletoPagarMe.Controller
{
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("ApiPagamentoBoletoPagarme OK");
        }
    }
}
