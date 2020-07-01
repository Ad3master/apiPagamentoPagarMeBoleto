using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VirtualMarket.apiPagamentoBoletoPagarMe.Entidades
{
    public class BaseClass
    {

        public string defaultEncryptionKey { get; set; }

        public string api_key { get; set; }

        [Required]
        public string versaoAPI { get; set; }
    }
}
