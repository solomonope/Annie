using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnnieWeb.Services
{
    public class TankServiceController : ApiController
    {
        // GET api/tankservice
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/tankservice/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/tankservice
        public void Post([FromBody]string value)
        {
        }

        // PUT api/tankservice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/tankservice/5
        public void Delete(int id)
        {
        }
    }
}
