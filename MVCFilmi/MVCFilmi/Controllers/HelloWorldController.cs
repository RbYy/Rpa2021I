﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilmi.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pozdravljen(string ime="Barbara", int num=1)
        {
            ViewBag.Message = "Pozdravljen, " + ime;
            ViewBag.Num = num;
            return View();
            //return HttpUtility.HtmlEncode("Pozdravljen "+ime+" kolikokrat "+num);
        }
        public string Nova(int id=1)
		{
            return "Vrednost id je " + id;
		}
    }
}