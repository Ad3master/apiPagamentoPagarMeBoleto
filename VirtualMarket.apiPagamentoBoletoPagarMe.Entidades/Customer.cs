using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMarket.apiPagamentoBoletoPagarMe.Entidades
{
    public class Customer
    {
        public string type { get; set; }
        public string country { get; set; }
        public string name { get; set; }
        public List<Document> documents { get; set; }

    }
}
