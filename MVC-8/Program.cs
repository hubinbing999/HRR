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
                config_file_first_kind cc = new config_file_first_kind()
                {
                    first_kind_id = "01",
                    first_kind_name = "集团",
                    first_kind_salary_id = "1",
                    first_kind_sale_id = "1"
                };
                mc.config_file_first_kind.Add(cc);

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
                int pd=mc.SaveChanges();
                Console.WriteLine(pd);
                Console.ReadKey();

}
}
}
}
