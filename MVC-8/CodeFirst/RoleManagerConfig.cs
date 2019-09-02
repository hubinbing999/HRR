using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8.CodeFirst
{
    public class RoleManagerConfig : EntityTypeConfiguration<RoleManager>
    {
        public RoleManagerConfig()
        {
            this.ToTable(nameof(RoleManager));
            this.Property(e => e.RoleID);
            this.Property(e => e.RoleName).HasMaxLength(50);
            this.Property(e => e.RoleState).HasMaxLength(200);
            this.Property(e => e.RoleOk).HasMaxLength(2);

        }

    }
}
