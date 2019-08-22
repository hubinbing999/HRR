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
    public class usersDAO : Daobase<users>, usersIDAO
    {
        public int Add(usersModel item)
        {
            users ko = new users(); 
                    ko.id = item.id;  
                    ko.u_name = item.u_name;  
                    ko.u_true_name = item.u_true_name;  
                    ko.u_password = item.u_password; return  Add(ko);
        }

        public List<usersModel> select()
        {
            List<users> list = SelectAll();
            List<usersModel> li = new List<usersModel>();
            foreach (users item in list)
            {
                usersModel ko = new usersModel();  
                    ko.id = item.id;  
                    ko.u_name = item.u_name;  
                    ko.u_true_name = item.u_true_name;  
                    ko.u_password = item.u_password;  li.Add(ko);
            }
            return li;
        }

        public int update(usersModel item)
        {
            users ko = new users(); 
                    ko.id = item.id;  
                    ko.u_name = item.u_name;  
                    ko.u_true_name = item.u_true_name;  
                    ko.u_password = item.u_password;   return ModifyWithOutproNames(ko);
            }
        public List<usersModel> selectupdate(int id)
        {
            List<users> list = SeleteBy(e => e.id == id);
        

            List<usersModel> li = new List<usersModel>();
            foreach (users item in list)
            {
                usersModel ko = new usersModel(); 
                    ko.id = item.id;  
                    ko.u_name = item.u_name;  
                    ko.u_true_name = item.u_true_name;  
                    ko.u_password = item.u_password;   li.Add(ko);
            }
            return li;

        }

       

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            users us = new users();
            //接收前台来的id与表的id匹配
            us.id = id;
            //开始删除
            db.Entry<users>(us).State = EntityState.Deleted;
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
        public int dl(usersModel us)
        {
            users u = new users();
           List<users>  li=SeleteBy(e => e.u_true_name.Equals(us.u_true_name) && e.u_password.Equals(us.u_password));

            //var result = db.Database.SqlQuery<users>($@"select [id] from  [dbo].[users] where [u_true_name]='{us.u_true_name}' and [u_password]='{us.u_password}'");
            return li[0].id;
        }




    }
}
