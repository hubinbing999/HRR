using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;
using ioc;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using IBLL;

namespace UI.Controllers
{
    /// <summary>
    /// 调动控制器
    /// </summary>
    public class transferController : Controller
    {
        human_fileBLL ibl = new human_fileBLL();
        // GET: transfer
        public ActionResult Index()
        {
            return View();
        }

        public   ActionResult register_locate()
        {
            BandFirst();
            return View();
        }

        private List<SelectListItem> BandFirst()
        {
            config_file_first_kindBLL ial = new config_file_first_kindBLL();
            List<config_file_first_kindModel> list = ial.select1();        
            List<SelectListItem> list2 = new List<SelectListItem>();
            foreach (config_file_first_kindModel item in list)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.first_kind_name,
                    Value = item.first_kind_id
                };
                list2.Add(sl);
            }
            ViewBag.dt = list2;
            //查询所有一级机构
            return list2;
        }
        private List<SelectListItem> BandFLZW()
        {
            config_major_kindIBLL ikl = iocComm.config_major_kindBLL();
            List<config_major_kindModel1> list = ikl.select1();
            List<SelectListItem> list2 = new List<SelectListItem>();
            foreach (config_major_kindModel1 item in list)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.major_kind_name,
                    Value = item.major_kind_id
                };
                list2.Add(sl);
            }
            ViewBag.zw = list2;
           
            return list2;

        }
        /// <summary>
        /// 绑定职位名称
        /// </summary>
        /// <returns></returns>
       
        public ActionResult BandZW()
        {
            config_majorIBLL iml = iocComm.config_majorBLL();
            string s1 = Request["zid"];
            List<config_majorModel> list2 = iml.selectxlk1(s1);
            return Content(JsonConvert.SerializeObject(list2));
        }
        salary_standardIBLL isl = iocComm.salary_standardBLL();
        /// <summary>
        /// 绑定薪酬表
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> BandXC()
        {
           
            List<salary_standardModel> list = isl.select1();
            List<SelectListItem> list2 = new List<SelectListItem>();
            foreach (salary_standardModel item in list)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.standard_name,
                    Value = item.ssd_id.ToString()
                };
                list2.Add(sl);
            }
            ViewBag.xc = list2;
            //查询所有一级机构
            return list2;


        }
      public ActionResult BandMoney()
        {
            string id = Request["id"];
            List<salary_standardModel> list = isl.selectupdate(int.Parse(id));
            return Content(JsonConvert.SerializeObject(list));
    }

        /// <summary>
        /// 查询后跳转的页面
        /// </summary>
        /// <returns></returns>
        public ActionResult index2()
        {
            return View();
        }
        //拿到查询条件，分页显示查询结果
        int rows;
        int pages;
        public ActionResult  SelectFenYe()
        {
            string yi = Request["yi"];
            string er = Request["er"];
            string san = Request["san"];
            string dateStart = Request["dateStart"];
            string dateEnd = Request["dateEnd"];
            string dqy = Request["dqy"];
            string pagesize = Request["pagesize"];
            string where = null;
            if (dateStart == "" && dateEnd == "")
            {
                where = $"first_kind_name like'%{yi}%' and second_kind_name like '%{er}%' and third_kind_name like '%{san}%'";
            }
            else
            {
                DateTime Start = DateTime.Parse(dateStart);
                DateTime End = DateTime.Parse(dateEnd);

                where = $"first_kind_name   like'%{yi}%' and second_kind_name like '%{er}%' and third_kind_name like '%{san}%' and regist_time >= '{Start}' and regist_time  <= '{End}'";
            }
            DataTable dt = ibl.FenYe(int.Parse(dqy), out rows, out pages, where, int.Parse(pagesize));
            int row = rows;
            int page = pages;
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["dt"] = dt;
            di["rows"] = row;
            di["pages"] = page;
            return Content(JsonConvert.SerializeObject(di));
        }
        /// <summary>
        /// 调动跳转页面
        /// </summary>
        /// <returns></returns>
        public ActionResult index3()
        {
            string id = Request["id"];
            //根据id查出原机构
          List<human_fileModel> list = ibl.selectupdate(id);
            human_fileModel hh = new human_fileModel()
            {
                
               huf_id = list[0].huf_id,
               human_id = list[0].human_id,
               first_kind_id = list[0].first_kind_id,
               first_kind_name = list[0].first_kind_name,
               second_kind_id = list[0].second_kind_id,
               second_kind_name = list[0].second_kind_name,
               third_kind_id = list[0].third_kind_id,
               third_kind_name = list[0].third_kind_name,
               human_name = list[0].human_name,
               human_address = list[0].human_address,
               human_postcode = list[0].human_postcode,
               human_pro_designation = list[0].human_pro_designation,
               human_major_kind_id = list[0].human_major_kind_id,
               human_major_kind_name = list[0].human_major_kind_name,
               human_major_id = list[0].human_major_id,
               hunma_major_name = list[0].hunma_major_name,
               human_telephone = list[0].human_telephone,
               human_mobilephone = list[0].human_mobilephone,
               human_bank = list[0].human_bank,
               human_account = list[0].human_account,
               human_qq = list[0].human_qq,
               human_email = list[0].human_email,
               human_hobby = list[0].human_hobby,
               human_speciality = list[0].human_speciality,
               human_sex = list[0].human_sex,
               human_religion = list[0].human_religion,
               human_party = list[0].human_party,
               human_nationality = list[0].human_nationality,
               human_race = list[0].human_race,
               human_birthday = list[0].human_birthday,
               human_birthplace = list[0].human_birthplace,
               human_age = list[0].human_age,
               human_educated_degree = list[0].human_educated_degree,
               human_educated_years = list[0].human_educated_years,
               human_educated_major = list[0].human_educated_major,
               human_society_security_id = list[0].human_society_security_id,
               human_id_card = list[0].human_id_card,
               remark = list[0].remark,
               salary_standard_id = list[0].salary_standard_id,
               salary_standard_name = list[0].salary_standard_name,
               salary_sum = list[0].salary_sum,
               demand_salaray_sum = list[0].demand_salaray_sum,
               paid_salary_sum = list[0].paid_salary_sum,
               major_change_amount = list[0].major_change_amount,
               bonus_amount = list[0].bonus_amount,
               training_amount = list[0].training_amount,
               file_chang_amount = list[0].file_chang_amount,
               human_histroy_records = list[0].human_histroy_records,
               human_family_membership = list[0].human_family_membership,
               human_picture = list[0].human_picture,
               attachment_name = list[0].attachment_name,
               check_status = list[0].check_status,
               register = list[0].register,
               checker = list[0].checker,
               changer = list[0].changer,
               regist_time = list[0].regist_time,
               check_time = list[0].check_time,
               change_time = list[0].change_time,
               lastly_change_time = list[0].lastly_change_time,
               delete_time = list[0].delete_time,
               recovery_time = list[0].recovery_time,
               human_file_status = list[0].human_file_status

        };
            //返回给页面
            BandFirst();
            BandFLZW();
              BandXC();
            ViewData.Model = hh;
            return View();
        }

        public ActionResult jueseTJ()
        {
            major_changeIBLL imm = iocComm.major_changeBLL();
            string Major_change = Request["major_change"];
            Dictionary<string, object> di = JsonConvert.DeserializeObject<Dictionary<string, object>>(Major_change);
            major_changeModel mm = new major_changeModel()
            {
                first_kind_id = di["first_kind_id"].ToString(),//
                first_kind_name = di["first_kind_name"].ToString(),//
                second_kind_id = di["second_kind_id"].ToString(),//
                second_kind_name = di["second_kind_name"].ToString(),//
                third_kind_id = di["third_kind_id"].ToString(),//
                third_kind_name = di["third_kind_name"].ToString(),//
               // major_kind_id = di["major_kind_id"].ToString(),
                major_kind_name = di["major_kind_name"].ToString(),
               // major_id = di["major_id"].ToString(),
                major_name = di["major_name"].ToString(),
                new_first_kind_id = di["new_first_kind_id"].ToString(),//
                new_first_kind_name = di["new_first_kind_name"].ToString(),
                new_second_kind_id = di["new_second_kind_id"].ToString(),
                new_second_kind_name = di["new_second_kind_name"].ToString(),
                new_third_kind_id = di["new_third_kind_id"].ToString(),
                new_third_kind_name = di["new_third_kind_name"].ToString(),
                new_major_kind_id = di["new_major_kind_id"].ToString(),
                new_major_kind_name = di["new_major_kind_name"].ToString(),
                new_major_id = di["new_major_id"].ToString(),
                new_major_name = di["new_major_name"].ToString(),
                human_id = di["human_id"].ToString(),
                human_name = di["human_name"].ToString(),
                //salary_standard_id = di["salary_standard_id"].ToString(),
                salary_standard_name = di["salary_standard_name"].ToString(),
                salary_sum = decimal.Parse(di["salary_sum"].ToString()),
                new_salary_standard_id = di["new_salary_standard_id"].ToString(),
                new_salary_standard_name = di["new_salary_standard_name"].ToString(),
                new_salary_sum = decimal.Parse(di["new_salary_sum"].ToString()),
                change_reason = di["change_reason"].ToString(),
                check_reason = null,
                register = di["register"].ToString(),
                regist_time = DateTime.Parse(di["regist_time"].ToString()),              
                check_status=0,
                //checker=null,
                //check_time=DateTime.Parse(null),
            };
            int res = 0;
            if (imm.Add1(mm) > 0)
            {
                res = 1;
            }
            return Content(JsonConvert.SerializeObject(res));
        }

        public ActionResult register_success()
        {
            return View();
        }
    }
}