using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Model;
using ioc;
using Newtonsoft.Json;

namespace UI.Controllers
{
    public class config_file_first_kindController : Controller
    {
        config_file_first_kindIBLL cb = iocComm.config_file_first_kindBLL();
        // GET: config_file_first_kind
        public ActionResult config_file_first_kind() {
            return View();
        }

        public ActionResult config_file_first_kind2()
        {
            List<config_file_first_kindModel> list = cb.select1();
            return Content(JsonConvert.SerializeObject(list));
        }


        // GET: config_file_first_kind/Create
        public ActionResult config_file_first_kindCreate()
        {
            return View();
        }

        // POST: config_file_first_kind/Create
        [HttpPost]
        public ActionResult config_file_first_kindCreate(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("config_file_first_kind");
            }
            catch
            {
                return View();
            }
        }

        // GET: config_file_first_kind/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: config_file_first_kind/Edit/5
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

        // GET: config_file_first_kind/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: config_file_first_kind/Delete/5
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
