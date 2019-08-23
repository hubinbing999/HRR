using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using IBLL;
using ioc;
using Newtonsoft.Json;
namespace UI.Controllers
{
    public class config_file_second_kindController : Controller
    {
        config_file_second_kindIBLL csb = iocComm.config_file_second_kindBLL();
        config_file_first_kindIBLL cfb = iocComm.config_file_first_kindBLL();
        // GET: config_file_second_kind
        public ActionResult second_kind()
        {
            return View();
        }

        public ActionResult second_kind2()
        {
            List<config_file_second_kindModel> list = csb.select1();
            return Content(JsonConvert.SerializeObject(list));
        }

        // GET: config_file_second_kind/Create
        public ActionResult second_kind_register()
        {
            List<config_file_second_kindModel> list = csb.select1();
            string bh = "";
            foreach (config_file_second_kindModel item in list)
            {
                bh = item.second_kind_id;
            }
            int i1 = int.Parse(bh) + 1;
            config_file_second_kindModel csm = new config_file_second_kindModel() {
                second_kind_id = i1.ToString()
            };
            ViewBag.dt = XLK();
            return View(csm);
        }

        private List<SelectListItem> XLK()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_file_first_kindModel> list2 = cfb.select1();
            foreach (config_file_first_kindModel item in list2)
            {
                SelectListItem sl = new SelectListItem() {
                    Text = item.first_kind_name.ToString(),
                    Value = item.first_kind_id.ToString()
                };
                list.Add(sl);
            }
            return list;
        }

        // POST: config_file_second_kind/Create
        [HttpPost]
        public ActionResult second_kind_register(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                string id = collection["first_kind_id"];
                if (Request["first_kind_id"] == "")
                {
                    return JavaScript("alert('请选择I级机构名称');");
                }
                else {
                    List<config_file_first_kindModel> list = cfb.select1();
                    string mc = "";
                    foreach (config_file_first_kindModel item in list)
                    {
                        if (id.Equals(item.first_kind_id)) {
                            mc = item.first_kind_name;
                        }
                    }
                    config_file_second_kindModel csm = new config_file_second_kindModel()
                    {
                        first_kind_id = id,
                        first_kind_name = mc,
                        second_kind_id = Request["second_kind_id"],
                        second_kind_name = Request["second_kind_name"],
                        second_salary_id = Request["second_salary_id"],
                        second_sale_id = Request["second_sale_id"]
                    };
                    int i1 = csb.Add1(csm);
                if (i1 > 0)
                {
                    return JavaScript("window.location='/config_file_second_kind/second_kind_register_success'");
                }
                else
                {
                    return View();
                }
            }
            }
            else {
                return View();
            }
        }
        public ActionResult second_kind_register_success() {
            return View();
        }

        // GET: config_file_second_kind/Edit/5
        public ActionResult second_kind_change(int id)
        {
            List<config_file_second_kindModel> list = csb.selectupdate(id);
            config_file_second_kindModel csm = new config_file_second_kindModel() {
                Id = list[0].Id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                second_salary_id = list[0].second_salary_id,
                second_sale_id = list[0].second_sale_id
                
            };
            return View(csm);
        }
        public ActionResult second_kind_change_success()
        {
            return View();
        }
        // POST: config_file_second_kind/Edit/5
        [HttpPost]
        public ActionResult second_kind_change(int id, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                config_file_second_kindModel csm = new config_file_second_kindModel
                {
                    Id = id,
                    first_kind_id = collection["first_kind_id"],
                    first_kind_name = collection["first_kind_name"],
                    second_kind_id = collection["second_kind_id"],
                    second_kind_name = collection["second_kind_name"],
                    second_salary_id = collection["second_salary_id"],
                    second_sale_id = collection["second_sale_id"]
                };
                int i1 = csb.update1(csm);
                if (i1 > 0)
                {
                    return JavaScript("window.location='/config_file_second_kind/second_kind_change_success'");
                }
                else {
                    return View();
                }
            }
            else {
                return View();
            }
        }
        public ActionResult second_delete_success() {
            return View();
        }
        // POST: config_file_second_kind/Delete/5
        [HttpPost]
        public ActionResult Delete()
        {
            int id1 =int.Parse(Request["id"]);
            int i1 = csb.delete(id1);
            if (i1 > 0)
            {
                return Content(i1.ToString());
            }
            else {
                return Content(i1.ToString());
            }
        }
    }
}
