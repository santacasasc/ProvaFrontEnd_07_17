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
    public class ItensController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Itens
        public async Task<ActionResult> Index()
        {
            var items = db.Items.Include(i => i.Layout).Include(i => i.Noticia);
            return View(await items.ToListAsync());
        }

        // GET: Itens/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = await db.Items.FindAsync(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: Itens/Create
        public ActionResult Create()
        {
            ViewBag.LayoutId = new SelectList(db.Layouts, "Id", "Nome");
            ViewBag.NoticiaId = new SelectList(db.Noticias, "Id", "Titulo");
            return View();
        }

        // POST: Itens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,NoticiaId,LayoutId,URL,Texto")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(item);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.LayoutId = new SelectList(db.Layouts, "Id", "Nome", item.LayoutId);
            ViewBag.NoticiaId = new SelectList(db.Noticias, "Id", "Titulo", item.NoticiaId);
            return View(item);
        }

        // GET: Itens/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = await db.Items.FindAsync(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            ViewBag.LayoutId = new SelectList(db.Layouts, "Id", "Nome", item.LayoutId);
            ViewBag.NoticiaId = new SelectList(db.Noticias, "Id", "Titulo", item.NoticiaId);
            return View(item);
        }

        // POST: Itens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,NoticiaId,LayoutId,URL,Texto")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.LayoutId = new SelectList(db.Layouts, "Id", "Nome", item.LayoutId);
            ViewBag.NoticiaId = new SelectList(db.Noticias, "Id", "Titulo", item.NoticiaId);
            return View(item);
        }

        // GET: Itens/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = await db.Items.FindAsync(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Itens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Item item = await db.Items.FindAsync(id);
            db.Items.Remove(item);
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
