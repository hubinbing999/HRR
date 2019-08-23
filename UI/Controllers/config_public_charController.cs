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
    public class config_public_charController : Controller
    {
        config_public_charIBLL bo = iocComm.config_public_charBLL();
        // GET: config_public_char
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            List<config_public_charModel> li = bo.select1();
            string aa = JsonConvert.SerializeObject(li);
            return Content(aa);
        }
        // GET: config_public_char/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: config_public_char/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: config_public_char/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                config_public_charModel ji = new config_public_charModel();
                string attribute_kind = Request["attribute_kind"];
                string attribute_name = Request["attribute_name"];
                ji.attribute_kind = attribute_kind;
                ji.attribute_name = attribute_name;
                if (bo.Add1(ji) > 0)
                {
                    return JavaScript("alert('新增成功'); window.location.href='/config_public_char/Index'");

                }
                else
                {
                    return JavaScript("alert('新增失败'); window.location.href='/config_public_char/Create'");
                    //return RedirectToAction("Create");
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: config_public_char/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: config_public_char/Edit/5
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

        // GET: config_public_char/Delete/5
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

        // POST: config_public_char/Delete/5
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


        public ActionResult SELECT()
        {
            config_public_charModel cpc = new config_public_charModel()
            {
                attribute_kind = "薪酬设置"
            };
            List<config_public_charModel> list = bo.SelectByKind(cpc);
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (config_public_charModel item in list)
            {
                config_public_charModel cpb = new config_public_charModel()
                {
                    id = item.id,
                    attribute_kind = item.attribute_kind,
                    attribute_name = item.attribute_name
                };
                list2.Add(cpb);

            }
            return View(list2);

        }

        // GET: config_public_char/Create
        public ActionResult XZCreate()
        {
            return View();
        }
        // POST: config_public_char/Create
        [HttpPost]
        public ActionResult XZCreate(config_public_charModel pcm)
        {

            config_public_charModel ji = new config_public_charModel();
            string attribute_kind = Request["attribute_kind"];
            string attribute_name = Request["attribute_name"];
            ji.attribute_kind = attribute_kind;
            ji.attribute_name = attribute_name;
            if (bo.Add1(ji) > 0)
                {
                    return Content("<script>alert('新增成功!'); window.location.href ='/config_public_char/SELECT';</script>");
                }
                else
                {
                    return Content("<script>alert('新增失败!'); window.location.href ='/config_public_char/XZCreate';</script>");
                }
            
           


        }
        public ActionResult Delete2(int id)
        {
            int pf = bo.delete(id);
            if (pf > 0)
            {
                return Content("<script>alert('删除成功!'); window.location.href ='/config_public_char/SELECT';</script>");
            }
            else
            {

                return Content("<script>alert('删除失败!'); window.location.href ='/config_public_char/SELECT';</script>");
            }

        }
    }
}
