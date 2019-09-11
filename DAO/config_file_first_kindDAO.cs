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
using System.Data;

namespace DAO
{
    public class config_file_first_kindDAO : Daobase<config_file_first_kind>, config_file_first_kindIDAO
    {
        public int Add(config_file_first_kindModel item)
        {
            config_file_first_kind ko = new config_file_first_kind(); 
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.first_kind_salary_id = item.first_kind_salary_id;  
                    ko.first_kind_sale_id = item.first_kind_sale_id; return  Add(ko);
        }

        public List<config_file_first_kindModel> select()
        {
            List<config_file_first_kind> list = SelectAll();
            List<config_file_first_kindModel> li = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel ko = new config_file_first_kindModel();  
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.first_kind_salary_id = item.first_kind_salary_id;  
                    ko.first_kind_sale_id = item.first_kind_sale_id;  li.Add(ko);
            }
            return li;
        }

        public int update(config_file_first_kindModel item)
        {
            config_file_first_kind ko = new config_file_first_kind(); 
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;
                    ko.first_kind_salary_id = item.first_kind_salary_id;  
                    ko.first_kind_sale_id = item.first_kind_sale_id;
            return ModifyWithOutproNames(ko);
            }
        public List<config_file_first_kindModel> selectupdate(int id)
        {
            List<config_file_first_kind> list = SeleteBy(e => e.Id == id);


            List<config_file_first_kindModel> li = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel ko = new config_file_first_kindModel(); 
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.first_kind_salary_id = item.first_kind_salary_id;  
                    ko.first_kind_sale_id = item.first_kind_sale_id;   li.Add(ko);
            }
            return li;

        }
        public List<config_file_first_kindModel> selectupdate1(int id)
        {
            string jj = id.ToString();
            List<config_file_first_kind> list = SeleteBy(e => e.first_kind_id.Equals(jj));


            List<config_file_first_kindModel> li = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel ko = new config_file_first_kindModel();
                ko.Id = item.Id;
                ko.first_kind_id = item.first_kind_id;
                ko.first_kind_name = item.first_kind_name;
                ko.first_kind_salary_id = item.first_kind_salary_id;
                ko.first_kind_sale_id = item.first_kind_sale_id; li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();

       

        public int delete(int id)
        {
            config_file_first_kind us = new config_file_first_kind();
            //接收前台来的id与表的id匹配
            us.Id = id;
            //开始删除
            db.Entry(us).State = EntityState.Deleted;
            //保存            
            return db.SaveChanges();


            // int pd = Del(e => e.id == id);
            // return pd;
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
