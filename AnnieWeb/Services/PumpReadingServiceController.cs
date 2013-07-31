using BitworkSystem.Annie.BLL.Contract;
using BitworkSystem.Annie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnnieWeb.Services
{
    public class PumpReadingServiceController : ApiController
    {
        IManager<Pump> PumpManager;
        IManager<PumpReading> PumpReadingManager;
        IManager<PumpSale> PumpSaleManager;
        IManager<Fluid> FluidManager;

      public PumpReadingServiceController(IManager<Pump> PumpManager, IManager<PumpReading> PumpReadingManager, IManager<PumpSale> PumpSaleManager, IManager<Fluid> FluidManager)
      {
          this.PumpManager = PumpManager;
          this.PumpReadingManager = PumpReadingManager;
          this.PumpSaleManager = PumpSaleManager;
          this.FluidManager = FluidManager;
      }
        // GET api/pumpreading
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/pumpreading/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/pumpreading
        public void Post([FromBody]string value)
        {
        }

        // PUT api/pumpreading/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/pumpreading/5
        public void Delete(int id)
        {
        }
    }
}
