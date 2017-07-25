using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS.Models;

namespace IMS.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        imsDbContext db = new imsDbContext();
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }
    }
}