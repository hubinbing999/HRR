using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Model;
using ioc;
using Newtonsoft.Json;
using MVC_8;
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
            List<config_file_first_kindModel> list = cb.select1();
            string bh = "";
            foreach (config_file_first_kindModel item in list)
            {
                bh = item.first_kind_id;
            };
            int i1 = int.Parse(bh) + 1;
            config_file_first_kindModel cfm = new config_file_first_kindModel() {
                first_kind_id = i1.ToString()
            };
            return View(cfm);
        }

        // POST: config_file_first_kind/Create
        [HttpPost]
        public ActionResult config_file_first_kindCreate(config_file_first_kindModel ccm)
        {
            if (ModelState.IsValid)
            {
                int i1 = cb.Add1(ccm);
                if (i1 > 0)
                {
                    return JavaScript("window.location='/config_file_first_kind/first_kind_register_success'");
                    //return JavaScript("window.location='/config_file_first_kind/first_kind_register_success'");
                }
                else {
                    return View();
                }
            }
            else {
                return View();
            }
        }

        // GET: config_file_first_kind/Edit/5
        public ActionResult first_kind_change(int id)
        {
            List<config_file_first_kindModel> list = cb.selectupdate(id);
            config_file_first_kindModel cm = new config_file_first_kindModel() {
                Id = list[0].Id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                first_kind_salary_id = list[0].first_kind_salary_id,
                first_kind_sale_id = list[0].first_kind_sale_id
            };
            return View(cm);
        }

        // POST: config_file_first_kind/Edit/5
        [HttpPost]
        public ActionResult first_kind_change(int id, config_file_first_kindModel ccm)
        {
            if (ModelState.IsValid)
            {
                int i1 = cb.update1(ccm);
                if (i1 > 0)
                {
                    return JavaScript("window.location='/config_file_first_kind/first_kind_change_success'");
                }
                else {
                    return View();
                }
            }
            else {
                return View();
            }
        }
        // GET: config_file_first_kind/Delete/5
        public ActionResult first_delete()
        {
            string id1 = Request["id"];
            int i1 = cb.delete(int.Parse(id1));
            if (i1 > 0)
            {
                return Content(i1.ToString());
            }
            else {
                return Content(i1.ToString());
            }
        }

        public ActionResult first_kind_register_success()
        {
            return View();
        }
        public ActionResult first_kind_change_success() {
            return View();
        }
        public ActionResult first_delete_success() {
            return View();
        }
    }
}
