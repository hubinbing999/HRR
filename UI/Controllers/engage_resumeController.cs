using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using IBLL;
using ioc;
using Newtonsoft.Json;
using UI.Filters;

namespace UI.Controllers
{
    public class engage_resumeController : Controller
    {
        engage_major_releaseIBLL emrm = iocComm.engage_major_releaseBLL();
        engage_resumeIBLL erb = iocComm.engage_resumeBLL();
        config_public_charIBLL cpcb = iocComm.config_public_charBLL();
        // GET: engage_resume
        public ActionResult resumechoose()
        {
            return View();
        }
        [engage_resumeAttibute]
        // GET: engage_resume/Create
        public ActionResult register()
        {
            int id = int.Parse(Session["eid"].ToString());
            ViewBag.dt = xlk(id);
            ViewBag.dt1 = xlk1(id);
            ViewBag.dt2 = xlk2(id);
            ViewBag.dt3 = xlk3();
            ViewBag.dt4 = xlk4();
            ViewBag.dt5 = xlk5();
            ViewBag.dt6 = xlk6();
            ViewBag.dt7 = xlk7();
            ViewBag.dt8 = xlk8();
            ViewBag.dt9 = xlk9();
            ViewBag.dt10 = xlk10();
            ViewBag.dt11 = xlk11();
            ViewBag.dt12 = xlk12();
            return View();
        }
        private List<SelectListItem> xlk12()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            string s1 = "爱好";
            config_public_charModel cpcm = new config_public_charModel();
            cpcm.attribute_kind = s1;

            List<config_public_charModel> list2 = cpcb.SelectByKind(cpcm);
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

        private List<SelectListItem> xlk11()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            string s1 = "特长";
            config_public_charModel cpcm = new config_public_charModel();
            cpcm.attribute_kind = s1;

            List<config_public_charModel> list2 = cpcb.SelectByKind(cpcm);
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

        private List<SelectListItem> xlk10()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            string s1 = "专业";
            config_public_charModel cpcm = new config_public_charModel();
            cpcm.attribute_kind = s1;

            List<config_public_charModel> list2 = cpcb.SelectByKind(cpcm);
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

        private List<SelectListItem> xlk9()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            string s1 = "教育年限";
            config_public_charModel cpcm = new config_public_charModel();
            cpcm.attribute_kind = s1;

            List<config_public_charModel> list2 = cpcb.SelectByKind(cpcm);
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

        private List<SelectListItem> xlk8()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            string s1 = "学历";
            config_public_charModel cpcm = new config_public_charModel();
            cpcm.attribute_kind = s1;

            List<config_public_charModel> list2 = cpcb.SelectByKind(cpcm);
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

        private List<SelectListItem> xlk7()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            string s1 = "政治面貌";
            config_public_charModel cpcm = new config_public_charModel();
            cpcm.attribute_kind = s1;

            List<config_public_charModel> list2 = cpcb.SelectByKind(cpcm);
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
        private List<SelectListItem> xlk6()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            string s1 = "宗教信仰";
            config_public_charModel cpcm = new config_public_charModel();
            cpcm.attribute_kind = s1;

            List<config_public_charModel> list2 = cpcb.SelectByKind(cpcm);
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

        private List<SelectListItem> xlk5()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            string s1 = "民族";
            config_public_charModel cpcm = new config_public_charModel();
            cpcm.attribute_kind = s1;

            List<config_public_charModel> list2 = cpcb.SelectByKind(cpcm);
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

        private List<SelectListItem> xlk4()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            string s1 = "国籍";
            config_public_charModel cpcm = new config_public_charModel();
            cpcm.attribute_kind = s1;

            List<config_public_charModel> list2 = cpcb.SelectByKind(cpcm);
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

        private List<SelectListItem> xlk(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_major_releaseModel> list2 = emrm.selectupdate(id);
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
        private List<SelectListItem> xlk1(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_major_releaseModel> list2 = emrm.selectupdate(id);
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
        private List<SelectListItem> xlk2(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_major_releaseModel> list2 = emrm.selectupdate(id);
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
        private List<SelectListItem> xlk3()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            Dictionary<string, string> dc = new Dictionary<string, string>();
            dc.Add("男", "男");
            dc.Add("女", "女");
            foreach (KeyValuePair<string, string> item in dc)
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
        // POST: engage_resume/Create
        [HttpPost]
        public ActionResult register(FormCollection collection)
        {
            engage_resumeModel erm = new engage_resumeModel();
            erm.human_major_kind_name = Request["hm"];
            erm.human_major_name = Request["hmn"];
            erm.engage_type = Request["et"];
            erm.human_name = Request["human_name"];
            erm.human_sex = Request["hs"];
            erm.human_email = Request["human_email"];
            erm.human_telephone = Request["human_telephone"];
            erm.human_homephone = Request["human_homephone"];
            erm.human_mobilephone = Request["human_mobilephone"];
            erm.human_address = Request["human_address"];
            erm.human_postcode = Request["human_postcode"];
            erm.human_nationality = Request["hmt"];
            erm.human_birthplace = Request["human_birthplace"];
            erm.human_birthday =DateTime.Parse(Request["human_birthday"]);
            erm.human_race = Request["hr"];
            erm.human_religion = Request["hrg"];
            erm.human_party = Request["hp"];
            erm.human_idcard = Request["human_idcard"];
            erm.human_age = int.Parse(Request["human_age"]);
            erm.human_college = Request["human_college"];
            erm.human_educated_degree = Request["hed"];
            erm.human_educated_years = int.Parse(Request["hey"]);
            erm.human_educated_major = Request["hem"];
            erm.demand_salary_standard = decimal.Parse(Request["demand_salary_standard"]);
            erm.regist_time = DateTime.Parse(Request["regist_time"]);
            erm.human_specility = Request["hsp"];
            erm.human_hobby = Request["hh"];
            erm.human_history_records = Request["human_history_records"];
            erm.remark = Request["remark"];
            //erm.check_time = DateTime.Now;
            //erm.test_check_time = DateTime.Now;
            //erm.pass_regist_time = DateTime.Now;
            //erm.pass_check_time = DateTime.Now;
            int i1 = erb.Add1(erm);
            if (i1 > 0)
            {
                return Content(i1.ToString());
            }
            else {
                return Content(i1.ToString());
            }
        }

        // GET: engage_resume/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: engage_resume/Edit/5
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

        // GET: engage_resume/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: engage_resume/Delete/5
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
