using NAC.Context;
using NAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAC.Controllers
{
    public class NotaController : Controller
    {
        // GET: Nota
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Lista()
        {
            return View(new Db().GetNotas());
        }

        [HttpPost]
        public ActionResult Create(Nota nota)
        {

            if (!ModelState.IsValid)
            {
                return View(nota);
            }
            new Db().Insert(nota);

            return RedirectToAction("Lista");
        }

        public ActionResult Edit(int? Rm)
        {
            var db = new Db();

            var nota  = db.GetNotaByRm(Rm);

            if(nota == null)
            {
                return RedirectToAction("Lista");
            }
            return View(nota);
        }

        [HttpPost]
        public ActionResult Edit(Nota nota, int? Rm)
        {
            var db = new Db();

            db.Update(nota, Rm);

            return RedirectToAction("Lista");
        }

        public ActionResult Delete(int? Rm)
        {
            var db = new Db();

            if(Rm == null)
            {
                return RedirectToAction("Lista");
            }

            Nota nota = db.GetNotaByRm(Rm);


            if(nota == null)
            {
                return RedirectToAction("Lista");
            }

            db.Remove(nota);

            return RedirectToAction("Lista");
        }
    }
}