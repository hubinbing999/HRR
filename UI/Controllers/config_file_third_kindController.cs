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
    public class config_file_third_kindController : Controller
    {
        config_file_third_kindIBLL ctb = iocComm.config_file_third_kindBLL();
        config_file_second_kindIBLL csb = iocComm.config_file_second_kindBLL();
        config_file_first_kindIBLL cfb = iocComm.config_file_first_kindBLL();
        // GET: config_file_third_kind
        public ActionResult third_kind()
        {
            return View();
        }


        // GET: config_file_third_kind/Create
        public ActionResult third_kind2()
        {
            List<config_file_third_kindModel> list = ctb.select1();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult third_kind_register()
        {
            List<config_file_third_kindModel> list = ctb.select1();
            string bh = "";
            foreach (config_file_third_kindModel item in list)
            {
                bh = item.third_kind_id;
            }
            int i1 = int.Parse(bh) + 1;
            config_file_third_kindModel csm = new config_file_third_kindModel()
            {
                third_kind_id = i1.ToString()
            };
            // int s1 = int.Parse(Request["id"]);
            
                ViewBag.dt = XLK();
            ViewBag.dt1 = sd();
            return View(csm);
        }
        public ActionResult third_kind_register2() {
            int s1 =int.Parse(Request["id"]);
            List<config_file_second_kindModel> list2 = csb.selectxlk1(s1.ToString());
            return Content(JsonConvert.SerializeObject(list2));
        }

        private List<SelectListItem> sd()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            Dictionary<string, string> list2 = new Dictionary<string, string>();
            list2.Add("是", "是");
            list2.Add("否", "否");
            foreach (KeyValuePair<string, string> item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.Value,
                    Value = item.Key
                };
                list.Add(sl);
            }
            return list;
        }
        //private List<SelectListItem> XLK1(int s1)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    List<config_file_second_kindModel> list2 = csb.selectupdate(s1);
        //    foreach (config_file_second_kindModel item in list2)
        //    {
        //        SelectListItem sl = new SelectListItem()
        //        {
        //            Text = item.second_kind_name,
        //            Value = item.second_kind_id
        //        };
        //        list.Add(sl);
        //    }
        //    return list;
        //}

        private List<SelectListItem> XLK()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_file_first_kindModel> list2 = cfb.select1();
            foreach (config_file_first_kindModel item in list2)
            {
                SelectListItem sl = new SelectListItem() {
                    Text = item.first_kind_name,
                    Value = item.first_kind_id
                };
                list.Add(sl);
            }
            return list;
        }
        public ActionResult third_kind_register_success() {
            return View();
        }
        // POST: config_file_third_kind/Create
        [HttpPost]
        public ActionResult third_kind_register(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                string id = collection["first_kind_id"];
                if (Request["first_kind_id"] == "")
                {
                    return JavaScript("alert('请选择I级机构名称');");
                }
                else
                {
                    List<config_file_first_kindModel> list = cfb.select1();
                    string mc = "";
                    foreach (config_file_first_kindModel item in list)
                    {
                        if (id.Equals(item.first_kind_id))
                        {
                            mc = item.first_kind_name;
                        }
                    }
                    string id1 = collection["cftk.secondKindId"];
                    if (id1 == "0")
                    {
                        return JavaScript("alert('请选择II级机构名称');");
                    }
                    else {
                        List<config_file_second_kindModel> list2 = csb.select1();
                        string mc1 = "";
                        foreach (config_file_second_kindModel item in list2)
                        {
                            if (id1.Equals(item.second_kind_id))
                            {
                                mc1 = item.second_kind_name;
                            }
                        }
                        config_file_third_kindModel ctm = new config_file_third_kindModel()
                        {
                            first_kind_id = id,
                            first_kind_name = mc,
                            second_kind_id = id1,
                            second_kind_name = mc1,
                            third_kind_id = Request["third_kind_id"],
                            third_kind_name = Request["third_kind_name"],
                            third_kind_sale_id = Request["third_kind_sale_id"],
                       third_kind_is_retail = Request["third_kind_is_retail"]
                    };
                    int i1 = ctb.Add1(ctm);
                    if (i1 > 0)
                    {
                        return JavaScript("window.location='/config_file_third_kind/third_kind_register_success'");
                    }
                    else
                    {
                        return View();
                    }
                    }
                }
            }
            else
            {
                return View();
            }
        }

        // GET: config_file_third_kind/Edit/5
        public ActionResult third_kind_change(int id)
        {
            List<config_file_third_kindModel> list = ctb.selectupdate(id);
            config_file_third_kindModel ctm = new config_file_third_kindModel()
            {
                Id = list[0].Id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                third_kind_sale_id = list[0].third_kind_sale_id,
                third_kind_is_retail= list[0].third_kind_is_retail
            };
            ViewBag.dt1 = sd();
            return View(ctm);
        }
        public ActionResult third_delete_success() {
            return View();
        }
        // POST: config_file_third_kind/Edit/5
        [HttpPost]
        public ActionResult third_kind_change(int id, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                config_file_third_kindModel ctm = new config_file_third_kindModel()
                {
                    Id = id,
                    third_kind_sale_id = Request["third_kind_sale_id"],
                    third_kind_is_retail = Request["third_kind_is_retail"]
                };
                int i1 = ctb.update1(ctm);
                if (i1 > 0)
                {
                    return JavaScript("window.location='/config_file_third_kind/third_kind_change_success'");
                }
                else
                {
                    return View();
                }
            }
            else {
                return View();
            }
        }
        public ActionResult third_kind_change_success() {
            return View();
        }
        // POST: config_file_third_kind/Delete/5
        [HttpPost]
        public ActionResult Delete()
        {
            int id =int.Parse(Request["id"]);
            int i1 = ctb.delete(id);
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
