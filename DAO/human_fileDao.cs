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
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity.Infrastructure;
using Model.bangzhu;
using System.Linq.Expressions;

namespace DAO
{
    public class human_fileDAO : Daobase<human_file>, human_fileIDAO
    {
        static MyDbContext db = CreateDbContext();
        public string Add(human_fileModel item)
        {
            human_file ko = new human_file();
            string sql = "bd";
            SqlParameter[] ji = {
                     new SqlParameter(){ ParameterName="@danhao",Size=14, SqlDbType= SqlDbType.VarChar, Direction= ParameterDirection.Output},
                };
            DataTable dt = DBHaipu.SelectProc(sql, ji, "");
            //获取值
            string r = ji[0].Value.ToString();
                    ko.human_id = r;
                   // ko.human_id = item.human_id;  
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
            // 
                    ko.attachment_name = item.attachment_name;  
                    ko.check_status = item.check_status;  
                    ko.register = item.register;  
                    ko.checker = item.checker;  
                    ko.changer = item.changer;  
            //
                    ko.regist_time = item.regist_time;  
                    ko.check_time = DateTime.Now;  
                    ko.change_time = DateTime.Now;  
                    ko.lastly_change_time = DateTime.Now;  
                    ko.delete_time = DateTime.Now;  
                    ko.recovery_time = DateTime.Now;  
                    ko.human_file_status = item.human_file_status;
            ko.salary_standard_name = item.salary_standard_name;
            ko.salary_standard_id = item.salary_standard_id;
            ko.salary_sum = item.salary_sum;
            ko.register = item.register;


            if (Add(ko) > 0)
            {
                return r;

            }
            else {
                return null;
            }
           
        }

        public List<human_fileModel> select()
        {
            List<human_file> list = SelectAll();
            List<human_fileModel> li = new List<human_fileModel>();
            foreach (human_file item in list)
            {
                human_fileModel ko = new human_fileModel();  
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

        public int update(human_fileModel item)
        {

          
            human_file st = db.human_file.Where(e => e.id.Equals(item.id)).FirstOrDefault();
            //修改名称
            st.human_picture = item.human_picture;

            return db.SaveChanges(); ;
            }
        //状态修改
        public int updateztai(human_fileModel item)
        {
            
            human_file st = db.human_file.Where(e => e.id.Equals(item.id)).FirstOrDefault();
            if (item.delete_time == DateTime.MinValue) {
                st.recovery_time = item.recovery_time;
            }
            if (item.recovery_time == DateTime.MinValue)
            {
                st.delete_time = item.delete_time;
            }


            //修改名称
            st.human_file_status = item.human_file_status;

            return db.SaveChanges(); ;
        }
        public int update12(human_fileModel item) {
            human_file ko = db.human_file.Where(e => e.id.Equals(item.id)).FirstOrDefault();
            //修改名称
            ko.human_pro_designation = item.human_pro_designation;
            ko.human_name = item.human_name;
            ko.human_sex = item.human_sex;
            ko.human_email = item.human_email;
            ko.human_telephone = item.human_telephone;
            ko.human_qq = item.human_qq;
            ko.human_mobilephone = item.human_mobilephone;
            ko.human_address = item.human_address;
            ko.human_postcode = item.human_postcode;
            ko.human_nationality = item.human_nationality;
            ko.human_birthplace = item.human_birthplace;
            ko.human_birthday = item.human_birthday;
            ko.human_race = item.human_race;
            ko.human_religion = item.human_religion;
            ko.human_party = item.human_party;
            ko.human_id_card = item.human_id_card;
            ko.human_society_security_id = item.human_society_security_id;
            ko.human_age = item.human_age;

            ko.human_educated_degree = item.human_educated_degree;

            ko.human_educated_years = item.human_educated_years;

            ko.human_educated_major = item.human_educated_major;

            ko.salary_standard_id = item.salary_standard_id;

            ko.human_bank = item.human_bank;

            ko.human_account = item.human_account;

            ko.checker = item.checker;

            ko.check_time = item.check_time;

            ko.human_speciality = item.human_speciality;

            ko.human_hobby = item.human_hobby;

            ko.human_histroy_records = item.human_histroy_records;

            ko.human_family_membership = item.human_family_membership;
            ko.remark = item.remark;
            ko.check_status = item.check_status;
            ko.human_file_status = false;

            return db.SaveChanges();

        }
        public int update13(human_fileModel item) {
            human_file ko = db.human_file.Where(e => e.id.Equals(item.id)).FirstOrDefault();
            //修改名称
            ko.human_pro_designation = item.human_pro_designation;
            ko.human_name = item.human_name;
            ko.human_sex = item.human_sex;
            ko.human_email = item.human_email;
            ko.human_telephone = item.human_telephone;
            ko.human_qq = item.human_qq;
            ko.human_mobilephone = item.human_mobilephone;
            ko.human_address = item.human_address;
            ko.human_postcode = item.human_postcode;
            ko.human_nationality = item.human_nationality;
            ko.human_birthplace = item.human_birthplace;
            ko.human_birthday = item.human_birthday;
            ko.human_race = item.human_race;
            ko.human_religion = item.human_religion;
            ko.human_party = item.human_party;
            ko.human_id_card = item.human_id_card;
            ko.human_society_security_id = item.human_society_security_id;
            ko.human_age = item.human_age;

            ko.human_educated_degree = item.human_educated_degree;

            ko.human_educated_years = item.human_educated_years;

            ko.human_educated_major = item.human_educated_major;

            ko.salary_standard_id = item.salary_standard_id;

            ko.human_bank = item.human_bank;

            ko.human_account = item.human_account;

            ko.changer = item.changer;

            ko.change_time = item.change_time;

            ko.human_speciality = item.human_speciality;

            ko.human_hobby = item.human_hobby;

            ko.human_histroy_records = item.human_histroy_records;

            ko.human_family_membership = item.human_family_membership;
            ko.remark = item.remark;
            ko.check_status = item.check_status;
            ko.human_file_status = false;
            ko.lastly_change_time = item.lastly_change_time;
            return db.SaveChanges();

        }
        public List<human_fileModel> selectupdate(string id)
        {
            List<human_file> list = SeleteBy(e => e.human_id.Equals(id));


            List<human_fileModel> li = new List<human_fileModel>();
            foreach (human_file item in list)
            {
                human_fileModel ko = new human_fileModel(); 
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


        public int delete(int id)
        {
            human_file us = new human_file();
            //接收前台来的id与表的id匹配
            us.id = id;
            RemoveHoldingEntityInContext(us);
            //开始删除
            db.Entry<human_file>(us).State = EntityState.Deleted;
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
        public canshulei fenye(int dqy,int rl) {
            canshulei cs = new canshulei();
            List<human_fileModel> li = new List<human_fileModel>();
            int rows=0;
            var data = db.Set<human_file>().OrderBy(e => e.id).Where(e => e.check_status==0).AsNoTracking();
            rows =data.Count();//获取总行数
            List<human_file> list = FenYe<int>(e => e.id, e => e.check_status == 0, ref rows, dqy, rl);
            foreach (human_file item in list)
            {
                human_fileModel mo = new human_fileModel();
                 mo.id = item.id;
                 mo.human_name= item.human_name ;
                mo.human_id = item.human_id;
               mo.human_sex = item.human_sex ;
                  mo.first_kind_name= item.first_kind_name;
                 mo.second_kind_name= item.second_kind_name ;
                mo.third_kind_name = item.third_kind_name ;
                 mo.hunma_major_name= item.hunma_major_name ;
                li.Add(mo);
            }
            cs.li = li;
            cs.MyProperty = rows;
            cs.zys = (rows % rl == 0 ? rows / rl : rows / rl + 1);
            return cs;
        }

        public canshulei fenye2(Cansh ji)
        {
            Expression<Func<human_file, bool>> expr = n => GetCondition(n,ji);
            canshulei cs = new canshulei();

            List<human_fileModel> li = new List<human_fileModel>();
            int rows = 0;
            var data = db.Set<human_file>().OrderBy(e => e.id).Where(expr.Compile()).ToList();
            rows = data.Count();//获取总行数
            List <human_file> list = data.Skip((ji.dqy - 1) * ji.rl)
                  .Take(ji.rl)
                  .ToList();
            foreach (human_file item in list)
            {
                human_fileModel mo = new human_fileModel();
                mo.id = item.id;
                mo.human_name = item.human_name;
                mo.human_id = item.human_id;
                mo.human_sex = item.human_sex;
                mo.first_kind_name = item.first_kind_name;
                mo.second_kind_name = item.second_kind_name;
                mo.third_kind_name = item.third_kind_name;
                mo.hunma_major_name = item.hunma_major_name;
                mo.human_major_kind_name = item.human_major_kind_name;
                li.Add(mo);
            }
            cs.li = li;
            cs.MyProperty = rows;
            cs.zys = (rows % ji.rl == 0 ? rows / ji.rl : rows / ji.rl + 1);
            return cs;
        }
        private bool GetCondition(human_file fb, Cansh ji)
        {
            bool boolResult = true;
            if (!ji.first_kind_id.Equals("查询全部"))
            {
                boolResult &= fb.first_kind_id.Equals(ji.first_kind_id);
            }
            if (!ji.second_kind_id.Equals("查询全部")) {
                boolResult &= fb.second_kind_id.Equals(ji.second_kind_id);
            }
            if (!ji.third_kind_id.Equals("查询全部"))
            {
                boolResult &= fb.third_kind_id.Equals(ji.third_kind_id);
            }
            if (!ji.human_major_kind_id.Equals("查询全部"))
            {
                boolResult &= fb.human_major_kind_id.Equals(ji.human_major_kind_id);
            }
            if (!ji.hunma_major_name.Equals("查询全部"))
            {
                boolResult &= fb.human_major_id.Equals(ji.hunma_major_name);
            }
            boolResult &= fb.regist_time >= ji.utilBeanstartDate;
            boolResult &= fb.regist_time <= ji.utilBeandatePropertyName;
            boolResult &= fb.human_file_status == ji.human_file_status;
            return boolResult;


        }
        public canshulei fenye3(int dqy, int rl, string name) {
            canshulei cs = new canshulei();
            List<human_fileModel> li = new List<human_fileModel>();
            int rows = 0;
            var data = db.Set<human_file>().OrderBy(e => e.id).Where(e => e.human_name.Contains(name) && e.check_status==0).AsNoTracking();
            rows = data.Count();//获取总行数
            List<human_file> list = FenYe<int>(e => e.id, e => e.human_name.Contains(name) &&e.check_status == 0, ref rows, dqy, rl);
            foreach (human_file item in list)
            {
                human_fileModel mo = new human_fileModel();
                mo.id = item.id;
                mo.human_name = item.human_name;
                mo.human_id = item.human_id;
                mo.human_sex = item.human_sex;
                mo.first_kind_name = item.first_kind_name;
                mo.second_kind_name = item.second_kind_name;
                mo.third_kind_name = item.third_kind_name;
                mo.hunma_major_name = item.hunma_major_name;
                mo.human_major_kind_name = item.human_major_kind_name;
                li.Add(mo);
            }
            cs.li = li;
            cs.MyProperty = rows;
            cs.zys = (rows % rl == 0 ? rows / rl : rows / rl + 1);
            return cs;
        }
        //删除分页
        public canshulei fenye4(int dqy, int rl)
        {
            canshulei cs = new canshulei();
            List<human_fileModel> li = new List<human_fileModel>();
            int rows = 0;
            var data = db.Set<human_file>().OrderBy(e => e.id).Where(e => e.human_file_status==true && e.check_status == 1).AsNoTracking();
            rows = data.Count();//获取总行数
            List<human_file> list = FenYe<int>(e => e.id, e => e.human_file_status == true && e.check_status == 1, ref rows, dqy, rl);
            foreach (human_file item in list)
            {
                human_fileModel mo = new human_fileModel();
                mo.id = item.id;
                mo.human_name = item.human_name;
                mo.human_id = item.human_id;
                mo.human_sex = item.human_sex;
                mo.first_kind_name = item.first_kind_name;
                mo.second_kind_name = item.second_kind_name;
                mo.third_kind_name = item.third_kind_name;
                mo.hunma_major_name = item.hunma_major_name;
                mo.human_major_kind_name = item.human_major_kind_name;
                li.Add(mo);
            }
            cs.li = li;
            cs.MyProperty = rows;
            cs.zys = (rows % rl == 0 ? rows / rl : rows / rl + 1);
            return cs;
        }
        private Boolean RemoveHoldingEntityInContext(human_file entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<human_file>();
            var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);

            Object foundEntity;
            var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

            if (exists)
            {
                objContext.Detach(foundEntity);
            }
       

            return (exists);
        }
    }
}
