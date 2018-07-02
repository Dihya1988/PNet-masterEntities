using P.Data;
using P.Domain.Entities;
using P.Service.ServiceImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace P.WebApi.Controllers
{
    public class VehicleController : ApiController
    {
        VehicleService vs = new VehicleService();
        private ContextPi db = new ContextPi();

        // GET: api/Vehicle
        public IEnumerable<Vehicle> Get()
        {
            return vs.GetAll();
        }

        // GET: api/Vehicle/5
        [ResponseType(typeof(Vehicle))]
        public IHttpActionResult Get(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return Ok(vehicle);
        }

        // POST: api/Vehicle
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Vehicle/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Vehicle/5
        public void Delete(int id)
        {
        }
    }
}
