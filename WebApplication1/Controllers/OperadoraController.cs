using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OperadoraController : ApiController
    {
        // GET: api/Operadora
        public List<OperadoraModel> Get()
        {

            return new List<OperadoraModel>()
                {
                    new OperadoraModel { nome = "Vivo", codigo = 22, preco = 23 },
                    new OperadoraModel { nome = "Claro", codigo = 34, preco = 56 },
                    new OperadoraModel { nome = "Tim", codigo = 12, preco = 78 }
                };
            //);

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
