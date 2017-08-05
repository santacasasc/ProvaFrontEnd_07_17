using ProvaFrontEnd_07_17.Models;
using ProvaFrontEnd_07_17.Models.Noticias;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProvaFrontEnd_07_17.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Noticias
        public async Task<ActionResult> Index()
        {
            var noticias = db.Noticias.Include(n => n.Categoria).Include(m => m.Itens);
            return View(await noticias.ToListAsync());
        }

        public async Task<ActionResult> Modal()
        {
            var noticias = db.Noticias.Include(n => n.Categoria).Include(m => m.Itens);
            return View(await noticias.ToListAsync());
        }

        public async Task<JsonResult> VisualizarModal(int id)
        {

            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;

            Noticia noticia = await db.Noticias.Include(n => n.Categoria).Include(n => n.Itens).Where(n => n.Id == id).FirstOrDefaultAsync();

            return Json(noticia, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> Visualizar(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Noticia noticia = await db.Noticias.Where(m => m.URL == id).FirstOrDefaultAsync();
            if (noticia == null)
            {
                return HttpNotFound();
            }
            return View(noticia);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
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