using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8.CodeFirst
{
   public class StudentConfig:EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            this.ToTable(nameof(Student));
            //一个学生里必须有一个班级: this.HasRequired(e => e.Classs)
            this.HasRequired(e => e.Classs).
                WithMany().
                HasForeignKey(e => e.classsid);
            //一个班级里有多个学生(e => e.Classs). WithMany()
        }
    }
}
    