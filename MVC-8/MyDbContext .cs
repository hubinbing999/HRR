using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8
{
  public  class MyDbContext: DbContext
    {
        public MyDbContext() : base("name=sql")
        {
            Database.SetInitializer<MyDbContext>(null);
        }
        //加载所有的配置类对象
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.
                AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Classs> ts { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<users> userss { get; set; }
        public DbSet<config_file_first_kind> config_file_first_kinds { get; set; }
        public DbSet<config_file_second_kind> config_file_second_kinds { get; set; }
        public DbSet<config_file_third_kind> config_file_third_kinds { get; set; }
        public DbSet<config_question_first_kind> config_question_first_kinds { get; set; }
        public DbSet<config_question_second_kind> config_question_second_kinds { get; set; }
        public DbSet<config_public_char> config_public_chars { get; set; }

    }
}

