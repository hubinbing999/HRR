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
using Common;
using System.IO;
using Newtonsoft.Json.Converters;
using Model.NewFolder1;

namespace UI.Controllers
{
    public class engage_resumeController : Controller
    {
        engage_major_releaseIBLL emrm = iocComm.engage_major_releaseBLL();
        engage_resumeIBLL erb = iocComm.engage_resumeBLL();
        config_public_charIBLL cpcb = iocComm.config_public_charBLL();
        config_major_kindIBLL cmkb = iocComm.config_major_kindBLL();
        config_majorIBLL cmb = iocComm.config_majorBLL();
        usersIBLL ub = iocComm.usersBLL();
        engage_interviewIBLL eib = iocComm.engage_interviewBLL();
        // GET: engage_resume
        public ActionResult resumechoose()
        {
            return View();
        }
        public ActionResult resumechoose2()
        {
            List<config_major_kindModel1> list = cmkb.select1();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult resumechoose3()
        {
            string mid = Request["mid"];
            List<config_majorModel> list = cmb.selectxlk1(mid);
            return Content(JsonConvert.SerializeObject(list));
        }

        [engage_resumeAttibute]
        // GET: engage_resume/Create
        public ActionResult register()
        {
            int id = int.Parse(Session["eid"].ToString());
            List<engage_major_releaseModel> emrm123 = emrm.selectupdate(id);
            engage_resumeModel erm = new engage_resumeModel()
            {
                register = emrm123[0].register
            };
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
            return View(erm);
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
        public ActionResult filesupload()
        {
            return View();
        }
        public ActionResult sc(string eid, HttpPostedFileBase file)
        {
            string name = Md5String.Md5CreateName(file.InputStream);//文件名
            string text = Path.GetExtension(file.FileName);//后缀名
            //1 获得上传文件的完整路径
            string path = $"/Uploader/{DateTime.Now.ToString("yyyy/MM/dd")}/" + name + text;
            string fullPath = Server.MapPath(path);
            new FileInfo(fullPath).Directory.Create();//创建文件夹
            //2 调用file.SaveAs(完整路径)
            file.SaveAs(fullPath);
            engage_resumeModel erm = new engage_resumeModel()
            {
                Id = int.Parse(eid),
                human_picture = fullPath
            };
            int i1 = erb.update1(erm);
            if (i1 > 0)
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }
        // POST: engage_resume/Create
        [HttpPost]
        public ActionResult register(FormCollection collection)
        {
            engage_resumeModel erm = new engage_resumeModel();
            erm.human_major_kind_id = Request["human_major_kind_name"];
            erm.human_major_id = Request["human_major_name"];
            erm.human_major_kind_name = Request["hm"];
            erm.human_major_name = Request["hmn"];
            erm.engage_type = Request["et"];
            erm.human_name = Request["human_name"];
            erm.human_sex = Request["hs"];
            erm.human_email = Request["human_email"];
            erm.human_telephone = Request["human_telephone"];
            erm.register = Request["register"];
            erm.human_homephone = Request["human_homephone"];
            erm.human_mobilephone = Request["human_mobilephone"];
            erm.human_address = Request["human_address"];
            erm.human_postcode = Request["human_postcode"];
            erm.human_nationality = Request["hmt"];
            erm.human_birthplace = Request["human_birthplace"];
            erm.human_birthday = DateTime.Parse(Request["human_birthday"]);
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
            erm.recomandation = null;
            erm.human_picture = null;
            erm.attachment_name = null;
            erm.check_status = 0;
            erm.checker = null;
            erm.interview_status = 0;
            erm.total_points = 0;
            erm.test_amount = 0;
            erm.test_checker = null;
            erm.pass_register = null;
            erm.pass_checker = null;
            erm.pass_check_status = 0;
            erm.pass_checkComment = null;
            erm.pass_passComment = null;
            int i1 = erb.Add1(erm);
            if (i1 > 0)
            {
                //List<engage_resumeModel> list = erb.selectupdate(i1);
                //string eid = list[0].Id.ToString();
                return Content(i1.ToString());
            }
            else
            {
                return Content(i1.ToString());
            }
        }

        // GET: engage_resume/Edit/5
        public ActionResult resumelist()
        {
            string major_kind_id = Request["major_kind_id"];
            string major_id = Request["major_id"];
            string gjz = Request["gjz"];
            string startDate = Request["startDate"];
            string endDate = Request["endDate"];
            engage_resumeModel erm = new engage_resumeModel()
            {
                human_major_kind_name = major_kind_id,
                human_major_name = major_id,
                human_name = gjz,
                register = startDate,
                pass_register = endDate,
            };
            return View(erm);
        }
        public ActionResult resumelist2(FormCollection form)
        {
            string major_kind_id = Request["human_major_kind_name"];
            string major_id = Request["human_major_name"];
            string gjz = Request["human_name"];
            string startDate = Request["register"];
            string endDate = Request["pass_register"];
            int currentPage = int.Parse(Request["currentPage"]);
            int rl = int.Parse(Request["rl"]);
            FenyeModel2 fy = erb.Fenye(currentPage, rl, major_kind_id, major_id, gjz, startDate, endDate);
            return Content(JsonConvert.SerializeObject(fy));
        }

        [DlFilterAttibute]
        public ActionResult resumedetails(int id)
        {
            ViewBag.dl = xlkdl();
            string us = HttpContext.Session["us"].ToString();
            ViewBag.dt = xlks(id);
            ViewBag.dt1 = xlk1s(id);
            ViewBag.dt2 = xlk2s(id);
            ViewBag.dt3 = xlk3s(id);
            ViewBag.dt4 = xlk4s(id);
            ViewBag.dt5 = xlk5s(id);
            ViewBag.dt6 = xlk6s(id);
            ViewBag.dt7 = xlk7s(id);
            ViewBag.dt8 = xlk8s(id);
            ViewBag.dt9 = xlk9s(id);
            ViewBag.dt10 = xlk10s(id);
            ViewBag.dt11 = xlk11s(id);
            ViewBag.dt12 = xlk12s(id);
            List<engage_resumeModel> list = erb.selectupdate(id);
            engage_resumeModel erm = new engage_resumeModel()
            {
                Id = list[0].Id,
                human_name = list[0].human_name,
                human_email = list[0].human_email,
                human_telephone = list[0].human_telephone,
                human_homephone = list[0].human_homephone,
                human_mobilephone = list[0].human_mobilephone,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_birthplace = list[0].human_birthplace,
                human_birthday = list[0].human_birthday,
                human_idcard = list[0].human_idcard,
                human_age = list[0].human_age,
                human_college = list[0].human_college,
                demand_salary_standard = list[0].demand_salary_standard,
                human_history_records = list[0].human_history_records,
                remark = list[0].remark,
                regist_time = list[0].regist_time
            };

            return View(erm);
        }

        private List<SelectListItem> xlkdl()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<usersModel> list2 = ub.select1();
            foreach (usersModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.u_name,
                    Value = item.u_true_name
                };
                list.Add(sl);
            }
            return list;
        }

        private List<SelectListItem> xlks(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_major_kind_name,
                    Value = item.human_major_kind_id
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk1s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_major_name,
                    Value = item.human_major_id
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk2s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
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
        private List<SelectListItem> xlk3s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<engage_resumeModel> dc = erb.selectupdate(id);
            foreach (engage_resumeModel item in dc)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_sex,
                    Value = item.human_sex
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk4s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_nationality,
                    Value = item.human_nationality
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk5s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_race,
                    Value = item.human_race
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk6s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_religion,
                    Value = item.human_religion
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk7s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_party,
                    Value = item.human_party
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk8s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_educated_degree,
                    Value = item.human_educated_degree
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk9s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_educated_years.ToString(),
                    Value = item.human_educated_years.ToString()
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk10s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_educated_major,
                    Value = item.human_educated_major
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk11s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_specility,
                    Value = item.human_specility
                };
                list.Add(sl);
            }
            return list;
        }
        private List<SelectListItem> xlk12s(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            foreach (engage_resumeModel item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.human_hobby,
                    Value = item.human_hobby
                };
                list.Add(sl);
            }
            return list;
        }
        [HttpPost]
        public ActionResult resumedetails(int id, FormCollection collection)
        {
            engage_resumeModel erm = new engage_resumeModel();
            erm.Id = id;
            erm.human_name = Request["human_name"];
            erm.human_email = Request["human_email"];
            erm.human_telephone = Request["human_telephone"];
            erm.human_homephone = Request["human_homephone"];
            erm.human_mobilephone = Request["human_mobilephone"];
            erm.human_address = Request["human_address"];
            erm.human_postcode = Request["human_postcode"];
            erm.human_birthplace = Request["human_birthplace"];
            erm.human_birthday = DateTime.Parse(Request["human_birthday"]);
            erm.human_idcard = Request["human_idcard"];
            erm.human_age = int.Parse(Request["human_age"]);
            erm.human_college = Request["human_college"];
            erm.demand_salary_standard = decimal.Parse(Request["demand_salary_standard"]);
            erm.checker = Request["checker"];
            erm.check_time = DateTime.Parse(Request["check_time"]);
            erm.check_status = 1;
            erm.recomandation = Request["recomandation"];
            int i1 = erb.update1(erm);
            if (i1 > 0)
            {
                return Content(i1.ToString());
            }
            else
            {
                return Content(i1.ToString());
            }

        }
        public ActionResult validresume()
        {
            return View();
        }
        public ActionResult validlist()
        {
            string major_kind_id = Request["major_kind_id"];
            string major_id = Request["major_id"];
            string gjz = Request["gjz"];
            string startDate = Request["startDate"];
            string endDate = Request["endDate"];
            engage_resumeModel erm = new engage_resumeModel()
            {
                human_major_kind_name = major_kind_id,
                human_major_name = major_id,
                human_name = gjz,
                register = startDate,
                pass_register = endDate,
            };
            return View(erm);
        }
        public ActionResult validlist2(FormCollection form)
        {
            string major_kind_id = Request["human_major_kind_name"];
            string major_id = Request["human_major_name"];
            string gjz = Request["human_name"];
            string startDate = Request["register"];
            string endDate = Request["pass_register"];
            int currentPage = int.Parse(Request["currentPage"]);
            int rl = int.Parse(Request["rl"]);
            FenyeModel2 fy = erb.Fenye2(currentPage, rl, major_kind_id, major_id, gjz, startDate, endDate);
            return Content(JsonConvert.SerializeObject(fy));
        }
        public ActionResult resumeselect(int id)
        {
            ViewBag.dt = xlks(id);
            ViewBag.dt1 = xlk1s(id);
            ViewBag.dt2 = xlk2s(id);
            ViewBag.dt3 = xlk3s(id);
            ViewBag.dt4 = xlk4s(id);
            ViewBag.dt5 = xlk5s(id);
            ViewBag.dt6 = xlk6s(id);
            ViewBag.dt7 = xlk7s(id);
            ViewBag.dt8 = xlk8s(id);
            ViewBag.dt9 = xlk9s(id);
            ViewBag.dt10 = xlk10s(id);
            ViewBag.dt11 = xlk11s(id);
            ViewBag.dt12 = xlk12s(id);
            List<engage_resumeModel> list = erb.selectupdate(id);
            engage_resumeModel erm = new engage_resumeModel()
            {
                Id = list[0].Id,
                human_name = list[0].human_name,
                human_email = list[0].human_email,
                human_telephone = list[0].human_telephone,
                human_homephone = list[0].human_homephone,
                human_mobilephone = list[0].human_mobilephone,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_birthplace = list[0].human_birthplace,
                human_birthday = list[0].human_birthday,
                human_idcard = list[0].human_idcard,
                human_age = list[0].human_age,
                human_college = list[0].human_college,
                demand_salary_standard = list[0].demand_salary_standard,
                human_history_records = list[0].human_history_records,
                remark = list[0].remark,
                regist_time = list[0].regist_time,
                check_time = list[0].check_time,
                recomandation = list[0].recomandation
            };

            return View(erm);
        }
        public ActionResult interviewlist()
        {
            return View();
        }
        public ActionResult interviewlist2()
        {
            int currentPage = int.Parse(Request["currentPage"]);
            int rl = int.Parse(Request["rl"]);
            FenyeModel2 fy = erb.Fenye3(currentPage, rl);
            return Content(JsonConvert.SerializeObject(fy));
        }
        public ActionResult interviewregister2()
        {
            int id = int.Parse(Request["Id"]);
            List<engage_interviewModel> list = eib.selectupdate2(id);
            if (list.Count() == 0)
            {
                int i1 = 0;
                return Content(i1.ToString());
            }
            else {
                    int i1 = list[0].interview_amount;
                    return Content(i1.ToString());
            }
        
            
            
        }
        public ActionResult interviewregister(int id)
        {
            ViewBag.dl = xlkdl();
            List<engage_resumeModel> list = erb.selectupdate(id);
            engage_resumeModel erm = new engage_resumeModel()
            {
                Id = list[0].Id,
                human_major_kind_name = list[0].human_major_kind_name,
                human_major_kind_id = list[0].human_major_kind_id,
                human_major_id = list[0].human_major_id,
                human_major_name = list[0].human_major_name,
                engage_type = list[0].engage_type,
                human_name = list[0].human_name,
                human_sex = list[0].human_sex,
                human_email = list[0].human_email,
                human_telephone = list[0].human_telephone,
                human_homephone = list[0].human_homephone,
                human_mobilephone = list[0].human_mobilephone,
                human_address = list[0].human_address,
                human_postcode = list[0].human_postcode,
                human_nationality = list[0].human_nationality,
                human_birthplace = list[0].human_birthplace,
                human_birthday = list[0].human_birthday,
                human_race = list[0].human_race,
                human_religion = list[0].human_religion,
                human_party = list[0].human_party,
                human_idcard = list[0].human_idcard,
                human_age = list[0].human_age,
                human_college = list[0].human_college,
                human_educated_degree = list[0].human_educated_degree,
                human_educated_years = list[0].human_educated_years,
                human_educated_major = list[0].human_educated_major,
                demand_salary_standard = list[0].demand_salary_standard,
                regist_time = list[0].regist_time,
                human_specility = list[0].human_specility,
                human_hobby = list[0].human_hobby,
                checker = list[0].checker,
                check_time = list[0].check_time,
                human_history_records = list[0].human_history_records,
                remark = list[0].remark,
                recomandation = list[0].recomandation,

            };
            return View(erm);
        }
        [HttpPost]
        public ActionResult interviewregister(FormCollection collection)
        {
            int id = int.Parse(Request["Id"]);
            List<engage_interviewModel> list = eib.selectupdate2(id);
            if (list.Count() == 0)
            {
                int mscs = 0;
                engage_interviewModel eim = new engage_interviewModel();
                eim.human_name = Request["human_name"];
                eim.interview_amount = mscs + 1;
                eim.human_major_kind_id = Request["human_major_kind_id"];
                eim.human_major_kind_name = Request["human_major_kind_name"];
                eim.human_major_id = Request["human_major_id"];
                eim.human_major_name = Request["human_major_name"];
                eim.image_degree = Request["image_degree1"];
                eim.native_language_degree = Request["native_language_degree1"];
                eim.foreign_language_degree = Request["foreign_language_degree1"];
                eim.response_speed_degree = Request["response_speed_degree1"];
                eim.EQ_degree = Request["EQ_degree1"];
                eim.IQ_degree = Request["IQ_degree1"];
                eim.multi_quality_degree = Request["multi_quality_degree1"];
                eim.register = Request["register1"];
                eim.checker = null;
                eim.registe_time = DateTime.Parse(Request["registe_time"]);
                eim.check_time = DateTime.Now;
                eim.resume_id = int.Parse(Request["Id"]);
                eim.result = null;
                eim.interview_comment = Request["interview_comment"];
                eim.check_comment = null;
                eim.interview_status = 1;
                eim.check_status = 0;

                engage_resumeModel erm = new engage_resumeModel()
                {
                    Id = int.Parse(Request["Id"]),
                    interview_status = 1
                };
                int i1 = eib.Add1(eim);
                int i2 = erb.update2(erm);
                if (i1 > 0 && i2 > 0)
                {
                    return Content(i1.ToString());
                }
                else
                {
                    return Content(i1.ToString());
                }
            }
            else {
                int sl = list[0].interview_amount;
            if (sl>=1) {
                engage_interviewModel eim = new engage_interviewModel();
                eim.resume_id = id;
                eim.interview_amount = sl + 1;
                eim.human_name = Request["human_name"];
                eim.human_major_kind_id = Request["human_major_kind_id"];
                eim.human_major_kind_name = Request["human_major_kind_name"];
                eim.human_major_id = Request["human_major_id"];
                eim.human_major_name = Request["human_major_name"];
                eim.image_degree = Request["image_degree1"];
                eim.native_language_degree = Request["native_language_degree1"];
                eim.foreign_language_degree = Request["foreign_language_degree1"];
                eim.response_speed_degree = Request["response_speed_degree1"];
                eim.EQ_degree = Request["EQ_degree1"];
                eim.IQ_degree = Request["IQ_degree1"];
                eim.multi_quality_degree = Request["multi_quality_degree1"];
                eim.register = Request["register1"];
                eim.registe_time = DateTime.Parse(Request["registe_time"]);
                eim.check_time = DateTime.Now;
                eim.resume_id = int.Parse(Request["Id"]);
                eim.interview_comment = Request["interview_comment"];
                eim.interview_status = 1;
                eim.check_status = 0;
                engage_resumeModel erm = new engage_resumeModel()
                {
                    Id = int.Parse(Request["Id"]),
                    interview_status = 1
                };
                int i1 = eib.update3(eim);
                int i2 = erb.update2(erm);
                if (i1 > 0 && i2 > 0)
                {
                    return Content(i1.ToString());
                }
                else
                {
                    return Content(i1.ToString());
                }
            }
            else { 
            int mscs = list[0].interview_amount;
            engage_interviewModel eim = new engage_interviewModel();
            eim.human_name = Request["human_name"];
            if (mscs > 0)
            {
                eim.interview_amount = mscs + 1;
            }
            else
            {
                eim.interview_amount = 1;
            }
            eim.human_major_kind_id = Request["human_major_kind_id"];
            eim.human_major_kind_name = Request["human_major_kind_name"];
            eim.human_major_id = Request["human_major_id"];
            eim.human_major_name = Request["human_major_name"];
            eim.image_degree = Request["image_degree1"];
            eim.native_language_degree = Request["native_language_degree1"];
            eim.foreign_language_degree = Request["foreign_language_degree1"];
            eim.response_speed_degree = Request["response_speed_degree1"];
            eim.EQ_degree = Request["EQ_degree1"];
            eim.IQ_degree = Request["IQ_degree1"];
            eim.multi_quality_degree = Request["multi_quality_degree1"];
            eim.register = Request["register1"];
            eim.checker = null;
            eim.registe_time = DateTime.Parse(Request["registe_time"]);
            eim.check_time = DateTime.Now;
            eim.resume_id = int.Parse(Request["Id"]);
            eim.result = null;
            eim.interview_comment = Request["interview_comment"];
            eim.check_comment = null;
            eim.interview_status = 1;
            eim.check_status = 0;

            engage_resumeModel erm = new engage_resumeModel()
            {
                Id = int.Parse(Request["Id"]),
                interview_status = 1
            };
            int i1 = eib.Add1(eim);
            int i2 = erb.update2(erm);
            if (i1 > 0 && i2 > 0)
            {
                return Content(i1.ToString());
            }
            else
            {
                return Content(i1.ToString());
            }
            }
            }
        }
        public ActionResult siftlist()
        {
            return View();
        }
        public ActionResult siftlist2()
        {
            int currentPage = int.Parse(Request["currentPage"]);
            IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd HH':'mm':'ss" };
            int rl = int.Parse(Request["rl"]);
            FenYeModel3 fy = eib.Fenye4(currentPage, rl);
            return Content(JsonConvert.SerializeObject(fy, Formatting.Indented, timeConverter));
        }
        public ActionResult interviewsift(int id)
        {
            ViewBag.dl = xlkdl();
            List<engage_interviewModel> list3 = eib.selectupdate2(id);
            int mscs = list3[0].interview_amount;
            List<engage_interviewModel> list = eib.selectupdate2(id);
            list[0].interview_amount = mscs;
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            ViewBag.vb1 = list[0];
            ViewBag.vb2 = list2[0];
            return View();
        }
        [HttpPost]
        public ActionResult interviewsift(int id,FormCollection collection)
        {
            string pd = Request["pd"];
            if (pd=="1") {
                int id1 = int.Parse(Request["Id"]);
                int id2 = int.Parse(Request["eId"]);
                
                engage_interviewModel eim = new engage_interviewModel();
                eim.Id = id2;
                eim.checker = Request["checker123"];
                eim.check_time = DateTime.Now;
                eim.interview_status = 0;
                eim.check_status = 1;
                eim.check_comment = Request["pass_checkComment"];
                engage_resumeModel erm = new engage_resumeModel();
                erm.Id = id1;
                erm.interview_status = 0;
                erm.pass_checkComment = Request["pass_checkComment"];
                int i1 = eib.update2(eim);
                int i2 = erb.update3(erm);
                if (i1 > 0 && i2 > 0)
                {
                    return Content(i1.ToString());
                }
                else {
                    return Content(i1.ToString());
                }
            }
            if (pd == "2")
            {
                int id1 = int.Parse(Request["Id"]);
                int id2 = int.Parse(Request["eId"]);

                engage_interviewModel eim = new engage_interviewModel();
                eim.Id = id2;
                eim.checker = Request["checker123"];
                eim.check_time = DateTime.Now;
                eim.interview_status = 2;
                eim.check_status = 3;
                eim.check_comment = Request["pass_checkComment"];
                engage_resumeModel erm = new engage_resumeModel();
                erm.Id = id1;
                erm.interview_status = 2;
                erm.pass_checkComment = Request["pass_checkComment"];
                int i1 = eib.update2(eim);
                int i2 = erb.update3(erm);
                if (i1 > 0 && i2 > 0)
                {
                    return Content(i1.ToString());
                }
                else
                {
                    return Content(i1.ToString());
                }

            }
            if (pd == "3")
            {
                int id1 = int.Parse(Request["Id"]);
                int id2 = int.Parse(Request["eId"]);
                int i1 = eib.delete(id2);
                int i2 = erb.delete(id1);
                if (i1 > 0 && i2 > 0)
                {
                    return Content(i1.ToString());
                }
                else
                {
                    return Content(i1.ToString());
                }
            }
            return View();
        }
        public ActionResult registerlist() {
            return View();
        }
        public ActionResult registerlist2()
        {
            int currentPage = int.Parse(Request["currentPage"]);
            int rl = int.Parse(Request["rl"]);
            FenyeModel2 fy = erb.Fenye4(currentPage, rl);
            return Content(JsonConvert.SerializeObject(fy));
        }
        public ActionResult employregister(int id) {
            List<engage_interviewModel> list3 = eib.selectupdate2(id);
            int mscs = list3[0].interview_amount;
            List<engage_interviewModel> list = eib.selectupdate2(id);
            list[0].interview_amount = mscs;
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            ViewBag.vb1 = list[0];
            ViewBag.vb2 = list2[0];
            return View();
        }
        [HttpPost]
        public ActionResult employregister(FormCollection collection) {
            string pd = Request["pd"];
            if (pd=="1") {
                engage_interviewModel eim = new engage_interviewModel();
                eim.Id = int.Parse(Request["eId"]);
                eim.interview_status = 1;
                engage_resumeModel erm = new engage_resumeModel();
                erm.Id = int.Parse(Request["Id"]);
                erm.interview_status = 1;
                erm.pass_checkComment = Request["pass_checkComment"];
                int i1 = erb.update4(erm);
                int i2 = eib.update4(eim);
                if (i1 > 0 && i2 > 0)
                {
                    return Content(i1.ToString());
                }
                else
                {
                    return Content(i1.ToString());
                }
            }
            if (pd=="2") { 
            engage_interviewModel eim = new engage_interviewModel();
            eim.Id = int.Parse(Request["eId"]);
            eim.interview_status = 3;
            engage_resumeModel erm = new engage_resumeModel();
            erm.Id = int.Parse(Request["Id"]);
            erm.interview_status = 3;
            erm.pass_checkComment = Request["pass_checkComment"];
            int i1 = erb.update4(erm);
            int i2 = eib.update4(eim);
            if (i1 > 0 && i2 > 0)
            {
                return Content(i1.ToString());
            }
            else {
                return Content(i1.ToString());
            }
            }
            return View();
        }
        public ActionResult employchecklist() {
            return View();
        }
        public ActionResult employchecklist2()
        {
            int currentPage = int.Parse(Request["currentPage"]);
            int rl = int.Parse(Request["rl"]);
            FenyeModel2 fy = erb.Fenye6(currentPage, rl);
            return Content(JsonConvert.SerializeObject(fy));
        }
        public ActionResult employcheck(int id) {
            List<engage_interviewModel> list3 = eib.selectupdate2(id);
            int mscs = list3[0].interview_amount;
            List<engage_interviewModel> list = eib.selectupdate2(id);
            list[0].interview_amount = mscs;
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            ViewBag.vb1 = list[0];
            ViewBag.vb2 = list2[0];
            return View();
        }
        [HttpPost]
        public ActionResult employcheck(FormCollection collection) {
            string pd = Request["pd"];
            if (pd == "2")
            {
                engage_interviewModel eim = new engage_interviewModel();
                eim.Id = int.Parse(Request["eId"]);
                eim.interview_status = 2;
                engage_resumeModel erm = new engage_resumeModel();
                erm.Id = int.Parse(Request["Id"]);
                erm.interview_status = 2;
                erm.pass_passComment = Request["pass_passComment"];
                int i1 = erb.update5(erm);
                int i2 = eib.update4(eim);
                if (i1 > 0 && i2 > 0)
                {
                    return Content(i1.ToString());
                }
                else
                {
                    return Content(i1.ToString());
                }
            }
            if (pd == "1")
            {
                engage_interviewModel eim = new engage_interviewModel();
                eim.Id = int.Parse(Request["eId"]);
                eim.interview_status = 4;
                engage_resumeModel erm = new engage_resumeModel();
                erm.Id = int.Parse(Request["Id"]);
                erm.interview_status = 4;
                erm.pass_passComment = Request["pass_passComment"];
                int i1 = erb.update5(erm);
                int i2 = eib.update4(eim);
                if (i1 > 0 && i2 > 0)
                {
                    return Content(i1.ToString());
                }
                else
                {
                    return Content(i1.ToString());
                }
            }
            return View();
        }
        public ActionResult employlist() {
            return View();
        }
        public ActionResult employlist2()
        {
            int currentPage = int.Parse(Request["currentPage"]);
            int rl = int.Parse(Request["rl"]);
            FenyeModel2 fy = erb.Fenye6(currentPage, rl);
            return Content(JsonConvert.SerializeObject(fy));
        }
        public ActionResult employdetails(int id) {
            List<engage_interviewModel> list3 = eib.selectupdate2(id);
            int mscs = list3[0].interview_amount;
            List<engage_interviewModel> list = eib.selectupdate2(id);
            list[0].interview_amount = mscs;
            List<engage_resumeModel> list2 = erb.selectupdate(id);
            ViewBag.vb1 = list[0];
            ViewBag.vb2 = list2[0];
            return View();
        }
    }
}
