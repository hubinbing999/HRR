using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
 public    class Classs
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //执行的是查询sql语句
        // var result= mc.Database.SqlQuery<Student>("select * from Student");
        //执行的是增删改的sql语句
        //int jieguo= mc.Database.ExecuteSqlCommand("delete from Student where Id=1");
    }
}
