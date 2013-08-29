using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularWithPartialViewViews.Controllers
{
    public class PartialsController : Controller
    {
        //
		// GET: /Partials/

		public ActionResult partialOne()
		{
			return View();
		}

		public ActionResult partialTwo()
		{
			return View();
		}

		public ActionResult partialThree()
		{
			return View();
		}

		public ActionResult partialFour()
		{
			return View();
		}

    }
}
