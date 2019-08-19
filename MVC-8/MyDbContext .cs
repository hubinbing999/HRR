﻿using System;
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
    }
}
