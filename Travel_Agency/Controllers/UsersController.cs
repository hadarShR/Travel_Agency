using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Agency.Models;

namespace Travel_Agency.Controllers
{
    public class UsersController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp(Users user)
        {
            if (ModelState.IsValid)
            {
                return View("ShowUserDetails", user);
            }
            return View("SignUp", user);  
        }
        public ActionResult ShowUserDetails(Users user)
        {
            return View("ShowUserDetails", user);
        }
    }
}