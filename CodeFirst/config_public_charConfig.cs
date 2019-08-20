using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace MVC_8.CodeFirst
{
   public class config_public_charConfig:EntityTypeConfiguration<config_public_char>
    {
        public config_public_charConfig() {
            this.ToTable(nameof(config_public_char));
            this.Property(e => e.attribute_kind).HasMaxLength(60);
            this.Property(e => e.attribute_name).HasMaxLength(60);
        }
    }
}
