using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RzLibCore;
using VirtualMarket.apiPagamentoBoletoPagarMe.BLL;
using VirtualMarket.apiPagamentoBoletoPagarMe.Entidades;

namespace VirtualMarket.apiPagamentoBoletoPagarMe.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class PagamentoBoletoController : ControllerBase
    {
        [HttpPost("CadastraPagamentoBoleto")]
        [Authorize]
        public ActionResult<RzJsonResultModel> CadastraPagamentoBoleto(TransacaoBoleto pagamentoBoleto)
        {
            if (Convert.ToInt32(pagamentoBoleto.versaoAPI) >= Constants.VersaoMinimaSuportada)
            {
                TransacaoBoletoBLL transacaoBoletoBLL = new TransacaoBoletoBLL();

                return Ok(transacaoBoletoBLL.CadastraPagamentoBoleto(pagamentoBoleto));
            }
            else
            {
                return Ok(RzJsonResultModel.ReturnError("Versão informada menor que a esperada!"));
            }
        }
    }
}
