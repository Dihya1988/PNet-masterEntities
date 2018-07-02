using P.Domain.Entities;
using P.Service.ServiceImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PWeb.Controllers
{
    public class FiscalPowerController : Controller
    {
        FiscalPowerService fps = new FiscalPowerService();

        // GET: FiscalPower
        public ActionResult Index()
        {
            return View();
        }

        // GET: FiscalPower/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FiscalPower/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FiscalPower/Create
        [HttpPost]
        public ActionResult Create(FiscalPower fp, HttpPostedFileBase file)
        {

            fps.Add(fp);
            fps.Commit();
            return RedirectToAction("Create");

        }

        // GET: FiscalPower/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FiscalPower/Edit/5
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

        // GET: FiscalPower/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FiscalPower/Delete/5
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
