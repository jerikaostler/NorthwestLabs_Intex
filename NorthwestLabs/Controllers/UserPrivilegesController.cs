using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NorthwestLabs.DAL;
using NorthwestLabs.Models;

namespace NorthwestLabs.Controllers
{
    public class UserPrivilegesController : Controller
    {
        private NorthWestLabsProductionContext db = new NorthWestLabsProductionContext();

        // GET: UserPrivileges
        public ActionResult Index()
        {
            var userprivileges = db.userprivileges.Include(u => u.Privilege).Include(u => u.User);
            return View(userprivileges.ToList());
        }

        // GET: UserPrivileges/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPrivileges userPrivileges = db.userprivileges.Find(id);
            if (userPrivileges == null)
            {
                return HttpNotFound();
            }
            return View(userPrivileges);
        }

        // GET: UserPrivileges/Create
        public ActionResult Create()
        {
            ViewBag.PrivilegeID = new SelectList(db.privilege, "PrivilegeID", "Description");
            ViewBag.UserName = new SelectList(db.user, "UserName", "Password");
            return View();
        }

        // POST: UserPrivileges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserPrivilegesID,UserName,PrivilegeID")] UserPrivileges userPrivileges)
        {
            if (ModelState.IsValid)
            {
                db.userprivileges.Add(userPrivileges);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PrivilegeID = new SelectList(db.privilege, "PrivilegeID", "Description", userPrivileges.PrivilegeID);
            ViewBag.UserName = new SelectList(db.user, "UserName", "Password", userPrivileges.UserName);
            return View(userPrivileges);
        }

        // GET: UserPrivileges/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPrivileges userPrivileges = db.userprivileges.Find(id);
            if (userPrivileges == null)
            {
                return HttpNotFound();
            }
            ViewBag.PrivilegeID = new SelectList(db.privilege, "PrivilegeID", "Description", userPrivileges.PrivilegeID);
            ViewBag.UserName = new SelectList(db.user, "UserName", "Password", userPrivileges.UserName);
            return View(userPrivileges);
        }

        // POST: UserPrivileges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserPrivilegesID,UserName,PrivilegeID")] UserPrivileges userPrivileges)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userPrivileges).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PrivilegeID = new SelectList(db.privilege, "PrivilegeID", "Description", userPrivileges.PrivilegeID);
            ViewBag.UserName = new SelectList(db.user, "UserName", "Password", userPrivileges.UserName);
            return View(userPrivileges);
        }

        // GET: UserPrivileges/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPrivileges userPrivileges = db.userprivileges.Find(id);
            if (userPrivileges == null)
            {
                return HttpNotFound();
            }
            return View(userPrivileges);
        }

        // POST: UserPrivileges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserPrivileges userPrivileges = db.userprivileges.Find(id);
            db.userprivileges.Remove(userPrivileges);
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
