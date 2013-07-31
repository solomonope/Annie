using AnnieWeb.Models;
using BitworkSystem.Annie.BLL.Contract;
using BitworkSystem.Annie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnnieWeb.Controllers
{
    public class FluidController : Controller
    {
        IManager<Fluid> FluidManager;
        public FluidController(IManager<Fluid> FluidManager)
        {
            this.FluidManager = FluidManager;
        }
        //
        // GET: /Fluid/

        public ActionResult Index()
        {
            return View(new List<FluidViewModel>());
        }

       

        //
        // GET: /Fluid/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Fluid/Create

        [HttpPost]
        public ActionResult Create(FluidViewModel Model)
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
        // GET: /Fluid/Edit/5

        public ActionResult Edit(string id)
        {
            return View();
        }

        //
        // POST: /Fluid/Edit/5

        [HttpPost]
        public ActionResult Edit(string id, FluidViewModel Model)
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
        // GET: /Fluid/Delete/5

        public ActionResult Delete(string id)
        {
            return View();
        }

    }
}
