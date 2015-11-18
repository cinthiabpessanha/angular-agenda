using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ContatoController : ApiController
    {
        // GET: api/Contato
        public List<ContatoModel> Get()
        {
              return  new List<ContatoModel>()
                {
                    new ContatoModel { nome = "Pedro", data = DateTime.Now.ToShortDateString(), telefone = "(22)873260", cor="gray" },
                    new ContatoModel { nome = "José", data = DateTime.Now.ToShortDateString(), telefone = "(22)873261", cor="pink" },
                    new ContatoModel { nome = "Fernanda", data = DateTime.Now.ToShortDateString(), telefone = "(22)873212", cor="green" }
                };

        }

        // GET: api/Contato/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Contato
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Contato/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Contato/5
        public void Delete(int id)
        {
        }
    }
}
