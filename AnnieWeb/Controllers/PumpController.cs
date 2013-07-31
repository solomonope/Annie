using BitworkSystem.Annie.BLL.Contract;
using BitworkSystem.Annie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnnieWeb.Controllers
{
    public class PumpController : Controller
    {
        IManager<Pump> PumpManager;
        IManager<PumpReading> PumpReadingManager;
        IManager<PumpSale> PumpSaleManager;
        IManager<Fluid> FluidManager;
      public  PumpController(IManager<Pump> PumpManager,IManager<PumpReading> PumpReadingManager,IManager<PumpSale> PumpSaleManager,IManager<Fluid> FluidManager)
      {
          this.PumpManager = PumpManager;
          this.PumpReadingManager = PumpReadingManager;
          this.PumpSaleManager = PumpSaleManager;
          this.FluidManager = FluidManager;
      }
        //
        // GET: /Pump/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Pump/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Pump/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pump/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pump/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Pump/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pump/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Pump/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
