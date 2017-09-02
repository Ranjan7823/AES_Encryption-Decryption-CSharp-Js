using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEncrypandDecryp.Models;
using ClientsideEncryption;

namespace MvcEncrypandDecryp.Controllers
{
    public class UserloginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Userlogin objUL )
        {
            if (ModelState.IsValid)
            {
                var username = AESEncrytDecry.DecryptStringAES(objUL.HDUser);
                var password = AESEncrytDecry.DecryptStringAES(objUL.HDpass);

                if (username == "keyError" && password == "keyError")
                {
                    TempData["notice"] = "Invalid  Login";
                }
                else
                {
                    TempData["notice"] = "login successfully";
                }
                return View(objUL);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid  Login");
                return View(objUL);
            }
        }

    }
}
