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
                    u_true_name = "123"
                };
                mc.users.Add(us);

                engage_major_release eng = new engage_major_release()
                {
                     human_amount=2, changer=null, change_time=DateTime.Now,  deadline= DateTime.Now, engage_required="张的帅", engage_type="校园招聘", first_kind_id="1", first_kind_name="啦", major_describe="你开心就好", major_id="03", major_name="运营部", major_kind_id="03", major_kind_name="经理", register="hbb", regist_time=DateTime.Now, second_kind_id="09", second_kind_name="胡彬冰", third_kind_id="07", third_kind_name="22"
                };
                mc.engage_major_release.Add(eng);
               
                
                config_file_second_kind cf = new config_file_second_kind() {
                    first_kind_id = "01",
                    first_kind_name= "集团",
                    second_kind_id= "01",
                    second_kind_name = "软件公司",
                    second_salary_id = "1",
                    second_sale_id = "1"
                };
                config_file_third_kind ck = new config_file_third_kind() {
                    first_kind_id = "01",
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
                    first_kind_id = "01",
                    first_kind_name = "集团",
                    first_kind_salary_id = "1",
                    first_kind_sale_id = "1"
                };

                mc.config_file_second_kinds.Add(cf);
                mc.config_file_first_kinds.Add(cc);
                mc.config_file_third_kinds.Add(ck);
                mc.SaveChanges();
                int pd = mc.SaveChanges();
                Console.WriteLine(pd);
                Console.WriteLine("ok");
                Console.ReadKey();

}
}
}
}
