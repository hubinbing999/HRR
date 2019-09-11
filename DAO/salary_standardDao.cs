using IDAO;
using MVC_8;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
using System.Data.SqlClient;
using System.Data;
using Model.bangzhu;
using System.Linq.Expressions;
using System.Linq;

namespace DAO
{
    public class salary_standardDAO : Daobase<salary_standard>, salary_standardIDAO
    {
        public int Add(salary_standardModel item)
        {
            salary_standard ko = new salary_standard(); 
                    ko.Id = item.id;  
                    ko.standard_id = item.standard_id;  
                    ko.standard_name = item.standard_name;  
                    ko.designer = item.designer;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.changer = item.changer;  
                    ko.regist_time = item.regist_time;  
                    ko.check_time = item.check_time;  
                    ko.change_time = item.change_time;  
                    ko.salary_sum = item.salary_sum;  
                    ko.check_status = item.check_status;  
                    ko.change_status = item.change_status;  
                    ko.check_comment = item.check_comment;  
                    ko.remark = item.remark; return  Add(ko);
        }

        public List<salary_standardModel> select()
        {
            List<salary_standard> list = SelectAll();
            List<salary_standardModel> li = new List<salary_standardModel>();
            foreach (salary_standard item in list)
            {
                salary_standardModel ko = new salary_standardModel();  
                    ko.id = item.Id;  
                    ko.standard_id = item.standard_id;  
                    ko.standard_name = item.standard_name;  
                    ko.designer = item.designer;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.changer = item.changer;  
                    ko.regist_time = item.regist_time;  
                    ko.check_time = item.check_time;  
                    ko.change_time = item.change_time;  
                    ko.salary_sum = item.salary_sum;  
                    ko.check_status = item.check_status;  
                    ko.change_status = item.change_status;  
                    ko.check_comment = item.check_comment;  
                    ko.remark = item.remark;  li.Add(ko);
            }
            return li;
        }

        public int update(salary_standardModel item)
        {
            salary_standard ko = db.salary_standard.Where(e => e.Id.Equals(item.id)).FirstOrDefault();
                    ko.Id = item.id;  
                    ko.standard_name = item.standard_name;  
                    ko.designer = item.designer;  
                    ko.register = item.register;  
                    ko.checker = item.checker;             
                    ko.check_time = item.check_time;    
                    ko.salary_sum = item.salary_sum;  
                    ko.check_status = item.check_status;  
                    ko.remark = item.remark;
            return db.SaveChanges();
        }
        public int BianGenupdate(salary_standardModel item)
        {
            salary_standard ko = db.salary_standard.Where(e => e.Id.Equals(item.id)).FirstOrDefault();
            ko.Id = item.id;
            ko.standard_name = item.standard_name;
            ko.designer = item.designer;
            ko.changer = item.changer;
            ko.change_time = item.change_time;
            ko.salary_sum = item.salary_sum;
            ko.change_status = item.change_status;
            ko.remark = item.remark;
            return db.SaveChanges();
        }
        public List<salary_standardModel> selectupdate(int id)
        {

            List<salary_standard> list = SeleteBy(e => e.Id == id);


            List<salary_standardModel> li = new List<salary_standardModel>();
            foreach (salary_standard item in list)
            {
                salary_standardModel ko = new salary_standardModel(); 
                    ko.id = item.Id;  
                    ko.standard_id = item.standard_id;  
                    ko.standard_name = item.standard_name;  
                    ko.designer = item.designer;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.changer = item.changer;  
                    ko.regist_time = item.regist_time;  
                    ko.check_time = item.check_time;  
                    ko.change_time = item.change_time;  
                    ko.salary_sum = item.salary_sum;  
                    ko.check_status = item.check_status;  
                    ko.change_status = item.change_status;  
                    ko.check_comment = item.check_comment;  
                    ko.remark = item.remark;   li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            salary_standard us = new salary_standard();
            //接收前台来的id与表的id匹配
            us.Id = id;
            //开始删除
            db.Entry<salary_standard>(us).State = EntityState.Deleted;
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

        public string BianHao() {
            string sql = "xcbj";
            SqlParameter[] ji = {
                     new SqlParameter(){ ParameterName="@danhao",Size=14, SqlDbType= SqlDbType.VarChar, Direction= ParameterDirection.Output},
                };
            DataTable dt = DBHaipu.SelectProc(sql, ji, "");
            //获取值
            string r = ji[0].Value.ToString();
            return r;
        }
        public salary_standardFenYe fenye(int dqy, int rl)
        {
            salary_standardFenYe cs = new salary_standardFenYe();
            List<salary_standardModel> li = new List<salary_standardModel>();
            int rows = 0;
            var data = db.Set<salary_standard>().OrderBy(e => e.Id).Where(e => e.check_status == 0).AsNoTracking();
            rows = data.Count();//获取总行数
            List<salary_standard> list = FenYe<int>(e => e.Id, e => e.check_status == 0, ref rows, dqy, rl);
            foreach (salary_standard item in list)
            {
                salary_standardModel ko = new salary_standardModel();
                ko.id = item.Id;
                ko.standard_id = item.standard_id;
                ko.standard_name = item.standard_name;
                ko.designer = item.designer;
                ko.register = item.register;
                ko.checker = item.checker;
                ko.changer = item.changer;
                ko.regist_time = item.regist_time;
                ko.check_time = item.check_time;
                ko.change_time = item.change_time;
                ko.salary_sum = item.salary_sum;
                ko.check_status = item.check_status;
                ko.change_status = item.change_status;
                ko.check_comment = item.check_comment;
                ko.remark = item.remark;
                li.Add(ko);
            }
            cs.li = li;
            cs.MyProperty = rows;
            cs.zys = (rows % rl == 0 ? rows / rl : rows % rl + 1);
            return cs;

        }
        public XCcan Fenye2(salarystandard_query_locateCan ji) {
            Expression<Func<salary_standard, bool>> expr = n => GetCondition(n, ji);
            XCcan cs = new XCcan();
            List<salary_standardModel> li = new List<salary_standardModel>();
            int rows = 0;
            var data = db.Set<salary_standard>().OrderBy(e => e.Id).Where(expr.Compile()).ToList();
            rows = data.Count();//获取总行数
            List<salary_standard> list = data.Skip((ji.dqy - 1) * ji.rl)
                  .Take(ji.rl)
                  .ToList();
            foreach (salary_standard item in list)
            {
                salary_standardModel ko = new salary_standardModel();
                ko.id = item.Id;
                ko.standard_id = item.standard_id;
                ko.standard_name = item.standard_name;
                ko.designer = item.designer;
                ko.register = item.register;
                ko.checker = item.checker;
                ko.changer = item.changer;
                ko.regist_time = item.regist_time;
                ko.check_time = item.check_time;
                ko.change_time = item.change_time;
                ko.salary_sum = item.salary_sum;
                ko.check_status = item.check_status;
                ko.change_status = item.change_status;
                ko.check_comment = item.check_comment;
                ko.remark = item.remark;
                li.Add(ko);
            }
            cs.li = li;
            cs.MyProperty = rows;
            cs.zys = (rows % ji.rl == 0 ? rows / ji.rl : rows % ji.rl + 1);
            return cs;

        }
        private bool GetCondition(salary_standard fb, salarystandard_query_locateCan ji)
        {
            bool boolResult = true;

            if (!ji.standard.Equals("查询全部"))
            {
                boolResult &= fb.standard_id.Contains(ji.standard);
            }
            if (!ji.utilbean.Equals("查询全部"))
            {
                boolResult &= fb.designer.Contains(ji.utilbean);
            }

            boolResult &= fb.regist_time >= ji.startDate;
            boolResult &= fb.regist_time <= ji.datePropertyName;
            return boolResult;


        }

    }
}
