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
    public class RoleManagerDAO : Daobase<RoleManager>, RoleManagerIDAO
    {
        public int Add(RoleManagerModel item)
        {
            RoleManager ko = new RoleManager();
            ko.RoleID = item.RoleID;
            ko.RoleName = item.RoleName;
            ko.RoleState = item.RoleState;
            ko.RoleOk = item.RoleOk;
            return Add(ko);
        }

        public List<RoleManagerModel> select()
        {
            List<RoleManager> list = SelectAll();
            List<RoleManagerModel> li = new List<RoleManagerModel>();
            foreach (RoleManager item in list)
            {
                RoleManagerModel ko = new RoleManagerModel();
                ko.RoleID = item.RoleID;
                ko.RoleName = item.RoleName;
                ko.RoleState = item.RoleState;
                ko.RoleOk = item.RoleOk; li.Add(ko);
            }
            return li;
        }

        public int update(RoleManagerModel item)
        {
            RoleManager ko = new RoleManager();
            ko.RoleID = item.RoleID;
            ko.RoleName = item.RoleName;
            ko.RoleState = item.RoleState;
            ko.RoleOk = item.RoleOk; return ModifyWithOutproNames(ko);
        }
        public List<RoleManagerModel> selectupdate(int id)
        {
            List<RoleManager> list = SeleteBy(e => e.RoleID == id);


            List<RoleManagerModel> li = new List<RoleManagerModel>();
            foreach (RoleManager item in list)
            {
                RoleManagerModel ko = new RoleManagerModel();
                ko.RoleID = item.RoleID;
                ko.RoleName = item.RoleName;
                ko.RoleState = item.RoleState;
                ko.RoleOk = item.RoleOk; li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            RoleManager us = new RoleManager();
            //接收前台来的id与表的id匹配
            us.RoleID = id;
            //开始删除
            // db.Entry<RoleManager>(us).State = EntityState.Deleted;
            int pd = Del(e => e.RoleID == id, us);
            //保存            
            // return db.SaveChanges();
            return pd;



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

        //分页查询
        public List<RoleManagerModel> fenye(int currentPage)
        {
            int rows = 0;
            List<RoleManager> list = FenYe<int>(e => e.RoleID, e => e.RoleID > 0, ref rows, currentPage, 5);
            List<RoleManagerModel> list1 = new List<RoleManagerModel>();
            foreach (RoleManager item in list)
            {
                RoleManagerModel rm = new RoleManagerModel()
                {
                    RoleID = item.RoleID,
                    RoleName = item.RoleName,
                    RoleState = item.RoleState,
                    RoleOk = item.RoleOk
                };
                list1.Add(rm);
            }
            return list1;
        }
        /// <summary>
        /// 总行数
        /// </summary>
        /// <returns></returns>
        public int Row()
        {
            int rows = 0;
            List<RoleManager> list = FenYe<int>(e => e.RoleID, e => e.RoleID > 0, ref rows, 1, 5);
            return rows;

        }
        public int pages()
        {

            int rows = 0;
            List<RoleManager> list = FenYe<int>(e => e.RoleID, e => e.RoleID > 0, ref rows, 1, 5);
            double page = rows / 5.00;
            return int.Parse(Math.Ceiling(page).ToString());

        }
        /// <summary>
        ///  查询当前角色对应权限
        /// </summary>
        /// <param name="rid"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        public DataTable selectQX(string rid, string pid)
        {
            string sql = string.Format("select id, text, state,pe.Pid,case when pe.Pid is not null then 1 else 0 end as checked from [Access] a left join(select * from Permisson where  roleID='{0}') pe on a.id= pe.Aid where a.PID ='{1}'", rid, pid);
            return DBHelper.SelectTable(sql);

        }
        //根据角色id删除角色权限表
        public int DeletePer(string rid)
        {
            string sql = string.Format(@"Delete from[dbo].[Permisson] where[roleID] ='{0}'", rid);
            return DBHelper.InsertDeleteUpdate(sql);

        }
        /// <summary>
        /// 新增角色权限表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int AddPer(string sql)
        {
            return DBHelper.InsertDeleteUpdate(sql);

        }

    }
}
