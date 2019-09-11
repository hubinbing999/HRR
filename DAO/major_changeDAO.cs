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
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class major_changeDAO : Daobase<major_change>, major_changeIDAO
    {
        public int Add(major_changeModel st)
        {
            major_change mm = new major_change();
            mm.mch_id = st.mch_id;
            mm.first_kind_id = st.first_kind_id;
            mm.first_kind_name = st.first_kind_name;
            mm.second_kind_id = st.second_kind_id;
            mm.second_kind_name = st.second_kind_name;
            mm.third_kind_id = st.third_kind_id;
            mm.third_kind_name = st.third_kind_name;
            mm.major_kind_id = st.major_kind_id;
            mm.major_kind_name = st.major_kind_name;
            mm.major_id = st.major_id;
            mm.major_name = st.major_name;
            mm.new_first_kind_id = st.new_first_kind_id;
            mm.new_first_kind_name = st.new_first_kind_name;
            mm.new_second_kind_id = st.new_second_kind_id;
            mm.new_second_kind_name = st.new_second_kind_name;
            mm.new_third_kind_id = st.new_third_kind_id;
            mm.new_third_kind_name = st.new_third_kind_name;
            mm.new_major_kind_id = st.new_major_kind_id;
            mm.new_major_kind_name = st.new_major_kind_name;
            mm.new_major_id = st.new_major_id;
            mm.new_major_name = st.new_major_name;
            mm.human_id = st.human_id;
            mm.human_name = st.human_name;
            mm.salary_standard_id = st.salary_standard_id;
            mm.salary_standard_name = st.salary_standard_name;
            mm.salary_sum = st.salary_sum;
            mm.new_salary_standard_id = st.new_salary_standard_id;
            mm.new_salary_standard_name = st.new_salary_standard_name;
            mm.new_salary_sum = st.new_salary_sum;
            mm.change_reason = st.change_reason;
            mm.check_reason = st.check_reason;
            mm.check_status = st.check_status;
            mm.register = st.register;
            mm.checker = st.checker;
            mm.regist_time = st.regist_time;
            mm.check_time = st.check_time;
            return Add(mm);

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

        public int delete(int id)
        {
            major_change us = new major_change();
            //接收前台来的id与表的id匹配
            us.mch_id = id;
            //开始删除
            db.Entry<major_change>(us).State = EntityState.Deleted;
            //保存            
            return db.SaveChanges();
        }

        public List<major_changeModel> select()
        {
            List<major_change> list = SelectAll();
            List<major_changeModel> li = new List<major_changeModel>();
            foreach (major_change item in list)
            {
                major_changeModel mm = new major_changeModel();
                mm.mch_id = item.mch_id;
                mm.first_kind_id = item.first_kind_id;
                mm.first_kind_name = item.first_kind_name;
                mm.second_kind_id = item.second_kind_id;
                mm.second_kind_name = item.second_kind_name;
                mm.third_kind_id = item.third_kind_id;
                mm.third_kind_name = item.third_kind_name;
                mm.major_kind_id = item.major_kind_id;
                mm.major_kind_name = item.major_kind_name;
                mm.major_id = item.major_id;
                mm.major_name = item.major_name;
                mm.new_first_kind_id = item.new_first_kind_id;
                mm.new_first_kind_name = item.new_first_kind_name;
                mm.new_second_kind_id = item.new_second_kind_id;
                mm.new_second_kind_name = item.new_second_kind_name;
                mm.new_third_kind_id = item.new_third_kind_id;
                mm.new_third_kind_name = item.new_third_kind_name;
                mm.new_major_kind_id = item.new_major_kind_id;
                mm.new_major_kind_name = item.new_major_kind_name;
                mm.new_major_id = item.new_major_id;
                mm.new_major_name = item.new_major_name;
                mm.human_id = item.human_id;
                mm.human_name = item.human_name;
                mm.salary_standard_id = item.salary_standard_id;
                mm.salary_standard_name = item.salary_standard_name;
                mm.salary_sum = item.salary_sum;
                mm.new_salary_standard_id = item.new_salary_standard_id;
                mm.new_salary_standard_name = item.new_salary_standard_name;
                mm.new_salary_sum = item.new_salary_sum;
                mm.change_reason = item.change_reason;
                mm.check_reason = item.check_reason;
                mm.check_status = item.check_status;
                mm.register = item.register;
                mm.checker = item.checker;
                mm.regist_time = item.regist_time;
                mm.check_time = item.check_time;
                li.Add(mm);
            }
            return li;
        }

        public List<major_changeModel> selectupdate(int id)
        {
            List<major_change> list = SeleteBy(e => e.mch_id == id);
            List<major_changeModel> li = new List<major_changeModel>();
            foreach (major_change item in list)
            {
                major_changeModel mm = new major_changeModel();
                mm.mch_id = item.mch_id;
                mm.first_kind_id = item.first_kind_id;
                mm.first_kind_name = item.first_kind_name;
                mm.second_kind_id = item.second_kind_id;
                mm.second_kind_name = item.second_kind_name;
                mm.third_kind_id = item.third_kind_id;
                mm.third_kind_name = item.third_kind_name;
                mm.major_kind_id = item.major_kind_id;
                mm.major_kind_name = item.major_kind_name;
                mm.major_id = item.major_id;
                mm.major_name = item.major_name;
                mm.new_first_kind_id = item.new_first_kind_id;
                mm.new_first_kind_name = item.new_first_kind_name;
                mm.new_second_kind_id = item.new_second_kind_id;
                mm.new_second_kind_name = item.new_second_kind_name;
                mm.new_third_kind_id = item.new_third_kind_id;
                mm.new_third_kind_name = item.new_third_kind_name;
                mm.new_major_kind_id = item.new_major_kind_id;
                mm.new_major_kind_name = item.new_major_kind_name;
                mm.new_major_id = item.new_major_id;
                mm.new_major_name = item.new_major_name;
                mm.human_id = item.human_id;
                mm.human_name = item.human_name;
                mm.salary_standard_id = item.salary_standard_id;
                mm.salary_standard_name = item.salary_standard_name;
                mm.salary_sum = item.salary_sum;
                mm.new_salary_standard_id = item.new_salary_standard_id;
                mm.new_salary_standard_name = item.new_salary_standard_name;
                mm.new_salary_sum = item.new_salary_sum;
                mm.change_reason = item.change_reason;
                mm.check_reason = item.check_reason;
                mm.check_status = item.check_status;
                mm.register = item.register;
                mm.checker = item.checker;
                mm.regist_time = item.regist_time;
                mm.check_time = item.check_time;
                li.Add(mm);
            }
            return li;
        }

        public int update(major_changeModel item)
        {
            major_change mm = new major_change();
            mm.mch_id = item.mch_id;
            mm.first_kind_id = item.first_kind_id;
            mm.first_kind_name = item.first_kind_name;
            mm.second_kind_id = item.second_kind_id;
            mm.second_kind_name = item.second_kind_name;
            mm.third_kind_id = item.third_kind_id;
            mm.third_kind_name = item.third_kind_name;
            mm.major_kind_id = item.major_kind_id;
            mm.major_kind_name = item.major_kind_name;
            mm.major_id = item.major_id;
            mm.major_name = item.major_name;
            mm.new_first_kind_id = item.new_first_kind_id;
            mm.new_first_kind_name = item.new_first_kind_name;
            mm.new_second_kind_id = item.new_second_kind_id;
            mm.new_second_kind_name = item.new_second_kind_name;
            mm.new_third_kind_id = item.new_third_kind_id;
            mm.new_third_kind_name = item.new_third_kind_name;
            mm.new_major_kind_id = item.new_major_kind_id;
            mm.new_major_kind_name = item.new_major_kind_name;
            mm.new_major_id = item.new_major_id;
            mm.new_major_name = item.new_major_name;
            mm.human_id = item.human_id;
            mm.human_name = item.human_name;
            mm.salary_standard_id = item.salary_standard_id;
            mm.salary_standard_name = item.salary_standard_name;
            mm.salary_sum = item.salary_sum;
            mm.new_salary_standard_id = item.new_salary_standard_id;
            mm.new_salary_standard_name = item.new_salary_standard_name;
            mm.new_salary_sum = item.new_salary_sum;
            mm.change_reason = item.change_reason;
            mm.check_reason = item.check_reason;
            mm.check_status = item.check_status;
            mm.register = item.register;
            mm.checker = item.checker;
            mm.regist_time = item.regist_time;
            mm.check_time = item.check_time;
            return ModifyWithOutproNames(mm);
        }
        public DataTable FenYe(int currentPage, out int rows, out int pages, int pageSize)
        {
            string sql = "[dbo].[proc_FenYeAA]";
            SqlParameter[] ps =
            {
                 new SqlParameter() {ParameterName="@pageSize ",Value=pageSize },
                 new SqlParameter() {ParameterName="@keyName ",Value="[mch_id]" },
                 new SqlParameter() {ParameterName="@tableName ",Value="[major_change]" },
                  new SqlParameter() {ParameterName="@whereText ",Value="" },
                   new SqlParameter() {ParameterName="@pageIndex",Value=currentPage },
                   new SqlParameter() {ParameterName="@Filter",Value="*"},
                   new SqlParameter() {ParameterName="@orderText",Value=""},
                     new SqlParameter() {ParameterName="@pages ",Direction=ParameterDirection.Output,SqlDbType=SqlDbType.Int },
                      new SqlParameter() {ParameterName="@rows ",Direction=ParameterDirection.Output,SqlDbType=SqlDbType.Int}
            };
            DataTable dt = DBHelper.SelectFenYe(sql, ps);
            pages = (int)ps[7].Value;
            rows = (int)ps[8].Value;
            return dt;
        }

        public List<major_changeModel> atjcx(string yi, string er, string san, string si, string wu, string time1, string time2)
        {
            List<major_change> list = new List<major_change>();
            if (time1 == null && time2 == null)
            {
                list = SeleteBy(e => e.new_first_kind_id.Contains(yi) && e.new_second_kind_id.Contains(er) && e.new_third_kind_id.Contains(san) && e.new_major_kind_id.Contains(si) && e.new_major_id.Contains(wu));
            }
            else if (time1 == null && time2 != null)
            {
                DateTime time4 = DateTime.Parse(time2);
                list = SeleteBy(e => e.new_first_kind_id.Contains(yi) && e.new_second_kind_id.Contains(er) && e.new_third_kind_id.Contains(san) && e.new_major_kind_id.Contains(si) && e.new_major_id.Contains(wu) && e.regist_time <= time4);
            }
            else if (time2 == null && time1 != null)
            {
                DateTime time3 = DateTime.Parse(time1);
                list = SeleteBy(e => e.new_first_kind_id.Contains(yi) && e.new_second_kind_id.Contains(er) && e.new_third_kind_id.Contains(san) && e.new_major_kind_id.Contains(si) && e.new_major_id.Contains(wu) && e.regist_time >= time3);
            }
            else
            {
                DateTime time3 = DateTime.Parse(time1);
                DateTime time4 = DateTime.Parse(time2);
                list = SeleteBy(e => e.new_first_kind_id.Contains(yi) && e.new_second_kind_id.Contains(er) && e.new_third_kind_id.Contains(san) && e.new_major_id.Contains(si) && e.new_major_kind_id.Contains(wu) && e.regist_time >= time3 && e.regist_time <= time4);
            }
            List<major_changeModel> list2 = new List<major_changeModel>();
            foreach (var item in list)
            {
                major_changeModel sd = new major_changeModel()
                {
                    mch_id = item.mch_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_id = item.major_id,
                    major_name = item.major_name,
                    new_first_kind_id = item.new_first_kind_id,
                    new_first_kind_name = item.new_first_kind_name,
                    new_second_kind_id = item.new_second_kind_id,
                    new_second_kind_name = item.new_second_kind_name,
                    new_third_kind_id = item.new_third_kind_id,
                    new_third_kind_name = item.new_third_kind_name,
                    new_major_kind_id = item.new_major_kind_id,
                    new_major_kind_name = item.new_major_kind_name,
                    new_major_id = item.new_major_id,
                    new_major_name = item.new_major_name,
                    human_id = item.human_id,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    new_salary_standard_id = item.new_salary_standard_id,
                    new_salary_standard_name = item.new_salary_standard_name,
                    new_salary_sum = item.new_salary_sum,
                    change_reason = item.change_reason,
                    check_reason = item.check_reason,
                    check_status = item.check_status,
                    register = item.register,
                    checker = item.checker,
                    regist_time = item.regist_time,
                    check_time = item.check_time
                };
                list2.Add(sd);
            }
            return list2;

        }
    }
    }
