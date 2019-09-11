
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace MVC_8.CodeFirst
{
   public class salary_standard_detailsConfig:EntityTypeConfiguration<salary_standard_details>
    {
        public salary_standard_detailsConfig()
        {
            this.ToTable(nameof(salary_standard_details));
            this.Property(e => e.standard_id).HasMaxLength(30);
            this.Property(e => e.standard_name).HasMaxLength(60);
            this.Property(e => e.item_name).HasMaxLength(60);
          
        }
    }
}
