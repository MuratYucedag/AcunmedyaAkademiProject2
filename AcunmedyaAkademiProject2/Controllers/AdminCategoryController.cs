using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiProject2.Entities;
using AcunmedyaAkademiProject2.Context;

namespace AcunmedyaAkademiProject2.Controllers
{
    public class AdminCategoryController : Controller
    {
        SweetContext context = new SweetContext();

        [Authorize]
        public ActionResult CategoryList()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
    }
}