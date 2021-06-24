using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web2.Controllers {
    public class AboutUsController : Controller {
        // GET: AboutUs
        public ActionResult Index() {

            Models.User u = new Models.User();

            u.FirstName = "Neina";
            u.LastName = "Cichon";
            u.Email = "NCichon@CincinnatiState.edu";

            return View(u);
        }

        [HttpPost]
        public ActionResult Index(FormCollection col) {
			try {
				Models.User u = new Models.User();
				u = u.GetMyInfo();


                if (col["btnSubmit"] == "more") { //more button pressed
                    return RedirectToAction("More");
                }
                else if (col["btnClose"] == "close") { //Close button pressed
                    return RedirectToAction("Index", "Home");
                }
                else {
                    return View(u);
                }
            }
			catch (Exception) {
				Models.User u = new Models.User();
				return View(u);
			}

        }

        // GET: More
        public ActionResult More() {

            Models.User u = new Models.User();

            u.FirstName = "Neina";
            u.LastName = "Cichon";
            u.Email = "NCichon@CincinnatiState.edu";

            return View(u);
        }

        [HttpPost]
        public ActionResult More(FormCollection col) {
            return RedirectToAction("Index");

        }
    }
}