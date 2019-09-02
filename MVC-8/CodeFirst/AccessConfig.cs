using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_8.CodeFirst
{
    public class AccessConfig: EntityTypeConfiguration<Access>
    {
        public AccessConfig(){
            
            this.ToTable(nameof(Access));
            this.Property(e => e.id);
            this.Property(e => e.text).HasMaxLength(50);
            this.Property(e => e.PID).IsRequired();
            this.Property(e => e.Aaddress).HasMaxLength(50);
            this.Property(e => e.state).HasMaxLength(50);



        }
    }
}
