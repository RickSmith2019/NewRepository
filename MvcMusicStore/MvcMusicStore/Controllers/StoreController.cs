﻿using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreDB db = new MusicStoreDB();
        // GET: Store
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult Browse()
        {            
            
            return View();
        }

        public ActionResult Details()
        {
            
            return View();
        }
        
    }
}