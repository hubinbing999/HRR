
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace MVC_8.CodeFirst
{
   public class salary_standardConfig:EntityTypeConfiguration<salary_standard>
    {
        public salary_standardConfig()
        {
            this.ToTable(nameof(salary_standard));
            this.Property(e => e.standard_id).HasMaxLength(30);
            this.Property(e => e.standard_name).HasMaxLength(60);
            this.Property(e => e.designer).HasMaxLength(60);
            this.Property(e => e.register).HasMaxLength(60);
            this.Property(e => e.checker).HasMaxLength(60);
            this.Property(e => e.changer).HasMaxLength(60);
            
        }
    }
}
