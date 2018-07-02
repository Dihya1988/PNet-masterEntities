using P.Data;
using P.Domain.Entities;
using P.Service.ServiceImplementation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PWeb.Controllers
{
    public class WreckReportController : Controller
    {
        private ContextPi db = new ContextPi();
        VehicleService vs = new VehicleService();
        WreckReportService wrs = new WreckReportService();

        // GET: WreckReport
        public ActionResult WreckReports()
        {
            var wreckreports = wrs.GetAll();
            return View(wreckreports);
        }

        // GET: WreckReport/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WreckReport/Create
        public ActionResult Create()
        {
            var vehicles = vs.GetAll();
            ViewBag.Vehicle = new SelectList(vehicles, "IdVehicle", "Registration");
            return View();
        }

        // POST: WreckReport/Create
        [HttpPost]
        public ActionResult Create(WreckReport wr, HttpPostedFileBase file)
        {
            wrs.Add(wr);
            wrs.Commit();
            return RedirectToAction("WreckReports");
        }

        // GET: WreckReport/Edit/5
        public ActionResult Edit(int id)
        {
            var vehicles = vs.GetAll();
            ViewBag.Vehicle = new SelectList(vehicles, "IdVehicle", "Registration");

            WreckReport wreckReport = db.WReports.Find(id);
            if (wreckReport == null)
            {
                return HttpNotFound();
            }
            return View(wreckReport);
        }

        // POST: WreckReport/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WreckReport wreckreport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wreckreport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("WreckReports");
            }
            return View(wreckreport);
        }

        // GET: WreckReport/Delete/5
        public ActionResult Delete(int id)
        {
            WreckReport wreckreport = db.WReports.Find(id);
            if (wreckreport == null)
            {
                return HttpNotFound();
            }
            return View(wreckreport);
        }

        // POST: WreckReport/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WreckReport wreckreport = db.WReports.Find(id);
            db.WReports.Remove(wreckreport);
            db.SaveChanges();
            return RedirectToAction("WreckReports");
        }
    }
}
