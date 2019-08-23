using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using ioc;
using IBLL;
using Newtonsoft.Json;
using UI.Filters;

namespace UI.Controllers
{
    public class config_majorController : Controller
    {
        // GET: config_major
        config_majorIBLL bo = iocComm.config_majorBLL(); 
        [DlFilterAttibute]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            List<config_majorModel> li = bo.select1();
            string aa = JsonConvert.SerializeObject(li);
            return Content(aa);
        }
        // GET: config_major/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [DlFilterAttibute]
        // GET: config_major/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: config_major/Create
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

        // GET: config_major/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: config_major/Edit/5
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

        // GET: config_major/Delete/5
        public ActionResult Delete(int id)
        {

          int pf=  bo.delete(id);
            if (pf > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {

                return RedirectToAction("Index");
            }
           
        }

        // POST: config_major/Delete/5
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
