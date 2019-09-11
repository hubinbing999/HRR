using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using MVC_8;
using System.Runtime.Remoting.Messaging;
using System.Data.Entity;

namespace DAO
{
   public  class salary_standardDAO :Daobase<salary_standard>, salary_standardIDAO
    {
        public int Add(salary_standardModel item)
        {
            salary_standard ss = new salary_standard();
            ss.ssd_id = item.ssd_id;
            ss.standard_id = item.standard_id;
            ss.standard_name = item.standard_name;
            ss.salary_sum = item.salary_sum;
            ss.remark = item.remark;
            ss.regist_time = item.regist_time;
            ss.register = item.register;
            ss.changer = item.changer;
            ss.change_status = item.change_status;
            ss.change_time = item.change_time;
            ss.checker = item.checker;
            ss.check_comment = item.check_comment;
            ss.check_status = item.check_status;
            ss.check_time = item.check_time;
            ss.designer = item.designer;
            return Add(ss);


          }

        

        public int delete(int id)
        {
            salary_standard us = new salary_standard();
            //接收前台来的id与表的id匹配
            us.ssd_id = id;
            //开始删除
            db.Entry<salary_standard>(us).State = EntityState.Deleted;
            //保存            
            return db.SaveChanges();
        }

        public List<salary_standardModel> select()
        {

        List<salary_standard> list = SelectAll();
        List<salary_standardModel> li = new List<salary_standardModel>();
        foreach (salary_standard item in list)
        {
                salary_standardModel ss = new salary_standardModel();
                ss.ssd_id = item.ssd_id;
                ss.standard_id = item.standard_id;
                ss.standard_name = item.standard_name;
                ss.salary_sum = item.salary_sum;
                ss.remark = item.remark;
                ss.regist_time = item.regist_time;
                ss.register = item.register;
                ss.changer = item.changer;
                ss.change_status = item.change_status;
                ss.change_time = item.change_time;
                ss.checker = item.checker;
                ss.check_comment = item.check_comment;
                ss.check_status = item.check_status;
                ss.check_time = item.check_time;
                ss.designer = item.designer;
                li.Add(ss);
            }
        return li;
    }

        public List<salary_standardModel> selectupdate(int id)
        {
            List<salary_standard> list = SeleteBy(e => e.ssd_id == id);


            List<salary_standardModel> li = new List<salary_standardModel>();
            foreach (salary_standard item in list)
            {
                salary_standardModel ss = new salary_standardModel();
                ss.ssd_id = item.ssd_id;
                ss.standard_id = item.standard_id;
                ss.standard_name = item.standard_name;
                ss.salary_sum = item.salary_sum;
                ss.remark = item.remark;
                ss.regist_time = item.regist_time;
                ss.register = item.register;
                ss.changer = item.changer;
                ss.change_status = item.change_status;
                ss.change_time = item.change_time;
                ss.checker = item.checker;
                ss.check_comment = item.check_comment;
                ss.check_status = item.check_status;
                ss.check_time = item.check_time;
                ss.designer = item.designer;
                li.Add(ss);
            }
            return li;
        }

        public int update(salary_standardModel item)
        {
            salary_standard ss = new salary_standard();
            ss.ssd_id = item.ssd_id;
            ss.standard_id = item.standard_id;
            ss.standard_name = item.standard_name;
            ss.salary_sum = item.salary_sum;
            ss.remark = item.remark;
            ss.regist_time = item.regist_time;
            ss.register = item.register;
            ss.changer = item.changer;
            ss.change_status = item.change_status;
            ss.change_time = item.change_time;
            ss.checker = item.checker;
            ss.check_comment = item.check_comment;
            ss.check_status = item.check_status;
            ss.check_time = item.check_time;
            ss.designer = item.designer;
            return ModifyWithOutproNames(ss);
        }

        static MyDbContext db = CreateDbContext();
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
