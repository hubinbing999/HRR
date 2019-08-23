using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using ioc;
using IBLL;
using Newtonsoft.Json;
namespace UI.Controllers
{
    public class engage_major_releaseController : Controller
    {
        engage_major_releaseIBLL eng = iocComm.engage_major_releaseBLL();
        // GET: engage_major_release
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            List<engage_major_releaseModel> li = eng.select1();
            string aa = JsonConvert.SerializeObject(li);
            return Content(aa);
        }
        // GET: engage_major_release/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: engage_major_release/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: engage_major_release/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: engage_major_release/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: engage_major_release/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: engage_major_release/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: engage_major_release/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
