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
                mc.config_file_second_kinds.Add(cf);
                mc.config_file_first_kinds.Add(cc);
                mc.config_file_third_kinds.Add(ck);
                mc.SaveChanges();
                Console.WriteLine("ok");
                Console.ReadKey();

}
}
}
}
