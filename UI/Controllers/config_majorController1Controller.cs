using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using ioc;
using IBLL;
using Newtonsoft.Json;
using System.Web.Routing;
using UI.Filters;

namespace UI.Controllers
{
   
    public class config_majorController1Controller : Controller
    {
        config_majorIBLL bo = iocComm.config_majorBLL();
        config_major_kindIBLL bq = iocComm.config_major_kindBLL();
        // GET: config_majorController1
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
        // GET: config_majorController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [DlFilterAttibute]
        // GET: config_majorController1/Create
        public ActionResult Create()
        {
            List<config_majorModel> hh=  bo.select1();
            int i = 0;
            foreach (config_majorModel item in hh)
            {
                i = item.mak_id;
            };
            i = i + 1;

            config_majorModel ka = new config_majorModel();
            ka.major_id = "0" + i.ToString();
            List<SelectListItem> list = new List<SelectListItem>();
            config_major_kindIBLL con = iocComm.config_major_kindBLL();
            List<config_major_kindModel1> li = con.select1();
            foreach (config_major_kindModel1 item in li)
            {
                SelectListItem sl = new SelectListItem()
                {
                    //设置文本值
                    Text =item.major_kind_name,
                    //设置value值
                    Value = item.major_kind_id
                };
                list.Add(sl);
            }
            
            ViewData["dt"] = list;
            return View(ka);
        }

        // POST: config_majorController1/Create
       
       
        [HttpPost]

        public ActionResult ft(FormCollection collection)
        {
            config_majorModel con = new config_majorModel();

            string major_kind_id = Request["major_kind_id"];
            string major_kind_name = Request["major_kind_name"];
            List<config_major_kindModel1> gt = bq.selectupdate(major_kind_name);
            string major_kind_name1 = gt[0].major_kind_name;
            string major_id = Request["major_id"];
            string major_name = Request["major_name"];
            con.major_kind_id = major_kind_id;
            con.major_kind_name = major_kind_name1;
            con.major_id = major_id;
            con.major_name = major_name;
            int pf = bo.Add1(con);
            if (pf > 0)
            {
                //return  RedirectToAction("Index", new RouteValueDictionary(
                // new { controller = "Index", action = "config_majorController1" }));
                // return Content("ok");

                return JavaScript("alert('新增成功'); window.location.href='/config_majorController1/Index'");
               // return RedirectToAction("Index");
                //return RedirectToAction("config_majorController1", "Index");  //RedirectToAction("Index");
            }
            else
            {
                return JavaScript("alert('新增失败'); window.location.href='/config_majorController1/Create'");
               
            }




        }
        // GET: config_majorController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: config_majorController1/Edit/5
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

        // GET: config_majorController1/Delete/5
        public ActionResult Delete(int id)
        {
            int pf = bo.delete(id);
            if (pf > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {

                return RedirectToAction("Index");
            }
           
        }

        // POST: config_majorController1/Delete/5
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
