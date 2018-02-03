using garten.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace garten.Controllers
{
    [Authorize]
    public class kindergartensController : Controller
    {
        public MyDbContext Context { get; private set; }

        public kindergartensController()
        {
            this.Context = new MyDbContext();
        }
        // GET: kindergartens
        [ActionName("List")]
        public ActionResult Index()
        {
            List<kindergarten> kindergartens = this.Context.kindergartens.ToList();
            return View("Index", kindergartens);
        }

        [HttpPost]
        public ActionResult Addkindergartens(kindergarten garten)
        {
            this.Context.kindergartens.Add(garten);
            this.Context.SaveChanges();
            return RedirectToAction("List", "kindergartens");
        }

    }
}