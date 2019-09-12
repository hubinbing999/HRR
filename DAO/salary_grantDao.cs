using IDAO;
using MVC_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
using Model.bangzhu;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class salary_grantDAO : Daobase<salary_grant>, salary_grantIDAO
    {
        //获取编号

        public List<string> bianHao() {
            string sql = "dj";
            SqlParameter[] ji = {
                     new SqlParameter(){ ParameterName="@danhao",Size=14, SqlDbType= SqlDbType.VarChar, Direction= ParameterDirection.Output},
                };
            DataTable dt = DBHaipu.SelectProc(sql, ji, "");
            //获取值
            List<string> sttt = new List<string>();
            string r = ji[0].Value.ToString();




            sttt.Add(r);
            string sql1 = "FF";
            SqlParameter ji1 = new SqlParameter() { ParameterName = "@danhao", Size = 14, SqlDbType = SqlDbType.VarChar, Direction = ParameterDirection.Output };

            DataTable dt1 = DBHaipu.SelectProc1(sql1, ji1, "");
            //获取值
            string r1 = ji1.Value.ToString();
            sttt.Add(r1);
            return sttt;
        }

        public int Add(salary_grantModel item)
        {
            
         

                    salary_grant ko = new salary_grant();
                    ko.salary_grant_id = item.salary_grant_id;
                    ko.salary_standard_id = item.salary_standard_id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;
                    ko.second_kind_id = item.second_kind_id;
                    ko.second_kind_name = item.second_kind_name;
                    ko.human_amount = item.human_amount;  
                    ko.salary_standard_sum = item.salary_standard_sum;  
                    ko.salary_paid_sum = item.salary_paid_sum;
            ko.register = item.register;
                    ko.regist_time = DateTime.Now;  
                   
                    ko.check_time = DateTime.Now;  
                    ko.check_status = item.check_status;
            return  Add(ko);
        }

        public List<salary_grantModel> select()
        {
            List<salary_grant> list = SelectAll();
            List<salary_grantModel> li = new List<salary_grantModel>();
            foreach (salary_grant item in list)
            {
                salary_grantModel ko = new salary_grantModel();  
                    ko.sgr_id = item.id;  
                    ko.salary_grant_id = item.salary_grant_id;  
                    ko.salary_standard_id = item.salary_standard_id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.third_kind_id = item.third_kind_id;  
                    ko.third_kind_name = item.third_kind_name;  
                    ko.human_amount = item.human_amount;  
                    ko.salary_standard_sum = item.salary_standard_sum;  
                    ko.salary_paid_sum = item.salary_paid_sum;  
                    ko.register = item.register;  
                    ko.regist_time = item.regist_time;  
                    ko.checker = item.checker;  
                    ko.check_time = item.check_time;  
                    ko.check_status = item.check_status;  li.Add(ko);
            }
            return li;
        }

        public int update(salary_grantModel item)
        {
            salary_grant ko = db.salary_grant.Where(e => e.id.Equals(item.sgr_id)).FirstOrDefault();
            
                    ko.id = item.sgr_id;  
                    
                    ko.human_amount = item.human_amount;  
                    ko.salary_standard_sum = item.salary_standard_sum;  
                    ko.salary_paid_sum = item.salary_paid_sum;  
                    ko.register = item.register;  
                    ko.regist_time = item.regist_time;
                   ko.check_status = item.check_status;
                       return db.SaveChanges();
        }
        public int updateChenk(salary_grantModel item)
        {
            salary_grant ko = db.salary_grant.Where(e => e.id.Equals(item.sgr_id)).FirstOrDefault();
            ko.id = item.sgr_id;
            ko.human_amount = item.human_amount;
            ko.salary_standard_sum = item.salary_standard_sum;
            ko.salary_paid_sum = item.salary_paid_sum;
            ko.checker = item.checker;
            ko.check_time = item.check_time;
            ko.check_status = item.check_status;
            return db.SaveChanges();
        }

        public int updateFan(salary_grantModel item)
        {
            salary_grant ko = db.salary_grant.Where(e => e.id.Equals(item.sgr_id)).FirstOrDefault();
            ko.id = item.sgr_id;
            ko.human_amount = item.human_amount;
            ko.salary_standard_sum = item.salary_standard_sum;
            ko.salary_paid_sum = item.salary_paid_sum;
            return db.SaveChanges();
        }

        public List<salary_grantModel> selectupdate(int id)
        {
            List<salary_grant> list = SeleteBy(e => e.id == id);


            List<salary_grantModel> li = new List<salary_grantModel>();
            foreach (salary_grant item in list)
            {
                salary_grantModel ko = new salary_grantModel(); 
                    ko.sgr_id = item.id;  
                    ko.salary_grant_id = item.salary_grant_id;  
                    ko.salary_standard_id = item.salary_standard_id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.third_kind_id = item.third_kind_id;  
                    ko.third_kind_name = item.third_kind_name;  
                    ko.human_amount = item.human_amount;  
                    ko.salary_standard_sum = item.salary_standard_sum;  
                    ko.salary_paid_sum = item.salary_paid_sum;  
                    ko.register = item.register;  
                    ko.regist_time = item.regist_time;  
                    ko.checker = item.checker;  
                    ko.check_time = item.check_time;  
                    ko.check_status = item.check_status;   li.Add(ko);
            }
            return li;

        }
        public List<salary_grantModel> selectupdateda(string id)
        {
            List<salary_grant> list = SeleteBy(e => e.salary_grant_id.Equals(id));


            List<salary_grantModel> li = new List<salary_grantModel>();
            foreach (salary_grant item in list)
            {
                salary_grantModel ko = new salary_grantModel();
                ko.sgr_id = item.id;
                ko.salary_grant_id = item.salary_grant_id;
                ko.salary_standard_id = item.salary_standard_id;
                ko.first_kind_id = item.first_kind_id;
                ko.first_kind_name = item.first_kind_name;
                ko.second_kind_id = item.second_kind_id;
                ko.second_kind_name = item.second_kind_name;
                ko.third_kind_id = item.third_kind_id;
                ko.third_kind_name = item.third_kind_name;
                ko.human_amount = item.human_amount;
                ko.salary_standard_sum = item.salary_standard_sum;
                ko.salary_paid_sum = item.salary_paid_sum;
                ko.register = item.register;
                ko.regist_time = item.regist_time;
                ko.checker = item.checker;
                ko.check_time = item.check_time;
                ko.check_status = item.check_status; li.Add(ko);
            }
            return li;

        }
        public salary_grantCan fenye(int dqy, int rl)
        {
            salary_grantCan cs = new salary_grantCan();
            List<salary_grantModel> li = new List<salary_grantModel>();
            int rows = 0;
            var data = db.Set<salary_grant>().OrderBy(e => e.id).Where(e => e.check_status == 0).AsNoTracking();
            rows = data.Count();//获取总行数
            List<salary_grant> list = FenYe<int>(e => e.id, e => e.check_status == 0, ref rows, dqy, rl);
            foreach (salary_grant item in list)
            {
                salary_grantModel ko = new salary_grantModel();
                ko.sgr_id = item.id;
                ko.salary_grant_id = item.salary_grant_id;
                ko.salary_standard_id = item.salary_standard_id;
                ko.first_kind_id = item.first_kind_id;
                ko.first_kind_name = item.first_kind_name;
                ko.second_kind_id = item.second_kind_id;
                ko.second_kind_name = item.second_kind_name;
                ko.third_kind_id = item.third_kind_id;
                ko.third_kind_name = item.third_kind_name;
                ko.human_amount = item.human_amount;
                ko.salary_standard_sum = item.salary_standard_sum;
                ko.salary_paid_sum = item.salary_paid_sum;
                ko.register = item.register;
                ko.regist_time = item.regist_time;
                ko.checker = item.checker;
                ko.check_time = item.check_time;
                ko.check_status = item.check_status;
                li.Add(ko);
            }
            cs.li = li;
            cs.MyProperty = rows;
            cs.zys = (rows % rl == 0 ? rows / rl : rows % rl + 1);
            return cs;
        }
        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            salary_grant us = new salary_grant();
            //接收前台来的id与表的id匹配
            us.id = id;
            //开始删除
            db.Entry<salary_grant>(us).State = EntityState.Deleted;
            //保存            
            return db.SaveChanges();


            
        }
        private static MyDbContext CreateDbContext()
        {

            //从当前请求的线程取值
            db = CallContext.GetData("s") as MyDbContext;
            if (db == null)
                {
                    db = new MyDbContext();
                    //把上下文对象存入当前请求的线程中
                    CallContext.SetData("s", db);
                }
                return db;
            }


        public salary_grantCan fenye2(query_locateCan va, int dqy, int rl)
        {
            string hu = va.year + "-" + va.month + "-1";
            string hu2 = va.year + "-" + va.month + "-30";
            DateTime t1=   DateTime.Parse(hu);
            DateTime t2 = DateTime.Parse(hu2);
            salary_grantCan cs = new salary_grantCan();
            List<salary_grantModel> li = new List<salary_grantModel>();
            int rows = 0;
            var data = db.Set<salary_grant>().OrderBy(e => e.id).Where(e => e.salary_standard_id.Contains(va.salaryGrant)&&e.check_time>=t1&&e.check_time<=t2).AsNoTracking();
            rows = data.Count();//获取总行数
            List<salary_grant> list = FenYe<int>(e => e.id, e => e.salary_standard_id.Contains(va.salaryGrant) && e.check_time >= t1 && e.check_time <= t2, ref rows, dqy, rl);
            foreach (salary_grant item in list)
            {
                salary_grantModel ko = new salary_grantModel();
                ko.sgr_id = item.id;
                ko.salary_grant_id = item.salary_grant_id;
                ko.salary_standard_id = item.salary_standard_id;
                ko.first_kind_id = item.first_kind_id;
                ko.first_kind_name = item.first_kind_name;
                ko.second_kind_id = item.second_kind_id;
                ko.second_kind_name = item.second_kind_name;
                ko.third_kind_id = item.third_kind_id;
                ko.third_kind_name = item.third_kind_name;
                ko.human_amount = item.human_amount;
                ko.salary_standard_sum = item.salary_standard_sum;
                ko.salary_paid_sum = item.salary_paid_sum;
                ko.register = item.register;
                ko.regist_time = item.regist_time;
                ko.checker = item.checker;
                ko.check_time = item.check_time;
                ko.check_status = item.check_status;
                li.Add(ko);
            }
            cs.li = li;
            cs.MyProperty = rows;
            cs.zys = (rows % rl == 0 ? rows / rl : rows % rl + 1);
            return cs;
        }
    }
   
}
