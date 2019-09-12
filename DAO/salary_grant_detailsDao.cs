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
namespace DAO
{
    public class salary_grant_detailsDAO : Daobase<salary_grant_details>, salary_grant_detailsIDAO
    {
        public int Add(salary_grant_detailsModel item)
        {
            salary_grant_details ko = new salary_grant_details();
            ko.salary_grant_id = item.salary_grant_id;
            ko.human_id = item.human_id;
            ko.human_name = item.human_name;
            ko.bouns_sum = item.bouns_sum;
            ko.sale_sum = item.sale_sum;
            ko.deduct_sum = item.deduct_sum;
            ko.salary_standard_sum = item.salary_standard_sum;
            ko.salary_paid_sum = item.salary_paid_sum; 
            return  Add(ko);
        }

        public List<salary_grant_detailsModel> select()
        {
            List<salary_grant_details> list = SelectAll();
            List<salary_grant_detailsModel> li = new List<salary_grant_detailsModel>();
            foreach (salary_grant_details item in list)
            {
                salary_grant_detailsModel ko = new salary_grant_detailsModel();  
                    ko.id = item.id;  
                    ko.salary_grant_id = item.salary_grant_id;  
                    ko.human_id = item.human_id;  
                    ko.human_name = item.human_name;  
                    ko.bouns_sum = item.bouns_sum;  
                    ko.sale_sum = item.sale_sum;  
                    ko.deduct_sum = item.deduct_sum;  
                    ko.salary_standard_sum = item.salary_standard_sum;  
                    ko.salary_paid_sum = item.salary_paid_sum;  li.Add(ko);
            }
            return li;
        }

        public int update(salary_grant_detailsModel item)
        {
            salary_grant_details ko = db.salary_grant_details.Where(e => e.id.Equals(item.id)).FirstOrDefault();
                    ko.id = item.id;  
                    ko.bouns_sum = item.bouns_sum;  
                    ko.sale_sum = item.sale_sum;  
                    ko.deduct_sum = item.deduct_sum;  
                    ko.salary_paid_sum = item.salary_paid_sum;
            return db.SaveChanges(); 
        }
        public List<salary_grant_detailsModel> selectupdate(int id)
        {
            List<salary_grant_details> list = SeleteBy(e => e.id == id);


            List<salary_grant_detailsModel> li = new List<salary_grant_detailsModel>();
            foreach (salary_grant_details item in list)
            {
                salary_grant_detailsModel ko = new salary_grant_detailsModel(); 
                    ko.id = item.id;  
                    ko.salary_grant_id = item.salary_grant_id;  
                    ko.human_id = item.human_id;  
                    ko.human_name = item.human_name;  
                    ko.bouns_sum = item.bouns_sum;  
                    ko.sale_sum = item.sale_sum;  
                    ko.deduct_sum = item.deduct_sum;  
                    ko.salary_standard_sum = item.salary_standard_sum;  
                    ko.salary_paid_sum = item.salary_paid_sum;   li.Add(ko);
            }
            return li;

        }
        public List<salary_grant_detailsModel> selectsalary_grant_id(string id)
        {
            List<salary_grant_details> list = SeleteBy(e => e.salary_grant_id.Equals(id));


            List<salary_grant_detailsModel> li = new List<salary_grant_detailsModel>();
            foreach (salary_grant_details item in list)
            {
                salary_grant_detailsModel ko = new salary_grant_detailsModel();
                ko.id = item.id;
                ko.salary_grant_id = item.salary_grant_id;
                ko.human_id = item.human_id;
                ko.human_name = item.human_name;
                ko.bouns_sum = item.bouns_sum;
                ko.sale_sum = item.sale_sum;
                ko.deduct_sum = item.deduct_sum;
                ko.salary_standard_sum = item.salary_standard_sum;
                ko.salary_paid_sum = item.salary_paid_sum; li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            salary_grant_details us = new salary_grant_details();
            //接收前台来的id与表的id匹配
            us.id = id;
            //开始删除
            db.Entry<salary_grant_details>(us).State = EntityState.Deleted;
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




        }
}
