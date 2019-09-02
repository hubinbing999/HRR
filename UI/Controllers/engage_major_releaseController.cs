using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using ioc;
using IBLL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UI.Controllers
{
    public class engage_major_releaseController : Controller
    {
        engage_major_releaseIBLL eng = iocComm.engage_major_releaseBLL();
        config_file_first_kindIBLL cfb = iocComm.config_file_first_kindBLL();
        config_file_third_kindIBLL ctb = iocComm.config_file_third_kindBLL();
        config_file_second_kindIBLL csb = iocComm.config_file_second_kindBLL();
        config_major_kindIBLL cmb = iocComm.config_major_kindBLL();
        config_majorIBLL cmib = iocComm.config_majorBLL();
        config_public_charIBLL cpb = iocComm.config_public_charBLL();
        // GET: engage_major_release
        public ActionResult position_release_search()
        {
            return View();
        }
        public ActionResult Index2()
        {
            int rl = int.Parse(Request["rl"]);
            IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd HH':'mm':'ss" };
            int currentPage = int.Parse(Request["currentPage"]);
            FenYeModel fy = eng.Fenye(currentPage, rl);
            string aa = JsonConvert.SerializeObject(fy, Formatting.Indented, timeConverter);
            return Content(aa);
        }
        public ActionResult position_change_update() {
            return View();
        }
        public ActionResult position_change_update2()
        {
            int rl = int.Parse(Request["rl"]);
            IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd HH':'mm':'ss" };
            int currentPage = int.Parse(Request["currentPage"]);
            FenYeModel fy = eng.Fenye(currentPage, rl);
            string aa = JsonConvert.SerializeObject(fy, Formatting.Indented, timeConverter);
            return Content(aa);
        }
        public ActionResult position_change_update1() {
            return View();
        }
        public ActionResult position_release_details(int id) {
            int id1 = id;
            ViewBag.dt = bdxlk(id1);
            ViewBag.dt1 = bdxlk1(id1);
            ViewBag.dt2 = bdxlk2(id1);
            ViewBag.dt3 = bdxlk3(id1);
            ViewBag.dt4 = bdxlk4(id1);
            ViewBag.dt5 = bdxlk5(id1);
            List<engage_major_releaseModel> list = eng.selectupdate(id);
            engage_major_releaseModel emrm = new engage_major_releaseModel() {
                 id = list[0].id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                major_kind_id = list[0].major_kind_id,
                major_kind_name = list[0].major_kind_name,
                major_id = list[0].major_id,
                major_name = list[0].major_name,
                human_amount = list[0].human_amount,
                engage_type = list[0].engage_type,
                deadline = list[0].deadline,
                register = list[0].register,
                changer = list[0].changer,
                regist_time = list[0].regist_time,
                change_time = list[0].change_time,
                major_describe = list[0].major_describe,
                engage_required = list[0].engage_required
            };
            return View(emrm);
        }
        private List<SelectListItem> bdxlk5(int id1)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_major_releaseModel> list2 = eng.selectupdate(id1);
            foreach (engage_major_releaseModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.major_name,
                    Value = item.major_id
                };
                list.Add(sl);
            }
            return list;
        }

        private List<SelectListItem> bdxlk4(int id1)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_major_releaseModel> list2 = eng.selectupdate(id1);
            foreach (engage_major_releaseModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.major_kind_name,
                    Value = item.major_kind_id
                };
                list.Add(sl);
            }
            return list;
        }

        private List<SelectListItem> bdxlk3(int id1)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_major_releaseModel> list2 = eng.selectupdate(id1);
            foreach (engage_major_releaseModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.engage_type,
                    Value = item.engage_type
                };
                list.Add(sl);
            }
            return list;
        }

        private List<SelectListItem> bdxlk2(int id1)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_major_releaseModel> list2 = eng.selectupdate(id1);
            foreach (engage_major_releaseModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.third_kind_name,
                    Value = item.third_kind_id
                };
                list.Add(sl);
            }
            return list;
        }

        private List<SelectListItem> bdxlk1(int id1)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_major_releaseModel> list2 = eng.selectupdate(id1);
            foreach (engage_major_releaseModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.second_kind_name,
                    Value = item.second_kind_id
                };
                list.Add(sl);
            }
            return list;
        }

        private List<SelectListItem> bdxlk(int id1)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_major_releaseModel> list2 = eng.selectupdate(id1);
            foreach (engage_major_releaseModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.first_kind_name,
                    Value = item.first_kind_id
                };
                list.Add(sl);
            }
            return list;
    }

        [HttpPost]
        public ActionResult position_release_details(FormCollection collection)
        {

            int eid = int.Parse(Request["id"]);
            Session["eid"] = eid;
            return JavaScript("window.location='/engage_resume/register'");
        }
        // GET: engage_major_release/Create
        public ActionResult position_register()
        {
            string us = "123";
            ViewData["us"] = us;
            ViewBag.dt = xlk();
                ViewBag.dt1 = xlk2();
                ViewBag.dt2 = xlk3();
                
            return View();
        }
        private List<SelectListItem> xlk3() {
            List<SelectListItem> list = new List<SelectListItem>();
            string s1 = "招聘类型";
            config_public_charModel cpm = new config_public_charModel() {
                attribute_kind = s1
            };
            List<config_public_charModel> list2 = cpb.SelectByKind(cpm);
            foreach (config_public_charModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.attribute_name,
                    Value = item.attribute_name
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk()
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
        private List<SelectListItem> xlk2()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_major_kindModel1> list2 = cmb.select1();
            foreach (config_major_kindModel1 item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.major_kind_name,
                    Value = item.major_kind_id
                };
                list.Add(sl);
            }
            return list;
        }
        public ActionResult fxlk() {
            string Fid = Request["Fid"];
            List<config_file_second_kindModel> list = csb.selectxlk1(Fid);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult mrxlk() {
            string Mid = Request["Mid"];
            List<config_majorModel> list = cmib.selectxlk1(Mid);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult sxlk() {
            string Sid = Request["Sid"];
            List<config_file_third_kindModel> list = ctb.selectxlk1(Sid);
            return Content(JsonConvert.SerializeObject(list));
        }
        // POST: engage_major_release/Create
        [HttpPost]
        public ActionResult position_register(FormCollection collection)
        {
            string fkid = Request["first_kind_id"];
            List<config_file_first_kindModel> list = cfb.select1();
            string mc = "";
            foreach (config_file_first_kindModel item in list)
            {
                if (fkid.Equals(item.first_kind_id)) {
                    mc = item.first_kind_name;
                }
            }
            string eskid = Request["emajorReleasesecondKindId"];
            List<config_file_second_kindModel> list1 = csb.select1();
            string mc1 = "";
            foreach (config_file_second_kindModel item in list1)
            {
                if (eskid.Equals(item.second_kind_id))
                {
                    mc1 = item.second_kind_name;
                }
            }
            string erkid = Request["emajorReleasethirdKindId"];
            List<config_file_third_kindModel> list2 = ctb.select1();
            string mc2 = "";
            foreach (config_file_third_kindModel item in list2)
            {
                if (eskid.Equals(item.third_kind_id))
                {
                    mc2 = item.third_kind_name;
                }
            }
            string mkid = Request["major_kind_id"];
            List<config_major_kindModel1> list3 = cmb.select1();
            string mc3 = "";
            foreach (config_major_kindModel1 item in list3)
            {
                if (mkid.Equals(item.major_kind_id))
                {
                    mc3 = item.major_kind_name;
                }
            }
            string erid = Request["emajorReleasemajorId"];
            List<config_majorModel> list4 = cmib.select1();
            string mc4 = "";
            foreach (config_majorModel item in list4)
            {
                if (erid.Equals(item.major_id))
                {
                    mc4 = item.major_name;
                }
            }
            engage_major_releaseModel emrm = new engage_major_releaseModel();
            emrm.first_kind_id = fkid;
            emrm.first_kind_name = mc;
            emrm.second_kind_id = eskid;
            emrm.second_kind_name = mc1;
            emrm.third_kind_id = erkid;
            emrm.third_kind_name = mc2;
            emrm.engage_type = Request["attribute_kind"];
            emrm.major_kind_id = mkid;
            emrm.major_kind_name = mc3;
            emrm.major_id = erid;
            emrm.major_name = mc4;
            emrm.human_amount = int.Parse(Request["human_amount"]);
            emrm.deadline = DateTime.Parse(Request["deadline"]);
            emrm.register = Request["register"];
            emrm.regist_time = DateTime.Parse(Request["regist_time"]);
            emrm.major_describe = Request["major_describe"];
            emrm.engage_required = Request["engage_required"];
            emrm.change_time = DateTime.Now;
            emrm.changer = null;
                int i1 = eng.Add1(emrm);
                if (i1 > 0)
                {
                    return JavaScript("window.location='/engage_major_release/position_release_search'");
                }
                else
                {
                    return View();
                }
            }

        // GET: engage_major_release/Edit/5
        public ActionResult position_release_change(int id)
        {
            ViewBag.dt2 = xlk3();
            string us = "123";
            ViewData["us"] = us;
            List<engage_major_releaseModel> list = eng.selectupdate(id);
            engage_major_releaseModel emm = new engage_major_releaseModel() {
                 id = list[0].id,
                first_kind_id = list[0].first_kind_id,
                first_kind_name = list[0].first_kind_name,
                second_kind_id = list[0].second_kind_id,
                second_kind_name = list[0].second_kind_name,
                third_kind_id = list[0].third_kind_id,
                third_kind_name = list[0].third_kind_name,
                major_kind_id = list[0].major_kind_id,
                major_kind_name = list[0].major_kind_name,
                major_id = list[0].major_id,
                major_name = list[0].major_name,
                human_amount = list[0].human_amount,
                engage_type = list[0].engage_type,
                deadline = list[0].deadline,
                register = list[0].register,
                changer = list[0].changer,
                regist_time = list[0].regist_time,
                change_time = list[0].change_time,
                major_describe = list[0].major_describe,
                engage_required = list[0].engage_required,
                
            };
            ViewData.Model = emm;
            return View();
        }

        //private List<SelectListItem> xlk4()
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    List<engage_major_releaseModel> list2 = eng.select1();
        //    foreach (engage_major_releaseModel item in list2)
        //    {
        //        SelectListItem sl = new SelectListItem() {
        //            Text = item.engage_type,
        //            Value = item.engage_type
        //        };
        //        list.Add(sl);
        //    }
            
        //    return list;
        //}

        // POST: engage_major_release/Edit/5
        [HttpPost]
        public ActionResult position_release_change(int id, FormCollection collection)
        {
            engage_major_releaseModel emrm = new engage_major_releaseModel();
            emrm.id = id;
            emrm.first_kind_name = Request["first_kind_name"];
            emrm.second_kind_name = Request["second_kind_name"];
            emrm.third_kind_name = Request["third_kind_name"];
            emrm.engage_type = Request["engage_type"];
            emrm.major_kind_name = Request["major_kind_name"];
            emrm.major_name = Request["major_name"];
            emrm.human_amount = int.Parse(Request["human_amount"]);
            emrm.deadline = DateTime.Parse(Request["deadline"]);
            emrm.changer = Request["changer"];
            emrm.change_time = DateTime.Parse(Request["change_time"]);
            emrm.major_describe = Request["major_describe"];
            emrm.engage_required = Request["engage_required"];
            int i1 = eng.update1(emrm);
            if (i1 > 0)
            {
                return JavaScript("window.location='/engage_major_release/position_release_search'");
            }
            else {
                return View();
            }
        }
        
        // POST: engage_major_release/Delete/5
        [HttpPost]
        public ActionResult Delete()
        {
            int eid = int.Parse(Request["eid"]);
            int i1 = eng.delete(eid);
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
