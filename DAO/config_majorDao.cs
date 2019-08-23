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
    public class config_majorDAO : Daobase<config_major>, config_majorIDAO
    {
        public int Add(config_majorModel item)
        {
            config_major ko = new config_major(); 
                    ko.id = item.mak_id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.test_amount = item.test_amount; return  Add(ko);
        }

        public List<config_majorModel> select()
        {
            List<config_major> list = SelectAll();
            List<config_majorModel> li = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel ko = new config_majorModel();  
                    ko.mak_id = item.id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.test_amount = item.test_amount;  li.Add(ko);
            }
            return li;
        }

        public int update(config_majorModel item)
        {
            config_major ko = new config_major(); 
                    ko.id = item.mak_id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.test_amount = item.test_amount;   return ModifyWithOutproNames(ko);
            }
        public List<config_majorModel> selectupdate(int id)
        {
            List<config_major> list = SeleteBy(e => e.id == id);


            List<config_majorModel> li = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel ko = new config_majorModel(); 
                    ko.mak_id = item.id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.test_amount = item.test_amount;   li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            config_major us = new config_major();
            //接收前台来的id与表的id匹配
            us.id = id;
            //开始删除
            db.Entry<config_major>(us).State = EntityState.Deleted;
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
