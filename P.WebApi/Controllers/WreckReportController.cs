using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace P.WebApi.Controllers
{
    public class WreckReportController : ApiController
    {
        // GET: api/WreckReport
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/WreckReport/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WreckReport
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WreckReport/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WreckReport/5
        public void Delete(int id)
        {
        }
    }
}
