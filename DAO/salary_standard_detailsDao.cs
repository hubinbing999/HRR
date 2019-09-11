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
    public class salary_standard_detailsDAO : Daobase<salary_standard_details>, salary_standard_detailsIDAO
    {
        public int Add(salary_standard_detailsModel item)
        {
            salary_standard_details ko = new salary_standard_details(); 
                    ko.Id = item.id;  
                    ko.standard_id = item.standard_id;  
                    ko.standard_name = item.standard_name;  
                    ko.item_id = item.item_id;  
                    ko.item_name = item.item_name;  
                    ko.salary = item.salary; return  Add(ko);
        }

        public List<salary_standard_detailsModel> select()
        {
            List<salary_standard_details> list = SelectAll();
            List<salary_standard_detailsModel> li = new List<salary_standard_detailsModel>();
            foreach (salary_standard_details item in list)
            {
                salary_standard_detailsModel ko = new salary_standard_detailsModel();  
                    ko.id = item.Id;  
                    ko.standard_id = item.standard_id;  
                    ko.standard_name = item.standard_name;  
                    ko.item_id = item.item_id;  
                    ko.item_name = item.item_name;  
                    ko.salary = item.salary;  li.Add(ko);
            }
            return li;
        }

        public int update(salary_standard_detailsModel item)
        {
            salary_standard_details ko = db.salary_standard_details.Where(e => e.Id==(item.id)).FirstOrDefault();
           
                    ko.Id = item.id; 
                    ko.salary = item.salary;

            return db.SaveChanges();
        }
        public List<salary_standard_detailsModel> selectupdate(string id)
        {
            List<salary_standard_details> list = SeleteBy(e => e.standard_id.Equals(id));


            List<salary_standard_detailsModel> li = new List<salary_standard_detailsModel>();
            foreach (salary_standard_details item in list)
            {
                salary_standard_detailsModel ko = new salary_standard_detailsModel(); 
                    ko.id = item.Id;  
                    ko.standard_id = item.standard_id;  
                    ko.standard_name = item.standard_name;  
                    ko.item_id = item.item_id;  
                    ko.item_name = item.item_name;  
                    ko.salary = item.salary;   li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            salary_standard_details us = new salary_standard_details();
            //接收前台来的id与表的id匹配
            us.Id = id;
            //开始删除
            db.Entry<salary_standard_details>(us).State = EntityState.Deleted;
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
