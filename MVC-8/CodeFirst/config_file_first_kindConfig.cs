using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace MVC_8.CodeFirst
{
   public class config_file_first_kindConfig:EntityTypeConfiguration<config_file_first_kind>
    {
        public config_file_first_kindConfig() {
            this.ToTable(nameof(config_file_first_kind));
            this.Property(e => e.first_kind_id).HasMaxLength(2);
            this.Property(e => e.first_kind_name).HasMaxLength(60);
            this.Property(e => e.first_kind_salary_id);
            this.Property(e => e.first_kind_sale_id);
        }
    }
}
