using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Model;
using ioc;
namespace UI.Controllers
{
    public class human_fileController : Controller
    {
        human_fileIBLL hhhhh = iocComm.human_fileBLL();
        // GET: human_file
        public ActionResult Index()
        {
            List<SelectListItem> list = NewMethod();
            ViewData["yj"] = list;

            List<SelectListItem> list1 = NewMethod1();
            ViewData["rj"] = list1;

            List<SelectListItem> list2 = NewMethod1();
            ViewData["sj"] = list2;
            List<SelectListItem> list3 = config_major_kind();
            ViewData["zwfl"] = list3;

            List<SelectListItem> list4 = config_major();
            ViewData["zwmc"] = list4;
            //职称
            List<SelectListItem> list5 = zc("职称");
            ViewData["zc"] = list5;
            //性别
            List<SelectListItem> list6 = zc("性别");
            ViewData["xb"] = list6;

            //国籍
            List<SelectListItem> list7 = zc("国籍");
            ViewData["gj"] = list7;

            //民族
            List<SelectListItem> list8 = zc("民族");
            ViewData["mz"] = list8;

            //宗教信仰
            List<SelectListItem> list9 = zc("宗教信仰");
            ViewData["zjxy"] = list9;

            //政治面貌
            List<SelectListItem> list10 = zc("政治面貌");
            ViewData["zzmm"] = list10;

            //学历
            List<SelectListItem> list11 = zc("学历");
            ViewData["xl"] = list11;

            //教育年限

            List<SelectListItem> list12 = zc("教育年限");
            ViewData["jylx"] = list12;
            //学历专业
            List<SelectListItem> list13 = zc("专业");
            ViewData["xlzy"] = list13;

            //薪酬标准bjcx
            List<SelectListItem> list14 = zc("薪酬设置");
            ViewData["bjcx"] = list14;

            //特长
            List<SelectListItem> list15 = zc("特长");
            ViewData["tc"] = list15;

            //爱好
            List<SelectListItem> list16 = zc("爱好");
            ViewData["ah"] = list16;
            return View();
        }
        //性别
       
        //职称 config_public_char
        private static List<SelectListItem> zc(string name)
        {
            List<SelectListItem> list1 = new List<SelectListItem>();
            config_public_charIBLL con = iocComm.config_public_charBLL();
            config_public_charModel ko = new config_public_charModel();
            ko.attribute_kind = name;
            List<config_public_charModel> li = con.SelectByKind(ko);
            foreach (config_public_charModel item in li)
            {
                SelectListItem sl = new SelectListItem()
                {
                    //设置文本值
                    Text = item.attribute_name,
                    //设置value值
                    Value = item.id.ToString()
                };
                list1.Add(sl);
            }

            return list1;
        }

        //config_major  职位名称
        private static List<SelectListItem> config_major()
        {
            List<SelectListItem> list1 = new List<SelectListItem>();
            config_majorIBLL con = iocComm.config_majorBLL();
            List<config_majorModel> li = con.select1();
            foreach (config_majorModel item in li)
            {
                SelectListItem sl = new SelectListItem()
                {
                    //设置文本值
                    Text = item.major_name,
                    //设置value值
                    Value = item.mak_id.ToString()
                };
                list1.Add(sl);
            }

            return list1;
        }
        //职位分类config_major_kind
        private static List<SelectListItem> config_major_kind()
        {
            List<SelectListItem> list1 = new List<SelectListItem>();
            config_major_kindIBLL con = iocComm.config_major_kindBLL();
            List<config_major_kindModel1> li = con.select1();
            foreach (config_major_kindModel1 item in li)
            {
                SelectListItem sl = new SelectListItem()
                {
                    //设置文本值
                    Text = item.major_kind_name,
                    //设置value值
                    Value = item.mfk_id.ToString()
                };
                list1.Add(sl);
            }

            return list1;
        }

        private static List<SelectListItem> NewMethod1()
        {
            List<SelectListItem> list1 = new List<SelectListItem>();
            config_file_second_kindIBLL con = iocComm.config_file_second_kindBLL();
            List<config_file_second_kindModel> li = con.select1();
            foreach (config_file_second_kindModel item in li)
            {
                SelectListItem sl = new SelectListItem()
                {
                    //设置文本值
                    Text = item.second_kind_name,
                    //设置value值
                    Value = item.Id.ToString()
                };
                list1.Add(sl);
            }

            return list1;
        }
        private static List<SelectListItem> NewMethod2()
        {
            List<SelectListItem> list1 = new List<SelectListItem>();
            config_file_third_kindIBLL con = iocComm.config_file_third_kindBLL();
            List<config_file_third_kindModel> li = con.select1();
            foreach (config_file_third_kindModel item in li)
            {
                SelectListItem sl = new SelectListItem()
                {
                    //设置文本值
                    Text = item.third_kind_name,
                    //设置value值
                    Value = item.Id.ToString()
                };
                list1.Add(sl);
            }

            return list1;
        }

        private static List<SelectListItem> NewMethod()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            config_file_first_kindIBLL con = iocComm.config_file_first_kindBLL();
            List<config_file_first_kindModel> li = con.select1();
            foreach (config_file_first_kindModel item in li)
            {
                SelectListItem sl = new SelectListItem()
                {
                    //设置文本值
                    Text = item.first_kind_name,
                    //设置value值
                    Value = item.Id.ToString()
                };
                list.Add(sl);
            }

            return list;
        }

        // GET: human_file/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: human_file/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: human_file/Create
        [HttpPost]
        public ActionResult hu(FormCollection collection)
        {
            try
            {
                //一级
                string first_kindid = Request["first_kind_id"];
                string first_kind_id = "";
                string first_kind_name = "";
                if (first_kind_id!=null|| !first_kind_id.Equals("")) {
                    config_file_first_kindIBLL yj = iocComm.config_file_first_kindBLL();
                    List<config_file_first_kindModel> con = yj.selectupdate(int.Parse(first_kindid));
                    first_kind_name = con[0].first_kind_name;
                    first_kind_id = con[0].first_kind_id;
                }
                
                //2级
                string second_kindid = Request["second_kind_id"];
                string second_kind_name = "";
                string second_kind_id = "";
                if (second_kindid != null || !second_kindid.Equals(""))
                {
                    config_file_second_kindIBLL yj = iocComm.config_file_second_kindBLL();
                    List<config_file_second_kindModel> con = yj.selectupdate(int.Parse(second_kindid));
                    second_kind_name = con[0].second_kind_name;
                    second_kind_id = con[0].second_kind_id;
                }

                //3级
                string third_kindid = Request["third_kind_id"];
                string third_kind_name = "";
                string third_kind_id = "";
                if (third_kindid != null || !third_kindid.Equals(""))
                {
                    config_file_third_kindIBLL yj = iocComm.config_file_third_kindBLL();
                    List<config_file_third_kindModel> con = yj.selectupdate(int.Parse(third_kindid));
                    third_kind_name = con[0].third_kind_name;
                    third_kind_id= con[0].third_kind_id;
                }
                //职位分类
                string human_major_kindid = Request["human_major_kind_id"];
                
                string human_major_kind_name = "";
                string human_major_kind_id = "";
                if (human_major_kindid != null || !human_major_kindid.Equals(""))
                {
                    config_major_kindIBLL yj = iocComm.config_major_kindBLL();
                    List<config_major_kindModel1> con = yj.selectupdate(human_major_kindid);
                    human_major_kind_name = con[0].major_kind_name;
                    human_major_kind_id = con[0].major_kind_id;
                }

                //职位名称
                string hunma_majorname = Request["hunma_major_name"];
                string hunma_major_name = "";
                string human_major_id = "";
                if (hunma_majorname != null || !hunma_majorname.Equals(""))
                {
                    config_majorIBLL yj = iocComm.config_majorBLL();
                    List<config_majorModel> con = yj.selectupdate(int.Parse(hunma_majorname));
                    hunma_major_name = con[0].major_name;
                    human_major_id = con[0].major_id;
                }

                //职称
                string human_prodesignation = Request["human_pro_designation"];
                string   human_pro_designation = cha(human_prodesignation);
                //姓名
                string human_name = Request["human_name"];
                //性别
                string humansex = Request["human_sex"];
                string human_sex = cha(humansex);
                //EMAIL
                string human_email = Request["human_email"];
                //电话
                string human_telephone = Request["human_telephone"];
                //QQ
                string human_qq = Request["human_qq"];
                //手机
                string human_mobilephone = Request["human_mobilephone"];
                //住址
                string human_address = Request["human_address"];
                //邮编
                string human_postcode = Request["human_postcode"];
                //国籍
                string humannationality = Request["human_nationality"];
                string human_nationality = cha(humannationality);
                //出生地
                string human_birthplace = Request["human_birthplace"];
                //生日
                string humanbirthday = Request["human_birthday"];
                DateTime human_birthday = Convert.ToDateTime(humanbirthday);
                //民族
                string humanrace = Request["human_race"];
                string human_race = cha(humanrace);
                //宗教信仰
                string humanreligion = Request["human_religion"];
                string human_religion = cha(humanreligion);
                //政治面貌
                string humanparty = Request["human_party"];
                string human_party = cha(humanparty);
                //身份证号码
                string human_id_card = Request["human_id_card"];
                //社会保障号码
                string human_society_security_id = Request["human_society_security_id"];
                //年龄
                string human_age = Request["human_age"];
                //学历
                string humaneducated_degree = Request["human_educated_degree"];
                string human_educated_degree = cha(humaneducated_degree);
                //教育年限
                string human_educatedyears = Request["human_educated_years"];
                string human_educated_years = cha(human_educatedyears);
                //学历专业
                string human_educatedmajor = Request["human_educated_major"];
                string human_educated_major = cha(human_educatedmajor);
                //薪酬标准
                string salary_standardid = Request["salary_standard_id"];
                string salary_standard_id = cha(salary_standardid);
                //开户行
                string human_bank = Request["human_bank"];
                //帐号
                string human_account = Request["human_account"];
                //登记人
                string register = Request["register"];
                //建档时间
                string regist_time = Request["regist_time"];
               
                //特长
                string humanspeciality = Request["human_speciality"];
                string human_speciality = cha(humanspeciality);
                //爱好
                string humanhobby = Request["human_hobby"];
                string human_hobby = cha(humanhobby);
                //个人履历
                string human_histroy_records = Request["human_histroy_records"];
                //家庭关系信息
                string human_family_membership = Request["human_family_membership"];
                //备注
                string remark = Request["remark"];
                //档案变更人 附件名称
                human_fileModel human = new human_fileModel();

                human.attachment_name = null;
                human.bonus_amount = 0;
                human.changer =null;
                human.change_time = DateTime.Now;
                human.checker = null;
                human.check_status = 0;
                human.file_chang_amount = 0;
                human.first_kind_id = first_kind_id;
                human.first_kind_name = first_kind_name;
                human.human_account = human_account;
                human.human_address = human_address;
                human.human_age = int.Parse(human_age);
                human.human_bank = human_bank;
                human.human_birthday = human_birthday;
                human.human_birthplace = human_birthplace;
                human.human_educated_degree = human_educated_degree;
                human.human_educated_major = human_educated_major;
                human.human_educated_years = int.Parse(human_educated_years);
                human.human_email = human_email;
                human.human_family_membership = human_family_membership;
                human.human_file_status = true;
                human.human_histroy_records = human_histroy_records;
                human.human_hobby = human_hobby;
                human.human_id_card = human_id_card;
                human.human_major_id = human_major_id;
                human.human_major_kind_id = human_major_kind_id;
                human.human_major_kind_name = human_major_kind_name;
                human.human_mobilephone = human_mobilephone;
                human.human_name = human_name;
                human.human_nationality = human_nationality;
                human.human_party = human_party;
                human.human_postcode = human_postcode;
                human.human_pro_designation = human_pro_designation;
                human.human_qq = human_qq;
                human.human_race = human_race;
                human.human_religion = human_religion;
                human.human_sex = human_sex;
                human.human_society_security_id = human_society_security_id;
                human.human_speciality = human_speciality;
                human.human_telephone = human_telephone;
                human.hunma_major_name = hunma_major_name;
                human.salary_standard_id = salary_standard_id;
                human.second_kind_id = second_kind_id;
                human.second_kind_name = second_kind_name;
                human.third_kind_id = third_kind_id;
                human.third_kind_name = third_kind_name;
                human.regist_time =DateTime.Now;
                human.training_amount = 0;
                

                int pd=   hhhhh.Add1(human);
                if (pd > 0)
                {
                    return Content("<script> window.location.href='/human_file/Index';alert('新增成功');</script>");
                }
                else {
                    return Content("<script> window.location.href='/human_file/Index';alert('新增失败');</script>");
                }
               
            }
            catch(Exception ex)
            {
                return View();
            }
        }
        public string cha(string id) {
            if (id != null || !id.Equals(""))
            {
                config_public_charIBLL yj = iocComm.config_public_charBLL();
                List<config_public_charModel> con = yj.selectupdate(int.Parse(id));
                return con[0].attribute_name;

            }
            else {
                return null;
            }

        }

        // GET: human_file/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: human_file/Edit/5
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

        // GET: human_file/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: human_file/Delete/5
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
