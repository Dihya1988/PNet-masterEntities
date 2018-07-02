using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace P.WebApi.Controllers
{
    public class FiscalPowerController : ApiController
    {
        // GET: api/FiscalPower
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/FiscalPower/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FiscalPower
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/FiscalPower/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FiscalPower/5
        public void Delete(int id)
        {
        }
    }
}
