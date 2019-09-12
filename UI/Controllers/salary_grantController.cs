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
                //一级发放 查询所有人力资源列表 
             List< human_fileModel> mo=  hu.select1();

                //对应编号

                //拿取所有一级机构不同
                List<string> str = new List<string>();
                str.Add(mo[0].first_kind_name);

               
                    foreach (human_fileModel item in mo)
                    {
                        if (item.first_kind_name.Equals(str[0]))
                        {
                        }
                        else
                        {
                        str.Add(item.first_kind_name);           
                        }
                    }
                //参数类id 用于判断类
                int iddid = 0;
                //参数类集合
                List<salary_grantANDsalary_grant_details> ca = new List<salary_grantANDsalary_grant_details>();
                foreach (string item1 in str)
                {
                    //查询所有一级结构相同的人
                    salary_grantANDsalary_grant_details ta = new salary_grantANDsalary_grant_details();
                    //人总数
                    int zrs = 0;
                    //标准薪酬总金额 
                    decimal ko = 0m;
                    string bian = "";
                    
                    
                    List<salary_grant_detailsModel> yyy = new List<salary_grant_detailsModel>();
                    foreach (human_fileModel item in mo)
                    {
                        if (item.first_kind_name.Equals(item1)) {
                            //赋值
                            zrs = zrs + 1;
                            ko = ko + item.salary_sum;
                            bian = item.first_kind_id;
                            //做详情表做数据添加
                            salary_grant_detailsModel detal = new salary_grant_detailsModel();
                            detal.human_id = item.human_id;
                            detal.human_name = item.human_name;
                            detal.salary_standard_sum = item.salary_sum;
                            detal.salary_paid_sum = item.salary_sum;
                            yyy.Add(detal);
                        }
                    }
                    //创建对象
                    salary_grantModel salary_mo = new salary_grantModel();
                    salary_mo.first_kind_id = bian;
                    salary_mo.first_kind_name = item1;
                    salary_mo.human_amount = zrs;
                    salary_mo.salary_standard_sum = ko;
                    salary_mo.salary_paid_sum = ko;
                    iddid = iddid + 1;
                    ta.id = iddid;
                    ta.salary_grant = salary_mo;
                    ta.salary_grant_details = yyy;
                    ca.Add(ta);
                }
                Session["salary_grantANDsalary_grant_details"]=ca;
                //查询所有人力资源一级机构不同的列表 获取一级机构名称
                //如果一级机构相同 放到同一个发放列表中 通过sesetion 保存
                
                return RedirectToAction("register_list");

            }
            //2级发放方式
            else if (nn.Equals("2"))
            {
                //一级发放 查询所有人力资源列表 
                List<human_fileModel> mo = hu.select1();

                //对应编号

                //拿取所有2级机构不同
                List<string> str = new List<string>();
                str.Add(mo[0].second_kind_name);


                foreach (human_fileModel item in mo)
                {
                    if (item.second_kind_name.Equals(str[0]))
                    {
                    }
                    else
                    {
                        str.Add(item.second_kind_name);
                    }
                }
                //参数类id 用于判断类
                int iddid = 0;
                //参数类集合
                List<salary_grantANDsalary_grant_details> ca = new List<salary_grantANDsalary_grant_details>();
                foreach (string item1 in str)
                {
                    //查询所有2级结构相同的人
                    salary_grantANDsalary_grant_details ta = new salary_grantANDsalary_grant_details();
                    //人总数
                    int zrs = 0;
                    //标准薪酬总金额 
                    decimal ko = 0m;
                    string bian = "";
                    string yi = "";
                    string yiID = "";

                    List<salary_grant_detailsModel> yyy = new List<salary_grant_detailsModel>();
                    foreach (human_fileModel item in mo)
                    {
                        if (item.second_kind_name.Equals(item1))
                        {
                            //赋值
                            zrs = zrs + 1;
                            ko = ko + item.salary_sum;
                            yi = item.first_kind_name;
                            yiID = item.first_kind_id;
                            bian = item.first_kind_id;
                            //做详情表做数据添加
                            salary_grant_detailsModel detal = new salary_grant_detailsModel();
                            detal.human_id = item.human_id;
                            detal.human_name = item.human_name;
                            detal.salary_standard_sum = item.salary_sum;
                            detal.salary_paid_sum = item.salary_sum;
                            yyy.Add(detal);
                        }
                    }
                    //创建对象
                    salary_grantModel salary_mo = new salary_grantModel();
                    salary_mo.first_kind_id = yi;
                    salary_mo.first_kind_name = yiID;
                    salary_mo.second_kind_id = bian;
                    salary_mo.second_kind_name = item1;
                    salary_mo.human_amount = zrs;
                    salary_mo.salary_standard_sum = ko;
                    salary_mo.salary_paid_sum = ko;
                    iddid = iddid + 1;
                    ta.id = iddid;
                    ta.salary_grant = salary_mo;
                    ta.salary_grant_details = yyy;
                    ca.Add(ta);
                }
                Session["salary_grantANDsalary_grant_details"] = ca;
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
            //获取sesstion值
            List<salary_grantANDsalary_grant_details> la= Session["salary_grantANDsalary_grant_details"] as List<salary_grantANDsalary_grant_details>;
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
            //
            List<salary_grant_detailsASsalary_standard> lei = new List<salary_grant_detailsASsalary_standard>();
            string ha = Session["register_commitID"].ToString();
            //查询薪酬详情
            //类  List<salary_grant_detailsModel>  查询详情表人
            // List<salary_grant_detailsModel> li = de.selectsalary_grant_id(ha);
            List<salary_grantANDsalary_grant_details> la = Session["salary_grantANDsalary_grant_details"] as List<salary_grantANDsalary_grant_details>;
            List<salary_grant_detailsModel> mm = new List<salary_grant_detailsModel>();

            foreach (salary_grantANDsalary_grant_details item in la)
            {
                if (item.id == int.Parse(ha)) {
                    mm = item.salary_grant_details;
                }
            }
            foreach (salary_grant_detailsModel item in mm)
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

        public ActionResult Fn()
        {
            //
            List<salary_grant_detailsASsalary_standard> lei = new List<salary_grant_detailsASsalary_standard>();
            string ha = Session["register_commitID"].ToString();
            //查询薪酬详情
            //类  List<salary_grant_detailsModel>  查询详情表人

            List<salary_grantANDsalary_grant_details> la = Session["salary_grantANDsalary_grant_details"] as List<salary_grantANDsalary_grant_details>;
            List<salary_grant_detailsModel> mm = new List<salary_grant_detailsModel>();
            mm = de.selectsalary_grant_id(ha);
            //foreach (salary_grantANDsalary_grant_details item in la)
            //{
            //    if (item.id == int.Parse(ha)) {
            //        mm = item.salary_grant_details;
            //    }
            //}
            foreach (salary_grant_detailsModel item in mm)
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
            string ha = Session["register_commitID"].ToString();
            List<salary_grantANDsalary_grant_details> la = Session["salary_grantANDsalary_grant_details"] as List<salary_grantANDsalary_grant_details>;
            List<salary_grant_detailsModel> mm = new List<salary_grant_detailsModel>();
            salary_grantModel lala = new salary_grantModel();
            foreach (salary_grantANDsalary_grant_details h in la)
            {
                if (h.id == int.Parse(ha))
                {
                    mm = h.salary_grant_details;
                    lala = h.salary_grant;
                }
            }
            //获取编号
           List<string>  sr= sa.bianHao();

            //查询发放详细表
           
            int zrs = 0;
            //基本总额
            decimal jbze = 0m;
            decimal sfze = 0m;
            for (int i = 0; i < mm.Count; i++)
            {
                zrs = zrs + 1;
                salary_grant_detailsModel mode = new salary_grant_detailsModel();
                //mode.id = mm[i].id;
                mode.human_id = mm[i].human_id;
                

                mode.human_name = mm[i].human_name;
                mode.salary_grant_id = sr[0];
                jbze = jbze + mm[i].salary_standard_sum;
                mode.salary_standard_sum = mm[i].salary_standard_sum;
                mode.bouns_sum = decimal.Parse(Request["grantDetails[" + i + "].bounsSum"].ToString());
                mode.sale_sum = decimal.Parse(Request["grantDetails[" + i + "].saleSum"].ToString());
                mode.deduct_sum = decimal.Parse(Request["grantDetails[" + i + "].deductSum"].ToString());
                mode.salary_paid_sum = decimal.Parse(Request["grantDetails[" + i + "].salaryPaidSum"].ToString());
                sfze = sfze + decimal.Parse(Request["grantDetails[" + i + "].salaryPaidSum"].ToString());
                int p = de.Add1(mode);
                //if (p > 0) {
                //    //删除人力资源 列表
                //    //根据human_id 查id;
                //   List<human_fileModel> lall= hu.selectupdate(mm[i].human_id);
                //   int sc=hu.delete( lall[0].id);
                //}
            }
            lala.salary_grant_id = sr[0];
            lala.salary_standard_id = sr[1];
            lala.salary_standard_sum = jbze;
            lala.salary_paid_sum = sfze;
            lala.register = Request["register"];
            lala.regist_time = DateTime.Parse(Request["salaryGrant.registTime"].ToString());
            lala.check_status = 0;
            int pd = sa.Add1(lala);
            if (pd > 0)
            {
                return JavaScript("alert('提交成功');window.location = '/salary_grant/register_locate'");
            }
            else {
                return JavaScript("alert('提交失败');");
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
            salary_grantCan da = sa.fenye(dqy,20);
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