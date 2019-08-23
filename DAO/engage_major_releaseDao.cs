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
    public class engage_major_releaseDAO : Daobase<engage_major_release>, engage_major_releaseIDAO
    {
        public int Add(engage_major_releaseModel item)
        {
            engage_major_release ko = new engage_major_release(); 
                    ko.id = item.id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.third_kind_id = item.third_kind_id;  
                    ko.third_kind_name = item.third_kind_name;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.human_amount = item.human_amount;  
                    ko.engage_type = item.engage_type;  
                    ko.deadline = item.deadline;  
                    ko.register = item.register;  
                    ko.changer = item.changer;  
                    ko.regist_time = item.regist_time;  
                    ko.change_time = item.change_time;  
                    ko.major_describe = item.major_describe;  
                    ko.engage_required = item.engage_required; return  Add(ko);
        }

        public List<engage_major_releaseModel> select()
        {
            List<engage_major_release> list = SelectAll();
            List<engage_major_releaseModel> li = new List<engage_major_releaseModel>();
            foreach (engage_major_release item in list)
            {
                engage_major_releaseModel ko = new engage_major_releaseModel();  
                    ko.id = item.id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.third_kind_id = item.third_kind_id;  
                    ko.third_kind_name = item.third_kind_name;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.human_amount = item.human_amount;  
                    ko.engage_type = item.engage_type;  
                    ko.deadline = item.deadline;  
                    ko.register = item.register;  
                    ko.changer = item.changer;  
                    ko.regist_time = item.regist_time;  
                    ko.change_time = item.change_time;  
                    ko.major_describe = item.major_describe;  
                    ko.engage_required = item.engage_required;  li.Add(ko);
            }
            return li;
        }

        public int update(engage_major_releaseModel item)
        {
            engage_major_release ko = new engage_major_release(); 
                    ko.id = item.id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.third_kind_id = item.third_kind_id;  
                    ko.third_kind_name = item.third_kind_name;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.human_amount = item.human_amount;  
                    ko.engage_type = item.engage_type;  
                    ko.deadline = item.deadline;  
                    ko.register = item.register;  
                    ko.changer = item.changer;  
                    ko.regist_time = item.regist_time;  
                    ko.change_time = item.change_time;  
                    ko.major_describe = item.major_describe;  
                    ko.engage_required = item.engage_required;   return ModifyWithOutproNames(ko);
            }
        public List<engage_major_releaseModel> selectupdate(int id)
        {
            List<engage_major_release> list = SeleteBy(e => e.id == id);


            List<engage_major_releaseModel> li = new List<engage_major_releaseModel>();
            foreach (engage_major_release item in list)
            {
                engage_major_releaseModel ko = new engage_major_releaseModel(); 
                    ko.id = item.id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.third_kind_id = item.third_kind_id;  
                    ko.third_kind_name = item.third_kind_name;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.human_amount = item.human_amount;  
                    ko.engage_type = item.engage_type;  
                    ko.deadline = item.deadline;  
                    ko.register = item.register;  
                    ko.changer = item.changer;  
                    ko.regist_time = item.regist_time;  
                    ko.change_time = item.change_time;  
                    ko.major_describe = item.major_describe;  
                    ko.engage_required = item.engage_required;   li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            engage_major_release us = new engage_major_release();
            //接收前台来的id与表的id匹配
            us.id = id;
            //开始删除
            db.Entry<engage_major_release>(us).State = EntityState.Deleted;
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
        //public List<engage_major_release> FY1(int dqy, int rl, string where)
        //{
        //    if (where == "" || where == null)
        //    {
        //        FenYe(List<engage_major_release>, e =>e.id>0,)
        //    }
        //    else
        //    {

        //    }

        //}




    }
}
