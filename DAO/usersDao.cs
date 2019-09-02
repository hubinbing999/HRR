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
    public class usersDAO : Daobase<users>, usersIDAO
    {
        public int Add(usersModel item)
        {
            users ko = new users(); 
                    ko.id = item.id;  
                    ko.u_name = item.u_name;  
                    ko.u_true_name = item.u_true_name;  
                    ko.u_password = item.u_password;
                    ko.roleID = item.roleID;
                    return  Add(ko);
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
                    ko.u_password = item.u_password;
                ko.roleID = item.roleID;
                li.Add(ko);
            }
            return li;
        }

        public int update(usersModel item)
        {
            users ko = new users(); 
                    ko.id = item.id;  
                    ko.u_name = item.u_name;  
                    ko.u_true_name = item.u_true_name;  
                    ko.u_password = item.u_password;
                     ko.roleID = item.roleID;
                   return ModifyWithOutproNames(ko);
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
                    ko.u_password = item.u_password;
                     ko.roleID = item.roleID;
                li.Add(ko);
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
           List<users>  li=SeleteBy(e => e.u_name.Equals(us.u_name) && e.u_password.Equals(us.u_password));
            foreach (users item in li)
            {
                if (item == null || item.Equals(""))
                {
                    return 0;
                }
                else
                {
                    return li[0].id;
                }
            }
            return 0;


           
            //var result = db.Database.SqlQuery<users>($@"select [id] from  [dbo].[users] where [u_true_name]='{us.u_true_name}' and [u_password]='{us.u_password}'");
            
        }

        public List<usersModel> SelectList()
        {
            var result = db.Database.SqlQuery<usersModel>($@"select id, u_name, u_true_name, u_password, (select [RoleName] from [dbo].[RoleManager] rm where(rm.roleID=u.roleID))as RoleName from [dbo].[users] u").ToList();
            return result;
        }

        public int SelectCount()
        {
            string sql = @"select count(*) from View_1 ";
            return int.Parse(DBHelper.SelectSinger(sql).ToString());
        }

        public DataTable BandList()
        {
            string sql = @"select * from [dbo].[RoleManager]";
            return DBHelper.SelectTable(sql);
        }
        //select * from View_1
        public  DataTable ShowBYQX(object Aid, object id)
        {
            string sql = "";
            if (id != null)
            {
                //查询子集
                sql = string.Format(@"select id, text,A.PID, Aaddress, state from [dbo].[Access] A where  A.PID={0}", id);

            }
            else
            {
                sql = string.Format(@"select A.id, text, A.PID, Aaddress, state from [dbo].[Access] A  inner join Permission p on a.id=p.Aid where p.roleID='{0}'and a.PID=0", Aid);

            }
            return DBHelper.SelectTable(sql);
        }
        /// <summary>
        /// 查询角色根据UID
        /// </summary>
        /// <returns></returns>
        public DataTable SelectJS(int Uid)
        {
            string sql = string.Format(@"select [roleID],u_true_name,(select  RoleName from RoleManager r where (u.roleID=r.[RoleID]))as RoleName from [dbo].[users] u  where id={0}", Uid);
            return DBHelper.SelectTable(sql);
        }
    }
}
