
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace MVC_8.CodeFirst
{
   public class salary_grantConfig:EntityTypeConfiguration<salary_grant>
    {
        public salary_grantConfig()
        {
            this.ToTable(nameof(salary_grant));
        }
    }
}
