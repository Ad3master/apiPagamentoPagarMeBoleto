using RzLibCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using VirtualMarket.apiPagamentoBoletoPagarMe.Entidades;
using VirtualMarket.apiPagamentoCartaoPagarMe.Utils;

namespace VirtualMarket.apiPagamentoBoletoPagarMe.BLL
{
    public class TransacaoBoletoBLL
    {
        public RzJsonResultModel CadastraPagamentoBoleto(TransacaoBoleto pagamentoBoleto)
        {
            try

            {

                pagamentoBoleto.api_key = LocalConfig.Values["PagarMeAPIDefaultApiKey"];
                pagamentoBoleto.defaultEncryptionKey = LocalConfig.Values["PagarMeAPIDefaultEncryptionKey"];

                string content = JsonSerializer.Serialize(pagamentoBoleto);

                string responseText = CurlRequest.SendRequest("https://api.pagar.me/1/transactions", content, "POST");

                return RzJsonResultModel.ReturnSuccess("OK", responseText);
                //return RzJsonResultModel.ReturnSuccess("OK", "");


            }
            catch (Exception ex)
            {
                return RzJsonResultModel.ReturnError(ex.Message);
            }

        }
    }
}