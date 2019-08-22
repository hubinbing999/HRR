using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8.CodeFirst
{
  public  class config_major_kindConfig : EntityTypeConfiguration<config_major_kind>
    {
        public config_major_kindConfig()
        {
            this.ToTable(nameof(config_major_kind));
            this.Property(e => e.major_kind_name).HasMaxLength(60);
            this.Property(e => e.major_kind_id).HasMaxLength(2);
           
        }
    }
}
