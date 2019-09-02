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
    public class engage_resumeDAO : Daobase<engage_resume>, engage_resumeIDAO
    {
        public int Add(engage_resumeModel item)
        {

            engage_resume ko = new engage_resume();
            ko.Id = item.Id;
            ko.human_name = item.human_name;
            ko.engage_type = item.engage_type;
            ko.human_address = item.human_address;
            ko.human_postcode = item.human_postcode;
            ko.human_major_kind_id = item.human_major_kind_id;
            ko.human_major_kind_name = item.human_major_kind_name;
            ko.human_major_id = item.human_major_id;
            ko.human_major_name = item.human_major_name;
            ko.human_telephone = item.human_telephone;
            ko.human_homephone = item.human_homephone;
            ko.human_mobilephone = item.human_mobilephone;
            ko.human_email = item.human_email;
            ko.human_hobby = item.human_hobby;
            ko.human_specility = item.human_specility;
            ko.human_sex = item.human_sex;
            ko.human_religion = item.human_religion;
            ko.human_party = item.human_party;
            ko.human_nationality = item.human_nationality;
            ko.human_race = item.human_race;
            ko.human_birthday = item.human_birthday;
            ko.human_age = item.human_age;
            ko.human_educated_degree = item.human_educated_degree;
            ko.human_educated_years = item.human_educated_years;
            ko.human_educated_major = item.human_educated_major;
            ko.human_college = item.human_college;
            ko.human_idcard = item.human_idcard;
            ko.human_birthplace = item.human_birthplace;
            ko.demand_salary_standard = item.demand_salary_standard;
            ko.human_history_records = item.human_history_records;
            ko.remark = item.remark;
            ko.recomandation = item.recomandation;
            ko.human_picture = item.human_picture;
            ko.attachment_name = item.attachment_name;
            ko.check_status = item.check_status;
            ko.register = item.register;
            ko.regist_time = item.regist_time;
            ko.checker = item.checker;
            ko.check_time = DateTime.Now;
            ko.interview_status = item.interview_status;
            ko.total_points = item.total_points;
            ko.test_amount = item.test_amount;
            ko.test_checker = item.test_checker;
            ko.test_check_time = DateTime.Now;
            ko.pass_register = item.pass_register;
            ko.pass_regist_time = DateTime.Now;
            ko.pass_checker = item.pass_checker;
            ko.pass_check_time = DateTime.Now;
            ko.pass_check_status = item.pass_check_status;
            ko.pass_checkComment = item.pass_checkComment;
            ko.pass_passComment = item.pass_passComment; return  Add(ko);
        }

        public List<engage_resumeModel> select()
        {
            List<engage_resume> list = SelectAll();
            List<engage_resumeModel> li = new List<engage_resumeModel>();
            foreach (engage_resume item in list)
            {
                engage_resumeModel ko = new engage_resumeModel();  
                    ko.Id = item.Id;  
                    ko.human_name = item.human_name;  
                    ko.engage_type = item.engage_type;  
                    ko.human_address = item.human_address;  
                    ko.human_postcode = item.human_postcode;  
                    ko.human_major_kind_id = item.human_major_kind_id;  
                    ko.human_major_kind_name = item.human_major_kind_name;  
                    ko.human_major_id = item.human_major_id;  
                    ko.human_major_name = item.human_major_name;  
                    ko.human_telephone = item.human_telephone;  
                    ko.human_homephone = item.human_homephone;  
                    ko.human_mobilephone = item.human_mobilephone;  
                    ko.human_email = item.human_email;  
                    ko.human_hobby = item.human_hobby;  
                    ko.human_specility = item.human_specility;  
                    ko.human_sex = item.human_sex;  
                    ko.human_religion = item.human_religion;  
                    ko.human_party = item.human_party;  
                    ko.human_nationality = item.human_nationality;  
                    ko.human_race = item.human_race;  
                    ko.human_birthday = item.human_birthday;  
                    ko.human_age = item.human_age;  
                    ko.human_educated_degree = item.human_educated_degree;  
                    ko.human_educated_years = item.human_educated_years;  
                    ko.human_educated_major = item.human_educated_major;  
                    ko.human_college = item.human_college;  
                    ko.human_idcard = item.human_idcard;  
                    ko.human_birthplace = item.human_birthplace;  
                    ko.demand_salary_standard = item.demand_salary_standard;  
                    ko.human_history_records = item.human_history_records;  
                    ko.remark = item.remark;  
                    ko.recomandation = item.recomandation;  
                    ko.human_picture = item.human_picture;  
                    ko.attachment_name = item.attachment_name;  
                    ko.check_status = item.check_status;  
                    ko.register = item.register;  
                    ko.regist_time = item.regist_time;  
                    ko.checker = item.checker;  
                    ko.check_time = item.check_time;  
                    ko.interview_status = item.interview_status;  
                    ko.total_points = item.total_points;  
                    ko.test_amount = item.test_amount;  
                    ko.test_checker = item.test_checker;  
                    ko.test_check_time = item.test_check_time;  
                    ko.pass_register = item.pass_register;  
                    ko.pass_regist_time = item.pass_regist_time;  
                    ko.pass_checker = item.pass_checker;  
                    ko.pass_check_time = item.pass_check_time;  
                    ko.pass_check_status = item.pass_check_status;  
                    ko.pass_checkComment = item.pass_checkComment;  
                    ko.pass_passComment = item.pass_passComment;  li.Add(ko);
            }
            return li;
        }

        public int update(engage_resumeModel item)
        {
            engage_resume ko = new engage_resume(); 
                    ko.Id = item.Id;  
                    ko.human_name = item.human_name;  
                    ko.engage_type = item.engage_type;  
                    ko.human_address = item.human_address;  
                    ko.human_postcode = item.human_postcode;  
                    ko.human_major_kind_id = item.human_major_kind_id;  
                    ko.human_major_kind_name = item.human_major_kind_name;  
                    ko.human_major_id = item.human_major_id;  
                    ko.human_major_name = item.human_major_name;  
                    ko.human_telephone = item.human_telephone;  
                    ko.human_homephone = item.human_homephone;  
                    ko.human_mobilephone = item.human_mobilephone;  
                    ko.human_email = item.human_email;  
                    ko.human_hobby = item.human_hobby;  
                    ko.human_specility = item.human_specility;  
                    ko.human_sex = item.human_sex;  
                    ko.human_religion = item.human_religion;  
                    ko.human_party = item.human_party;  
                    ko.human_nationality = item.human_nationality;  
                    ko.human_race = item.human_race;  
                    ko.human_birthday = item.human_birthday;  
                    ko.human_age = item.human_age;  
                    ko.human_educated_degree = item.human_educated_degree;  
                    ko.human_educated_years = item.human_educated_years;  
                    ko.human_educated_major = item.human_educated_major;  
                    ko.human_college = item.human_college;  
                    ko.human_idcard = item.human_idcard;  
                    ko.human_birthplace = item.human_birthplace;  
                    ko.demand_salary_standard = item.demand_salary_standard;  
                    ko.human_history_records = item.human_history_records;  
                    ko.remark = item.remark;  
                    ko.recomandation = item.recomandation;  
                    ko.human_picture = item.human_picture;  
                    ko.attachment_name = item.attachment_name;  
                    ko.check_status = item.check_status;  
                    ko.register = item.register;  
                    ko.regist_time = item.regist_time;  
                    ko.checker = item.checker;  
                    ko.check_time = item.check_time;  
                    ko.interview_status = item.interview_status;  
                    ko.total_points = item.total_points;  
                    ko.test_amount = item.test_amount;  
                    ko.test_checker = item.test_checker;  
                    ko.test_check_time = item.test_check_time;  
                    ko.pass_register = item.pass_register;  
                    ko.pass_regist_time = item.pass_regist_time;  
                    ko.pass_checker = item.pass_checker;  
                    ko.pass_check_time = item.pass_check_time;  
                    ko.pass_check_status = item.pass_check_status;  
                    ko.pass_checkComment = item.pass_checkComment;  
                    ko.pass_passComment = item.pass_passComment;   return ModifyWithOutproNames(ko);
            }
        public List<engage_resumeModel> selectupdate(int id)
        {
            List<engage_resume> list = SeleteBy(e => e.Id == id);


            List<engage_resumeModel> li = new List<engage_resumeModel>();
            foreach (engage_resume item in list)
            {
                engage_resumeModel ko = new engage_resumeModel(); 
                    ko.Id = item.Id;  
                    ko.human_name = item.human_name;  
                    ko.engage_type = item.engage_type;  
                    ko.human_address = item.human_address;  
                    ko.human_postcode = item.human_postcode;  
                    ko.human_major_kind_id = item.human_major_kind_id;  
                    ko.human_major_kind_name = item.human_major_kind_name;  
                    ko.human_major_id = item.human_major_id;  
                    ko.human_major_name = item.human_major_name;  
                    ko.human_telephone = item.human_telephone;  
                    ko.human_homephone = item.human_homephone;  
                    ko.human_mobilephone = item.human_mobilephone;  
                    ko.human_email = item.human_email;  
                    ko.human_hobby = item.human_hobby;  
                    ko.human_specility = item.human_specility;  
                    ko.human_sex = item.human_sex;  
                    ko.human_religion = item.human_religion;  
                    ko.human_party = item.human_party;  
                    ko.human_nationality = item.human_nationality;  
                    ko.human_race = item.human_race;  
                    ko.human_birthday = item.human_birthday;  
                    ko.human_age = item.human_age;  
                    ko.human_educated_degree = item.human_educated_degree;  
                    ko.human_educated_years = item.human_educated_years;  
                    ko.human_educated_major = item.human_educated_major;  
                    ko.human_college = item.human_college;  
                    ko.human_idcard = item.human_idcard;  
                    ko.human_birthplace = item.human_birthplace;  
                    ko.demand_salary_standard = item.demand_salary_standard;  
                    ko.human_history_records = item.human_history_records;  
                    ko.remark = item.remark;  
                    ko.recomandation = item.recomandation;  
                    ko.human_picture = item.human_picture;  
                    ko.attachment_name = item.attachment_name;  
                    ko.check_status = item.check_status;  
                    ko.register = item.register;  
                    ko.regist_time = item.regist_time;  
                    ko.checker = item.checker;  
                    ko.check_time = item.check_time;  
                    ko.interview_status = item.interview_status;  
                    ko.total_points = item.total_points;  
                    ko.test_amount = item.test_amount;  
                    ko.test_checker = item.test_checker;  
                    ko.test_check_time = item.test_check_time;  
                    ko.pass_register = item.pass_register;  
                    ko.pass_regist_time = item.pass_regist_time;  
                    ko.pass_checker = item.pass_checker;  
                    ko.pass_check_time = item.pass_check_time;  
                    ko.pass_check_status = item.pass_check_status;  
                    ko.pass_checkComment = item.pass_checkComment;  
                    ko.pass_passComment = item.pass_passComment;   li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            engage_resume us = new engage_resume();
            //接收前台来的id与表的id匹配
            us.Id = id;
            //开始删除
            db.Entry<engage_resume>(us).State = EntityState.Deleted;
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
