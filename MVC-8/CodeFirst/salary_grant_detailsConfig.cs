
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace MVC_8.CodeFirst
{
   public class salary_grant_detailsConfig:EntityTypeConfiguration<salary_grant_details>
    {
        public salary_grant_detailsConfig()
        {
            this.ToTable(nameof(salary_grant_details));
        }
    }
}
