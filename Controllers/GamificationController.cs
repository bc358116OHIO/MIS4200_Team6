using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200_Team6.DAL;
using MIS4200_Team6.Models;

namespace MIS4200_Team6.Controllers
{
    public class GamificationController : Controller
    {
        private MIS4200Team6Context db = new MIS4200Team6Context();

        // GET: Gamification
        public ActionResult Index()
        {
            var recognitions = db.recognitions.Include(r => r.corevalues).Include(r => r.userdatas);
            return View(recognitions.ToList());
        }

        // GET: Gamification/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognition recognition = db.recognitions.Find(id);
            if (recognition == null)
            {
                return HttpNotFound();
            }
            return View(recognition);
        }

        // GET: Gamification/Create
        public ActionResult Create()
        {
            ViewBag.CoreValueID = new SelectList(db.corevalues, "CoreValueID", "CoreValue");
            ViewBag.ID = new SelectList(db.UserDatas, "ID", "firstName");
            return View();
        }

        // POST: Gamification/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecognitionID,CoreValueID,ID,RecDate,GiveID,RecID")] Recognition recognition)
        {
            if (ModelState.IsValid)
            {
                db.recognitions.Add(recognition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CoreValueID = new SelectList(db.corevalues, "CoreValueID", "CoreValue", recognition.CoreValueID);
            ViewBag.ID = new SelectList(db.UserDatas, "ID", "firstName", recognition.ID);
            return View(recognition);
        }

        // GET: Gamification/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognition recognition = db.recognitions.Find(id);
            if (recognition == null)
            {
                return HttpNotFound();
            }
            ViewBag.CoreValueID = new SelectList(db.corevalues, "CoreValueID", "CoreValue", recognition.CoreValueID);
            ViewBag.ID = new SelectList(db.UserDatas, "ID", "firstName", recognition.ID);
            return View(recognition);
        }

        // POST: Gamification/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecognitionID,CoreValueID,ID,RecDate,GiveID,RecID")] Recognition recognition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recognition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CoreValueID = new SelectList(db.corevalues, "CoreValueID", "CoreValue", recognition.CoreValueID);
            ViewBag.ID = new SelectList(db.UserDatas, "ID", "firstName", recognition.ID);
            return View(recognition);
        }

        // GET: Gamification/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognition recognition = db.recognitions.Find(id);
            if (recognition == null)
            {
                return HttpNotFound();
            }
            return View(recognition);
        }

        // POST: Gamification/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recognition recognition = db.recognitions.Find(id);
            db.recognitions.Remove(recognition);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
