using BitworkSystem.Annie.BLL.Contract;
using BitworkSystem.Annie.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnnieWeb.Controllers
{
    public class BusinessDayController : Controller
    {
        private IManager<BusinessDay> Manager;

        public BusinessDayController(IManager<BusinessDay> Manager){

            this.Manager = Manager;
        }
        //
        // GET: /BusinessDay/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /BusinessDay/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /BusinessDay/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BusinessDay/Create

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
        // GET: /BusinessDay/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /BusinessDay/Edit/5

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
        // GET: /BusinessDay/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /BusinessDay/Delete/5

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
