using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{

    // {"nome": "Pedro", "data": new DateTime() ,"telefone": "(22)873264", "cor":"gray"}
    public class ContatoModel
    {
        public string nome { get; set; }
        public string data { get; set; }
        public string telefone { get; set; }
        public string cor { get; set; }
    }
}