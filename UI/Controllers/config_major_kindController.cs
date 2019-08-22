using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ioc;
using IBLL;
using Model;
using Newtonsoft.Json;
using UI.Filters;

namespace UI.Controllers
{
    public class config_major_kindController : Controller
    {
        config_major_kindIBLL con = iocComm.config_major_kindBLL();
        // GET: config_major_kind
        [DlFilterAttibute]
        public ActionResult Index()
        {
            //List<config_major_kindModel1> li = con.select1();
            //JsonConvert.SerializeObject(li)
            return View();
        }
        [HttpPost]
        public ActionResult Index2() {
            List<config_major_kindModel1> li = con.select1();
            string aa = JsonConvert.SerializeObject(li);
            return Content(aa);
        }
        public ActionResult config_major_kindxg()
        {
            return View();
        }
        // GET: config_major_kind/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [DlFilterAttibute]
        // GET: config_major_kind/Create
        public ActionResult Create1()
        {
            return View();
        }

        // POST: config_major_kind/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                string con1 = Request["major_kind_name"];
                List<config_major_kindModel1> li = con.select1();
                int i = 1;
                foreach (config_major_kindModel1 item in li)
                {
                    i++;
                }
                string p = i.ToString();
                string pd = "0" + p;
                config_major_kindModel1 mo = new config_major_kindModel1();
                mo.major_kind_id = pd;
                mo.major_kind_name = con1;
                int pf=  con.Add1(mo);
                if (pf > 0)
                {
                    return JavaScript("alert('新增成功'); window.location.href='/config_major_kind/Index'");
                   // return RedirectToAction("Index");
                }
                else {
                    return JavaScript("alert('新增失败'); window.location.href='/config_major_kind/config_major_kindxg'");
                    
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: config_major_kind/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: config_major_kind/Edit/5
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

        // GET: config_major_kind/Delete/5
        public ActionResult Delete(int id)
        {
            int pf=  con.delete(id);

            if (pf > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {

                return RedirectToAction("Index");
            }
            
        }

        // POST: config_major_kind/Delete/5
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
