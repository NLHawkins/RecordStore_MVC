using RecordStore_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecordStore_MVC.Controllers
{
    public class BandController : Controller
    {

        BandContext db = new BandContext();
        //ICollection<Band> searchResults;
        //[HttpPost]
        /*public ICollection<Band> Index()
            searchResults = db.Bands.ToList();
            return View();
        }
        */
        // GET: Band
        public ActionResult Index()
        {
            ViewBag.bands = db.Bands.ToList();
            /*if (!String.IsNullOrEmpty(search))
            {

                var results = db.Bands.Where(s => s.Name.Contains(search));
                return View(results);
            }
            else
            {*/
                return View();
           // }
              
        }

        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Band band)
        {
           
                db.Bands.Add(band);
                db.SaveChanges();
          
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? Id)
        {
            Band band = db.Bands.Find(Id);
            return View(band);
        }

        [HttpPost]
        public ActionResult Delete(Band band)
        {
            db.Entry(band).State = EntityState.Modified;
            db.Bands.Remove(band);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            Band band = db.Bands.Find(id);
            return View(band);            
        }

        [HttpPost]
        public ActionResult Edit(Band band)
        {
                     
            db.Entry(band).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? Id)
        {
            Band band = db.Bands.Find(Id);
            return View(band);
        }

    }
}

    
