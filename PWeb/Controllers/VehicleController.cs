using P.Data;
using P.Service.ServiceImplementation;
using P.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace PWeb.Controllers
{
    public class VehicleController : Controller
    {
        private ContextPi db = new ContextPi();
        VehicleService vs = new VehicleService();
        FiscalPowerService fps = new FiscalPowerService();
        UserServices us = new UserServices();

        // GET: Vehicle
        public ActionResult Vehicles()
        {
            var vehicles = vs.GetAll();
            return View(vehicles);
        }

        // GET: Vehicle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vehicle/Create
        public ActionResult Create()
        {
           // var users = us.GetAll();
           // ViewBag.User = new SelectList(users, "idUser", "LastName");
            var fpowers = fps.GetAll();
            ViewBag.FiscalPower = new SelectList(fpowers, "IdFiscalPower", "FPower");

            return View();
        }

        // POST: Vehicle/Create
        [HttpPost]
        public ActionResult Create(Vehicle v, HttpPostedFileBase file)
        {

            vs.Add(v);
            vs.Commit();
            return RedirectToAction("Vehicles");
        }

        // GET: Vehicle/Edit/5
        public ActionResult Edit(int id)
        {
            //var users = us.GetAll();
            //ViewBag.User = new SelectList(users, "IdUser", "Name");
            var fpowers = fps.GetAll();
            ViewBag.FiscalPower = new SelectList(fpowers, "IdFiscalPower", "FPower");


            Vehicle vehicle = db.Vehicles.Find(id);
             if (vehicle == null)
             {
                return HttpNotFound();
            }
             return View(vehicle);        
           
    }

        // POST: Vehicle/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                //vs.Update(vehicle);
                //fps.Update(fs1);
                //us.Update(us1);
                //us.Commit();
                //fps.Commit();
               // vs.Commit();
                return RedirectToAction("Vehicles");
            }
            return View(vehicle);
        }

        // GET: Vehicle/Delete/5
        public ActionResult Delete(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(vehicle);
            db.SaveChanges();
            return RedirectToAction("Vehicles");
        }
    }
}
