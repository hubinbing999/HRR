using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using ioc;
using Model;
using Newtonsoft.Json;
using System.Data;
using Model.bangzhu;

namespace UI.Controllers
{
    public class salary_grantController : Controller
    {
        human_fileIBLL hu = iocComm.human_fileBLL();
        salary_grantIBLL sa = iocComm.salary_grantBLL();
        salary_grant_detailsIBLL de = iocComm.salary_grant_detailsBLL();
        //工资详情
        salary_standard_detailsIBLL standard = iocComm.salary_standard_detailsBLL();
        // GET: salary_grant
        public ActionResult register_locate()
        {
            return View();
        }
        //发放方式
        public ActionResult dj() {
            string nn = Request["submitType"];
            Session["fANSE"] = nn;
            //一级发放方式
            if (nn.Equals("1"))
            {
                return RedirectToAction("register_list");

            }
            //2级发放方式
            else if (nn.Equals("2"))
            {
                return RedirectToAction("register_list2");

            }
            //3级发放方式
            else
            {


            }
            return View();
        }
        public ActionResult register_list() {

            return View();
        }
       
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

        public ActionResult register_list2()
        {

            return View();
        }
        //页面数据ajax
        public ActionResult Yiji() {
            CXinCan la = new CXinCan();
            List<salary_grantModel> li = sa.select1();
            la.li = li;
            int zrs = 0;
            int xczs = 0;
            decimal salary_standard_sum = 0;
            decimal salary_paid_sum = 0;
            foreach (salary_grantModel item in li)
            {
                zrs += item.human_amount;
                xczs = xczs + 1;
                salary_standard_sum += item.salary_standard_sum;
                salary_paid_sum += item.salary_paid_sum;
            }
            la.zrs = zrs;
            la.xczs = xczs;
            la.salary_standard_sum = salary_standard_sum;
            la.salary_paid_sum = salary_paid_sum;
            string aa = JsonConvert.SerializeObject(la);
            return Content(aa);
        }
        public ActionResult register_commit(string id)
        {
            string id1 = id;
            Session["register_commitID"] = id1;
            List<SelectListItem> lis = djr();
            ViewData["djr"] = lis;
            return View();
        }
        //发放页面AJAX
        public ActionResult Fan() {
            List<salary_grant_detailsASsalary_standard> lei = new List<salary_grant_detailsASsalary_standard>();
            string ha = Session["register_commitID"].ToString();
            //查询薪酬详情
            //类  List<salary_grant_detailsModel> 
            List<salary_grant_detailsModel> li = de.selectsalary_grant_id(ha);

            foreach (salary_grant_detailsModel item in li)
            {
                salary_grant_detailsASsalary_standard salaretwq = new salary_grant_detailsASsalary_standard();
                salaretwq.salary_grant_details = item;
                //查询human表的工资详细
                List<human_fileModel> mo = hu.selectupdate(item.human_id);
                //查询工资详细
                List<salary_standard_detailsModel> fa = standard.selectupdate(mo[0].salary_standard_id);
                salaretwq.salary_standard_detailsModel = fa;
                lei.Add(salaretwq);
            }
            string aa = JsonConvert.SerializeObject(lei);
            return Content(aa);


        }
        public ActionResult Shuju() {

            string ha = Session["register_commitID"].ToString();
            List<salary_grantModel> item = sa.selectupdateda(ha);
            salary_grantModel ko = new salary_grantModel();
            ko.salary_standard_id = item[0].salary_standard_id;
            if (Session["fANSE"].ToString().Equals("1"))
            {
                ko.third_kind_name = "I级结构";
            }
            else {
                ko.third_kind_name = "II级结构";
            }

            ko.human_amount = item[0].human_amount;
            ko.salary_standard_sum = item[0].salary_standard_sum;
            ko.salary_paid_sum = item[0].salary_paid_sum;
            string aa = JsonConvert.SerializeObject(ko);
            return Content(aa);

        }
        //头部信息
        public ActionResult Shuju1() {
            string ha = Session["register_commitID"].ToString();
            List<salary_grantModel> item = sa.selectupdateda(ha);
            salary_grantModel ko = new salary_grantModel();
            ko.salary_standard_id = item[0].salary_standard_id;    
                ko.third_kind_name = "III级结构";
            ko.human_amount = item[0].human_amount;
            ko.salary_standard_sum = item[0].salary_standard_sum;
            ko.salary_paid_sum = item[0].salary_paid_sum;
            string aa = JsonConvert.SerializeObject(ko);
            return Content(aa);

        }
        public ActionResult TiJiao() {
            //查询发放详细表
            string ha = Session["register_commitID"].ToString();
            //获取其中详细信息
            List<salary_grant_detailsModel> li = de.selectsalary_grant_id(ha);
            List<salary_grantModel> item = sa.selectupdateda(ha);
            salary_grantModel sala = new salary_grantModel();
            sala.sgr_id = item[0].sgr_id;
            int zrs = 0;
            //基本总额
            decimal jbze = 0m;
            decimal sfze = 0m;
            for (int i = 0; i < li.Count; i++)
            {
                zrs = zrs + 1;
                salary_grant_detailsModel mode = new salary_grant_detailsModel();
                mode.id = li[i].id;
                jbze = jbze + li[i].salary_standard_sum;
                mode.bouns_sum = decimal.Parse(Request["grantDetails[" + i + "].bounsSum"].ToString());
                mode.sale_sum = decimal.Parse(Request["grantDetails[" + i + "].saleSum"].ToString());
                mode.deduct_sum = decimal.Parse(Request["grantDetails[" + i + "].deductSum"].ToString());
                mode.salary_paid_sum = decimal.Parse(Request["grantDetails[" + i + "].salaryPaidSum"].ToString());
                sfze = sfze + decimal.Parse(Request["grantDetails[" + i + "].salaryPaidSum"].ToString());
                int p = de.update1(mode);
            }
            sala.human_amount = zrs;
            sala.salary_standard_sum = jbze;
            sala.salary_paid_sum = sfze;
            sala.register = Request["register"];
            sala.regist_time = DateTime.Parse(Request["salaryGrant.registTime"].ToString());
            sala.check_status = 0;
            int pd = sa.update1(sala);
            if (pd > 0)
            {
                return JavaScript("alert('修改成功');window.location = '/salary_grant/register_locate'");
            }
            else {
                return JavaScript("alert('修改失败');");
            }


        }
        public ActionResult register_success() {
            return View();
        }
        //工资详情
        public ActionResult FanCha() {
            string id = Request["id"];
            List<salary_standard_detailsModel> fa = standard.selectupdate(id);
            string aa = JsonConvert.SerializeObject(fa);
            return Content(aa);
        }
        //待复核页面
        public ActionResult check_list() {
            return View();
        }
        //ajax发送页面
        public ActionResult dacx1() {
            int dqy=int.Parse(Request["id"].ToString());
            salary_grantCan da = sa.fenye(dqy,2);
            string aa = JsonConvert.SerializeObject(da);
            return Content(aa);
        }
      
      
       
      

        //复核页面
        public ActionResult check(string id) {
            string id1 = id;
            Session["register_commitID"] = id1;
            List<SelectListItem> lis = djr();
            ViewData["djr"] = lis;
            return View();
        }
      
        //复核提交
        public ActionResult Tio() {
            //查询发放详细表
            string ha = Session["register_commitID"].ToString();
            //获取其中详细信息
            List<salary_grant_detailsModel> li = de.selectsalary_grant_id(ha);
            List<salary_grantModel> item = sa.selectupdateda(ha);
            salary_grantModel sala = new salary_grantModel();
            sala.sgr_id = item[0].sgr_id;
            int zrs = 0;
            //基本总额
            decimal jbze = 0m;
            decimal sfze = 0m;
            for (int i = 0; i < li.Count; i++)
            {
                zrs = zrs + 1;
                salary_grant_detailsModel mode = new salary_grant_detailsModel();
                mode.id = li[i].id;
                jbze = jbze + li[i].salary_standard_sum;
                mode.bouns_sum = decimal.Parse(Request["grantDetails[" + i + "].bounsSum"].ToString());
                mode.sale_sum = decimal.Parse(Request["grantDetails[" + i + "].saleSum"].ToString());
                mode.deduct_sum = decimal.Parse(Request["grantDetails[" + i + "].deductSum"].ToString());
                mode.salary_paid_sum = decimal.Parse(Request["grantDetails[" + i + "].salaryPaidSum"].ToString());
                sfze = sfze + decimal.Parse(Request["grantDetails[" + i + "].salaryPaidSum"].ToString());
                int p = de.update1(mode);
            }
            sala.human_amount = zrs;
            sala.salary_standard_sum = jbze;
            sala.salary_paid_sum = sfze;
            sala.checker = Request["checker"];
            sala.check_time = DateTime.Parse(Request["salaryGrant.registTime"].ToString());
            sala.check_status = 1;
            int pd = sa.updateChenk(sala);
          
                return JavaScript("window.location = '/salary_grant/check_success'");
           


        }
        public ActionResult check_success() {
            return View();
        }
        //查询页面
        public ActionResult query_locate() {
            return View();
        }
        public ActionResult Shujubao() {
            query_locateCan na = new query_locateCan();
            string name=   Request["salaryGrant.salaryGrantId"];
            string year = Request["year"];
            string month = Request["month"];
            na.month = month;
            na.salaryGrant = name;
            na.year = year;
            Session["query_locateCan"] = na;
            return RedirectToAction("query_list");
        }
        public ActionResult query_list() {
            return View();
        }
        public ActionResult JiaZai() {
            query_locateCan va= Session["query_locateCan"] as query_locateCan;
            int dqy = int.Parse(Request["id"].ToString());
            salary_grantCan da = sa.fenye2(va,dqy, 2);
            string aa = JsonConvert.SerializeObject(da);
            return Content(aa);

        }
        //查询页面
        public ActionResult query(string id) {
            string id1 = id;
            Session["register_commitID1"] = id1;
            return View();
        }
        public ActionResult Fan1()
        {
            List<salary_grant_detailsASsalary_standard> lei = new List<salary_grant_detailsASsalary_standard>();
            string ha = Session["register_commitID1"].ToString();
            //查询薪酬详情
            //类  List<salary_grant_detailsModel> 
            List<salary_grant_detailsModel> li = de.selectsalary_grant_id(ha);

            foreach (salary_grant_detailsModel item in li)
            {
                salary_grant_detailsASsalary_standard salaretwq = new salary_grant_detailsASsalary_standard();
                salaretwq.salary_grant_details = item;
                //查询human表的工资详细
                List<human_fileModel> mo = hu.selectupdate(item.human_id);
                //查询工资详细
                List<salary_standard_detailsModel> fa = standard.selectupdate(mo[0].salary_standard_id);
                salaretwq.salary_standard_detailsModel = fa;
                lei.Add(salaretwq);
            }
            string aa = JsonConvert.SerializeObject(lei);
            return Content(aa);


        }
        public ActionResult Shuju11()
        {
            string ha = Session["register_commitID1"].ToString();
            List<salary_grantModel> item = sa.selectupdateda(ha);
            salary_grantModel ko = new salary_grantModel();
            ko.salary_standard_id = item[0].salary_standard_id;
            ko.third_kind_name = "III级结构";
            ko.human_amount = item[0].human_amount;
            ko.salary_standard_sum = item[0].salary_standard_sum;
            ko.salary_paid_sum = item[0].salary_paid_sum;
            string aa = JsonConvert.SerializeObject(ko);
            return Content(aa);

        }

    }
}