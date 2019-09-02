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
    public class engage_interviewDAO : Daobase<engage_interview>, engage_interviewIDAO
    {
        public int Add(engage_interviewModel item)
        {
            engage_interview ko = new engage_interview(); 
                    ko.Id = item.Id;  
                    ko.human_name = item.human_name;  
                    ko.interview_amount = item.interview_amount;  
                    ko.human_major_kind_id = item.human_major_kind_id;  
                    ko.human_major_kind_name = item.human_major_kind_name;  
                    ko.human_major_id = item.human_major_id;  
                    ko.human_major_name = item.human_major_name;  
                    ko.image_degree = item.image_degree;  
                    ko.native_language_degree = item.native_language_degree;  
                    ko.foreign_language_degree = item.foreign_language_degree;  
                    ko.response_speed_degree = item.response_speed_degree;  
                    ko.EQ_degree = item.EQ_degree;  
                    ko.IQ_degree = item.IQ_degree;  
                    ko.multi_quality_degree = item.multi_quality_degree;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.registe_time = item.registe_time;  
                    ko.check_time = item.check_time;  
                    ko.resume_id = item.resume_id;  
                    ko.result = item.result;  
                    ko.interview_comment = item.interview_comment;  
                    ko.check_comment = item.check_comment;  
                    ko.interview_status = item.interview_status;  
                    ko.check_status = item.check_status; return  Add(ko);
        }

        public List<engage_interviewModel> select()
        {
            List<engage_interview> list = SelectAll();
            List<engage_interviewModel> li = new List<engage_interviewModel>();
            foreach (engage_interview item in list)
            {
                engage_interviewModel ko = new engage_interviewModel();  
                    ko.Id = item.Id;  
                    ko.human_name = item.human_name;  
                    ko.interview_amount = item.interview_amount;  
                    ko.human_major_kind_id = item.human_major_kind_id;  
                    ko.human_major_kind_name = item.human_major_kind_name;  
                    ko.human_major_id = item.human_major_id;  
                    ko.human_major_name = item.human_major_name;  
                    ko.image_degree = item.image_degree;  
                    ko.native_language_degree = item.native_language_degree;  
                    ko.foreign_language_degree = item.foreign_language_degree;  
                    ko.response_speed_degree = item.response_speed_degree;  
                    ko.EQ_degree = item.EQ_degree;  
                    ko.IQ_degree = item.IQ_degree;  
                    ko.multi_quality_degree = item.multi_quality_degree;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.registe_time = item.registe_time;  
                    ko.check_time = item.check_time;  
                    ko.resume_id = item.resume_id;  
                    ko.result = item.result;  
                    ko.interview_comment = item.interview_comment;  
                    ko.check_comment = item.check_comment;  
                    ko.interview_status = item.interview_status;  
                    ko.check_status = item.check_status;  li.Add(ko);
            }
            return li;
        }

        public int update(engage_interviewModel item)
        {
            engage_interview ko = new engage_interview(); 
                    ko.Id = item.Id;  
                    ko.human_name = item.human_name;  
                    ko.interview_amount = item.interview_amount;  
                    ko.human_major_kind_id = item.human_major_kind_id;  
                    ko.human_major_kind_name = item.human_major_kind_name;  
                    ko.human_major_id = item.human_major_id;  
                    ko.human_major_name = item.human_major_name;  
                    ko.image_degree = item.image_degree;  
                    ko.native_language_degree = item.native_language_degree;  
                    ko.foreign_language_degree = item.foreign_language_degree;  
                    ko.response_speed_degree = item.response_speed_degree;  
                    ko.EQ_degree = item.EQ_degree;  
                    ko.IQ_degree = item.IQ_degree;  
                    ko.multi_quality_degree = item.multi_quality_degree;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.registe_time = item.registe_time;  
                    ko.check_time = item.check_time;  
                    ko.resume_id = item.resume_id;  
                    ko.result = item.result;  
                    ko.interview_comment = item.interview_comment;  
                    ko.check_comment = item.check_comment;  
                    ko.interview_status = item.interview_status;  
                    ko.check_status = item.check_status;   return ModifyWithOutproNames(ko);
            }
        public List<engage_interviewModel> selectupdate(int id)
        {
            List<engage_interview> list = SeleteBy(e => e.Id == id);


            List<engage_interviewModel> li = new List<engage_interviewModel>();
            foreach (engage_interview item in list)
            {
                engage_interviewModel ko = new engage_interviewModel(); 
                    ko.Id = item.Id;  
                    ko.human_name = item.human_name;  
                    ko.interview_amount = item.interview_amount;  
                    ko.human_major_kind_id = item.human_major_kind_id;  
                    ko.human_major_kind_name = item.human_major_kind_name;  
                    ko.human_major_id = item.human_major_id;  
                    ko.human_major_name = item.human_major_name;  
                    ko.image_degree = item.image_degree;  
                    ko.native_language_degree = item.native_language_degree;  
                    ko.foreign_language_degree = item.foreign_language_degree;  
                    ko.response_speed_degree = item.response_speed_degree;  
                    ko.EQ_degree = item.EQ_degree;  
                    ko.IQ_degree = item.IQ_degree;  
                    ko.multi_quality_degree = item.multi_quality_degree;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.registe_time = item.registe_time;  
                    ko.check_time = item.check_time;  
                    ko.resume_id = item.resume_id;  
                    ko.result = item.result;  
                    ko.interview_comment = item.interview_comment;  
                    ko.check_comment = item.check_comment;  
                    ko.interview_status = item.interview_status;  
                    ko.check_status = item.check_status;   li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            engage_interview us = new engage_interview();
            //接收前台来的id与表的id匹配
            us.Id = id;
            //开始删除
            db.Entry<engage_interview>(us).State = EntityState.Deleted;
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




        }
}
