using System;
using System.Collections.Generic;
using System.Web.Mvc;
using IBLL;
using Model;
using ioc;
using Newtonsoft.Json;
using System.Web.Caching;
using Model.bangzhu;
namespace UI.Controllers
{
   // [JsonNetAction]
   
    public class salary_standardController : Controller
    {
        salary_standardIBLL sa = iocComm.salary_standardBLL();
        salary_standard_detailsIBLL de = iocComm.salary_standard_detailsBLL();
        config_public_charIBLL con = iocComm.config_public_charBLL();
        public ActionResult salarystandard_register() {
            salary_standardModel ko = new salary_standardModel();

            ko.standard_id = sa.BianHao();
            ViewData.Model = ko;
            return View();
        }
        public ActionResult Chaxun() {
            string ji=Request["order"];
            string[] la = ji.Split(',');
            List<config_public_charModel> list = new List<config_public_charModel>();
            for (int i = 0; i < la.Length; i++)
            {
                string jj = la[i];
                 List<config_public_charModel> li=con.selectupdate(int.Parse(jj));
                list.Add(li[0]);
            }


            Cache cahe = this.HttpContext.Cache;
            if (cahe["student"] == null)
            {
             
                //设置缓存值
                cahe.Insert("student", list, null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
                string aa = JsonConvert.SerializeObject(list);
                return Content(aa);
            }
            else
            {

                string aa = JsonConvert.SerializeObject(list);
                return Content(aa);
            }  
          
        }

        public ActionResult salarystandard_register_success() {
            return View();
        }
        //数据添加
        public ActionResult tj() {
            Cache cahe = this.HttpContext.Cache;
            List<config_public_charModel> hu= cahe["student"] as List<config_public_charModel>;
            salary_standardModel sata = new salary_standardModel();
            string bh = Request["standard_id"];
            string mc = Request["standard_name"];
            string ze = Request["salary_sum"];
            string zdr = Request["designer"];
            string djr = Request["register"];
            string djsj = Request["regist_time"];
            string bz = Request["remark"];
            sata.standard_id = bh;
            sata.standard_name = mc;
            sata.designer = zdr;
            sata.register = djr;
            sata.checker = null;
            sata.changer = null;
            sata.regist_time =DateTime.Parse( djsj);
            sata.remark = bz;
            sata.check_comment = null;
            sata.change_status = 0;
            sata.check_status = 0;
            sata.salary_sum = decimal.Parse(ze);
            sata.check_time = DateTime.Now;
            sata.change_time = DateTime.Now;
           

           int pd = sa.Add1(sata);
            if (pd > 0)
            {
                int sq = 0;
                for (int i = 0; i < hu.Count; i++)
                {
                    salary_standard_detailsModel ft = new salary_standard_detailsModel();
                    ft.item_id = hu[i].id;
                    ft.item_name = hu[i].attribute_name;

                    string h = Request["details[" + i + "].salary"];
                    ft.salary = decimal.Parse(h);
                    ft.standard_id = bh;
                    ft.standard_name = mc;
                    int pd1 = de.Add1(ft);
                    if (pd1 > 0)
                    {
                        sq = sq + 1;
                        //cahe.Remove("student");
                        //return Content("<script>alert('添加成功');</script>");
                       
                    }
                    else
                    {
                        return Content("<script>alert('添加失败');</script>");
                    }
                    
                }
                if (sq== hu.Count) {
                    cahe.Remove("student");
                    return Content("<script>window.location.href='/salary_standard/salarystandard_register_success';</script>");
                }
            }
            else {
                return Content("<script>alert('添加失败');</script>");
            }
            return View();
            
        }
        //复核查询
        public ActionResult salarystandard_check_list(){

            return View();

        }
        //分页
        public ActionResult salarystandard_check_listSelete()
        {
             int dqy=int.Parse(Request["dqy"]);
            salary_standardFenYe can = sa.fenye(dqy, 2);
            string aa = JsonConvert.SerializeObject(can);
            return Content(aa);
        }
        //复核页面
        public ActionResult salarystandard_check(int id) {
          List<salary_standardModel> fa=  sa.selectupdate(id);
            // List<salary_standard_detailsModel>  li=de.selectupdate(fa[0].standard_id);
            salary_standardModel ko = new salary_standardModel();
            ko.id = fa[0].id;
            ko.standard_id = fa[0].standard_id;
            Session["id"] = fa[0].id;
            Session["mid"]= fa[0].standard_id;
            ko.standard_name = fa[0].standard_name;
            ko.designer = fa[0].designer;
            ko.register = fa[0].register;
            ko.checker = fa[0].checker;
            ko.changer = fa[0].changer;
            ko.regist_time = fa[0].regist_time;
            ko.check_time = fa[0].check_time;
            ko.change_time = fa[0].change_time;
            ko.salary_sum = fa[0].salary_sum;
            ko.check_status = fa[0].check_status;
            ko.change_status = fa[0].change_status;
            ko.check_comment = fa[0].check_comment;
            ko.remark = fa[0].remark;

            return View(ko);
        }
        [HttpPost]
        public ActionResult Chagagun() {
           
             List<salary_standard_detailsModel>  li=de.selectupdate(Session["mid"].ToString());
            //设置缓存详情的数据
            Cache cahe = this.HttpContext.Cache;
            if (cahe["xq"] == null)
            {

                //设置缓存值
                cahe.Insert("xq", li, null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
                string aea = JsonConvert.SerializeObject(li);
                return Content(aea);
            }
            else
            {

                string aea = JsonConvert.SerializeObject(li);
                return Content(aea);
            }


           
        }
        public ActionResult salarystandard_check_success() {
            return View();
        }

        [HttpPost]

        public ActionResult fhqr() {
            Cache cahe = this.HttpContext.Cache;
            List<salary_standard_detailsModel> hu = cahe["xq"] as List<salary_standard_detailsModel>;
            salary_standardModel sata = new salary_standardModel();
            string bh = Request["standard_id"];
            string mc = Request["standard_name"];
            string ze = Request["salary_sum"];
            string zdr = Request["designer"];
            string djr = Request["register"];
            string djsj = Request["regist_time"];
            string bz = Request["remark"];
            string fhr = Request["checker"];
            sata.standard_name = mc;
            sata.designer = zdr;
            sata.register = djr; 
            sata.remark = bz;
            sata.check_status = 1;
            sata.salary_sum = decimal.Parse(ze);
            sata.check_time = DateTime.Now;
            sata.id = int.Parse(Session["id"].ToString());
            sata.checker = fhr;
            int pd = sa.update1(sata);
            int ji = 0;
            if (pd > 0) { 
                for (int i = 0; i < hu.Count; i++)
                {
                    salary_standard_detailsModel details = new salary_standard_detailsModel();
                    details.id = hu[i].id;
                    string h = Request["details[" + i + "].salary"];
                    details.salary =decimal.Parse( h);
                    int pdeq = de.update1(details);
                    if (pdeq > 0) {
                        ji++;
                    }
                }
                cahe.Remove("xq");
                return Content("<script>window.location.href='/salary_standard/salarystandard_check_success';</script>");
            }
             return Content("<script>alert('修改失败');</script>");
            
        }
        public ActionResult salarystandard_query_locate() {
            return View();
        }
        [HttpPost]
        public ActionResult Chaxunfa() {
           string standardId=   Request["standard.standardId"];
            string primarKey = Request["utilbean.primarKey"];
            string startDate = Request["utilBean.startDate"];
            string datePropertyName = Request["utilBean.endDate"];
            salarystandard_query_locateCan hu = new salarystandard_query_locateCan();
            hu.datePropertyName = DateTime.Parse(datePropertyName);
            hu.startDate= DateTime.Parse(startDate);
            if (primarKey == null || primarKey.Equals(""))
            {
                //hu.standard = standardId;
                hu.utilbean = "查询全部";
            }
            else {
                hu.utilbean = primarKey;
            }
            if (standardId == null || standardId.Equals(""))
            {

                hu.standard = "查询全部";
            }
            else
            {
                hu.standard = standardId;
            }
            hu.dqy = 1;
            hu.rl = 2;
            Session["salarystandard_query_locateCan"] = hu;
            return RedirectToAction("salarystandard_query_locateSrlete");
        }
        public ActionResult salarystandard_query_locateSrlete()
        {
            return View();
        }
        [HttpPost]
        //查询
        public ActionResult Srlete()
        {
            int dqy = int.Parse(Request["dqy"]);
            salarystandard_query_locateCan hu = new salarystandard_query_locateCan();
            hu = Session["salarystandard_query_locateCan"] as salarystandard_query_locateCan;
            hu.dqy = dqy;
            XCcan ji= sa. Fenye2(hu);
            //salary_standardFenYe can = sa.fenye(dqy, 2);
            string aa = JsonConvert.SerializeObject(ji);
            return Content(aa);
        }
        public ActionResult salarystandard_change_locate() {
            return View();

        }
        //变更查询
        public ActionResult ChaxunfaSelete() {
            string standardId = Request["standard.standardId"];
            string primarKey = Request["utilbean.primarKey"];
            string startDate = Request["utilBean.startDate"];
            string datePropertyName = Request["utilBean.endDate"];
            salarystandard_query_locateCan hu = new salarystandard_query_locateCan();
            hu.datePropertyName = DateTime.Parse(datePropertyName);
            hu.startDate = DateTime.Parse(startDate);
            if (primarKey == null || primarKey.Equals(""))
            {
                //hu.standard = standardId;
                primarKey = "查询全部";
            }
            else
            {
                hu.utilbean = primarKey;
            }
            if (standardId == null || standardId.Equals(""))
            {

                standardId = "查询全部";
            }
            else
            {
                hu.standard = standardId;
            }
            hu.dqy = 1;
            hu.rl = 2;
            Session["salarystandard_query_locateCan1"] = hu;
            return RedirectToAction("salarystandard_change_list");
        }
        //变更查询页面
        public ActionResult salarystandard_change_list() {

            return View();
        }
        //变更ajax
        
        public ActionResult Srlete11()
        {
            int dqy = int.Parse(Request["dqy"]);
            salarystandard_query_locateCan hu = new salarystandard_query_locateCan();
            hu = Session["salarystandard_query_locateCan1"] as salarystandard_query_locateCan;
            hu.dqy = dqy;
            XCcan ji = sa.Fenye2(hu);
            List<salary_standardModel> hs = ji.li;
            for (int i = 0; i < hs.Count; i++)
            {
                if (hs[i].check_status == 1)
                {
                    hs.Remove(hs[i]);

                }
            }
            ji.li = hs;
            //salary_standardFenYe can = sa.fenye(dqy, 2);
            string aa = JsonConvert.SerializeObject(ji);
            return Content(aa);
        }
        //变更页面
        public ActionResult salarystandard_change(int id) {
            List<salary_standardModel> fa = sa.selectupdate(id);
            // List<salary_standard_detailsModel>  li=de.selectupdate(fa[0].standard_id);
            salary_standardModel ko = new salary_standardModel();
            ko.id = fa[0].id;
            ko.standard_id = fa[0].standard_id;
            Session["Bid"] = fa[0].id;
            Session["Bmid"] = fa[0].standard_id;
            ko.standard_name = fa[0].standard_name;
            ko.designer = fa[0].designer;
            ko.register = fa[0].register;
           
            ko.changer = fa[0].changer;
            ko.regist_time = fa[0].regist_time;
           
            ko.change_time = fa[0].change_time;
            ko.salary_sum = fa[0].salary_sum;
            ko.check_status = fa[0].check_status;
            ko.change_status = fa[0].change_status;
            ko.check_comment = fa[0].check_comment;
            ko.remark = fa[0].remark;
            return View(ko);
        }
        //变更数据查询
        [HttpPost]
        public ActionResult ChagagunBian()
        {

            List<salary_standard_detailsModel> li = de.selectupdate(Session["Bmid"].ToString());
            //设置缓存详情的数据
            Cache cahe = this.HttpContext.Cache;
            if (cahe["xqBiana"] == null)
            {
                //设置缓存值
                cahe.Insert("xqBiana", li, null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
                string aea = JsonConvert.SerializeObject(li);
                return Content(aea);
            }
            else
            {
                string aea = JsonConvert.SerializeObject(li);
                return Content(aea);
            }



        }
        //查询一个数据
        public ActionResult salarystandard_query(int id) {
            
            List<salary_standardModel> fa = sa.selectupdate(id);
            // List<salary_standard_detailsModel>  li=de.selectupdate(fa[0].standard_id);
            salary_standardModel ko = new salary_standardModel();
            ko.id = fa[0].id;
            ko.standard_id = fa[0].standard_id;
            //Session["id"] = fa[0].id;
            Session["mid"] = fa[0].standard_id;
            ko.standard_name = fa[0].standard_name;
            ko.designer = fa[0].designer;
            ko.register = fa[0].register;
            ko.checker = fa[0].checker;
            ko.changer = fa[0].changer;
            ko.regist_time = fa[0].regist_time;
            ko.check_time = fa[0].check_time;
            ko.change_time = fa[0].change_time;
            ko.salary_sum = fa[0].salary_sum;
            ko.check_status = fa[0].check_status;
            ko.change_status = fa[0].change_status;
            ko.check_comment = fa[0].check_comment;
            ko.remark = fa[0].remark;

            return View(ko);
           

        }
        //查询内容
        [HttpPost]
        public ActionResult Chagagun11()
        {
            List<salary_standard_detailsModel> li = de.selectupdate(Session["mid"].ToString());
            
                string aea = JsonConvert.SerializeObject(li);
                return Content(aea);
         
        }

        //变更确认
        [HttpPost]
        public ActionResult BianGengqie() {
            Cache cahe = this.HttpContext.Cache;
            List<salary_standard_detailsModel> hu = cahe["xqBiana"] as List<salary_standard_detailsModel>;
            salary_standardModel sata = new salary_standardModel();
            string bh = Request["standard_id"];
            string mc = Request["standard_name"];
            string ze = Request["salary_sum"];
            string zdr = Request["designer"];
            string djr = Request["changer"];
            string djsj = Request["change_time"];
            string bz = Request["remark"];
            sata.standard_name = mc;
            sata.designer = zdr;
            sata.changer = djr;
            sata.remark = bz;
            sata.change_status = 1;
            sata.salary_sum = decimal.Parse(ze);
            sata.change_time = DateTime.Now;
            sata.id = int.Parse(Session["Bid"].ToString());
            int pd = sa.BianGenupdate(sata);
            int ji = 0;
            if (pd > 0)
            {
                for (int i = 0; i < hu.Count; i++)
                {
                    salary_standard_detailsModel details = new salary_standard_detailsModel();
                    details.id = hu[i].id;
                    string h = Request["details[" + i + "].salary"];
                    details.salary = decimal.Parse(h);
                    int pdeq = de.update1(details);
                    if (pdeq > 0)
                    {
                        ji++;
                    }
                }
                cahe.Remove("xqBiana");
                return Content("<script>window.location.href='/salary_standard/salarystandard_change_list';</script>");
            }
            return Content("<script>alert('修改失败');</script>");

        }
    }
}