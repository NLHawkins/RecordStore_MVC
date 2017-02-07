﻿using RecordStore_MVC.Models;
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

        public ActionResult Delete(Band band)
        {
            db.Bands.Remove(band);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            
            Band band = db.Bands.Find(id);
            return View(band);            
        }

        
        public ActionResult Edit(int id)
        {
            Band band = db.Bands.Find(id);

            return RedirectToAction("Index");
        }


    }
}

    
