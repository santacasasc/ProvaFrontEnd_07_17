using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProvaFrontEnd_07_17.Models;
using ProvaFrontEnd_07_17.Models.Noticias;

namespace ProvaFrontEnd_07_17.Controllers.Noticias
{
    public class LayoutsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Layouts
        public async Task<ActionResult> Index()
        {
            return View(await db.Layouts.ToListAsync());
        }

        // GET: Layouts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Layout layout = await db.Layouts.FindAsync(id);
            if (layout == null)
            {
                return HttpNotFound();
            }
            return View(layout);
        }

        // GET: Layouts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Layouts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome,Descricao")] Layout layout)
        {
            if (ModelState.IsValid)
            {
                db.Layouts.Add(layout);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(layout);
        }

        // GET: Layouts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Layout layout = await db.Layouts.FindAsync(id);
            if (layout == null)
            {
                return HttpNotFound();
            }
            return View(layout);
        }

        // POST: Layouts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nome,Descricao")] Layout layout)
        {
            if (ModelState.IsValid)
            {
                db.Entry(layout).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(layout);
        }

        // GET: Layouts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Layout layout = await db.Layouts.FindAsync(id);
            if (layout == null)
            {
                return HttpNotFound();
            }
            return View(layout);
        }

        // POST: Layouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Layout layout = await db.Layouts.FindAsync(id);
            db.Layouts.Remove(layout);
            await db.SaveChangesAsync();
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
