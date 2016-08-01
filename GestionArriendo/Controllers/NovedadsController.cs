using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestionArriendo.Models;

namespace GestionArriendo.Controllers
{
    public class NovedadsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Novedads
        public ActionResult Index()
        {
            return View(db.Novedads.ToList());
        }

        // GET: Novedads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novedad novedad = db.Novedads.Find(id);
            if (novedad == null)
            {
                return HttpNotFound();
            }
            return View(novedad);
        }

        // GET: Novedads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Novedads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descripcion,Tipo")] Novedad novedad)
        {
            if (ModelState.IsValid)
            {
                db.Novedads.Add(novedad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(novedad);
        }

        // GET: Novedads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novedad novedad = db.Novedads.Find(id);
            if (novedad == null)
            {
                return HttpNotFound();
            }
            return View(novedad);
        }

        // POST: Novedads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descripcion,Tipo")] Novedad novedad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(novedad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(novedad);
        }

        // GET: Novedads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novedad novedad = db.Novedads.Find(id);
            if (novedad == null)
            {
                return HttpNotFound();
            }
            return View(novedad);
        }

        // POST: Novedads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Novedad novedad = db.Novedads.Find(id);
            db.Novedads.Remove(novedad);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
