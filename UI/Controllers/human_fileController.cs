using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Model;
using ioc;
using Common;
using System.IO;
using Newtonsoft.Json;
using Model.bangzhu;

namespace UI.Controllers
{
    public class human_fileController : Controller
    {
        human_fileIBLL hhhhh = iocComm.human_fileBLL();
        human_file_digIBLL huuu = iocComm.human_file_digBLL();
        config_majorIBLL ctb = iocComm.config_majorBLL();
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



            //登记人
            List<SelectListItem> lis = djr();
            ViewData["djr"] = lis;
            
            //教育年限

            List<SelectListItem> list12 = zc("教育年限");
            ViewData["jylx"] = list12;
            //学历专业
            List<SelectListItem> list13 = zc("专业");
            ViewData["xlzy"] = list13;

            //薪酬标准bjcx
            List<SelectListItem> list14 = salary_standard();
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
        //登记人
       
        private static List<SelectListItem> djr()
        {
            List<SelectListItem> list1 = new List<SelectListItem>();
            usersIBLL us = iocComm.usersBLL();
          
          
            foreach (usersModel item in us.select1())
            {
                SelectListItem sl = new SelectListItem()
                {
                    //设置文本值
                    Text = item.u_true_name,
                    //设置value值
                    Value = item.u_true_name.ToString()
                };
                list1.Add(sl);
            }

            return list1;
        }


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
                    Value = item.attribute_name.ToString()
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
                    Value = item.major_id.ToString()
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
                    Value = item.major_kind_id.ToString()
                };
                list1.Add(sl);
            }

            return list1;
        }

        //职位分类config_major_kind
        private static List<SelectListItem> salary_standard()
        {
            List<SelectListItem> list1 = new List<SelectListItem>();
            salary_standardIBLL con = iocComm.salary_standardBLL();
            List<salary_standardModel> li = con.select1();
            foreach (salary_standardModel item in li)
            {
                SelectListItem sl = new SelectListItem()
                {
                    //设置文本值
                    Text = item.standard_name,
                    //设置value值
                    Value = item.id.ToString()
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
                    Value = item.second_kind_id.ToString()
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
                    Value = item.first_kind_id.ToString()
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
                    List<config_file_first_kindModel> con = yj.selectupdate1(int.Parse(first_kindid));
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
                    List<config_file_second_kindModel> con = yj.selectupdate1(int.Parse(second_kindid));
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
                string   human_pro_designation = human_prodesignation;
                //姓名
                string human_name = Request["human_name"];
                //性别
                string humansex = Request["human_sex"];
                string human_sex = humansex;
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
                string human_nationality = humannationality;
                //出生地
                string human_birthplace = Request["human_birthplace"];
                //生日
                string humanbirthday = Request["human_birthday"];
                DateTime human_birthday = Convert.ToDateTime(humanbirthday);
                //民族
                string humanrace = Request["human_race"];
                string human_race = humanrace;
                //宗教信仰
                string humanreligion = Request["human_religion"];
                string human_religion =humanreligion;
                //政治面貌
                string humanparty = Request["human_party"];
                string human_party = humanparty;
                //身份证号码
                string human_id_card = Request["human_id_card"];
                //社会保障号码
                string human_society_security_id = Request["human_society_security_id"];
                //年龄
                string human_age = Request["human_age"];
                //学历
                string humaneducated_degree = Request["human_educated_degree"];
                string human_educated_degree = humaneducated_degree;
                //教育年限
                string human_educatedyears = Request["human_educated_years"];
                string human_educated_years = human_educatedyears;
                //学历专业
                string human_educatedmajor = Request["human_educated_major"];
                string human_educated_major =human_educatedmajor;
                //薪酬标准
                string salary_standardid = Request["salary_standard_id"];
                //string salary_standard_id = cha(salary_standardid);

               

               
                string salary_standard_name = "";
                string salary_standard_id = "";
                decimal salary_sum = 0m;
                if (salary_standardid != null || !salary_standardid.Equals(""))
                {
                    salary_standardIBLL yj = iocComm.salary_standardBLL();
                    List<salary_standardModel> con = yj.selectupdate(int.Parse(salary_standardid));
                    salary_standard_name = con[0].standard_name;
                    salary_standard_id = con[0].standard_id;
                    salary_sum = con[0].salary_sum;                }

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
                string human_speciality = humanspeciality;
                //爱好
                string humanhobby = Request["human_hobby"];
                string human_hobby = humanhobby;
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
                human.human_file_status = false;
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
                human.register = register;
                human.second_kind_id = second_kind_id;
                human.second_kind_name = second_kind_name;
                human.third_kind_id = third_kind_id;
                human.third_kind_name = third_kind_name;
                human.regist_time =DateTime.Now;
                human.training_amount = 0;
                human.salary_standard_name = salary_standard_name;
                human.salary_standard_id = salary_standard_id;
                human.salary_sum = salary_sum;
               
                string pd=hhhhh.Add1(human);
                if (pd !=null)
                {
                     List<human_fileModel> list=  hhhhh.selectupdate(pd);
                    return JavaScript("alert('新增成功'); window.location.href='/human_file/wenjian?uid=" + list[0].id + "'");
                    
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
        public ActionResult wenjian(int uid)
        {

            return View(uid);
        }
        public ActionResult Delete(int id)
        {
            return View();
        }
        public ActionResult sc(string uid, HttpPostedFileBase file)
        {
            string name = Md5String.Md5CreateName(file.InputStream);//文件名
            string ext = Path.GetExtension(file.FileName);//后缀名
            //1 获得上传文件的完整路径
            string path = $"/Uploader/{DateTime.Now.ToString("yyyy/MM/dd")}/" + name + ext;
            string fullPath = Server.MapPath(path);
            new FileInfo(fullPath).Directory.Create();//创建文件夹
            //2 调用file.SaveAs(完整路径)
            file.SaveAs(fullPath);
           
            //根据uid做表的修改
            human_fileModel bin = new human_fileModel();
            bin.id =int.Parse(uid);
            bin.human_picture = fullPath;
            int pd = hhhhh.update1(bin);
            //如果存在puid 则修改数据
            //string p =Session["puid"].ToString();
            //if (p != null || !p.Equals("")) {
            //    human_file_digModel mo = new human_file_digModel();
            //    mo.id = int.Parse(p);
            //    mo.human_picture = fullPath;
            //    //判断是否修改成功
            //    int xgla=  huuu.update1(mo);
            //}
           
            //hhhhh.update1()
            if (pd > 0)
            {
                return Content("ok");
            }
            else {
                return Content("no");
            }
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
        //复核页面
        public ActionResult fuhe() {

            return View();
        }
      
        public ActionResult fuhe1()
        {
            int pd = int.Parse(Request["dqy"]);
            canshulei li = hhhhh.fenye(pd,2);
            string aa = JsonConvert.SerializeObject(li);
            return  Content(aa);
        }
        //提交复核
        public ActionResult tijiao(string id) {
            List<human_fileModel> li = hhhhh.selectupdate(id);
            human_fileModel ko = new human_fileModel();
            foreach (human_fileModel item in li)
            {
                ko = new human_fileModel();
                ko.id = item.id;
                ko.human_id = item.human_id;
                ko.first_kind_id = item.first_kind_id;
                ko.first_kind_name = item.first_kind_name;
                ko.second_kind_id = item.second_kind_id;
                ko.second_kind_name = item.second_kind_name;
                ko.third_kind_id = item.third_kind_id;
                ko.third_kind_name = item.third_kind_name;
                ko.human_name = item.human_name;
                ko.human_address = item.human_address;
                ko.human_postcode = item.human_postcode;
                ko.human_pro_designation = item.human_pro_designation;
                ko.human_major_kind_id = item.human_major_kind_id;
                ko.human_major_kind_name = item.human_major_kind_name;
                ko.human_major_id = item.human_major_id;
                ko.hunma_major_name = item.hunma_major_name;
                ko.human_telephone = item.human_telephone;
                ko.human_mobilephone = item.human_mobilephone;
                ko.human_bank = item.human_bank;
                ko.human_account = item.human_account;
                ko.human_qq = item.human_qq;
                ko.human_email = item.human_email;
                ko.human_hobby = item.human_hobby;
                ko.human_speciality = item.human_speciality;
                ko.human_sex = item.human_sex;
                ko.human_religion = item.human_religion;
                ko.human_party = item.human_party;
                ko.human_nationality = item.human_nationality;
                ko.human_race = item.human_race;
                ko.human_birthday = item.human_birthday;
                ko.human_birthplace = item.human_birthplace;
                ko.human_age = item.human_age;
                ko.human_educated_degree = item.human_educated_degree;
                ko.human_educated_years = item.human_educated_years;
                ko.human_educated_major = item.human_educated_major;
                ko.human_society_security_id = item.human_society_security_id;
                ko.human_id_card = item.human_id_card;
                ko.remark = item.remark;
                ko.salary_standard_id = item.salary_standard_id;
                ko.salary_standard_name = item.salary_standard_name;
                ko.salary_sum = item.salary_sum;
                ko.demand_salaray_sum = item.demand_salaray_sum;
                ko.paid_salary_sum = item.paid_salary_sum;
                ko.major_change_amount = item.major_change_amount;
                ko.bonus_amount = item.bonus_amount;
                ko.training_amount = item.training_amount;
                ko.file_chang_amount = item.file_chang_amount;
                ko.human_histroy_records = item.human_histroy_records;
                ko.human_family_membership = item.human_family_membership;
                ko.human_picture = item.human_picture;
                ko.attachment_name = item.attachment_name;
                ko.check_status = item.check_status;
                ko.register = item.register;
                ko.checker = item.checker;
                ko.changer = item.changer;
                ko.regist_time = item.regist_time;
                ko.check_time = item.check_time;
                ko.change_time = item.change_time;
                ko.lastly_change_time = item.lastly_change_time;
                ko.delete_time = item.delete_time;
                ko.recovery_time = item.recovery_time;
                ko.human_file_status = item.human_file_status;
            }
            string d = li[0].human_picture;
            string[] st = d.Split('U'); 
            ViewData["ttt"] ="../../U"+st[2];
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
            this.ViewData["human_sex"] = ko.human_sex;
            //国籍
            List<SelectListItem> list7 = zc("国籍");
            ViewData["gj"] = list7;
            //复核人
            List<SelectListItem> lis = djr();
            ViewData["djr"] = lis;
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
            //薪酬标准bjcx
            List<SelectListItem> list14 = salary_standard();
            ViewData["bjcx"] = list14;

            //特长
            List<SelectListItem> list15 = zc("特长");
            ViewData["tc"] = list15;

            //爱好
            List<SelectListItem> list16 = zc("爱好");
            ViewData["ah"] = list16;
            ViewData.Model = ko;


            return View();
        }
        public ActionResult xcsz()
        {

            config_public_charIBLL con = iocComm.config_public_charBLL();
            config_public_charModel ko = new config_public_charModel();
            ko.attribute_kind = "薪酬设置";
            List<config_public_charModel> li = con.SelectByKind(ko);
            string aa = JsonConvert.SerializeObject(li);
            return Content(aa);
        }

        public ActionResult qddd(FormCollection collection) {
            human_fileModel human = new human_fileModel();
            string hunma_majorname = Request["hunma_major_name"];
            string human_id = Request["human_id"];
             List<human_fileModel> list=  hhhhh.selectupdate(human_id);
            human.id = list[0].id;
            //职称
            string human_prodesignation = Request["human_pro_designation"];
            string human_pro_designation = human_prodesignation;
            human.human_pro_designation = human_pro_designation;
            //姓名
            string human_name = Request["human_name"];
            human.human_name = human_name;
            //性别
            string humansex = Request["human_sex"];
            string human_sex = humansex;
            human.human_sex = human_sex;
            //EMAIL
            string human_email = Request["human_email"];
            human.human_email = human_email;
            //电话
            string human_telephone = Request["human_telephone"];
            human.human_telephone = human_telephone;
            //QQ
            string human_qq = Request["human_qq"];
            human.human_qq = human_qq;
            //手机
            string human_mobilephone = Request["human_mobilephone"];
            human.human_mobilephone = human_mobilephone;
            //住址
            string human_address = Request["human_address"];
            human.human_address = human_address;
            //邮编
            string human_postcode = Request["human_postcode"];
            human.human_postcode = human_postcode;
            //国籍
            string humannationality = Request["human_nationality"];
            string human_nationality = humannationality;
            human.human_nationality = human_nationality;
            //出生地
            string human_birthplace = Request["human_birthplace"];
            human.human_birthplace = human_birthplace;
            //生日
            string humanbirthday = Request["human_birthday"];
            DateTime human_birthday = Convert.ToDateTime(humanbirthday);
            human.human_birthday = human_birthday;
            //民族
            string humanrace = Request["human_race"];
            string human_race = humanrace;
            human.human_race = human_race;
            //宗教信仰
            string humanreligion = Request["human_religion"];
            string human_religion = humanreligion;
            human.human_religion = human_religion;
            //政治面貌
            string humanparty = Request["human_party"];
            string human_party = humanparty;
            human.human_party = human_party;
            //身份证号码
            string human_id_card = Request["human_id_card"];
            human.human_id_card = human_id_card;
            //社会保障号码
            string human_society_security_id = Request["human_society_security_id"];
            human.human_society_security_id = human_society_security_id;
            //年龄
            string human_age = Request["human_age"];
            human.human_age = int.Parse(human_age);
            //学历
            string humaneducated_degree = Request["human_educated_degree"];
            string human_educated_degree = humaneducated_degree;
            human.human_educated_degree = human_educated_degree;
            //教育年限
            string human_educatedyears = Request["human_educated_years"];
            string human_educated_years = human_educatedyears;
            human.human_educated_years = int.Parse(human_educated_years);
            //学历专业
            string human_educatedmajor = Request["human_educated_major"];
            string human_educated_major = human_educatedmajor;
            human.human_educated_major = human_educated_major;
            //薪酬标准

            string salary_standardid = Request["salary_standard_id"];
            //string salary_standard_id = cha(salary_standardid);




            string salary_standard_name = "";
            string salary_standard_id = "";
            decimal salary_sum = 0m;
            if (salary_standardid != null || !salary_standardid.Equals(""))
            {
                salary_standardIBLL yj = iocComm.salary_standardBLL();
                List<salary_standardModel> con = yj.selectupdate(int.Parse(salary_standardid));
                salary_standard_name = con[0].standard_name;
                salary_standard_id = con[0].standard_id;
                salary_sum = con[0].salary_sum;
            }




            //开户行
            string human_bank = Request["human_bank"];
            human.human_bank = human_bank;
            //帐号
            string human_account = Request["human_account"];
            human.human_account = human_account;
            //复核人
            string register = Request["checker"];
            human.checker = register;
            //复核时间
            string check_time = Request["check_time"];
            human.check_time =DateTime.Parse( check_time);

            //特长
            string humanspeciality = Request["human_speciality"];
            string human_speciality = humanspeciality;
            human.human_speciality = human_speciality;
            //爱好
            string humanhobby = Request["human_hobby"];
            string human_hobby = humanhobby;
            human.human_hobby = human_hobby;
            //个人履历
            string human_histroy_records = Request["human_histroy_records"];
            human.human_histroy_records = human_histroy_records;
            //家庭关系信息
            string human_family_membership = Request["human_family_membership"];
            human.human_family_membership = human_family_membership;
            human.salary_standard_id = salary_standard_id;
            human.salary_sum = salary_sum;
            //备注
            string remark = Request["remark"];
            human.remark = remark;
            human.check_status = 1;
            int pd=hhhhh.update12(human);
            if (pd > 0)
            {
                //给薪酬发放添加数据
                //一级编号
                string ii = list[0].first_kind_id;
                //2级编号
                string i2 = list[0].second_kind_id;
                //3级编号
                string i3 = list[0].third_kind_id;
                //查询薪酬发放
                salary_grantIBLL sa = iocComm.salary_grantBLL();
                //薪酬发放详情
                salary_grant_detailsIBLL de = iocComm.salary_grant_detailsBLL();
                List<salary_grantModel> salary=  sa.select1();
                int p2d = 0;
                foreach (salary_grantModel item in salary)
                {
                    //如果1 2 3 级相同  给薪酬发放详情 添加一条信息
                    if (item.first_kind_id.Equals(ii) && item.second_kind_id.Equals(i2) && item.third_kind_id.Equals(i3)) {
                        salary_grant_detailsModel details = new salary_grant_detailsModel();
                        details.salary_grant_id= item.salary_grant_id;
                        //档案编号
                        details.human_id= list[0].human_id;
                        details.human_name= list[0].human_name;
                        details.salary_standard_sum= list[0].salary_sum;
                        details.salary_paid_sum= list[0].salary_sum;
                        p2d= de.Add1(details);
                        //修改薪酬发放表
                        salary_grantModel cgai = new salary_grantModel();
                        cgai.sgr_id = item.sgr_id;
                        cgai.human_amount = item.human_amount + 1;
                        cgai.salary_standard_sum=item.salary_standard_sum+ list[0].salary_sum;
                        cgai.salary_paid_sum=item.salary_paid_sum+ list[0].salary_sum;
                        int xg=  sa.updateFan(cgai);

                    }
                }
                return JavaScript("alert('修改成功'); window.location.href='/human_file/wenjian?uid=" + list[0].id + "'");




                // return RedirectToAction("Index");
                //return RedirectToAction("config_majorController1", "Index");  //RedirectToAction("Index");
            }
            else
            {
                return JavaScript("alert('修改失败'); window.location.href='/human_file/tijiao?id="+human.human_id+"'");

            }
        }
        public ActionResult query_locate() {
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
            return View();

        }
        public ActionResult dacx(FormCollection collection) {
            string first_kind_id = Request["first_kind_id"];
            if (first_kind_id == null || first_kind_id == "")
            {
                first_kind_id = "查询全部";
            }
            
            string second_kind_id = Request["second_kind_id"];
            if (second_kind_id == null || second_kind_id == "")
            {
                second_kind_id = "查询全部";
            }
           
            string third_kind_id = Request["third_kind_id"];
            if (third_kind_id == null || third_kind_id == "")
            {
                third_kind_id = "查询全部";
            }
           
            string human_major_kind_id = Request["human_major_kind_id"];
            if (human_major_kind_id == null || human_major_kind_id == "")
            {
                human_major_kind_id = "查询全部";
            }
            else
            {
                human_major_kind_id = "0" + human_major_kind_id;
            }
            string hunma_major_name = Request["hunma_major_name"];
            if (hunma_major_name == null || hunma_major_name == "")
            {
                hunma_major_name = "查询全部";
            }
            else
            {
                hunma_major_name = "0" + hunma_major_name;
            }
            string utilBeanstartDate = Request["utilBean.startDate"];
            string utilBeandatePropertyName = Request["utilBean.endDate"];
             DateTime ji=   DateTime.Parse(utilBeanstartDate);
            DateTime ji2 = DateTime.Parse(utilBeandatePropertyName);
            Cansh ba = new Cansh();
            ba.third_kind_id = third_kind_id;
            ba.second_kind_id = second_kind_id;
            ba.human_major_kind_id = human_major_kind_id;
            ba.hunma_major_name = hunma_major_name;
            ba.first_kind_id = first_kind_id;
            ba.utilBeanstartDate = ji;
            ba.utilBeandatePropertyName = ji2;
            ba.rl = 2;
            ba.dqy = 1;
            //canshulei can=  hhhhh.fenye2(ba);
            //string aa = JsonConvert.SerializeObject(can);
            Session["tiaojian"] = ba;
            
            return View();
            
        }
        public ActionResult dacx1(int id)
        {
            Cansh ba = new Cansh();
             ba= (Cansh)Session["tiaojian"];
            ba.dqy = id;
            ba.human_file_status = false;
            canshulei can=  hhhhh.fenye2(ba);
            string aa = JsonConvert.SerializeObject(can);
            return Content(aa);
        }
        public ActionResult change_keywords() {
            return View();
        }
        public ActionResult biandeng() {
           string name=   Request["human_name"];
            Session["name"] = name;
            return View();
        }
        public ActionResult change_keywords1(int id)
        {
           
           string ba = (string)Session["name"];
          
            canshulei can = hhhhh.fenye3(id,2,ba);
            string aa = JsonConvert.SerializeObject(can);
            return Content(aa);
        }
        public ActionResult bian(string id)
        {

            List<human_fileModel> li = hhhhh.selectupdate(id);
            human_fileModel ko = new human_fileModel();
            foreach (human_fileModel item in li)
            {
                ko = new human_fileModel();
                ko.id = item.id;
                ko.human_id = item.human_id;
                ko.first_kind_id = item.first_kind_id;
                ko.first_kind_name = item.first_kind_name;
                ko.second_kind_id = item.second_kind_id;
                ko.second_kind_name = item.second_kind_name;
                ko.third_kind_id = item.third_kind_id;
                ko.third_kind_name = item.third_kind_name;
                ko.human_name = item.human_name;
                ko.human_address = item.human_address;
                ko.human_postcode = item.human_postcode;
                ko.human_pro_designation = item.human_pro_designation;
                ko.human_major_kind_id = item.human_major_kind_id;
                ko.human_major_kind_name = item.human_major_kind_name;
                ko.human_major_id = item.human_major_id;
                ko.hunma_major_name = item.hunma_major_name;
                ko.human_telephone = item.human_telephone;
                ko.human_mobilephone = item.human_mobilephone;
                ko.human_bank = item.human_bank;
                ko.human_account = item.human_account;
                ko.human_qq = item.human_qq;
                ko.human_email = item.human_email;
                ko.human_hobby = item.human_hobby;
                ko.human_speciality = item.human_speciality;
                ko.human_sex = item.human_sex;
                ko.human_religion = item.human_religion;
                ko.human_party = item.human_party;
                ko.human_nationality = item.human_nationality;
                ko.human_race = item.human_race;
                ko.human_birthday = item.human_birthday;
                ko.human_birthplace = item.human_birthplace;
                ko.human_age = item.human_age;
                ko.human_educated_degree = item.human_educated_degree;
                ko.human_educated_years = item.human_educated_years;
                ko.human_educated_major = item.human_educated_major;
                ko.human_society_security_id = item.human_society_security_id;
                ko.human_id_card = item.human_id_card;
                ko.remark = item.remark;
                ko.salary_standard_id = item.salary_standard_id;
                ko.salary_standard_name = item.salary_standard_name;
                ko.salary_sum = item.salary_sum;
                ko.demand_salaray_sum = item.demand_salaray_sum;
                ko.paid_salary_sum = item.paid_salary_sum;
                ko.major_change_amount = item.major_change_amount;
                ko.bonus_amount = item.bonus_amount;
                ko.training_amount = item.training_amount;
                ko.file_chang_amount = item.file_chang_amount;
                ko.human_histroy_records = item.human_histroy_records;
                ko.human_family_membership = item.human_family_membership;
                ko.human_picture = item.human_picture;
                ko.attachment_name = item.attachment_name;
                ko.check_status = item.check_status;
                ko.register = item.register;
                ko.checker = item.checker;
                ko.changer = item.changer;
                ko.regist_time = item.regist_time;
                ko.check_time = item.check_time;
                ko.change_time = item.change_time;
                ko.lastly_change_time = item.lastly_change_time;
                ko.delete_time = item.delete_time;
                ko.recovery_time = item.recovery_time;
                ko.human_file_status = item.human_file_status;
            }
            string d = li[0].human_picture;
            string[] st = d.Split('U');
            ViewData["ttt"] = "../../U" + st[2];
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
            ViewData.Model = ko;


            return View();
        }

        //确认变更
        public ActionResult qrbg(FormCollection collection) {
            human_file_digModel yy = new human_file_digModel();
            human_fileModel human = new human_fileModel();
            string hunma_majorname = Request["hunma_major_name"];
            string human_id = Request["human_id"];
            List<human_fileModel> list = hhhhh.selectupdate(human_id);
            human.id = list[0].id;

            yy.human_id = human_id;
            //职称
            string human_prodesignation = Request["human_pro_designation"];
            string human_pro_designation = cha(human_prodesignation);
            human.human_pro_designation = human_pro_designation;
            yy.human_pro_designation = human_pro_designation;
            //姓名
            string human_name = Request["human_name"];
            human.human_name = human_name;
            yy.human_id = human_id;
            //性别
            string humansex = Request["human_sex"];
            string human_sex = cha(humansex);
            human.human_sex = human_sex;
            yy.human_id = human_id;
            //EMAIL
            string human_email = Request["human_email"];
            human.human_email = human_email;
            yy.human_email = human_email;
            //电话
            string human_telephone = Request["human_telephone"];
            human.human_telephone = human_telephone;
            yy.human_telephone = human_telephone;
            //QQ
            string human_qq = Request["human_qq"];
            human.human_qq = human_qq;
            yy.human_qq = human_qq;
            //手机
            string human_mobilephone = Request["human_mobilephone"];
            human.human_mobilephone = human_mobilephone;
            yy.human_mobilephone = human_mobilephone;
            //住址
            string human_address = Request["human_address"];
            human.human_address = human_address;
            yy.human_address = human_address;
            //邮编
            string human_postcode = Request["human_postcode"];
            human.human_postcode = human_postcode;
            yy.human_postcode = human_postcode;
            //国籍
            string humannationality = Request["human_nationality"];
            string human_nationality = cha(humannationality);
            human.human_nationality = human_nationality;
            yy.human_nationality = human_nationality;
            //出生地
            string human_birthplace = Request["human_birthplace"];
            human.human_birthplace = human_birthplace;
            yy.human_birthplace = human_birthplace;
            //生日
            string humanbirthday = Request["human_birthday"];
            DateTime human_birthday = Convert.ToDateTime(humanbirthday);
            human.human_birthday = human_birthday;
            yy.human_birthday = human_birthday;
            //民族
            string humanrace = Request["human_race"];
            string human_race = cha(humanrace);
            human.human_race = human_race;
            yy.human_race = human_race;
            //宗教信仰
            string humanreligion = Request["human_religion"];
            string human_religion = cha(humanreligion);
            human.human_religion = human_religion;
            yy.human_religion = human_religion;
            //政治面貌
            string humanparty = Request["human_party"];
            string human_party = cha(humanparty);
            human.human_party = human_party;
            yy.human_party = human_party;
            //身份证号码
            string human_id_card = Request["human_id_card"];
            human.human_id_card = human_id_card;
            yy.human_id_card = human_id_card;
            //社会保障号码
            string human_society_security_id = Request["human_society_security_id"];
            human.human_society_security_id = human_society_security_id;
            yy.human_society_security_id = human_society_security_id;
            //年龄
            string human_age = Request["human_age"];
            human.human_age = int.Parse(human_age);
            yy.human_age = int.Parse(human_age);
            //学历
            string humaneducated_degree = Request["human_educated_degree"];
            string human_educated_degree = cha(humaneducated_degree);
            human.human_educated_degree = human_educated_degree;
            yy.human_educated_degree = human_educated_degree;
            //教育年限
            string human_educatedyears = Request["human_educated_years"];
            string human_educated_years = cha(human_educatedyears);
            human.human_educated_years = int.Parse(human_educated_years);
            yy.human_educated_years = int.Parse(human_educated_years);
            //学历专业
            string human_educatedmajor = Request["human_educated_major"];
            string human_educated_major = cha(human_educatedmajor);
            human.human_educated_major = human_educated_major;
            yy.human_educated_major = human_educated_major;
            //薪酬标准
            string salary_standardid = Request["salary_standard_id"];
            string salary_standard_id = cha(salary_standardid);
            human.salary_standard_id = salary_standard_id;
            yy.salary_standard_id = salary_standard_id;
            //开户行
            string human_bank = Request["human_bank"];
            human.human_bank = human_bank;
            yy.human_bank = human_bank;
            //帐号
            string human_account = Request["human_account"];
            human.human_account = human_account;
            yy.human_account = human_account;
            //变更人
            string register = Request["checker"];
            human.changer = register;
            yy.changer = register;
            //变更时间
            string check_time = Request["check_time"];
            human.change_time = DateTime.Parse(check_time);
            yy.change_time = DateTime.Parse(check_time);
            //最近变更时间
            human.lastly_change_time = DateTime.Parse(check_time);
            yy.lastly_change_time = DateTime.Parse(check_time);
            //特长
            string humanspeciality = Request["human_speciality"];
            string human_speciality = cha(humanspeciality);
            human.human_speciality = human_speciality;
            yy.human_speciality = human_speciality;
            //爱好
            string humanhobby = Request["human_hobby"];
            string human_hobby = cha(humanhobby);
            human.human_hobby = human_hobby;
            yy.human_hobby = human_hobby;
            //个人履历
            string human_histroy_records = Request["human_histroy_records"];
            human.human_histroy_records = human_histroy_records;
            yy.human_histroy_records = human_histroy_records;
            //家庭关系信息
            string human_family_membership = Request["human_family_membership"];
            human.human_family_membership = human_family_membership;
            yy.human_family_membership = human_family_membership;
            //备注
            string remark = Request["remark"];
            human.remark = remark;
            yy.remark = remark;
            //复核状态
            human.check_status = 0;
            yy.check_status = 0;
           
            int xxz = huuu.Add1(yy);
            //Session["puid"] = xxz;
            int pd = hhhhh.update13(human);
            if (pd > 0)
            {
                //return  RedirectToAction("Index", new RouteValueDictionary(
                // new { controller = "Index", action = "config_majorController1" }));
                // return Content("ok");

                return JavaScript("alert('修改成功'); window.location.href='/human_file/wenjian?uid=" + list[0].id + "'");

                // return RedirectToAction("Index");
                //return RedirectToAction("config_majorController1", "Index");  //RedirectToAction("Index");
            }
            else
            {
                return JavaScript("alert('修改失败'); window.location.href='/human_file/tijiao?id=" + human.human_id + "'");

            }
        }
        //删除管理
        public ActionResult delete_locate() {
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
            return View();
        }
        //删除管理查询
        [HttpPost]
        public ActionResult delete_locateDEL(FormCollection collection) {
            string first_kind_id = Request["first_kind_id"];
            if (first_kind_id == null || first_kind_id == "")
            {
                first_kind_id = "查询全部";
            }

            string second_kind_id = Request["second_kind_id"];
            if (second_kind_id == null || second_kind_id == "")
            {
                second_kind_id = "查询全部";
            }

            string third_kind_id = Request["third_kind_id"];
            if (third_kind_id == null || third_kind_id == "")
            {
                third_kind_id = "查询全部";
            }

            string human_major_kind_id = Request["human_major_kind_id"];
            if (human_major_kind_id == null || human_major_kind_id == "")
            {
                human_major_kind_id = "查询全部";
            }
            else
            {
                human_major_kind_id = "0" + human_major_kind_id;
            }
            string hunma_major_name = Request["hunma_major_name"];
            if (hunma_major_name == null || hunma_major_name == "")
            {
                hunma_major_name = "查询全部";
            }
            else
            {
                hunma_major_name = "0" + hunma_major_name;
            }
            string utilBeanstartDate = Request["utilBean.startDate"];
            string utilBeandatePropertyName = Request["utilBean.endDate"];
            DateTime ji = DateTime.Parse(utilBeanstartDate);
            DateTime ji2 = DateTime.Parse(utilBeandatePropertyName);
            Cansh ba = new Cansh();
            ba.third_kind_id = third_kind_id;
            ba.second_kind_id = second_kind_id;
            ba.human_major_kind_id = human_major_kind_id;
            ba.hunma_major_name = hunma_major_name;
            ba.first_kind_id = first_kind_id;
            ba.utilBeanstartDate = ji;
            ba.utilBeandatePropertyName = ji2;
            ba.human_file_status = false;
            ba.rl = 2;
            ba.dqy = 1;
            Session["delete_locateDELtiaojian"] = ba;
            return RedirectToAction("delete_locateDEL12");

        }
        public ActionResult delete_locateDEL12() {
            return View();
        }

        //删除管理查询页面

        public ActionResult delete_listSelete(int id) {
            Cansh ba = new Cansh();
            ba = (Cansh)Session["delete_locateDELtiaojian"];
            ba.dqy=id;
            ba.human_file_status = false;
            canshulei can = hhhhh.fenye2(ba);
            string aa = JsonConvert.SerializeObject(can);
            return Content(aa);
        }
        //删除delete_listSeleteDel
        public ActionResult delete_listSeleteDel(string id)
        {
            //查询该对象
         List<human_fileModel>  huameModel = hhhhh.selectupdate(id);
            //判断是否fuh
            if (huameModel[0].check_status == 0)
            {
                return Content("<script>alert('不能删除喔！还没有复核'); window.location.href='/human_file/delete_locateDEL12';</script>");
            }
            else {
                human_fileModel model = new human_fileModel();
                model.human_file_status = true;
                model.id = huameModel[0].id;
                model.delete_time = DateTime.Now;
                int pd=hhhhh.updateztai(model);
                return Content("<script>alert('状态已删除！'); window.location.href='/human_file/delete_locateDEL12';</script>");
            }

            
        }
        //人力资源档案恢复查询
        public ActionResult recovery_locate() {
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
            return View();
        }
        //人力资源档案恢复查询条件保存
        public ActionResult recovery_locatebaocue(FormCollection collection) {
            string first_kind_id = Request["first_kind_id"];
            if (first_kind_id == null || first_kind_id == "")
            {
                first_kind_id = "查询全部";
            }

            string second_kind_id = Request["second_kind_id"];
            if (second_kind_id == null || second_kind_id == "")
            {
                second_kind_id = "查询全部";
            }

            string third_kind_id = Request["third_kind_id"];
            if (third_kind_id == null || third_kind_id == "")
            {
                third_kind_id = "查询全部";
            }

            string human_major_kind_id = Request["human_major_kind_id"];
            if (human_major_kind_id == null || human_major_kind_id == "")
            {
                human_major_kind_id = "查询全部";
            }
            else
            {
                human_major_kind_id = "0" + human_major_kind_id;
            }
            string hunma_major_name = Request["hunma_major_name"];
            if (hunma_major_name == null || hunma_major_name == "")
            {
                hunma_major_name = "查询全部";
            }
            else
            {
                hunma_major_name = "0" + hunma_major_name;
            }
            string utilBeanstartDate = Request["utilBean.startDate"];
            string utilBeandatePropertyName = Request["utilBean.endDate"];
            DateTime ji = DateTime.Parse(utilBeanstartDate);
            DateTime ji2 = DateTime.Parse(utilBeandatePropertyName);
            Cansh ba = new Cansh();
            ba.third_kind_id = third_kind_id;
            ba.second_kind_id = second_kind_id;
            ba.human_major_kind_id = human_major_kind_id;
            ba.hunma_major_name = hunma_major_name;
            ba.first_kind_id = first_kind_id;
            ba.utilBeanstartDate = ji;
            ba.utilBeandatePropertyName = ji2;
            ba.human_file_status = true;
            ba.rl = 2;
            ba.dqy = 1;
            Session["recovery_locatebaocuen"] = ba;
            return RedirectToAction("recovery_locatChan");
        }

        
        public ActionResult recovery_locatChan() {

            return View();
        }
        public ActionResult recovery(int id) {
            Cansh ba = new Cansh();
            ba = (Cansh)Session["recovery_locatebaocuen"];
            ba.dqy = id;
            ba.human_file_status = true;
            canshulei can = hhhhh.fenye2(ba);
            string aa = JsonConvert.SerializeObject(can);
            return Content(aa);
        }
        public ActionResult reupdate(string id) {
            List<human_fileModel> huameModel = hhhhh.selectupdate(id);
            human_fileModel model = new human_fileModel();
            model.human_file_status = false;
            model.id = huameModel[0].id;
            model.recovery_time = DateTime.Now;
            int pd = hhhhh.updateztai(model);
            if (pd > 0)
            {
                return Content("<script>alert('已恢复！'); window.location.href='/human_file/recovery_locatChan';</script>");
            }
            else {
                return Content("<script>alert('恢复失败！'); window.location.href='/human_file/recovery_locatChan';</script>");
            }
           
        }
        //档案永久删除
        public ActionResult delete_forever_list() {
            return View();
        }
        public ActionResult delete_forever_list1(int dqy)
        {
             
            canshulei can = hhhhh.fenye4(dqy, 2);
            string aa = JsonConvert.SerializeObject(can);
            return Content(aa);
        }
        public ActionResult Deletefa() {
            string hu = Request["fa"].ToString();
            List<human_fileModel> huameModel = hhhhh.selectupdate(Request["fa"].ToString());
            int it = huameModel[0].id;
            int pd = hhhhh.delete(it);
            if (pd > 0)
            {
                return Content("已删除！");
                
            }
            else
            {
                return Content("删除失败！");
            }
        }
        //职位下拉框
        public ActionResult chaxun() {
            string Sid = Request["id"];
            //Sid = "0" + Sid;
            List<config_majorModel> list = ctb.selectxlk1(Sid);
            return Content(JsonConvert.SerializeObject(list));
        }

    }
}
