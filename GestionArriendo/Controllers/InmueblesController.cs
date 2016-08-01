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
    public class InmueblesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Inmuebles
        public ActionResult Index()
        {
            return View(db.Inmuebles.ToList());
        }

        // GET: Inmuebles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inmueble inmueble = db.Inmuebles.Find(id);
            if (inmueble == null)
            {
                return HttpNotFound();
            }
            return View(inmueble);
        }

        // GET: Inmuebles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inmuebles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Direccion,Telefono,MyProperty,Tipo,BañosComunes,Area,Estrato,Precio,Patio,Parqueadero,Lavadero,Comedor,SalaComedor,Sala")] Inmueble inmueble)
        {
            if (ModelState.IsValid)
            {
                db.Inmuebles.Add(inmueble);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inmueble);
        }

        // GET: Inmuebles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inmueble inmueble = db.Inmuebles.Find(id);
            if (inmueble == null)
            {
                return HttpNotFound();
            }
            return View(inmueble);
        }

        // POST: Inmuebles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Direccion,Telefono,MyProperty,Tipo,BañosComunes,Area,Estrato,Precio,Patio,Parqueadero,Lavadero,Comedor,SalaComedor,Sala")] Inmueble inmueble)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inmueble).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inmueble);
        }

        // GET: Inmuebles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inmueble inmueble = db.Inmuebles.Find(id);
            if (inmueble == null)
            {
                return HttpNotFound();
            }
            return View(inmueble);
        }

        // POST: Inmuebles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inmueble inmueble = db.Inmuebles.Find(id);
            db.Inmuebles.Remove(inmueble);
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
