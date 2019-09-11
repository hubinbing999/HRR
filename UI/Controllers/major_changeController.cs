using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using ioc;
using Newtonsoft.Json;
using Model;
using BLL;

namespace UI.Controllers
{
    public class major_changeController : Controller
    {
        // GET: major_change
        public ActionResult check_list()
        {
            return View();
        }
        major_changeIBLL ibl = iocComm.major_changeBLL();
        int rows;
        int pages;
        public ActionResult index()
        {
            string dqy = Request["dqy"];
            string pagesize = Request["pagesize"];
            DataTable dt = ibl.FenYe(int.Parse(dqy), out rows, out pages, int.Parse(pagesize));
            int row = rows;
            int page = pages;
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["dt"] = dt;
            di["rows"] = row;
            di["pages"] = page;
            return Content(JsonConvert.SerializeObject(di));
        }
        
        public ActionResult check(int id)
        {
            List<major_changeModel> list = ibl.selectupdate(id);
            major_changeModel mm = new major_changeModel()
            {
                 mch_id = list[0].mch_id,
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
             new_first_kind_id = list[0].new_first_kind_id,
             new_first_kind_name = list[0].new_first_kind_name,
             new_second_kind_id = list[0].new_second_kind_id,
             new_second_kind_name = list[0].new_second_kind_name,
             new_third_kind_id = list[0].new_third_kind_id,
             new_third_kind_name = list[0].new_third_kind_name,
             new_major_kind_id = list[0].new_major_kind_id,
             new_major_kind_name = list[0].new_major_kind_name,
             new_major_id = list[0].new_major_id,
             new_major_name = list[0].new_major_name,
             human_id = list[0].human_id,
             human_name = list[0].human_name,
             salary_standard_id = list[0].salary_standard_id,
             salary_standard_name = list[0].salary_standard_name,
             salary_sum = list[0].salary_sum,
             new_salary_standard_id = list[0].new_salary_standard_id,
             new_salary_standard_name = list[0].new_salary_standard_name,
             new_salary_sum = list[0].new_salary_sum,
             change_reason = list[0].change_reason,
             check_reason = list[0].check_reason,
             check_status = list[0].check_status,
             register = list[0].register,
             checker = list[0].checker,
             regist_time = list[0].regist_time,
             check_time = list[0].check_time,
        };
            ViewData.Model = mm;
            return View();
        }
        [HttpPost]
        public ActionResult check(FormCollection frm,major_changeModel mcm)
         {
             int i = 0;
            int id =mcm.mch_id;
            major_changeModel mm = new major_changeModel()
            {
                mch_id =id ,
            };
           
            if (frm["check_status"] == "通过")
            {
                i = 1;
            }
            //不通过，删除
            
            else
            {
                int m = ibl.delete(id);
                return Content("<script>window.location.href='/major_change/check_success'</script>");
            }
            mcm.check_status = i;
            //修改操作
            if (ibl.update1(mcm) > 0)
            {
                return Content("<script>alert('修改成功');window.location.href='/major_change/check_success'</script>");
            }
            else
            {
                return Content("<script>alert('修改失败');window.location.href='/major_change/check'</script>");
            }

        }

        public ActionResult check_success()
        {

            return View();
        }

        public ActionResult locate()
        {
            FillDrop4();
            FillDrop7();
            return View();
        }

        private List<SelectListItem> FillDrop4()
        {
            config_file_first_kindIBLL ial = iocComm.config_file_first_kindBLL();
            List<config_file_first_kindModel> list = ial.select1();
            List<SelectListItem> list2 = new List<SelectListItem>();
            list2.Add(new SelectListItem { Text = "全部", Value = "", Selected = true });
            foreach (config_file_first_kindModel item in list)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.first_kind_name,
                    Value = item.first_kind_id
                };
                list2.Add(sl);
            }
            ViewBag.dt4 = list2;
            //查询所有一级机构
            return list2;
        }
        private List<SelectListItem> FillDrop7()
        {
            config_major_kindIBLL ia = iocComm.config_major_kindBLL();
            List<config_major_kindModel1> list2 = ia.select1();
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "全部", Value = "", Selected = true });
            foreach (config_major_kindModel1 item in list2)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.major_kind_name,
                    Value = item.major_kind_id.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dt7 = list;
            return list;
        }
        /// <summary>
        /// 根据一级查询二级
        /// </summary>
        /// <returns></returns>
        public ActionResult SeByy()
        {
            config_file_second_kindIBLL sb = iocComm.config_file_second_kindBLL();
            String Id = Request["sid"];
            List<config_file_second_kindModel> list = sb.selectxlk1(Id);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult SeByyy()
        {
            config_file_third_kindIBLL isb = iocComm.config_file_third_kindBLL();
            String Id = Request["bid"];
            List<config_file_third_kindModel> list = isb.selectxlk1(Id);
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult SeByyyy()
        {
            config_majorIBLL ib = iocComm.config_majorBLL();
             String Id = Request["qid"];
            List<config_majorModel> list = ib.selectxlk1(Id);
            return Content(JsonConvert.SerializeObject(list));
        }

        [HttpPost]
        public ActionResult atjcx()
        {
            Session["yi"] = Request["yi"];
            Session["er"] = Request["er"];
            Session["san"] = Request["san"];
            Session["si"] = Request["si"];
            Session["wu"] = Request["wu"];
            Session["dateks"] = Request["dateks"];
            Session["datejs"] = Request["datejs"];
            return JavaScript("window.location.href='/major_change/list'");
        }

        //查询后的页面
        [HttpGet]
        public ActionResult list()
        {
            return View();
        }
        //调用查询de方法
        public ActionResult list2()
        {
            string yi = Session["yi"].ToString();
            string er = Session["er"].ToString();
            string san = Session["san"].ToString();
            string si = Session["si"].ToString();
            string wu = Session["wu"].ToString();
            List<major_changeModel> list = new List<major_changeModel>();
            if (Session["dateks"].ToString() == "" && Session["datejs"].ToString() == "")
            {
                list = ibl.atjcx(yi, er, san, si, wu, null, null);
            }
            else if (Session["dateks"].ToString() == "" && Session["datejs"].ToString() != "")
            {
                string time2 = Session["datejs"].ToString();
                list = ibl.atjcx(yi, er, san, si, wu, null, time2);
            }
            else if (Session["dateks"].ToString() != "" && Session["datejs"].ToString() == "")
            {
                string time1 = Session["dateks"].ToString();
                list = ibl.atjcx(yi, er, san, si, wu, time1, null);
            }
            else
            {
                string time1 = Session["dateks"].ToString();
                string time2 = Session["datejs"].ToString();
                list = ibl.atjcx(yi, er, san, si, wu, time1, time2);
            }
            return Content(JsonConvert.SerializeObject(list));
        }
        //根据id查看详细页面
        public ActionResult detail(int id)
        {
          
            List<major_changeModel> listm = ibl.selectupdate(id);
            major_changeModel m = new major_changeModel
            {
                mch_id = listm[0].mch_id,
                first_kind_id = listm[0].first_kind_id,
                first_kind_name = listm[0].first_kind_name,
                second_kind_id = listm[0].second_kind_id,
                second_kind_name = listm[0].second_kind_name,
                third_kind_id = listm[0].third_kind_id,
                third_kind_name = listm[0].third_kind_name,
                major_kind_id = listm[0].major_kind_id,
                major_kind_name = listm[0].major_kind_name,
                major_id = listm[0].major_id,
                major_name = listm[0].major_name,
                new_first_kind_id = listm[0].new_first_kind_id,
                new_first_kind_name = listm[0].new_first_kind_name,
                new_second_kind_id = listm[0].new_second_kind_id,
                new_second_kind_name = listm[0].new_second_kind_id,
                new_third_kind_id = listm[0].new_third_kind_id,
                new_third_kind_name = listm[0].new_third_kind_id,
                new_major_kind_id = listm[0].new_major_kind_id,
                new_major_kind_name = listm[0].new_major_kind_name,
                new_major_id = listm[0].new_major_id,
                new_major_name = listm[0].new_major_name,
                human_id = listm[0].human_id,
                human_name = listm[0].human_name,
                salary_standard_id = listm[0].salary_standard_id,
                salary_standard_name = listm[0].salary_standard_name,
                salary_sum = listm[0].salary_sum,
                new_salary_standard_id = listm[0].new_salary_standard_id,
                new_salary_standard_name = listm[0].new_salary_standard_name,
                new_salary_sum = listm[0].new_salary_sum,
                change_reason = listm[0].change_reason,
                check_reason = listm[0].check_reason,
                check_status = listm[0].check_status,
                register = listm[0].register,
                checker = listm[0].checker,
                regist_time = listm[0].regist_time,
                check_time = listm[0].check_time
            };
            ViewData.Model = m;
            return View();
        }
        }
}