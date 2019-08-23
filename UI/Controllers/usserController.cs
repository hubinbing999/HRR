using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using ioc;
using IBLL;
namespace UI.Controllers
{
    public class usserController : Controller
    {
        usersIBLL us = iocComm.usersBLL();
        // GET: usser
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index3()
        {
            

        string q=  HttpContext.Session["user"].ToString();
            return Content(q);
        }
        public ActionResult dl(FormCollection collection) {
            
            string u_true_name1 = Request["u_true_name"];
            string u_password1 = Request["u_password"];
            usersModel us1 = new usersModel()
            {
                u_true_name = u_true_name1,
                u_password = u_password1
            };
            int pd=   us.dl(us1);
            if (pd > 0) {
                Session["user"] = pd;
                Session["us"] = u_true_name1;
                return JavaScript("alert('登录成功'); localStorage.setItem('a', '"+ u_true_name1 + "');  window.location.href='../page/index.html'");
                
            }
            else {
                return JavaScript("alert('登录失败'); window.location.href='/usser/Index'");
            };

            
        }
        // GET: usser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: usser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: usser/Create
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

        // GET: usser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: usser/Edit/5
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

        // GET: usser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: usser/Delete/5
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
