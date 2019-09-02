using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (MyDbContext mc = new MyDbContext()) {
                
                mc.Database.Log = (sql) =>
                {
                    Console.WriteLine(sql);
                };


                config_major_kind jj = new config_major_kind()
                {

                    major_kind_id = "01",
                    major_kind_name = "销售"
                };
                mc.config_major_kind.Add(jj);
                config_major ko = new config_major()
                {
                    major_id = "01",
                    major_kind_name = "销售",
                    major_kind_id = "01",
                    major_name = "区域经理",
                    test_amount = 0
                };

                mc.config_major.Add(ko);
                config_public_char c = new config_public_char()
                {
                    attribute_kind = "国籍",
                    attribute_name = "中国"

                };
                mc.config_public_char.Add(c);
                users us = new users()
                {
                    u_name = "123",
                    u_password = "123",
                    u_true_name = "123",
                    roleID = 1

                };
                mc.users.Add(us);

                engage_major_release eng = new engage_major_release()
                {
                    human_amount = 2,
                    changer = null,
                    change_time = DateTime.Now,
                    deadline = DateTime.Now,
                    engage_required = "张的帅",
                    engage_type = "校园招聘",
                    first_kind_id = "1",
                    first_kind_name = "啦",
                    major_describe = "你开心就好",
                    major_id = "03",
                    major_name = "运营部",
                    major_kind_id = "03",
                    major_kind_name = "经理",
                    register = "hbb",
                    regist_time = DateTime.Now,
                    second_kind_id = "09",
                    second_kind_name = "胡彬冰",
                    third_kind_id = "07",
                    third_kind_name = "22"
                };
                mc.engage_major_release.Add(eng);


                config_file_second_kind cf = new config_file_second_kind()
                {
                    first_kind_id = "01",
                    first_kind_name = "集团",
                    second_kind_id = "01",
                    second_kind_name = "软件公司",
                    second_salary_id = "1",
                    second_sale_id = "1"
                };
                config_file_third_kind ck = new config_file_third_kind()
                {
                    first_kind_id = "08",
                    first_kind_name = "集团",
                    second_kind_id = "01",
                    second_kind_name = "软件公司",
                    third_kind_id = "01",
                    third_kind_name = "外包组",
                    third_kind_sale_id = "1",
                    third_kind_is_retail = "否"
                };
                config_file_first_kind cc = new config_file_first_kind()
                {
                    first_kind_id = "08",
                    first_kind_name = "集团",
                    first_kind_salary_id = "1",
                    first_kind_sale_id = "1"
                };
                users uu = new users()
                {
                    id = 1,
                    u_name = "XXXX",
                    u_true_name = "易烊千玺",
                    u_password = "1128",
                    roleID = 2
                };
                RoleManager rr = new RoleManager()
                {
                    RoleID = 1,
                    RoleName = "人事专员",
                    RoleState = "完善公司的人事制度与招聘计划，员工培训与发展计划",
                    RoleOk = "是"
                };
                Access aa = new Access()
                {
                    id = 1,
                    text= "招聘管理",
                    PID=0,
                    Aaddress="狗头",
                    state= "closed"
                };
                Permission pp = new Permission()
                {
                    Pid=1,
                    roleID=1,
                    Aid=20
                };
                mc.config_file_second_kinds.Add(cf);
                mc.config_file_first_kinds.Add(cc);
                mc.config_file_third_kinds.Add(ck);

                human_file_dig yy = new human_file_dig()
                {
                    attachment_name = "胡彬",
                    bonus_amount = 1,
                    changer = "罗盼",
                    change_time = DateTime.Now,
                    checker = "胡彬冰",
                    check_status = 2,
                    check_time = DateTime.Now,
                    delete_time = DateTime.Now,
                    demand_salaray_sum = 1300,
                    file_chang_amount = 7,
                    first_kind_id = "01",
                    first_kind_name = "机构",
                    human_account = "21321312",
                    human_address = "长沙理工",
                    human_age = 12,
                    human_bank = "长沙银行",
                    human_birthday = DateTime.Now,
                    human_birthplace = "湖南宁乡",
                    human_educated_degree = "本科",
                    human_educated_major = "IT",
                    human_educated_years = 18,
                    human_email = "2387108878@qq.com",
                    human_family_membership = "子女",
                    human_file_status = true,
                    human_histroy_records = "好孩子",
                    human_hobby = "吃饭",
                    human_id = "213213131321",
                    human_id_card = "4301241990909765x",
                    human_major_id = "2",
                    human_major_kind_id = "02",
                    human_major_kind_name = "记录",
                    human_mobilephone = "13758751873",
                    human_name = "胡彬冰",
                    human_nationality = "中国",
                    human_party = "团员",
                    human_picture = "uwuuwuw",
                    human_postcode = "43101",
                    human_pro_designation = "垃圾员",
                    human_qq = "2387108878",
                    human_race = "汉族",
                    human_religion = "基督教",
                    human_sex = "男",
                    human_society_security_id = "123213",
                    human_speciality = "跳舞",
                    human_telephone = "15074933279",
                    hunma_major_name = "垃圾",
                    lastly_change_time = DateTime.Now,
                    major_change_amount = 1,
                    paid_salary_sum = 12313,
                    recovery_time = DateTime.Now,
                    register = "胡彬冰",
                    regist_time = DateTime.Now,
                    remark = "亲戚",
                    salary_standard_id = "232",
                    salary_standard_name = "垃圾",
                    salary_sum = 1000,
                    second_kind_id = "12",
                    second_kind_name = "lak",
                    third_kind_id = "03",
                    third_kind_name = "pd",
                    training_amount = 0

                };
                mc.human_file_dig.Add(yy);
                human_file hu = new human_file()
                {
                     attachment_name="胡彬", bonus_amount=1, changer="罗盼", change_time=DateTime.Now, checker="胡彬冰", check_status=2, check_time=DateTime.Now, delete_time=DateTime.Now, demand_salaray_sum=1300, file_chang_amount=7, first_kind_id="01", first_kind_name="机构", human_account="21321312", human_address="长沙理工", human_age=12, human_bank="长沙银行", human_birthday=DateTime.Now, human_birthplace="湖南宁乡", human_educated_degree="本科", human_educated_major="IT", human_educated_years=18, human_email="2387108878@qq.com", human_family_membership="子女", human_file_status=true, human_histroy_records="好孩子", human_hobby="吃饭", human_id="213213131321", human_id_card="4301241990909765x", human_major_id="2", human_major_kind_id="02", human_major_kind_name="记录", human_mobilephone="13758751873", human_name="胡彬冰", human_nationality="中国", human_party="团员", human_picture="uwuuwuw", human_postcode="43101", human_pro_designation="垃圾员", human_qq="2387108878", human_race="汉族", human_religion="基督教", human_sex="男", human_society_security_id="123213",  human_speciality="跳舞", human_telephone="15074933279", hunma_major_name="垃圾", lastly_change_time=DateTime.Now, major_change_amount=1, paid_salary_sum=12313, recovery_time=DateTime.Now, register="胡彬冰", regist_time=DateTime.Now, remark="亲戚", salary_standard_id="232", salary_standard_name="垃圾", salary_sum=1000, second_kind_id="12", second_kind_name="lak", third_kind_id="03", third_kind_name="pd", training_amount=0
                };
                mc.human_file.Add(hu);

                mc.SaveChanges();
                int pd = mc.SaveChanges();
                Console.WriteLine(pd);
                Console.WriteLine("ok");
                Console.ReadKey();

}
}
}
}
