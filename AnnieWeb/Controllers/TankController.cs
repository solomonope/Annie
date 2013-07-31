using BitworkSystem.Annie.BLL.Contract;
using BitworkSystem.Annie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnnieWeb.Controllers
{
    public class TankController : Controller
    {
        IManager<Tank> TankManager;
        IManager<Fluid> FluidManager;
        public TankController(IManager<Tank> TankManager,IManager<Fluid> FluidManager)
        {
            this.TankManager = TankManager;
            this.FluidManager = FluidManager;
        }
        //
        // GET: /Tank/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Tank/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Tank/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tank/Create

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
        // GET: /Tank/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Tank/Edit/5

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
        // GET: /Tank/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Tank/Delete/5

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
