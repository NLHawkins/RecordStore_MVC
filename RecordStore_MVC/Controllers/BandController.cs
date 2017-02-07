using RecordStore_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecordStore_MVC.Controllers
{
    public class BandController : Controller
    {

        BandContext db = new BandContext();
        
        // GET: Band
        public ActionResult Index()
        {
            ViewBag.Bands = db.Bands.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Band band)
        {
            using (db)
            {
                
                db.Bands.Add(band);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}

    
