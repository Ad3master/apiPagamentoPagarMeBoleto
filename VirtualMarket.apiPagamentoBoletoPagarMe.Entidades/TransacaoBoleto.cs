using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMarket.apiPagamentoBoletoPagarMe.Entidades
{
    public class TransacaoBoleto:BaseClass
    {
        public int amount { get; set; }
        public string payment_method { get; set; }
        public Customer customer { get; set; }
        public string postback_url { get; set; }
    }
}
