using LoginStyle2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginStyle2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Logon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Logon(LogonViewModel pageData)
        {
            if (pageData.Account == "skill" &&
            pageData.Password == "tree")
            {
                pageData.Message =$"您使用{pageData.Account}登入成功。";
            }
            else
            {
                pageData.Message =$"您使用{pageData.Account}登入失敗。";
            }
            return View(pageData);
        }
        }
}