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
    public class config_major_kindDAO : Daobase<config_major_kind>, config_major_kindIDAO
    {
        public int Add(config_major_kindModel1 item)
        {
            config_major_kind ko = new config_major_kind(); 
                    ko.id = item.mfk_id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name; return  Add(ko);
        }

        public List<config_major_kindModel1> select()
        {
            List<config_major_kind> list = SelectAll();
            List<config_major_kindModel1> li = new List<config_major_kindModel1>();
            foreach (config_major_kind item in list)
            {
                config_major_kindModel1 ko = new config_major_kindModel1();  
                    ko.mfk_id = item.id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  li.Add(ko);
            }
            return li;
        }

        public int update(config_major_kindModel1 item)
        {
            config_major_kind ko = new config_major_kind(); 
                    ko.id = item.mfk_id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;   return ModifyWithOutproNames(ko);
            }
        public List<config_major_kindModel1> selectupdate(string id)
        {
           
            List<config_major_kind> list = SeleteBy(e => e.major_kind_id.Equals(id));


            List<config_major_kindModel1> li = new List<config_major_kindModel1>();
            foreach (config_major_kind item in list)
            {
                config_major_kindModel1 ko = new config_major_kindModel1(); 
                    ko.mfk_id = item.id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;   li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            config_major_kind us = new config_major_kind();
            //接收前台来的id与表的id匹配
            us.id = id;
            //开始删除
            db.Entry<config_major_kind>(us).State = EntityState.Deleted;
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
