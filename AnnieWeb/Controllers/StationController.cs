using BitworkSystem.Annie.BLL.Contract;
using BitworkSystem.Annie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnnieWeb.Controllers
{
    public class StationController : Controller
    {

        IManager<Station> StationManager;
        public StationController(IManager<Station> StationManager)
        {
            this.StationManager = StationManager;
        }
        //
        // GET: /Station/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Station/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Station/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Station/Create

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
        // GET: /Station/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Station/Edit/5

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
        // GET: /Station/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Station/Delete/5

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
