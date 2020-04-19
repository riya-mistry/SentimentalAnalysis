using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;
namespace WebApplication9.Controllers
{

    public class RegisterController : Controller
    {
        private CUSERSLENOVODOCUMENTSDBMYONLINESHOPPINGMDFContext _context;
        public RegisterController(CUSERSLENOVODOCUMENTSDBMYONLINESHOPPINGMDFContext context)
        {
            _context = context;
        }
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(TblMembers user)
        {
            if (ModelState.IsValid)
            {
                _context.TblMembers.Add(user);
                _context.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = user.FirstName + " " + user.LastName + " is successfully registered.";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(TblMembers user)
        {
            var account = _context.TblMembers.Where(u => u.EmailId == user.EmailId && u.Password == user.Password).FirstOrDefault();
            if (account != null)
            {
                HttpContext.Session.SetString("UserID", account.MemberId.ToString());
                HttpContext.Session.SetString("Username", account.FirstName);
                HttpContext.Session.SetString("id", account.MemberId.ToString());
                return RedirectToAction("Index", "Home");
            }
            else if(user.EmailId =="Admin@gmail.com" && user.Password == "Admin123")
            {
                HttpContext.Session.SetString("UserID", "Admin");
               // HttpContext.Session.SetString("id", "1");
                HttpContext.Session.SetString("Username", "Admin");
                return RedirectToAction("Category", "Admin");
                
            }
            else
            {
                ModelState.AddModelError("", "Username or password is wrong.");
            }
            return View();
        }

     

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("UserID");
            HttpContext.Session.Remove("Username");
            HttpContext.Session.Remove("id");

            return RedirectToAction("Index","Home");
        }

    }
}