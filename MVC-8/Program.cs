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
                mc.config_file_first_kinds.Add(cc);
                Console.ReadKey();

}
}
}
}
