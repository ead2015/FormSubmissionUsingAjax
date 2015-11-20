using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmissionUsingAjax.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult SerializeExample()
        {
            return View();
        }
        [HttpPost]
        public string Save()
        {
            return "You have been Registered with following details, Name = " + Request["name"] + " Email = " + Request["email"] + " Message = " + Request["message"];
        }
    }
}
