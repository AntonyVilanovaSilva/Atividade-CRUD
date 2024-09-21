using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AtividadeCrud.Models;

namespace AtividadeCrud.Controllers
{
    public class TB_UsuarioController : Controller
    {
        private DbTarefaEntities db = new DbTarefaEntities();

        // GET: TB_Usuario
        public ActionResult Index()
        {
            return View(db.TB_Usuario.ToList());
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "IDUsu,Nome,Senha")] TB_Usuario tb_usuario)
        {
            TB_Usuario usuario= db.TB_Usuario.Where(x => x.Nome == tb_usuario.Nome &&
            x.Senha==tb_usuario.Senha).FirstOrDefault();
            if (usuario == null)
                return RedirectToAction("Login", "TB_Usuario");
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        // GET: TB_Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Usuario tB_Usuario = db.TB_Usuario.Find(id);
            if (tB_Usuario == null)
            {
                return HttpNotFound();
            }
            return View(tB_Usuario);
        }

        // GET: TB_Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TB_Usuario/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDUsu,Nome,Senha")] TB_Usuario tB_Usuario)
        {
            if (ModelState.IsValid)
            {
                db.TB_Usuario.Add(tB_Usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tB_Usuario);
        }

        // GET: TB_Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Usuario tB_Usuario = db.TB_Usuario.Find(id);
            if (tB_Usuario == null)
            {
                return HttpNotFound();
            }
            return View(tB_Usuario);
        }

        // POST: TB_Usuario/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDUsu,Nome,Senha")] TB_Usuario tB_Usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_Usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tB_Usuario);
        }

        // GET: TB_Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Usuario tB_Usuario = db.TB_Usuario.Find(id);
            if (tB_Usuario == null)
            {
                return HttpNotFound();
            }
            return View(tB_Usuario);
        }

        // POST: TB_Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Usuario tB_Usuario = db.TB_Usuario.Find(id);
            db.TB_Usuario.Remove(tB_Usuario);
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
