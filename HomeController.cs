using FBLeague.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace FBLeague.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        FBDbContext context = new FBDbContext();
        public ActionResult Index()
        {
            ViewData["str1"] = "This is a string passed using ViewData";

            ViewData["num1"] = 100;

            ViewBag.str2 = "This is a string passed using ViewBag";

            ViewBag.num2 = 200;

            return View();
        }
        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult SaveUser(FBData f)
        {
            StreamWriter sw = new
             StreamWriter(Server.MapPath("~/App_Data/users.txt"), true);
            sw.WriteLine("User details added on: " +
             DateTime.Now.ToString());
            sw.WriteLine("MatchID: " + f.MatchID);
            sw.WriteLine("TeamName1: " + f.TeamName1);
            sw.WriteLine("TeamName2: " + f.TeamName2);
            sw.WriteLine("Status: " + f.Status);
            sw.WriteLine("WinningTeam: " + f.WinningTeam);
            sw.WriteLine();
            sw.Close();
            return Content("User details have been saved");
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreateAccount(FBData a)
        {
            context.Users.Add(a);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}