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
    public class ArrendatariosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Arrendatarios
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

        // GET: Arrendatarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arrendatario arrendatario = db.Arrendatarios.Find(id);
            if (arrendatario == null)
            {
                return HttpNotFound();
            }
            return View(arrendatario);
        }

        // GET: Arrendatarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Arrendatarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellido,SegundoApellido,NombreUsuario,Clave,Telefono,Celular,Direccion,Edad,TipoArrendatario")] Arrendatario arrendatario)
        {
            if (ModelState.IsValid)
            {
                db.Usuarios.Add(arrendatario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arrendatario);
        }

        // GET: Arrendatarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arrendatario arrendatario = db.Arrendatarios.Find(id);
            if (arrendatario == null)
            {
                return HttpNotFound();
            }
            return View(arrendatario);
        }

        // POST: Arrendatarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellido,SegundoApellido,NombreUsuario,Clave,Telefono,Celular,Direccion,Edad,TipoArrendatario")] Arrendatario arrendatario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arrendatario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arrendatario);
        }

        // GET: Arrendatarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arrendatario arrendatario = db.Arrendatarios.Find(id);
            if (arrendatario == null)
            {
                return HttpNotFound();
            }
            return View(arrendatario);
        }

        // POST: Arrendatarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Arrendatario arrendatario = db.Arrendatarios.Find(id);
            db.Usuarios.Remove(arrendatario);
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
