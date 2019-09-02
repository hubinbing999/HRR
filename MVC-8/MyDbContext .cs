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
           //Database.SetInitializer<MyDbContext>(null);
        }
        //加载所有的配置类对象
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.
                AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        
        public DbSet<config_major_kind> config_major_kind { get; set; }
        public DbSet<config_major> config_major { get; set; }
        public DbSet<config_public_char> config_public_char { get; set; }
        public DbSet<users> users { get; set; }
        public DbSet<engage_major_release> engage_major_release { get; set; }
        
        public DbSet<config_file_first_kind> config_file_first_kinds { get; set; }
        public DbSet<config_file_second_kind> config_file_second_kinds { get; set; }
        public DbSet<config_file_third_kind> config_file_third_kinds { get; set; }
        public DbSet<RoleManager> RoleManager { get; set; }
        public DbSet<Access> Access { get; set; }
        public DbSet<Permission> Permission { get; set; }


    }
}

