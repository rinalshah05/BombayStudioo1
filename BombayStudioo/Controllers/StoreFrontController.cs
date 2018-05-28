using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataObjects;

namespace BombayStudioo.Controllers
{
    public class StoreFrontController : Controller
    {
        private BombayStudiooDBEntities db = new BombayStudiooDBEntities();
        // GET: StoreFront
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            else
            {

                return View(category);
            }
            
        }
	}
}