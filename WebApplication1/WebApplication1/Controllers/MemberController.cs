﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult MemberIndex()
        {
            return View();
        }
    }
}