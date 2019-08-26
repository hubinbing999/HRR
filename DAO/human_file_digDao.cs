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
    public class human_file_digDAO : Daobase<human_file_dig>, human_file_digIDAO
    {
        public int Add(human_file_digModel item)
        {
            human_file_dig ko = new human_file_dig(); 
                    ko.id = item.id;  
                    ko.human_id = item.human_id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.third_kind_id = item.third_kind_id;  
                    ko.third_kind_name = item.third_kind_name;  
                    ko.human_name = item.human_name;  
                    ko.human_address = item.human_address;  
                    ko.human_postcode = item.human_postcode;  
                    ko.human_pro_designation = item.human_pro_designation;  
                    ko.human_major_kind_id = item.human_major_kind_id;  
                    ko.human_major_kind_name = item.human_major_kind_name;  
                    ko.human_major_id = item.human_major_id;  
                    ko.hunma_major_name = item.hunma_major_name;  
                    ko.human_telephone = item.human_telephone;  
                    ko.human_mobilephone = item.human_mobilephone;  
                    ko.human_bank = item.human_bank;  
                    ko.human_account = item.human_account;  
                    ko.human_qq = item.human_qq;  
                    ko.human_email = item.human_email;  
                    ko.human_hobby = item.human_hobby;  
                    ko.human_speciality = item.human_speciality;  
                    ko.human_sex = item.human_sex;  
                    ko.human_religion = item.human_religion;  
                    ko.human_party = item.human_party;  
                    ko.human_nationality = item.human_nationality;  
                    ko.human_race = item.human_race;  
                    ko.human_birthday = item.human_birthday;  
                    ko.human_birthplace = item.human_birthplace;  
                    ko.human_age = item.human_age;  
                    ko.human_educated_degree = item.human_educated_degree;  
                    ko.human_educated_years = item.human_educated_years;  
                    ko.human_educated_major = item.human_educated_major;  
                    ko.human_society_security_id = item.human_society_security_id;  
                    ko.human_id_card = item.human_id_card;  
                    ko.remark = item.remark;  
                    ko.salary_standard_id = item.salary_standard_id;  
                    ko.salary_standard_name = item.salary_standard_name;  
                    ko.salary_sum = item.salary_sum;  
                    ko.demand_salaray_sum = item.demand_salaray_sum;  
                    ko.paid_salary_sum = item.paid_salary_sum;  
                    ko.major_change_amount = item.major_change_amount;  
                    ko.bonus_amount = item.bonus_amount;  
                    ko.training_amount = item.training_amount;  
                    ko.file_chang_amount = item.file_chang_amount;  
                    ko.human_histroy_records = item.human_histroy_records;  
                    ko.human_family_membership = item.human_family_membership;  
                    ko.human_picture = item.human_picture;  
                    ko.attachment_name = item.attachment_name;  
                    ko.check_status = item.check_status;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.changer = item.changer;  
                    ko.regist_time = item.regist_time;  
                    ko.check_time = item.check_time;  
                    ko.change_time = item.change_time;  
                    ko.lastly_change_time = item.lastly_change_time;  
                    ko.delete_time = item.delete_time;  
                    ko.recovery_time = item.recovery_time;  
                    ko.human_file_status = item.human_file_status; return  Add(ko);
        }

        public List<human_file_digModel> select()
        {
            List<human_file_dig> list = SelectAll();
            List<human_file_digModel> li = new List<human_file_digModel>();
            foreach (human_file_dig item in list)
            {
                human_file_digModel ko = new human_file_digModel();  
                    ko.id = item.id;  
                    ko.human_id = item.human_id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.third_kind_id = item.third_kind_id;  
                    ko.third_kind_name = item.third_kind_name;  
                    ko.human_name = item.human_name;  
                    ko.human_address = item.human_address;  
                    ko.human_postcode = item.human_postcode;  
                    ko.human_pro_designation = item.human_pro_designation;  
                    ko.human_major_kind_id = item.human_major_kind_id;  
                    ko.human_major_kind_name = item.human_major_kind_name;  
                    ko.human_major_id = item.human_major_id;  
                    ko.hunma_major_name = item.hunma_major_name;  
                    ko.human_telephone = item.human_telephone;  
                    ko.human_mobilephone = item.human_mobilephone;  
                    ko.human_bank = item.human_bank;  
                    ko.human_account = item.human_account;  
                    ko.human_qq = item.human_qq;  
                    ko.human_email = item.human_email;  
                    ko.human_hobby = item.human_hobby;  
                    ko.human_speciality = item.human_speciality;  
                    ko.human_sex = item.human_sex;  
                    ko.human_religion = item.human_religion;  
                    ko.human_party = item.human_party;  
                    ko.human_nationality = item.human_nationality;  
                    ko.human_race = item.human_race;  
                    ko.human_birthday = item.human_birthday;  
                    ko.human_birthplace = item.human_birthplace;  
                    ko.human_age = item.human_age;  
                    ko.human_educated_degree = item.human_educated_degree;  
                    ko.human_educated_years = item.human_educated_years;  
                    ko.human_educated_major = item.human_educated_major;  
                    ko.human_society_security_id = item.human_society_security_id;  
                    ko.human_id_card = item.human_id_card;  
                    ko.remark = item.remark;  
                    ko.salary_standard_id = item.salary_standard_id;  
                    ko.salary_standard_name = item.salary_standard_name;  
                    ko.salary_sum = item.salary_sum;  
                    ko.demand_salaray_sum = item.demand_salaray_sum;  
                    ko.paid_salary_sum = item.paid_salary_sum;  
                    ko.major_change_amount = item.major_change_amount;  
                    ko.bonus_amount = item.bonus_amount;  
                    ko.training_amount = item.training_amount;  
                    ko.file_chang_amount = item.file_chang_amount;  
                    ko.human_histroy_records = item.human_histroy_records;  
                    ko.human_family_membership = item.human_family_membership;  
                    ko.human_picture = item.human_picture;  
                    ko.attachment_name = item.attachment_name;  
                    ko.check_status = item.check_status;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.changer = item.changer;  
                    ko.regist_time = item.regist_time;  
                    ko.check_time = item.check_time;  
                    ko.change_time = item.change_time;  
                    ko.lastly_change_time = item.lastly_change_time;  
                    ko.delete_time = item.delete_time;  
                    ko.recovery_time = item.recovery_time;  
                    ko.human_file_status = item.human_file_status;  li.Add(ko);
            }
            return li;
        }

        public int update(human_file_digModel item)
        {
            human_file_dig ko = new human_file_dig(); 
                    ko.id = item.id;  
                    ko.human_id = item.human_id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.third_kind_id = item.third_kind_id;  
                    ko.third_kind_name = item.third_kind_name;  
                    ko.human_name = item.human_name;  
                    ko.human_address = item.human_address;  
                    ko.human_postcode = item.human_postcode;  
                    ko.human_pro_designation = item.human_pro_designation;  
                    ko.human_major_kind_id = item.human_major_kind_id;  
                    ko.human_major_kind_name = item.human_major_kind_name;  
                    ko.human_major_id = item.human_major_id;  
                    ko.hunma_major_name = item.hunma_major_name;  
                    ko.human_telephone = item.human_telephone;  
                    ko.human_mobilephone = item.human_mobilephone;  
                    ko.human_bank = item.human_bank;  
                    ko.human_account = item.human_account;  
                    ko.human_qq = item.human_qq;  
                    ko.human_email = item.human_email;  
                    ko.human_hobby = item.human_hobby;  
                    ko.human_speciality = item.human_speciality;  
                    ko.human_sex = item.human_sex;  
                    ko.human_religion = item.human_religion;  
                    ko.human_party = item.human_party;  
                    ko.human_nationality = item.human_nationality;  
                    ko.human_race = item.human_race;  
                    ko.human_birthday = item.human_birthday;  
                    ko.human_birthplace = item.human_birthplace;  
                    ko.human_age = item.human_age;  
                    ko.human_educated_degree = item.human_educated_degree;  
                    ko.human_educated_years = item.human_educated_years;  
                    ko.human_educated_major = item.human_educated_major;  
                    ko.human_society_security_id = item.human_society_security_id;  
                    ko.human_id_card = item.human_id_card;  
                    ko.remark = item.remark;  
                    ko.salary_standard_id = item.salary_standard_id;  
                    ko.salary_standard_name = item.salary_standard_name;  
                    ko.salary_sum = item.salary_sum;  
                    ko.demand_salaray_sum = item.demand_salaray_sum;  
                    ko.paid_salary_sum = item.paid_salary_sum;  
                    ko.major_change_amount = item.major_change_amount;  
                    ko.bonus_amount = item.bonus_amount;  
                    ko.training_amount = item.training_amount;  
                    ko.file_chang_amount = item.file_chang_amount;  
                    ko.human_histroy_records = item.human_histroy_records;  
                    ko.human_family_membership = item.human_family_membership;  
                    ko.human_picture = item.human_picture;  
                    ko.attachment_name = item.attachment_name;  
                    ko.check_status = item.check_status;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.changer = item.changer;  
                    ko.regist_time = item.regist_time;  
                    ko.check_time = item.check_time;  
                    ko.change_time = item.change_time;  
                    ko.lastly_change_time = item.lastly_change_time;  
                    ko.delete_time = item.delete_time;  
                    ko.recovery_time = item.recovery_time;  
                    ko.human_file_status = item.human_file_status;   return ModifyWithOutproNames(ko);
            }
        public List<human_file_digModel> selectupdate(int id)
        {
            List<human_file_dig> list = SeleteBy(e => e.id == id);


            List<human_file_digModel> li = new List<human_file_digModel>();
            foreach (human_file_dig item in list)
            {
                human_file_digModel ko = new human_file_digModel(); 
                    ko.id = item.id;  
                    ko.human_id = item.human_id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.second_kind_id = item.second_kind_id;  
                    ko.second_kind_name = item.second_kind_name;  
                    ko.third_kind_id = item.third_kind_id;  
                    ko.third_kind_name = item.third_kind_name;  
                    ko.human_name = item.human_name;  
                    ko.human_address = item.human_address;  
                    ko.human_postcode = item.human_postcode;  
                    ko.human_pro_designation = item.human_pro_designation;  
                    ko.human_major_kind_id = item.human_major_kind_id;  
                    ko.human_major_kind_name = item.human_major_kind_name;  
                    ko.human_major_id = item.human_major_id;  
                    ko.hunma_major_name = item.hunma_major_name;  
                    ko.human_telephone = item.human_telephone;  
                    ko.human_mobilephone = item.human_mobilephone;  
                    ko.human_bank = item.human_bank;  
                    ko.human_account = item.human_account;  
                    ko.human_qq = item.human_qq;  
                    ko.human_email = item.human_email;  
                    ko.human_hobby = item.human_hobby;  
                    ko.human_speciality = item.human_speciality;  
                    ko.human_sex = item.human_sex;  
                    ko.human_religion = item.human_religion;  
                    ko.human_party = item.human_party;  
                    ko.human_nationality = item.human_nationality;  
                    ko.human_race = item.human_race;  
                    ko.human_birthday = item.human_birthday;  
                    ko.human_birthplace = item.human_birthplace;  
                    ko.human_age = item.human_age;  
                    ko.human_educated_degree = item.human_educated_degree;  
                    ko.human_educated_years = item.human_educated_years;  
                    ko.human_educated_major = item.human_educated_major;  
                    ko.human_society_security_id = item.human_society_security_id;  
                    ko.human_id_card = item.human_id_card;  
                    ko.remark = item.remark;  
                    ko.salary_standard_id = item.salary_standard_id;  
                    ko.salary_standard_name = item.salary_standard_name;  
                    ko.salary_sum = item.salary_sum;  
                    ko.demand_salaray_sum = item.demand_salaray_sum;  
                    ko.paid_salary_sum = item.paid_salary_sum;  
                    ko.major_change_amount = item.major_change_amount;  
                    ko.bonus_amount = item.bonus_amount;  
                    ko.training_amount = item.training_amount;  
                    ko.file_chang_amount = item.file_chang_amount;  
                    ko.human_histroy_records = item.human_histroy_records;  
                    ko.human_family_membership = item.human_family_membership;  
                    ko.human_picture = item.human_picture;  
                    ko.attachment_name = item.attachment_name;  
                    ko.check_status = item.check_status;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.changer = item.changer;  
                    ko.regist_time = item.regist_time;  
                    ko.check_time = item.check_time;  
                    ko.change_time = item.change_time;  
                    ko.lastly_change_time = item.lastly_change_time;  
                    ko.delete_time = item.delete_time;  
                    ko.recovery_time = item.recovery_time;  
                    ko.human_file_status = item.human_file_status;   li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            human_file_dig us = new human_file_dig();
            //接收前台来的id与表的id匹配
            us.id = id;
            //开始删除
            db.Entry<human_file_dig>(us).State = EntityState.Deleted;
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
