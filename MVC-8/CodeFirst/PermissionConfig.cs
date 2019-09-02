using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8.CodeFirst
{
   public  class PermissionConfig : EntityTypeConfiguration<Permission>
    {
        public PermissionConfig()
        {
            this.ToTable(nameof(Permission));
            this.Property(e => e.Pid);
            this.Property(e => e.roleID).IsRequired();;
            this.Property(e => e.Aid).IsRequired();;
        }
    }
}
