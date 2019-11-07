using MvcMusicStore.Models;
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
        public ActionResult Index(int id)
        {
            var albumnList = db.Albums
                .Where(a => a.GenreId == id)
                .ToList();

            return View(albumnList);
        }

        public ActionResult Browse()
        {            
            return View(db.Genres.ToList());
        }

        public ActionResult Details(int id)
        {            
            return View(db.Albums.Find(id));
        }
        
    }
}