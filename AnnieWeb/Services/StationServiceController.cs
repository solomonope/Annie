﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnnieWeb.Services
{
    public class StationServiceController : ApiController
    {
        // GET api/stationservice
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/stationservice/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/stationservice
        public void Post([FromBody]string value)
        {
        }

        // PUT api/stationservice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/stationservice/5
        public void Delete(int id)
        {
        }
    }
}
